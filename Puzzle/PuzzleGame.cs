using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Puzzle
{
    public partial class PuzzleForm : Form
    {
        private PuzzleMatrix GM;
        private Box[] Boxes;

        private string gameInfoPath;
        private int solvingTime = 0;
        private int bestTime = -1;
        private bool Won = true;

        private int boxWidth = 100;
        private int boxHeight = 120;

        private Image boxBackground;
        private Image boxZeroBackground;

        private int Level = 4;
        private string BackgroundPicturePath = "";

        private Color firstColor = Color.White;
        private Color secondColor = Color.Yellow;

        private bool includeNumbers = true;

        public PuzzleForm()
        {
            InitializeComponent();

            readBoxBackgrounds();
            loadLastGamePlayed();
            newGame();
            paintBoxes();
        }

        private void saveGame()
        {
            gameInfoPath=GameSaver_Reader.getSavedGame("Puzzle Game");
            if (!GameSaver_Reader.existsObject(gameInfoPath, "Last Game", "Played"))
            {
                GameSaver_Reader.saveObject("Last Game", "Played", gameInfoPath);
                GameSaver_Reader.saveObject("Last Level", Level.ToString(), gameInfoPath);
                GameSaver_Reader.saveObject("BackGroundPicturePath", BackgroundPicturePath, gameInfoPath);
                GameSaver_Reader.saveObject("includeNumbers", includeNumbers.ToString(), gameInfoPath);
            }
            else
            {
                GameSaver_Reader.changeObject(gameInfoPath, "Last Game", "Played", "Last Level", Level.ToString());
                GameSaver_Reader.changeObject(gameInfoPath, "Last Game", "Played", "BackGroundPicturePath", BackgroundPicturePath.ToString());
                GameSaver_Reader.changeObject(gameInfoPath, "Last Game", "Played", "includeNumbers", includeNumbers.ToString());
            }
            if (!GameSaver_Reader.existsObject(gameInfoPath, "Level", Level.ToString()))
            {
                    GameSaver_Reader.saveObject("Level", Level.ToString(), gameInfoPath);
                    GameSaver_Reader.saveObject("Best Time", bestTime.ToString(), gameInfoPath);
            }
            else
            {
                if ((getBestTimeFromFile() > bestTime && bestTime!=-1) || (getBestTimeFromFile() == -1 && bestTime!=-1))
                {
                    GameSaver_Reader.changeObject(gameInfoPath, "Level", Level.ToString(), "Best Time", bestTime.ToString());
                }
            }
        }

        private void loadLastGamePlayed()
        {
            gameInfoPath = GameSaver_Reader.getSavedGame("Puzzle Game");
            if (GameSaver_Reader.existsObject(gameInfoPath, "Last Game", "Played"))
            {
                Level = int.Parse(GameSaver_Reader.getObjectValue(gameInfoPath, "Last Game", "Played", "Last Level"));
                BackgroundPicturePath = GameSaver_Reader.getObjectValue(gameInfoPath, "Last Game", "Played", "BackGroundPicturePath");
                string s = GameSaver_Reader.getObjectValue(gameInfoPath, "Last Game", "Played", "includeNumbers");
                if (s == "False")
                    includeNumbers = false;
                else includeNumbers = true;
            }
        }

        private void newGame()
        {
            Won = true;
            showSolvePuzzle();
            backgroundWorker1.RunWorkerAsync();
        }

        private void showSolvePuzzle()
        {
            GM = new PuzzleMatrix(Level);
            Boxes = new Box[Level * Level];
            bestTime = -1;
            solvingTime = 0;
            updateForm();
        }

        private void objectsInicialization()
        {
            GM = new PuzzleMatrix(Level);
            Boxes = new Box[Level * Level];
            Won = false;
            bestTime = -1;
            solvingTime = 0;
        }

        private void updateForm()
        {
            updateBestTimeLabel();
            updateComboBoxLevels();
            updateComboBoxBackgrounds();
            checkBoxSizes(Level);
            readBoxBackgrounds();
            Create_UpdateBoxes();
            changeWindowSize(GM.Matrix.GetLength(1) * boxWidth + (GM.Matrix.GetLength(1) - 1) * 2 + 35, GM.Matrix.GetLength(0) * (boxHeight + 2) + 100);
        }

        #region Box Functions
        private void readBoxBackgrounds()
        {
            try
            {
                boxBackground = Puzzle.Properties.Resources.WoodBoxBackground;
                boxZeroBackground = Puzzle.Properties.Resources.WoodBoxZeroBackground;
                boxZeroBackground = resizeImage(boxZeroBackground, new Size(boxWidth, boxHeight));
                boxBackground = resizeImage(boxBackground, new Size(boxWidth, boxHeight));
            }
            catch
            {
                boxBackground = Image.FromFile("Images//WoodBoxBackground.jpg");
                boxZeroBackground = Image.FromFile("Images//WoodBoxZeroBackground.jpg");
                boxZeroBackground = resizeImage(boxZeroBackground, new Size(boxWidth, boxHeight));
                boxBackground = resizeImage(boxBackground, new Size(boxWidth, boxHeight));
            }
        }

        private Image cropImage(Image toCrop, Rectangle r)
        {
            Bitmap b = new Bitmap(toCrop);
            return (Image) b.Clone(r, System.Drawing.Imaging.PixelFormat.DontCare);
        }

        private void Create_UpdateBoxes(bool update=false)
        {
            Image background = boxBackground;

            Font TXTFont = new Font(FontFamily.GenericSansSerif, 25);
            if(BackgroundPicturePath!="")
                background=resizeImage(Image.FromFile(BackgroundPicturePath),new Size(boxWidth*Level,boxHeight*Level));

            int count = 1;
            int locX = 10;
            int locY = 60;
            for (int i = 0; i < GM.Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < GM.Matrix.GetLength(1); j++)
                {
                    Point BoxPoint = new Point(locX, locY);
                    string Name=count.ToString() + "box";
                    string Text="";
                    if (includeNumbers == true)
                        Text = GM.Matrix[i, j].ToString();

                    if (GM.Matrix[i,j]!=0)
                    {
                        if (j == GM.getNumberPositionColumn(0) || i == GM.getNumberPositionRow(0))
                        {
                            if (update == false)
                            {

                                if (BackgroundPicturePath != "")
                                {
                                    Rectangle r = new Rectangle(GM.getNumberPositionColumnOfMatrix(GM.Matrix[i, j], GM.FirstMatrix) * boxWidth, GM.getNumberPositionRowOfMatrix(GM.Matrix[i, j], GM.FirstMatrix) * boxHeight, boxWidth, boxHeight);
                                    boxBackground = cropImage(background, r);
                                }
                                Boxes[count - 1] = new Box(Name, Text, secondColor, BoxPoint, boxBackground, TXTFont);
                            }
                            else
                            {
                                //Boxes[count - 1].BoxName = Name;
                                Boxes[count - 1].BoxText = Text;
                                Boxes[count - 1].BoxTXTColor = secondColor;
                                if (Boxes[count - 1].BoxImg == boxZeroBackground)
                                {
                                    if (BackgroundPicturePath != "")
                                    {
                                        Rectangle r = new Rectangle(GM.getNumberPositionColumnOfMatrix(GM.Matrix[i, j], GM.FirstMatrix) * boxWidth, GM.getNumberPositionRowOfMatrix(GM.Matrix[i, j], GM.FirstMatrix) * boxHeight, boxWidth, boxHeight);
                                        boxBackground = cropImage(background, r);
                                    }
                                    Boxes[count - 1].BoxImg = boxBackground;
                                }
                            }
                        }
                        else
                        {
                            if (update == false)
                            {

                                if (BackgroundPicturePath != "")
                                {
                                    Rectangle r = new Rectangle(GM.getNumberPositionColumnOfMatrix(GM.Matrix[i, j], GM.FirstMatrix) * boxWidth, GM.getNumberPositionRowOfMatrix(GM.Matrix[i, j], GM.FirstMatrix) * boxHeight, boxWidth, boxHeight);
                                    boxBackground = cropImage(background, r);
                                }
                                Boxes[count - 1] = new Box(Name, Text, firstColor, BoxPoint, boxBackground, TXTFont);
                            }
                            //else
                            //{
                            //    Boxes[count - 1].BoxName = Name;
                            Boxes[count - 1].BoxText = Text;
                            Boxes[count - 1].BoxTXTColor = firstColor;
                            //    if (Boxes[count - 1].BoxImg == boxZeroBackground)
                            //    {

                            //        if (BackgroundPicturePath != "")
                            //        {
                            //            Rectangle r = new Rectangle(GM.getNumberPositionColumnOfMatrix(GM.Matrix[i, j], GM.FirstMatrix) * boxWidth, GM.getNumberPositionRowOfMatrix(GM.Matrix[i, j], GM.FirstMatrix) * boxHeight, boxWidth, boxHeight);
                            //            boxBackground = cropImage(background, r);
                            //        }
                            //        Boxes[count - 1].BoxImg = boxBackground;
                            //    }
                            //}
                        }
                    }
                    else Boxes[count - 1] = new Box(Name, "", secondColor, BoxPoint, boxZeroBackground, TXTFont);
                    locX += boxWidth + 2;
                    count++;
                }
                locX = 10;
                locY += boxHeight + 2;
            }
        }

        private void paintBoxes()
        {
            foreach (Box b in Boxes)
            {
                Label lb = new Label();
                lb.AutoSize = false;
                lb.Size = new Size(boxWidth, boxHeight);
                lb.TextAlign = ContentAlignment.MiddleCenter;

                lb.Name = b.BoxName;
                lb.Text = b.BoxText;
                lb.ForeColor = b.BoxTXTColor;
                lb.Location = b.BoxLocation;
                lb.Image = b.BoxImg;
                lb.Font = b.BoxTXTFont;
                lb.Click += lb_Click;

                this.Controls.Add(lb);
            }
        }

        private void checkBoxSizes(int lev)
        {
            if (lev >= 3 && lev <= 5)
            {
                boxWidth = 100;
                boxHeight = 120;
            }
            else
            {
                if (lev == 6)
                {
                    boxWidth = 80;
                    boxHeight = 90;
                }
                else
                {
                    boxWidth = 70;
                    boxHeight = (-10) * lev + 150;
                }
            }
        }

        private void repaintBoxes()
        {
            foreach (Box b in Boxes)
            {
                Control[] c = this.Controls.Find(b.BoxName, false);
                Label lb = (Label)c[0];
                lb.Name = b.BoxName;
                if (lb.Text != b.BoxText && includeNumbers)
                {
                    lb.Text = b.BoxText;
                    lb.Image = b.BoxImg;
                }
                if (!includeNumbers)
                {
                    lb.Text = b.BoxText;
                    lb.Image = b.BoxImg;
                }
                lb.ForeColor = b.BoxTXTColor;
            }
        }

        private int getBox(int num)
        {
            int count=1;
            for (int i = 0; i < GM.Matrix.GetLength(0); i++)
                for (int j = 0; j < GM.Matrix.GetLength(1); j++)
                {
                    if (GM.Matrix[i, j] == num)
                        return count;
                    count++;
                }
            return -1;
        }
        #endregion

        private void changeMatrix(int num)
        {
            if (num != 0)
            {
                int numberPositionRow = GM.getNumberPositionRow(num);
                int numberPositionColumn = GM.getNumberPositionColumn(num);
                int nullPositionRow = GM.getNumberPositionRow(0);
                int nullPositionColumn = GM.getNumberPositionColumn(0);
                if (nullPositionColumn == numberPositionColumn)
                {
                    if (nullPositionRow > numberPositionRow)
                    {
                        int k = nullPositionRow - numberPositionRow;
                        for (int i = 0; i < k; i++)
                        {
                            GM.downMove();
                            Create_UpdateBoxes(true);
                        }
                    }
                    if (nullPositionRow < numberPositionRow)
                    {
                        int k = numberPositionRow - nullPositionRow;
                        for (int i = 0; i < k; i++)
                        {
                            GM.upMove();
                            Create_UpdateBoxes(true);
                        }
                    }
                }
                if (nullPositionRow == numberPositionRow)
                {
                    if (nullPositionColumn > numberPositionColumn)
                    {
                        int k = nullPositionColumn - numberPositionColumn;
                        for (int i = 0; i < k; i++)
                        {
                            GM.rightMove();
                            Create_UpdateBoxes(true);
                        }
                    }
                    if (nullPositionColumn < numberPositionColumn)
                    {
                        int k = numberPositionColumn - nullPositionColumn;
                        for (int i = 0; i < k; i++)
                        {
                            GM.leftMove();
                            Create_UpdateBoxes(true);
                        }
                    }
                }
            }
        }

        public void checkWon()
        {
            if (GM.won() && !Won)
            {
                GameTimer.Stop();
                Won = true;
                if (bestTime == -1 || solvingTime < bestTime)
                    bestTime = solvingTime;
                saveGame();
                updateBestTimeLabel();
                MessageBox.Show("You Won!!! Solve Puzzle Time: "+getTimeToString(solvingTime), "Won", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int getNumber(int box)
        {
            int count = 1;
            for (int i = 0; i < GM.Matrix.GetLength(0); i++)
                for (int j = 0; j < GM.Matrix.GetLength(1); j++)
                {
                    if (box == count)
                    {
                        return GM.Matrix[i, j];
                    }
                    count++;
                }
            return -1;
        }

        private string getTimeToString(int t)
        {
            if (t < 60)
            {
                if (t < 10)
                    return "0" + t.ToString();
                else return t.ToString();
            }
            else
            {
                int minute = t / 60;
                int second = t % 60;
                if (second < 10)
                    return minute.ToString() + ":0" + second.ToString();
                else return minute.ToString() + ":" + second.ToString();
            }
        }

        private int getBestTimeFromFile()
        {
            string b = GameSaver_Reader.getObjectValue(gameInfoPath, "Level", Level.ToString(), "Best Time");
            if (b != "")
                return int.Parse(b);
            else return -1;
        }

        #region Interface Functions
        private void updateComboBoxLevels()
        {
            if (toolStripComboBoxLevel.SelectedIndex + 3 != Level)
                toolStripComboBoxLevel.SelectedIndex = Level - 3;
        }

        private void updateComboBoxBackgrounds()
        {
            toolStripComboBoxBackGrounds.Items.Clear();
            toolStripComboBoxBackGrounds.Items.Add("Standart");
            string[] images= Directory.GetFiles("Images");
            foreach (string image in images)
            {
                toolStripComboBoxBackGrounds.Items.Add(image);
            }
        }

        private void clearAllBoxes()
        {
            foreach (Box b in Boxes)
            {
                try
                {
                    Control[] c = this.Controls.Find(b.BoxName, false);
                    this.Controls.Remove(c[0]);
                }
                catch
                {
                }
            }
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void changeWindowSize(int x, int y)
        {
             this.Size = new Size(x, y);
        }

        private void updateBestTimeLabel()
        {
            bestTime = getBestTimeFromFile();
            if (bestTime != -1)
                labelBestTime.Text = "Best Time: " + getTimeToString(bestTime);
            else labelBestTime.Text = "Best Time: ";
        }
        #endregion

        #region Events
        private void PuzzleForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                GM.upMove();
            if (e.KeyCode == Keys.Down)
                GM.downMove();
            if (e.KeyCode == Keys.Left)
                GM.leftMove();
            if (e.KeyCode == Keys.Right)
                GM.rightMove();
            Create_UpdateBoxes(true);
            repaintBoxes();
            checkWon();
        }

        private void lb_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            int box = int.Parse(lb.Name.Substring(0,lb.Name.Length-3));
            int num = getNumber(box);
            changeMatrix(num);
            repaintBoxes();
            checkWon();
        }

        private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
            Won = true;
            newGame();
            repaintBoxes();
        }

        private void toolStripComboBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBoxLevel.SelectedIndex + 3 != Level)
            {
                Level = toolStripComboBoxLevel.SelectedIndex + 3;
                clearAllBoxes();
                newGame();
                paintBoxes();
                saveGame();
                this.CenterToScreen();
            }
            labelBestTime.Focus();
        }

        private void toolStripComboBoxBackGrounds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBoxBackGrounds.SelectedItem.ToString() != "Standart")
            {
                if (toolStripComboBoxBackGrounds.SelectedItem.ToString() != BackgroundPicturePath)
                {
                    BackgroundPicturePath = toolStripComboBoxBackGrounds.SelectedItem.ToString();
                    clearAllBoxes();
                    Create_UpdateBoxes();
                    paintBoxes();
                    saveGame();
                }
            }
            else
            {
                if (BackgroundPicturePath!="")
                {
                    BackgroundPicturePath = "";
                    readBoxBackgrounds();
                    clearAllBoxes();
                    Create_UpdateBoxes();
                    paintBoxes();
                    saveGame();
                }
            }
            labelBestTime.Focus();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
            OptionsForm f = new OptionsForm(Level);
            f.ShowDialog(this);
            if (f.Level != -1)
                Level = f.Level;
            if (f.PicturePathForBackgorund != "")
            {
                Image im = Image.FromFile(f.PicturePathForBackgorund);
                string path="";
                path = "Images//" + f.PictureName;
                im.Save(path);
                BackgroundPicturePath = path;
            }
            if (f.NumbersFirstColor != Color.Empty)
                firstColor = f.NumbersFirstColor;
            if (f.NumbersSecondColor != Color.Empty)
                secondColor = f.NumbersSecondColor;
            clearAllBoxes();
            newGame();
            paintBoxes();
            this.CenterToScreen();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void authorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
            MessageBox.Show("Author: DaViD :)", "About Author", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GameTimer.Start();
        }

        private void gameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
            MessageBox.Show("Try to Solve Puzzle by Pressing Arrow Keys or by Clicking on Yellow Boxes :)", "About Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            solvingTime++;
            labelTimer.Text = "Solving Time: " + getTimeToString(solvingTime);
        }

        private void PuzzleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            saveGame();
        }
       
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(2000);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            objectsInicialization();
            GM.randomMatrix();
            updateForm();
            repaintBoxes();

            saveGame();
            GameTimer.Start();
        }
       
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (includeNumbers == true)
            {
                includeNumbers = false;
                toolStripButtonIncludeNumber.Checked = false;
            }
            else
            {
                includeNumbers = true;
                toolStripButtonIncludeNumber.Checked = true;
            }
            Create_UpdateBoxes(true);
            repaintBoxes();
        }
        #endregion

    }
}
