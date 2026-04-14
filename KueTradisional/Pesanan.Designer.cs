namespace KueTradisional
{
    partial class Pesananform
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
            this.lbljudulp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbljudulp
            // 
            this.lbljudulp.AutoSize = true;
            this.lbljudulp.Font = new System.Drawing.Font("Lucida Sans", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljudulp.ForeColor = System.Drawing.Color.DimGray;
            this.lbljudulp.Location = new System.Drawing.Point(12, 9);
            this.lbljudulp.Name = "lbljudulp";
            this.lbljudulp.Size = new System.Drawing.Size(362, 49);
            this.lbljudulp.TabIndex = 0;
            this.lbljudulp.Text = "Daftar Pesanan";
            // 
            // Pesananform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1345, 848);
            this.Controls.Add(this.lbljudulp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pesananform";
            this.Text = "Pesanan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbljudulp;
    }
}