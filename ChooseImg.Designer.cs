
namespace APO
{
    partial class ChooseImg
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
            this.cmbChoose = new System.Windows.Forms.ComboBox();
            this.lblText = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbChoose
            // 
            this.cmbChoose.FormattingEnabled = true;
            this.cmbChoose.Location = new System.Drawing.Point(12, 29);
            this.cmbChoose.Name = "cmbChoose";
            this.cmbChoose.Size = new System.Drawing.Size(173, 21);
            this.cmbChoose.TabIndex = 0;
            this.cmbChoose.SelectedIndexChanged += new System.EventHandler(this.cmbChoose_SelectedIndexChanged);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(13, 13);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(92, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Choose  an image";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(128, 79);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ChooseImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 114);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.cmbChoose);
            this.Name = "ChooseImg";
            this.Text = "ChooseImg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChoose;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnOk;
    }
}