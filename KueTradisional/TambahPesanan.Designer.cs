namespace KueTradisional
{
    partial class TambahPesanan
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
            this.lblNamatp = new System.Windows.Forms.Label();
            this.txtTpnama = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblnamaptp = new System.Windows.Forms.Label();
            this.lblJumtp = new System.Windows.Forms.Label();
            this.txtpJumlah = new System.Windows.Forms.TextBox();
            this.lblAmtp = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSimpantp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNamatp
            // 
            this.lblNamatp.AutoSize = true;
            this.lblNamatp.Font = new System.Drawing.Font("Lucida Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamatp.Location = new System.Drawing.Point(29, 29);
            this.lblNamatp.Name = "lblNamatp";
            this.lblNamatp.Size = new System.Drawing.Size(136, 28);
            this.lblNamatp.TabIndex = 1;
            this.lblNamatp.Text = "Nama Kue";
            // 
            // txtTpnama
            // 
            this.txtTpnama.Location = new System.Drawing.Point(252, 105);
            this.txtTpnama.Name = "txtTpnama";
            this.txtTpnama.Size = new System.Drawing.Size(328, 31);
            this.txtTpnama.TabIndex = 3;
            this.txtTpnama.TextChanged += new System.EventHandler(this.txtTpnama_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(252, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 33);
            this.comboBox1.TabIndex = 4;
            // 
            // lblnamaptp
            // 
            this.lblnamaptp.AutoSize = true;
            this.lblnamaptp.Font = new System.Drawing.Font("Lucida Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamaptp.Location = new System.Drawing.Point(29, 105);
            this.lblnamaptp.Name = "lblnamaptp";
            this.lblnamaptp.Size = new System.Drawing.Size(217, 28);
            this.lblnamaptp.TabIndex = 5;
            this.lblnamaptp.Text = "Nama Pelanggan";
            // 
            // lblJumtp
            // 
            this.lblJumtp.AutoSize = true;
            this.lblJumtp.Font = new System.Drawing.Font("Lucida Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumtp.Location = new System.Drawing.Point(29, 194);
            this.lblJumtp.Name = "lblJumtp";
            this.lblJumtp.Size = new System.Drawing.Size(97, 28);
            this.lblJumtp.TabIndex = 6;
            this.lblJumtp.Text = "Jumlah";
            // 
            // txtpJumlah
            // 
            this.txtpJumlah.Location = new System.Drawing.Point(252, 191);
            this.txtpJumlah.Name = "txtpJumlah";
            this.txtpJumlah.Size = new System.Drawing.Size(328, 31);
            this.txtpJumlah.TabIndex = 7;
            // 
            // lblAmtp
            // 
            this.lblAmtp.AutoSize = true;
            this.lblAmtp.Font = new System.Drawing.Font("Lucida Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmtp.Location = new System.Drawing.Point(29, 279);
            this.lblAmtp.Name = "lblAmtp";
            this.lblAmtp.Size = new System.Drawing.Size(188, 28);
            this.lblAmtp.TabIndex = 8;
            this.lblAmtp.Text = "Tanggal Ambil";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(252, 276);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // btnSimpantp
            // 
            this.btnSimpantp.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSimpantp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSimpantp.ForeColor = System.Drawing.Color.White;
            this.btnSimpantp.Location = new System.Drawing.Point(778, 395);
            this.btnSimpantp.Name = "btnSimpantp";
            this.btnSimpantp.Size = new System.Drawing.Size(150, 50);
            this.btnSimpantp.TabIndex = 10;
            this.btnSimpantp.Text = "Simpan";
            this.btnSimpantp.UseVisualStyleBackColor = false;
            // 
            // TambahPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 467);
            this.Controls.Add(this.btnSimpantp);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblAmtp);
            this.Controls.Add(this.txtpJumlah);
            this.Controls.Add(this.lblJumtp);
            this.Controls.Add(this.lblnamaptp);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtTpnama);
            this.Controls.Add(this.lblNamatp);
            this.Name = "TambahPesanan";
            this.Text = "TambahPesanan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamatp;
        private System.Windows.Forms.TextBox txtTpnama;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblnamaptp;
        private System.Windows.Forms.Label lblJumtp;
        private System.Windows.Forms.TextBox txtpJumlah;
        private System.Windows.Forms.Label lblAmtp;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSimpantp;
    }
}