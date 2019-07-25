namespace Puzzle
{
    partial class PuzzleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuzzleForm));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.newGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.authorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxLevel = new System.Windows.Forms.ToolStripComboBox();
            this.labelBestTime = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStripButtonIncludeNumber = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxBackGrounds = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTimer.Location = new System.Drawing.Point(0, 24);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(97, 18);
            this.labelTimer.TabIndex = 4;
            this.labelTimer.Text = "Solving Time:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripComboBoxLevel,
            this.toolStripButtonIncludeNumber,
            this.toolStripComboBoxBackGrounds});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(484, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem1,
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(51, 22);
            this.toolStripDropDownButton1.Text = "Menu";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // newGameToolStripMenuItem1
            // 
            this.newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
            this.newGameToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.newGameToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.newGameToolStripMenuItem1.Text = "New Game";
            this.newGameToolStripMenuItem1.Click += new System.EventHandler(this.newGameToolStripMenuItem1_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem1,
            this.gameToolStripMenuItem1});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(53, 22);
            this.toolStripDropDownButton2.Text = "About";
            // 
            // authorToolStripMenuItem1
            // 
            this.authorToolStripMenuItem1.Name = "authorToolStripMenuItem1";
            this.authorToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.authorToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.authorToolStripMenuItem1.Text = "Author";
            this.authorToolStripMenuItem1.Click += new System.EventHandler(this.authorToolStripMenuItem1_Click);
            // 
            // gameToolStripMenuItem1
            // 
            this.gameToolStripMenuItem1.Name = "gameToolStripMenuItem1";
            this.gameToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.gameToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.gameToolStripMenuItem1.Text = "Game";
            this.gameToolStripMenuItem1.Click += new System.EventHandler(this.gameToolStripMenuItem1_Click);
            // 
            // toolStripComboBoxLevel
            // 
            this.toolStripComboBoxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolStripComboBoxLevel.Items.AddRange(new object[] {
            "Level 3",
            "Level 4",
            "Level 5",
            "Level 6",
            "Level 7",
            "Level 8",
            "Level 9",
            "Level 10"});
            this.toolStripComboBoxLevel.Name = "toolStripComboBoxLevel";
            this.toolStripComboBoxLevel.Size = new System.Drawing.Size(80, 25);
            this.toolStripComboBoxLevel.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxLevel_SelectedIndexChanged);
            // 
            // labelBestTime
            // 
            this.labelBestTime.AutoSize = true;
            this.labelBestTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelBestTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBestTime.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBestTime.Location = new System.Drawing.Point(401, 25);
            this.labelBestTime.Name = "labelBestTime";
            this.labelBestTime.Size = new System.Drawing.Size(83, 18);
            this.labelBestTime.TabIndex = 7;
            this.labelBestTime.Text = "Best Time: ";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // toolStripButtonIncludeNumber
            // 
            this.toolStripButtonIncludeNumber.Checked = true;
            this.toolStripButtonIncludeNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonIncludeNumber.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonIncludeNumber.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIncludeNumber.Image")));
            this.toolStripButtonIncludeNumber.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIncludeNumber.Name = "toolStripButtonIncludeNumber";
            this.toolStripButtonIncludeNumber.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonIncludeNumber.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripComboBoxBackGrounds
            // 
            this.toolStripComboBoxBackGrounds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxBackGrounds.DropDownWidth = 200;
            this.toolStripComboBoxBackGrounds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolStripComboBoxBackGrounds.Name = "toolStripComboBoxBackGrounds";
            this.toolStripComboBoxBackGrounds.Size = new System.Drawing.Size(100, 25);
            this.toolStripComboBoxBackGrounds.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxBackGrounds_SelectedIndexChanged);
            // 
            // PuzzleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(484, 464);
            this.Controls.Add(this.labelBestTime);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PuzzleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzzle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PuzzleForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PuzzleForm_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem1;
        private System.Windows.Forms.Label labelBestTime;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxLevel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripButton toolStripButtonIncludeNumber;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxBackGrounds;


    }
}

