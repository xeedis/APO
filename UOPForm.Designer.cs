
namespace APO
{
    partial class UOPForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.pUOP = new System.Windows.Forms.Panel();
            this.lPosition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(265, 343);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pUOP
            // 
            this.pUOP.Location = new System.Drawing.Point(12, 12);
            this.pUOP.Name = "pUOP";
            this.pUOP.Size = new System.Drawing.Size(325, 325);
            this.pUOP.TabIndex = 1;
            this.pUOP.Paint += new System.Windows.Forms.PaintEventHandler(this.pUOP_Paint);
            this.pUOP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pUOP_MouseDown);
            this.pUOP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pUOP_MouseMove);
            this.pUOP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pUOP_MouseUp);
            // 
            // lPosition
            // 
            this.lPosition.AutoSize = true;
            this.lPosition.Location = new System.Drawing.Point(13, 344);
            this.lPosition.Name = "lPosition";
            this.lPosition.Size = new System.Drawing.Size(44, 13);
            this.lPosition.TabIndex = 2;
            this.lPosition.Text = "Pozycja";
            // 
            // UOPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 378);
            this.Controls.Add(this.lPosition);
            this.Controls.Add(this.pUOP);
            this.Controls.Add(this.btnOk);
            this.Name = "UOPForm";
            this.Text = "UOPForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel pUOP;
        private System.Windows.Forms.Label lPosition;
    }
}