namespace KueTradisional
{
    partial class Kueform
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kueform));
            this.lbljudulk = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTambahk = new System.Windows.Forms.Button();
            this.btnUpdatek = new System.Windows.Forms.Button();
            this.btnHapusk = new System.Windows.Forms.Button();
            this.btnTampilk = new System.Windows.Forms.Button();
            this.lblTk = new System.Windows.Forms.Label();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.btnTk = new System.Windows.Forms.Button();
            this.scrp = new System.Windows.Forms.Label();
            this.txtScrp = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTestInjection = new System.Windows.Forms.Button();
            this.btnResetData = new System.Windows.Forms.Button();
            this.btnImportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbljudulk
            // 
            this.lbljudulk.AutoSize = true;
            this.lbljudulk.Font = new System.Drawing.Font("Lucida Sans", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljudulk.ForeColor = System.Drawing.Color.DimGray;
            this.lbljudulk.Location = new System.Drawing.Point(12, 27);
            this.lbljudulk.Name = "lbljudulk";
            this.lbljudulk.Size = new System.Drawing.Size(262, 49);
            this.lbljudulk.TabIndex = 1;
            this.lbljudulk.Text = "Daftar Kue";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(21, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 661);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnTambahk
            // 
            this.btnTambahk.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTambahk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTambahk.Font = new System.Drawing.Font("Lucida Sans", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahk.ForeColor = System.Drawing.Color.White;
            this.btnTambahk.Location = new System.Drawing.Point(1113, 101);
            this.btnTambahk.Name = "btnTambahk";
            this.btnTambahk.Size = new System.Drawing.Size(173, 50);
            this.btnTambahk.TabIndex = 3;
            this.btnTambahk.Text = "Tambah";
            this.btnTambahk.UseVisualStyleBackColor = false;
            this.btnTambahk.Click += new System.EventHandler(this.btnTambahk_Click);
            // 
            // btnUpdatek
            // 
            this.btnUpdatek.BackColor = System.Drawing.Color.OliveDrab;
            this.btnUpdatek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdatek.Font = new System.Drawing.Font("Lucida Sans", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatek.ForeColor = System.Drawing.Color.White;
            this.btnUpdatek.Location = new System.Drawing.Point(1113, 182);
            this.btnUpdatek.Name = "btnUpdatek";
            this.btnUpdatek.Size = new System.Drawing.Size(173, 50);
            this.btnUpdatek.TabIndex = 4;
            this.btnUpdatek.Text = "Edit";
            this.btnUpdatek.UseVisualStyleBackColor = false;
            this.btnUpdatek.Click += new System.EventHandler(this.btnUpdatek_Click);
            // 
            // btnHapusk
            // 
            this.btnHapusk.BackColor = System.Drawing.Color.IndianRed;
            this.btnHapusk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapusk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHapusk.Font = new System.Drawing.Font("Lucida Sans", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapusk.ForeColor = System.Drawing.Color.White;
            this.btnHapusk.Location = new System.Drawing.Point(1113, 264);
            this.btnHapusk.Name = "btnHapusk";
            this.btnHapusk.Size = new System.Drawing.Size(173, 50);
            this.btnHapusk.TabIndex = 5;
            this.btnHapusk.Text = "Hapus";
            this.btnHapusk.UseVisualStyleBackColor = false;
            this.btnHapusk.Click += new System.EventHandler(this.btnHapusk_Click);
            // 
            // btnTampilk
            // 
            this.btnTampilk.BackColor = System.Drawing.Color.DimGray;
            this.btnTampilk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTampilk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTampilk.Font = new System.Drawing.Font("Lucida Sans", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTampilk.ForeColor = System.Drawing.Color.White;
            this.btnTampilk.Location = new System.Drawing.Point(1113, 344);
            this.btnTampilk.Name = "btnTampilk";
            this.btnTampilk.Size = new System.Drawing.Size(173, 50);
            this.btnTampilk.TabIndex = 6;
            this.btnTampilk.Text = "Tampil";
            this.btnTampilk.UseVisualStyleBackColor = false;
            this.btnTampilk.Click += new System.EventHandler(this.btnTampilk_Click);
            // 
            // lblTk
            // 
            this.lblTk.AutoSize = true;
            this.lblTk.Font = new System.Drawing.Font("Lucida Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTk.ForeColor = System.Drawing.Color.DimGray;
            this.lblTk.Location = new System.Drawing.Point(16, 777);
            this.lblTk.Name = "lblTk";
            this.lblTk.Size = new System.Drawing.Size(150, 28);
            this.lblTk.TabIndex = 9;
            this.lblTk.Text = "Total Kue : ";
            // 
            // txtTk
            // 
            this.txtTk.Location = new System.Drawing.Point(172, 777);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(102, 31);
            this.txtTk.TabIndex = 10;
            // 
            // btnTk
            // 
            this.btnTk.BackColor = System.Drawing.Color.Sienna;
            this.btnTk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTk.Font = new System.Drawing.Font("Lucida Sans", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTk.ForeColor = System.Drawing.Color.White;
            this.btnTk.Location = new System.Drawing.Point(301, 768);
            this.btnTk.Name = "btnTk";
            this.btnTk.Size = new System.Drawing.Size(173, 50);
            this.btnTk.TabIndex = 11;
            this.btnTk.Text = "Hitung";
            this.btnTk.UseVisualStyleBackColor = false;
            this.btnTk.Click += new System.EventHandler(this.btnTk_Click);
            // 
            // scrp
            // 
            this.scrp.AutoSize = true;
            this.scrp.Font = new System.Drawing.Font("Lucida Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrp.ForeColor = System.Drawing.Color.DimGray;
            this.scrp.Location = new System.Drawing.Point(686, 48);
            this.scrp.Name = "scrp";
            this.scrp.Size = new System.Drawing.Size(118, 28);
            this.scrp.TabIndex = 14;
            this.scrp.Text = "Search : ";
            // 
            // txtScrp
            // 
            this.txtScrp.Location = new System.Drawing.Point(810, 45);
            this.txtScrp.Name = "txtScrp";
            this.txtScrp.Size = new System.Drawing.Size(282, 31);
            this.txtScrp.TabIndex = 15;
            this.txtScrp.TextChanged += new System.EventHandler(this.txtScrp_TextChanged_1);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(747, 765);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(348, 42);
            this.bindingNavigator1.TabIndex = 16;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(70, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            this.bindingNavigatorCountItem.Click += new System.EventHandler(this.bindingNavigatorCountItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // btnTestInjection
            // 
            this.btnTestInjection.BackColor = System.Drawing.Color.Purple;
            this.btnTestInjection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestInjection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTestInjection.Font = new System.Drawing.Font("Lucida Sans", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestInjection.ForeColor = System.Drawing.Color.White;
            this.btnTestInjection.Location = new System.Drawing.Point(1113, 418);
            this.btnTestInjection.Name = "btnTestInjection";
            this.btnTestInjection.Size = new System.Drawing.Size(173, 50);
            this.btnTestInjection.TabIndex = 17;
            this.btnTestInjection.Text = "Inject";
            this.btnTestInjection.UseVisualStyleBackColor = false;
            this.btnTestInjection.Click += new System.EventHandler(this.btnTestInjection_Click);
            // 
            // btnResetData
            // 
            this.btnResetData.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnResetData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetData.Font = new System.Drawing.Font("Lucida Sans", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetData.ForeColor = System.Drawing.Color.White;
            this.btnResetData.Location = new System.Drawing.Point(1113, 495);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(173, 50);
            this.btnResetData.TabIndex = 18;
            this.btnResetData.Text = "Reset";
            this.btnResetData.UseVisualStyleBackColor = false;
            this.btnResetData.Click += new System.EventHandler(this.btnResetData_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.BackColor = System.Drawing.Color.DeepPink;
            this.btnImportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImportExcel.Font = new System.Drawing.Font("Lucida Sans", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportExcel.ForeColor = System.Drawing.Color.White;
            this.btnImportExcel.Location = new System.Drawing.Point(1113, 680);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(173, 82);
            this.btnImportExcel.TabIndex = 19;
            this.btnImportExcel.Text = "Impor Data";
            this.btnImportExcel.UseVisualStyleBackColor = false;
            this.btnImportExcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kueform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1345, 848);
            this.Controls.Add(this.btnImportExcel);
            this.Controls.Add(this.btnResetData);
            this.Controls.Add(this.btnTestInjection);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.txtScrp);
            this.Controls.Add(this.scrp);
            this.Controls.Add(this.btnTk);
            this.Controls.Add(this.txtTk);
            this.Controls.Add(this.lblTk);
            this.Controls.Add(this.btnTampilk);
            this.Controls.Add(this.btnHapusk);
            this.Controls.Add(this.btnUpdatek);
            this.Controls.Add(this.btnTambahk);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbljudulk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kueform";
            this.Text = "Kue";
            this.Load += new System.EventHandler(this.Kueform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbljudulk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTambahk;
        private System.Windows.Forms.Button btnUpdatek;
        private System.Windows.Forms.Button btnHapusk;
        private System.Windows.Forms.Button btnTampilk;
        private System.Windows.Forms.Label lblTk;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.Button btnTk;
        private System.Windows.Forms.Label scrp;
        private System.Windows.Forms.TextBox txtScrp;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btnTestInjection;
        private System.Windows.Forms.Button btnResetData;
        private System.Windows.Forms.Button btnImportExcel;
    }
}