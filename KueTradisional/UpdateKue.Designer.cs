namespace KueTradisional
{
    partial class UpdateKue
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
            this.lblNamakU = new System.Windows.Forms.Label();
            this.lblHargakU = new System.Windows.Forms.Label();
            this.txtUknama = new System.Windows.Forms.TextBox();
            this.txtUkharga = new System.Windows.Forms.TextBox();
            this.btnUk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNamakU
            // 
            this.lblNamakU.AutoSize = true;
            this.lblNamakU.Font = new System.Drawing.Font("Lucida Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamakU.Location = new System.Drawing.Point(50, 72);
            this.lblNamakU.Name = "lblNamakU";
            this.lblNamakU.Size = new System.Drawing.Size(136, 28);
            this.lblNamakU.TabIndex = 1;
            this.lblNamakU.Text = "Nama Kue";
            // 
            // lblHargakU
            // 
            this.lblHargakU.AutoSize = true;
            this.lblHargakU.Font = new System.Drawing.Font("Lucida Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHargakU.Location = new System.Drawing.Point(50, 173);
            this.lblHargakU.Name = "lblHargakU";
            this.lblHargakU.Size = new System.Drawing.Size(87, 28);
            this.lblHargakU.TabIndex = 2;
            this.lblHargakU.Text = "Harga";
            // 
            // txtUknama
            // 
            this.txtUknama.Location = new System.Drawing.Point(222, 72);
            this.txtUknama.Name = "txtUknama";
            this.txtUknama.Size = new System.Drawing.Size(328, 31);
            this.txtUknama.TabIndex = 3;
            // 
            // txtUkharga
            // 
            this.txtUkharga.Location = new System.Drawing.Point(222, 173);
            this.txtUkharga.Name = "txtUkharga";
            this.txtUkharga.Size = new System.Drawing.Size(328, 31);
            this.txtUkharga.TabIndex = 4;
            // 
            // btnUk
            // 
            this.btnUk.BackColor = System.Drawing.Color.Olive;
            this.btnUk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUk.ForeColor = System.Drawing.Color.White;
            this.btnUk.Location = new System.Drawing.Point(563, 308);
            this.btnUk.Name = "btnUk";
            this.btnUk.Size = new System.Drawing.Size(150, 50);
            this.btnUk.TabIndex = 5;
            this.btnUk.Text = "Update";
            this.btnUk.UseVisualStyleBackColor = false;
            // 
            // UpdateKue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 387);
            this.Controls.Add(this.btnUk);
            this.Controls.Add(this.txtUkharga);
            this.Controls.Add(this.txtUknama);
            this.Controls.Add(this.lblHargakU);
            this.Controls.Add(this.lblNamakU);
            this.Name = "UpdateKue";
            this.Text = "UpdateKue";
            this.Load += new System.EventHandler(this.UpdateKue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamakU;
        private System.Windows.Forms.Label lblHargakU;
        private System.Windows.Forms.TextBox txtUknama;
        private System.Windows.Forms.TextBox txtUkharga;
        private System.Windows.Forms.Button btnUk;
    }
}