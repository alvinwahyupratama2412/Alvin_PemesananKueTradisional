namespace KueTradisional
{
    partial class FormReportPesanan
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
            this.dtpAwal = new System.Windows.Forms.DateTimePicker();
            this.dtpAkhir = new System.Windows.Forms.DateTimePicker();
            this.scrp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCetak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpAwal
            // 
            this.dtpAwal.Location = new System.Drawing.Point(292, 96);
            this.dtpAwal.Name = "dtpAwal";
            this.dtpAwal.Size = new System.Drawing.Size(289, 31);
            this.dtpAwal.TabIndex = 0;
            // 
            // dtpAkhir
            // 
            this.dtpAkhir.Location = new System.Drawing.Point(292, 167);
            this.dtpAkhir.Name = "dtpAkhir";
            this.dtpAkhir.Size = new System.Drawing.Size(289, 31);
            this.dtpAkhir.TabIndex = 1;
            // 
            // scrp
            // 
            this.scrp.AutoSize = true;
            this.scrp.Font = new System.Drawing.Font("Lucida Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrp.ForeColor = System.Drawing.Color.DimGray;
            this.scrp.Location = new System.Drawing.Point(60, 98);
            this.scrp.Name = "scrp";
            this.scrp.Size = new System.Drawing.Size(200, 28);
            this.scrp.TabIndex = 15;
            this.scrp.Text = "Tanggal Awal : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(52, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tanggal Akhir : ";
            // 
            // btnCetak
            // 
            this.btnCetak.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCetak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCetak.Font = new System.Drawing.Font("Lucida Sans", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCetak.ForeColor = System.Drawing.Color.White;
            this.btnCetak.Location = new System.Drawing.Point(713, 287);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(173, 50);
            this.btnCetak.TabIndex = 17;
            this.btnCetak.Text = "Lihat";
            this.btnCetak.UseVisualStyleBackColor = false;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // FormReportPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 349);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scrp);
            this.Controls.Add(this.dtpAkhir);
            this.Controls.Add(this.dtpAwal);
            this.Name = "FormReportPesanan";
            this.Text = "FormReportPesanan";
            this.Load += new System.EventHandler(this.FormReportPesanan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpAwal;
        private System.Windows.Forms.DateTimePicker dtpAkhir;
        private System.Windows.Forms.Label scrp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCetak;
    }
}