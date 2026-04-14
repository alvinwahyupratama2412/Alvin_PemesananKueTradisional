namespace KueTradisional
{
    partial class TambahKue
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
            this.lblNamakT = new System.Windows.Forms.Label();
            this.lblHargakT = new System.Windows.Forms.Label();
            this.txtTknama = new System.Windows.Forms.TextBox();
            this.txtTkharga = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNamakT
            // 
            this.lblNamakT.AutoSize = true;
            this.lblNamakT.Font = new System.Drawing.Font("Lucida Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamakT.Location = new System.Drawing.Point(50, 72);
            this.lblNamakT.Name = "lblNamakT";
            this.lblNamakT.Size = new System.Drawing.Size(136, 28);
            this.lblNamakT.TabIndex = 0;
            this.lblNamakT.Text = "Nama Kue";
            // 
            // lblHargakT
            // 
            this.lblHargakT.AutoSize = true;
            this.lblHargakT.Font = new System.Drawing.Font("Lucida Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHargakT.Location = new System.Drawing.Point(50, 173);
            this.lblHargakT.Name = "lblHargakT";
            this.lblHargakT.Size = new System.Drawing.Size(87, 28);
            this.lblHargakT.TabIndex = 1;
            this.lblHargakT.Text = "Harga";
            // 
            // txtTknama
            // 
            this.txtTknama.Location = new System.Drawing.Point(222, 72);
            this.txtTknama.Name = "txtTknama";
            this.txtTknama.Size = new System.Drawing.Size(328, 31);
            this.txtTknama.TabIndex = 2;
            // 
            // txtTkharga
            // 
            this.txtTkharga.Location = new System.Drawing.Point(222, 173);
            this.txtTkharga.Name = "txtTkharga";
            this.txtTkharga.Size = new System.Drawing.Size(328, 31);
            this.txtTkharga.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(563, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TambahKue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTkharga);
            this.Controls.Add(this.txtTknama);
            this.Controls.Add(this.lblHargakT);
            this.Controls.Add(this.lblNamakT);
            this.Name = "TambahKue";
            this.Text = "TambahKue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamakT;
        private System.Windows.Forms.Label lblHargakT;
        private System.Windows.Forms.TextBox txtTknama;
        private System.Windows.Forms.TextBox txtTkharga;
        private System.Windows.Forms.Button button1;
    }
}