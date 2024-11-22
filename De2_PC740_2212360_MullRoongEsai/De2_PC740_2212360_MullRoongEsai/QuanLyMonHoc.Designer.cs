namespace De2_PC740_2212360_MullRoongEsai
{
    partial class QuanLyMonHoc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rb2015 = new System.Windows.Forms.RadioButton();
            this.rb2017 = new System.Windows.Forms.RadioButton();
            this.rb2020 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTimTheoTC = new System.Windows.Forms.RadioButton();
            this.tbTimtheoMaMH = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dsMonHoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDanhSáchĐăngKýMônHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tổngSốLượngSVĐăngKýMHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMonHoc)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb2020);
            this.groupBox1.Controls.Add(this.rb2017);
            this.groupBox1.Controls.Add(this.rb2015);
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chương trình đào tạo";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(21, 32);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(56, 17);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Tất cả";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rb2015
            // 
            this.rb2015.AutoSize = true;
            this.rb2015.Location = new System.Drawing.Point(126, 32);
            this.rb2015.Name = "rb2015";
            this.rb2015.Size = new System.Drawing.Size(49, 17);
            this.rb2015.TabIndex = 0;
            this.rb2015.TabStop = true;
            this.rb2015.Text = "2015";
            this.rb2015.UseVisualStyleBackColor = true;
            this.rb2015.CheckedChanged += new System.EventHandler(this.rb2015_CheckedChanged);
            // 
            // rb2017
            // 
            this.rb2017.AutoSize = true;
            this.rb2017.Location = new System.Drawing.Point(232, 32);
            this.rb2017.Name = "rb2017";
            this.rb2017.Size = new System.Drawing.Size(49, 17);
            this.rb2017.TabIndex = 0;
            this.rb2017.TabStop = true;
            this.rb2017.Text = "2017";
            this.rb2017.UseVisualStyleBackColor = true;
            this.rb2017.CheckedChanged += new System.EventHandler(this.rb2017_CheckedChanged);
            // 
            // rb2020
            // 
            this.rb2020.AutoSize = true;
            this.rb2020.Location = new System.Drawing.Point(347, 32);
            this.rb2020.Name = "rb2020";
            this.rb2020.Size = new System.Drawing.Size(49, 17);
            this.rb2020.TabIndex = 0;
            this.rb2020.TabStop = true;
            this.rb2020.Text = "2020";
            this.rb2020.UseVisualStyleBackColor = true;
            this.rb2020.CheckedChanged += new System.EventHandler(this.rb2020_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.rbTimTheoTC);
            this.groupBox2.Controls.Add(this.tbTimtheoMaMH);
            this.groupBox2.Location = new System.Drawing.Point(26, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 73);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // rbTimTheoTC
            // 
            this.rbTimTheoTC.AutoSize = true;
            this.rbTimTheoTC.Location = new System.Drawing.Point(152, 32);
            this.rbTimTheoTC.Name = "rbTimTheoTC";
            this.rbTimTheoTC.Size = new System.Drawing.Size(81, 17);
            this.rbTimTheoTC.TabIndex = 0;
            this.rbTimTheoTC.TabStop = true;
            this.rbTimTheoTC.Text = "Theo số TC";
            this.rbTimTheoTC.UseVisualStyleBackColor = true;
            // 
            // tbTimtheoMaMH
            // 
            this.tbTimtheoMaMH.AutoSize = true;
            this.tbTimtheoMaMH.Location = new System.Drawing.Point(21, 32);
            this.tbTimtheoMaMH.Name = "tbTimtheoMaMH";
            this.tbTimtheoMaMH.Size = new System.Drawing.Size(107, 17);
            this.tbTimtheoMaMH.TabIndex = 0;
            this.tbTimtheoMaMH.TabStop = true;
            this.tbTimtheoMaMH.Text = "Theo mã/tên MH";
            this.tbTimtheoMaMH.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(386, 20);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dsMonHoc);
            this.groupBox3.Location = new System.Drawing.Point(26, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(640, 233);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Môn Học";
            // 
            // dsMonHoc
            // 
            this.dsMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dsMonHoc.ContextMenuStrip = this.contextMenuStrip1;
            this.dsMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsMonHoc.Location = new System.Drawing.Point(3, 16);
            this.dsMonHoc.Name = "dsMonHoc";
            this.dsMonHoc.Size = new System.Drawing.Size(634, 214);
            this.dsMonHoc.TabIndex = 0;
            this.dsMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaMH";
            this.Column1.HeaderText = "Mã Môn Học";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenMH";
            this.Column2.HeaderText = "Tên Môn Học";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaCTĐT";
            this.Column3.HeaderText = "Chương trình đào tạo";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoTC";
            this.Column4.HeaderText = "Số tín chỉ";
            this.Column4.Name = "Column4";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem,
            this.xemDanhSáchĐăngKýMônHToolStripMenuItem,
            this.tổngSốLượngSVĐăngKýMHToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(252, 70);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // xemDanhSáchĐăngKýMônHToolStripMenuItem
            // 
            this.xemDanhSáchĐăngKýMônHToolStripMenuItem.Name = "xemDanhSáchĐăngKýMônHToolStripMenuItem";
            this.xemDanhSáchĐăngKýMônHToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.xemDanhSáchĐăngKýMônHToolStripMenuItem.Text = "Xem danh sách đăng ký môn học";
            // 
            // tổngSốLượngSVĐăngKýMHToolStripMenuItem
            // 
            this.tổngSốLượngSVĐăngKýMHToolStripMenuItem.Name = "tổngSốLượngSVĐăngKýMHToolStripMenuItem";
            this.tổngSốLượngSVĐăngKýMHToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.tổngSốLượngSVĐăngKýMHToolStripMenuItem.Text = "Tổng số lượng SV đăng ký MH";
            // 
            // QuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLyMonHoc";
            this.Text = "QuanLyMonHoc";
            this.Load += new System.EventHandler(this.QuanLyMonHoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsMonHoc)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb2020;
        private System.Windows.Forms.RadioButton rb2017;
        private System.Windows.Forms.RadioButton rb2015;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbTimTheoTC;
        private System.Windows.Forms.RadioButton tbTimtheoMaMH;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dsMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemDanhSáchĐăngKýMônHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tổngSốLượngSVĐăngKýMHToolStripMenuItem;
    }
}