
namespace APO
{
    partial class DoubleParameterOperations
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblMinStart = new System.Windows.Forms.Label();
            this.lblMaxStart = new System.Windows.Forms.Label();
            this.lblMinEnd = new System.Windows.Forms.Label();
            this.lblMaxEnd = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.lblCurrentStart = new System.Windows.Forms.Label();
            this.lblCurrentEnd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(278, 210);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(15, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(12, 9);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(135, 13);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Podaj poczatkowa wartość";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(9, 103);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(121, 13);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "Podaj końcową wartość";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 55);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(341, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblMinStart
            // 
            this.lblMinStart.AutoSize = true;
            this.lblMinStart.Location = new System.Drawing.Point(12, 39);
            this.lblMinStart.Name = "lblMinStart";
            this.lblMinStart.Size = new System.Drawing.Size(35, 13);
            this.lblMinStart.TabIndex = 5;
            this.lblMinStart.Text = "label1";
            // 
            // lblMaxStart
            // 
            this.lblMaxStart.AutoSize = true;
            this.lblMaxStart.Location = new System.Drawing.Point(318, 39);
            this.lblMaxStart.Name = "lblMaxStart";
            this.lblMaxStart.Size = new System.Drawing.Size(35, 13);
            this.lblMaxStart.TabIndex = 6;
            this.lblMaxStart.Text = "label1";
            // 
            // lblMinEnd
            // 
            this.lblMinEnd.AutoSize = true;
            this.lblMinEnd.Location = new System.Drawing.Point(12, 131);
            this.lblMinEnd.Name = "lblMinEnd";
            this.lblMinEnd.Size = new System.Drawing.Size(35, 13);
            this.lblMinEnd.TabIndex = 7;
            this.lblMinEnd.Text = "label1";
            // 
            // lblMaxEnd
            // 
            this.lblMaxEnd.AutoSize = true;
            this.lblMaxEnd.Location = new System.Drawing.Point(318, 131);
            this.lblMaxEnd.Name = "lblMaxEnd";
            this.lblMaxEnd.Size = new System.Drawing.Size(35, 13);
            this.lblMaxEnd.TabIndex = 8;
            this.lblMaxEnd.Text = "label1";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(15, 147);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(338, 45);
            this.trackBar2.TabIndex = 9;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // lblCurrentStart
            // 
            this.lblCurrentStart.AutoSize = true;
            this.lblCurrentStart.Location = new System.Drawing.Point(168, 39);
            this.lblCurrentStart.Name = "lblCurrentStart";
            this.lblCurrentStart.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentStart.TabIndex = 10;
            this.lblCurrentStart.Text = "label1";
            // 
            // lblCurrentEnd
            // 
            this.lblCurrentEnd.AutoSize = true;
            this.lblCurrentEnd.Location = new System.Drawing.Point(168, 131);
            this.lblCurrentEnd.Name = "lblCurrentEnd";
            this.lblCurrentEnd.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentEnd.TabIndex = 11;
            this.lblCurrentEnd.Text = "label2";
            // 
            // DoubleParameterOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 241);
            this.Controls.Add(this.lblCurrentEnd);
            this.Controls.Add(this.lblCurrentStart);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.lblMaxEnd);
            this.Controls.Add(this.lblMinEnd);
            this.Controls.Add(this.lblMaxStart);
            this.Controls.Add(this.lblMinStart);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "DoubleParameterOperations";
            this.Text = "DoubleParameterOperations";
            this.Load += new System.EventHandler(this.DoubleParameterOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblMinStart;
        private System.Windows.Forms.Label lblMaxStart;
        private System.Windows.Forms.Label lblMinEnd;
        private System.Windows.Forms.Label lblMaxEnd;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label lblCurrentStart;
        private System.Windows.Forms.Label lblCurrentEnd;
    }
}