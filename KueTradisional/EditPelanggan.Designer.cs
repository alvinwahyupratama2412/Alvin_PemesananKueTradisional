namespace KueTradisional
{
    partial class EditPelanggan
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
            this.txtno = new System.Windows.Forms.TextBox();
            this.txtnm = new System.Windows.Forms.TextBox();
            this.lblno = new System.Windows.Forms.Label();
            this.lblnm = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(174, 133);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(268, 31);
            this.txtno.TabIndex = 8;
            // 
            // txtnm
            // 
            this.txtnm.Location = new System.Drawing.Point(174, 52);
            this.txtnm.Name = "txtnm";
            this.txtnm.Size = new System.Drawing.Size(268, 31);
            this.txtnm.TabIndex = 7;
            // 
            // lblno
            // 
            this.lblno.AutoSize = true;
            this.lblno.Font = new System.Drawing.Font("Lucida Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblno.Location = new System.Drawing.Point(58, 136);
            this.lblno.Name = "lblno";
            this.lblno.Size = new System.Drawing.Size(85, 28);
            this.lblno.TabIndex = 6;
            this.lblno.Text = "No Hp";
            // 
            // lblnm
            // 
            this.lblnm.AutoSize = true;
            this.lblnm.Font = new System.Drawing.Font("Lucida Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnm.Location = new System.Drawing.Point(58, 55);
            this.lblnm.Name = "lblnm";
            this.lblnm.Size = new System.Drawing.Size(99, 28);
            this.lblnm.TabIndex = 5;
            this.lblnm.Text = "Nama  ";
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Olive;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Location = new System.Drawing.Point(763, 385);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(150, 50);
            this.btnUp.TabIndex = 21;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // EditPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 469);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.txtnm);
            this.Controls.Add(this.lblno);
            this.Controls.Add(this.lblnm);
            this.Name = "EditPelanggan";
            this.Text = "EditPelanggan";
            this.Load += new System.EventHandler(this.EditPelanggan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.TextBox txtnm;
        private System.Windows.Forms.Label lblno;
        private System.Windows.Forms.Label lblnm;
        private System.Windows.Forms.Button btnUp;
    }
}