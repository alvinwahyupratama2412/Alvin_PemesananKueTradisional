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
            this.panelheader = new System.Windows.Forms.Panel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnKue = new System.Windows.Forms.Button();
            this.btnPesanan = new System.Windows.Forms.Button();
            this.panelside.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.Gray;
            this.panelside.Controls.Add(this.btnPesanan);
            this.panelside.Controls.Add(this.btnKue);
            this.panelside.Controls.Add(this.btnConnect);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Location = new System.Drawing.Point(0, 44);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(358, 919);
            this.panelside.TabIndex = 0;
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.Silver;
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1729, 44);
            this.panelheader.TabIndex = 1;
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(358, 44);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1371, 919);
            this.mainpanel.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Gray;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnect.Font = new System.Drawing.Font("Lucida Handwriting", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(37, 860);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(265, 47);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect Database";
            this.btnConnect.UseVisualStyleBackColor = false;
            // 
            // btnKue
            // 
            this.btnKue.BackColor = System.Drawing.Color.Gray;
            this.btnKue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKue.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKue.ForeColor = System.Drawing.Color.White;
            this.btnKue.Location = new System.Drawing.Point(0, 272);
            this.btnKue.Name = "btnKue";
            this.btnKue.Size = new System.Drawing.Size(358, 106);
            this.btnKue.TabIndex = 1;
            this.btnKue.Text = "Kue";
            this.btnKue.UseVisualStyleBackColor = false;
            // 
            // btnPesanan
            // 
            this.btnPesanan.BackColor = System.Drawing.Color.Gray;
            this.btnPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesanan.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesanan.ForeColor = System.Drawing.Color.White;
            this.btnPesanan.Location = new System.Drawing.Point(3, 375);
            this.btnPesanan.Name = "btnPesanan";
            this.btnPesanan.Size = new System.Drawing.Size(358, 106);
            this.btnPesanan.TabIndex = 2;
            this.btnPesanan.Text = "Pesanan";
            this.btnPesanan.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1729, 963);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelside);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelside.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button btnPesanan;
        private System.Windows.Forms.Button btnKue;
    }
}

