namespace APO
{
    partial class Picture
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
            this.tpHistogram = new System.Windows.Forms.TabPage();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelAmountTxt = new System.Windows.Forms.Label();
            this.labelLevelTxt = new System.Windows.Forms.Label();
            this.pHistogram = new System.Windows.Forms.Panel();
            this.tpObraz = new System.Windows.Forms.TabPage();
            this.pbImageToShow = new System.Windows.Forms.PictureBox();
            this.tbObraz = new System.Windows.Forms.TabControl();
            this.tpHistogram.SuspendLayout();
            this.tpObraz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageToShow)).BeginInit();
            this.tbObraz.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpHistogram
            // 
            this.tpHistogram.BackColor = System.Drawing.Color.White;
            this.tpHistogram.Controls.Add(this.labelAmount);
            this.tpHistogram.Controls.Add(this.labelLevel);
            this.tpHistogram.Controls.Add(this.labelAmountTxt);
            this.tpHistogram.Controls.Add(this.labelLevelTxt);
            this.tpHistogram.Controls.Add(this.pHistogram);
            this.tpHistogram.Location = new System.Drawing.Point(4, 22);
            this.tpHistogram.Name = "tpHistogram";
            this.tpHistogram.Padding = new System.Windows.Forms.Padding(3);
            this.tpHistogram.Size = new System.Drawing.Size(398, 331);
            this.tpHistogram.TabIndex = 2;
            this.tpHistogram.Text = "Histogram";
            // 
            // labelAmount
            // 
            this.labelAmount.BackColor = System.Drawing.Color.White;
            this.labelAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAmount.Location = new System.Drawing.Point(71, 256);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(100, 20);
            this.labelAmount.TabIndex = 4;
            // 
            // labelLevel
            // 
            this.labelLevel.BackColor = System.Drawing.Color.White;
            this.labelLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLevel.Location = new System.Drawing.Point(71, 230);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(100, 20);
            this.labelLevel.TabIndex = 3;
            // 
            // labelAmountTxt
            // 
            this.labelAmountTxt.AutoSize = true;
            this.labelAmountTxt.Location = new System.Drawing.Point(8, 256);
            this.labelAmountTxt.Name = "labelAmountTxt";
            this.labelAmountTxt.Size = new System.Drawing.Size(29, 13);
            this.labelAmountTxt.TabIndex = 2;
            this.labelAmountTxt.Text = "Ilość";
            // 
            // labelLevelTxt
            // 
            this.labelLevelTxt.AutoSize = true;
            this.labelLevelTxt.Location = new System.Drawing.Point(3, 230);
            this.labelLevelTxt.Name = "labelLevelTxt";
            this.labelLevelTxt.Size = new System.Drawing.Size(41, 13);
            this.labelLevelTxt.TabIndex = 1;
            this.labelLevelTxt.Text = "Poziom";
            // 
            // pHistogram
            // 
            this.pHistogram.BackColor = System.Drawing.Color.White;
            this.pHistogram.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pHistogram.Location = new System.Drawing.Point(3, 3);
            this.pHistogram.Name = "pHistogram";
            this.pHistogram.Size = new System.Drawing.Size(260, 224);
            this.pHistogram.TabIndex = 0;
            this.pHistogram.Paint += new System.Windows.Forms.PaintEventHandler(this.pHistogram_Paint);
            this.pHistogram.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pHistogram_MouseMove);
            // 
            // tpObraz
            // 
            this.tpObraz.Controls.Add(this.pbImageToShow);
            this.tpObraz.Location = new System.Drawing.Point(4, 22);
            this.tpObraz.Name = "tpObraz";
            this.tpObraz.Padding = new System.Windows.Forms.Padding(3);
            this.tpObraz.Size = new System.Drawing.Size(398, 331);
            this.tpObraz.TabIndex = 0;
            this.tpObraz.Text = "Obraz";
            this.tpObraz.UseVisualStyleBackColor = true;
            // 
            // pbImageToShow
            // 
            this.pbImageToShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImageToShow.Location = new System.Drawing.Point(3, 3);
            this.pbImageToShow.Name = "pbImageToShow";
            this.pbImageToShow.Size = new System.Drawing.Size(385, 320);
            this.pbImageToShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageToShow.TabIndex = 0;
            this.pbImageToShow.TabStop = false;
            // 
            // tbObraz
            // 
            this.tbObraz.Controls.Add(this.tpObraz);
            this.tbObraz.Controls.Add(this.tpHistogram);
            this.tbObraz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbObraz.Location = new System.Drawing.Point(0, 0);
            this.tbObraz.Name = "tbObraz";
            this.tbObraz.SelectedIndex = 0;
            this.tbObraz.Size = new System.Drawing.Size(406, 357);
            this.tbObraz.TabIndex = 0;
            this.tbObraz.Tag = "";
            // 
            // Picture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 357);
            this.Controls.Add(this.tbObraz);
            this.Name = "Picture";
            this.Text = "openFile";
            this.Load += new System.EventHandler(this.Picture_Load);
            this.tpHistogram.ResumeLayout(false);
            this.tpHistogram.PerformLayout();
            this.tpObraz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageToShow)).EndInit();
            this.tbObraz.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpHistogram;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelAmountTxt;
        private System.Windows.Forms.Label labelLevelTxt;
        private System.Windows.Forms.Panel pHistogram;
        private System.Windows.Forms.TabPage tpObraz;
        private System.Windows.Forms.PictureBox pbImageToShow;
        private System.Windows.Forms.TabControl tbObraz;
    }
}