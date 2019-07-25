using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class OptionsForm : Form
    {
        private int level;
        private string picturePathForBackgorund = "";
        private string pictureName = "";
        private Color numbersFirstColor = Color.Empty;
        private Color numbersSecondColor = Color.Empty;

        public OptionsForm(int lv)
        {
            InitializeComponent();

            level = lv;
            trackBarLevel.Value = level - 3;
            textBoxLevel.ReadOnly = true;
        }

        private void trackBarLevel_ValueChanged(object sender, EventArgs e)
        {
            textBoxLevel.Text = "Level "+(trackBarLevel.Value + 3).ToString();
        }

        private void buttonPicture_Click(object sender, EventArgs e)
        {
            DialogResult d= openFileDialogImg.ShowDialog();
            if (d == DialogResult.OK)
                textBoxBrowsePicture.Text = openFileDialogImg.FileName;
        }

        private void buttonBrowseColor_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialogForFirstNumber.ShowDialog();
            if (d == DialogResult.OK)
                textBoxBrowseFirstColor.Text = colorDialogForFirstNumber.Color.ToString();
        }

        private void buttonBrowseSecondColor_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialogForSecondNumber.ShowDialog();
            if (d == DialogResult.OK)
                textBoxBrowseSecondColor.Text = colorDialogForSecondNumber.Color.ToString();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxLevel.Text != "")
                level = int.Parse(textBoxLevel.Text.Substring(textBoxLevel.Text.IndexOf(" ")));
            if (textBoxBrowsePicture.Text != "")
            {
                picturePathForBackgorund = openFileDialogImg.FileName;
                pictureName = openFileDialogImg.SafeFileName;
            }
            if (textBoxBrowseFirstColor.Text != "")
                numbersFirstColor = colorDialogForFirstNumber.Color;
            if (textBoxBrowseSecondColor.Text != "")
                numbersSecondColor = colorDialogForSecondNumber.Color;
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public string PicturePathForBackgorund
        {
            get { return picturePathForBackgorund; }
            set { picturePathForBackgorund = value; }
        }

        public Color NumbersFirstColor
        {
            get { return numbersFirstColor; }
            set { numbersFirstColor = value; }
        }

        public Color NumbersSecondColor
        {
            get { return numbersSecondColor; }
            set { numbersSecondColor = value; }
        }

        public string PictureName
        {
            get { return pictureName; }
            set { pictureName = value; }
        }
    }
}
