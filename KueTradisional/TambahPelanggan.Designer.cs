namespace KueTradisional
{
    partial class TambahPelanggan
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
            this.lblnm = new System.Windows.Forms.Label();
            this.lblno = new System.Windows.Forms.Label();
            this.txtnm = new System.Windows.Forms.TextBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.btntambahpl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnm
            // 
            this.lblnm.AutoSize = true;
            this.lblnm.Font = new System.Drawing.Font("Lucida Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnm.Location = new System.Drawing.Point(92, 81);
            this.lblnm.Name = "lblnm";
            this.lblnm.Size = new System.Drawing.Size(99, 28);
            this.lblnm.TabIndex = 0;
            this.lblnm.Text = "Nama  ";
            // 
            // lblno
            // 
            this.lblno.AutoSize = true;
            this.lblno.Font = new System.Drawing.Font("Lucida Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblno.Location = new System.Drawing.Point(92, 162);
            this.lblno.Name = "lblno";
            this.lblno.Size = new System.Drawing.Size(85, 28);
            this.lblno.TabIndex = 1;
            this.lblno.Text = "No Hp";
            // 
            // txtnm
            // 
            this.txtnm.Location = new System.Drawing.Point(208, 78);
            this.txtnm.Name = "txtnm";
            this.txtnm.Size = new System.Drawing.Size(268, 31);
            this.txtnm.TabIndex = 2;
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(208, 159);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(268, 31);
            this.txtno.TabIndex = 3;
            // 
            // btntambahpl
            // 
            this.btntambahpl.BackColor = System.Drawing.Color.DarkCyan;
            this.btntambahpl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntambahpl.ForeColor = System.Drawing.Color.White;
            this.btntambahpl.Location = new System.Drawing.Point(767, 416);
            this.btntambahpl.Name = "btntambahpl";
            this.btntambahpl.Size = new System.Drawing.Size(148, 49);
            this.btntambahpl.TabIndex = 4;
            this.btntambahpl.Text = "Tambah";
            this.btntambahpl.UseVisualStyleBackColor = false;
            // 
            // TambahPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 498);
            this.Controls.Add(this.btntambahpl);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.txtnm);
            this.Controls.Add(this.lblno);
            this.Controls.Add(this.lblnm);
            this.Name = "TambahPelanggan";
            this.Text = "TambahPelanggan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnm;
        private System.Windows.Forms.Label lblno;
        private System.Windows.Forms.TextBox txtnm;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Button btntambahpl;
    }
}