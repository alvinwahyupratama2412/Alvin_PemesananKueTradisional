namespace KueTradisional
{
    partial class Kue
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
            this.lbljudulk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbljudulk
            // 
            this.lbljudulk.AutoSize = true;
            this.lbljudulk.Font = new System.Drawing.Font("Lucida Sans", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljudulk.ForeColor = System.Drawing.Color.DimGray;
            this.lbljudulk.Location = new System.Drawing.Point(12, 9);
            this.lbljudulk.Name = "lbljudulk";
            this.lbljudulk.Size = new System.Drawing.Size(262, 49);
            this.lbljudulk.TabIndex = 1;
            this.lbljudulk.Text = "Daftar Kue";
            // 
            // Kue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1345, 848);
            this.Controls.Add(this.lbljudulk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kue";
            this.Text = "Kue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbljudulk;
    }
}