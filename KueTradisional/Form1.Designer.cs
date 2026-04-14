namespace KueTradisional
{
    partial class Form1
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
            this.panelside = new System.Windows.Forms.Panel();
            this.btnPesanan = new System.Windows.Forms.Button();
            this.btnKue = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panelheader = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panelside.SuspendLayout();
            this.panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.Gray;
            this.panelside.Controls.Add(this.logo);
            this.panelside.Controls.Add(this.btnPesanan);
            this.panelside.Controls.Add(this.btnKue);
            this.panelside.Controls.Add(this.btnConnect);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Location = new System.Drawing.Point(0, 44);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(358, 919);
            this.panelside.TabIndex = 0;
            // 
            // btnPesanan
            // 
            this.btnPesanan.BackColor = System.Drawing.Color.Gray;
            this.btnPesanan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesanan.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesanan.ForeColor = System.Drawing.Color.White;
            this.btnPesanan.Location = new System.Drawing.Point(0, 427);
            this.btnPesanan.Name = "btnPesanan";
            this.btnPesanan.Size = new System.Drawing.Size(358, 106);
            this.btnPesanan.TabIndex = 2;
            this.btnPesanan.Text = "Pesanan";
            this.btnPesanan.UseVisualStyleBackColor = false;
            this.btnPesanan.Click += new System.EventHandler(this.btnPesanan_Click);
            // 
            // btnKue
            // 
            this.btnKue.BackColor = System.Drawing.Color.Gray;
            this.btnKue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKue.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKue.ForeColor = System.Drawing.Color.White;
            this.btnKue.Location = new System.Drawing.Point(0, 326);
            this.btnKue.Name = "btnKue";
            this.btnKue.Size = new System.Drawing.Size(358, 106);
            this.btnKue.TabIndex = 1;
            this.btnKue.Text = "Kue";
            this.btnKue.UseVisualStyleBackColor = false;
            this.btnKue.Click += new System.EventHandler(this.btnKue_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Gray;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnect.Font = new System.Drawing.Font("Lucida Handwriting", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(38, 823);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(271, 59);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect Database";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.Silver;
            this.panelheader.Controls.Add(this.lbltitle);
            this.panelheader.Controls.Add(this.btnClose);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1668, 44);
            this.panelheader.TabIndex = 1;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Lucida Sans", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.DimGray;
            this.lbltitle.Location = new System.Drawing.Point(12, 8);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(392, 32);
            this.lbltitle.TabIndex = 2;
            this.lbltitle.Text = "Pemesanan Kue Tradisional";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1621, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 44);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(358, 44);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1310, 919);
            this.mainpanel.TabIndex = 2;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // logo
            // 
            this.logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logo.Image = global::KueTradisional.Properties.Resources.Logo_sistem_pemesanan_kue_tradisional__3_;
            this.logo.Location = new System.Drawing.Point(49, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(270, 270);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1668, 963);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelside);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelside.ResumeLayout(false);
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button btnPesanan;
        private System.Windows.Forms.Button btnKue;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbltitle;
    }
}

