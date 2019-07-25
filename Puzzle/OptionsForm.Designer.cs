namespace Puzzle
{
    partial class OptionsForm
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
            this.trackBarLevel = new System.Windows.Forms.TrackBar();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialogImg = new System.Windows.Forms.OpenFileDialog();
            this.labelChoosePicture = new System.Windows.Forms.Label();
            this.buttonBrowsePicture = new System.Windows.Forms.Button();
            this.textBoxBrowsePicture = new System.Windows.Forms.TextBox();
            this.textBoxBrowseFirstColor = new System.Windows.Forms.TextBox();
            this.buttonBrowseFirstColor = new System.Windows.Forms.Button();
            this.labelFirstColor = new System.Windows.Forms.Label();
            this.colorDialogForFirstNumber = new System.Windows.Forms.ColorDialog();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxBrowseSecondColor = new System.Windows.Forms.TextBox();
            this.buttonBrowseSecondColor = new System.Windows.Forms.Button();
            this.labelSecondColor = new System.Windows.Forms.Label();
            this.colorDialogForSecondNumber = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLevel)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarLevel
            // 
            this.trackBarLevel.LargeChange = 6;
            this.trackBarLevel.Location = new System.Drawing.Point(129, 47);
            this.trackBarLevel.Maximum = 7;
            this.trackBarLevel.Name = "trackBarLevel";
            this.trackBarLevel.Size = new System.Drawing.Size(259, 45);
            this.trackBarLevel.TabIndex = 0;
            this.trackBarLevel.TickFrequency = 2;
            this.trackBarLevel.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarLevel.ValueChanged += new System.EventHandler(this.trackBarLevel_ValueChanged);
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.Location = new System.Drawing.Point(129, 21);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(139, 20);
            this.textBoxLevel.TabIndex = 1;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.Location = new System.Drawing.Point(9, 18);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(109, 20);
            this.labelLevel.TabIndex = 8;
            this.labelLevel.Text = "Choose Level:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelLevel);
            this.panel1.Controls.Add(this.textBoxLevel);
            this.panel1.Controls.Add(this.trackBarLevel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 95);
            this.panel1.TabIndex = 7;
            // 
            // openFileDialogImg
            // 
            this.openFileDialogImg.FileName = "openFileDialog1";
            this.openFileDialogImg.Filter = "JPG Files (*.jpg)(*.png)|*.jpg";
            // 
            // labelChoosePicture
            // 
            this.labelChoosePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoosePicture.Location = new System.Drawing.Point(22, 123);
            this.labelChoosePicture.Name = "labelChoosePicture";
            this.labelChoosePicture.Size = new System.Drawing.Size(121, 41);
            this.labelChoosePicture.TabIndex = 9;
            this.labelChoosePicture.Text = "Choose Picture For Background:";
            this.labelChoosePicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBrowsePicture
            // 
            this.buttonBrowsePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowsePicture.ForeColor = System.Drawing.Color.Blue;
            this.buttonBrowsePicture.Location = new System.Drawing.Point(148, 132);
            this.buttonBrowsePicture.Name = "buttonBrowsePicture";
            this.buttonBrowsePicture.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowsePicture.TabIndex = 10;
            this.buttonBrowsePicture.Text = "Browse";
            this.buttonBrowsePicture.UseVisualStyleBackColor = true;
            this.buttonBrowsePicture.Click += new System.EventHandler(this.buttonPicture_Click);
            // 
            // textBoxBrowsePicture
            // 
            this.textBoxBrowsePicture.Location = new System.Drawing.Point(224, 134);
            this.textBoxBrowsePicture.Name = "textBoxBrowsePicture";
            this.textBoxBrowsePicture.Size = new System.Drawing.Size(192, 20);
            this.textBoxBrowsePicture.TabIndex = 11;
            // 
            // textBoxBrowseFirstColor
            // 
            this.textBoxBrowseFirstColor.Location = new System.Drawing.Point(224, 204);
            this.textBoxBrowseFirstColor.Name = "textBoxBrowseFirstColor";
            this.textBoxBrowseFirstColor.Size = new System.Drawing.Size(192, 20);
            this.textBoxBrowseFirstColor.TabIndex = 14;
            // 
            // buttonBrowseFirstColor
            // 
            this.buttonBrowseFirstColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowseFirstColor.ForeColor = System.Drawing.Color.Blue;
            this.buttonBrowseFirstColor.Location = new System.Drawing.Point(148, 202);
            this.buttonBrowseFirstColor.Name = "buttonBrowseFirstColor";
            this.buttonBrowseFirstColor.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseFirstColor.TabIndex = 13;
            this.buttonBrowseFirstColor.Text = "Browse";
            this.buttonBrowseFirstColor.UseVisualStyleBackColor = true;
            this.buttonBrowseFirstColor.Click += new System.EventHandler(this.buttonBrowseColor_Click);
            // 
            // labelFirstColor
            // 
            this.labelFirstColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstColor.Location = new System.Drawing.Point(22, 193);
            this.labelFirstColor.Name = "labelFirstColor";
            this.labelFirstColor.Size = new System.Drawing.Size(121, 41);
            this.labelFirstColor.TabIndex = 12;
            this.labelFirstColor.Text = "Choose Numbers First Color:";
            this.labelFirstColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorDialogForFirstNumber
            // 
            this.colorDialogForFirstNumber.ShowHelp = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.ForeColor = System.Drawing.Color.Blue;
            this.buttonOk.Location = new System.Drawing.Point(42, 328);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(135, 26);
            this.buttonOk.TabIndex = 15;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Blue;
            this.buttonClose.Location = new System.Drawing.Point(246, 328);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(135, 26);
            this.buttonClose.TabIndex = 16;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxBrowseSecondColor
            // 
            this.textBoxBrowseSecondColor.Location = new System.Drawing.Point(224, 258);
            this.textBoxBrowseSecondColor.Name = "textBoxBrowseSecondColor";
            this.textBoxBrowseSecondColor.Size = new System.Drawing.Size(192, 20);
            this.textBoxBrowseSecondColor.TabIndex = 19;
            // 
            // buttonBrowseSecondColor
            // 
            this.buttonBrowseSecondColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowseSecondColor.ForeColor = System.Drawing.Color.Blue;
            this.buttonBrowseSecondColor.Location = new System.Drawing.Point(148, 256);
            this.buttonBrowseSecondColor.Name = "buttonBrowseSecondColor";
            this.buttonBrowseSecondColor.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseSecondColor.TabIndex = 18;
            this.buttonBrowseSecondColor.Text = "Browse";
            this.buttonBrowseSecondColor.UseVisualStyleBackColor = true;
            this.buttonBrowseSecondColor.Click += new System.EventHandler(this.buttonBrowseSecondColor_Click);
            // 
            // labelSecondColor
            // 
            this.labelSecondColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecondColor.Location = new System.Drawing.Point(22, 247);
            this.labelSecondColor.Name = "labelSecondColor";
            this.labelSecondColor.Size = new System.Drawing.Size(121, 41);
            this.labelSecondColor.TabIndex = 17;
            this.labelSecondColor.Text = "Choose Numbers Second Color:";
            this.labelSecondColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 366);
            this.Controls.Add(this.textBoxBrowseSecondColor);
            this.Controls.Add(this.buttonBrowseSecondColor);
            this.Controls.Add(this.labelSecondColor);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxBrowseFirstColor);
            this.Controls.Add(this.buttonBrowseFirstColor);
            this.Controls.Add(this.labelFirstColor);
            this.Controls.Add(this.textBoxBrowsePicture);
            this.Controls.Add(this.buttonBrowsePicture);
            this.Controls.Add(this.labelChoosePicture);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLevel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarLevel;
        private System.Windows.Forms.TextBox textBoxLevel;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialogImg;
        private System.Windows.Forms.Label labelChoosePicture;
        private System.Windows.Forms.Button buttonBrowsePicture;
        private System.Windows.Forms.TextBox textBoxBrowsePicture;
        private System.Windows.Forms.TextBox textBoxBrowseFirstColor;
        private System.Windows.Forms.Button buttonBrowseFirstColor;
        private System.Windows.Forms.Label labelFirstColor;
        private System.Windows.Forms.ColorDialog colorDialogForFirstNumber;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxBrowseSecondColor;
        private System.Windows.Forms.Button buttonBrowseSecondColor;
        private System.Windows.Forms.Label labelSecondColor;
        private System.Windows.Forms.ColorDialog colorDialogForSecondNumber;

    }
}