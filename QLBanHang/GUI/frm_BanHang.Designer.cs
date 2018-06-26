namespace QLBanHang.GUI
{
    partial class frm_BanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BanHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_KiemTraKho = new System.Windows.Forms.Button();
            this.btn_ThemHang = new System.Windows.Forms.Button();
            this.btn_SearchHang = new System.Windows.Forms.Button();
            this.cb_resHang = new System.Windows.Forms.ComboBox();
            this.txt_KeySearchHang = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grid_DSChiTiet = new System.Windows.Forms.DataGridView();
            this.giamSL = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tangSL = new System.Windows.Forms.DataGridViewButtonColumn();
            this.xoaTruong = new System.Windows.Forms.DataGridViewButtonColumn();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_MaKhach = new System.Windows.Forms.RichTextBox();
            this.txtMakhach = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoaiKhach = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_NhanVien = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.lb_TienTraLai = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.print_Dialog = new System.Windows.Forms.PrintPreviewDialog();
            this.print_Document = new System.Drawing.Printing.PrintDocument();
            this.maHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoHoaDonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSChiTiet)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoHoaDonBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btn_KiemTraKho);
            this.panel1.Controls.Add(this.btn_ThemHang);
            this.panel1.Controls.Add(this.btn_SearchHang);
            this.panel1.Controls.Add(this.cb_resHang);
            this.panel1.Controls.Add(this.txt_KeySearchHang);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 37);
            this.panel1.TabIndex = 5;
            // 
            // btn_KiemTraKho
            // 
            this.btn_KiemTraKho.BackColor = System.Drawing.Color.Firebrick;
            this.btn_KiemTraKho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_KiemTraKho.BackgroundImage")));
            this.btn_KiemTraKho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_KiemTraKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KiemTraKho.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_KiemTraKho.Location = new System.Drawing.Point(641, 1);
            this.btn_KiemTraKho.Name = "btn_KiemTraKho";
            this.btn_KiemTraKho.Size = new System.Drawing.Size(159, 36);
            this.btn_KiemTraKho.TabIndex = 3;
            this.btn_KiemTraKho.Text = "Kiểm tra kho";
            this.btn_KiemTraKho.UseVisualStyleBackColor = false;
            // 
            // btn_ThemHang
            // 
            this.btn_ThemHang.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ThemHang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ThemHang.BackgroundImage")));
            this.btn_ThemHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ThemHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThemHang.Location = new System.Drawing.Point(516, 1);
            this.btn_ThemHang.Name = "btn_ThemHang";
            this.btn_ThemHang.Size = new System.Drawing.Size(121, 36);
            this.btn_ThemHang.TabIndex = 2;
            this.btn_ThemHang.Text = "Thêm";
            this.btn_ThemHang.UseVisualStyleBackColor = false;
            this.btn_ThemHang.Click += new System.EventHandler(this.btn_ThemHang_Click);
            // 
            // btn_SearchHang
            // 
            this.btn_SearchHang.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_SearchHang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SearchHang.BackgroundImage")));
            this.btn_SearchHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_SearchHang.Location = new System.Drawing.Point(250, 1);
            this.btn_SearchHang.Name = "btn_SearchHang";
            this.btn_SearchHang.Size = new System.Drawing.Size(41, 36);
            this.btn_SearchHang.TabIndex = 1;
            this.btn_SearchHang.UseVisualStyleBackColor = false;
            // 
            // cb_resHang
            // 
            this.cb_resHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_resHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_resHang.ForeColor = System.Drawing.Color.DimGray;
            this.cb_resHang.FormattingEnabled = true;
            this.cb_resHang.ItemHeight = 24;
            this.cb_resHang.Location = new System.Drawing.Point(293, 2);
            this.cb_resHang.Name = "cb_resHang";
            this.cb_resHang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_resHang.Size = new System.Drawing.Size(217, 32);
            this.cb_resHang.TabIndex = 1;
            // 
            // txt_KeySearchHang
            // 
            this.txt_KeySearchHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_KeySearchHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KeySearchHang.Location = new System.Drawing.Point(2, 4);
            this.txt_KeySearchHang.MaxLength = 50;
            this.txt_KeySearchHang.Name = "txt_KeySearchHang";
            this.txt_KeySearchHang.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txt_KeySearchHang.Size = new System.Drawing.Size(248, 31);
            this.txt_KeySearchHang.TabIndex = 1;
            this.txt_KeySearchHang.Text = "";
            this.txt_KeySearchHang.TextChanged += new System.EventHandler(this.txt_KeySearchHang_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.grid_DSChiTiet);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 224);
            this.panel2.TabIndex = 6;
            // 
            // grid_DSChiTiet
            // 
            this.grid_DSChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_DSChiTiet.AutoGenerateColumns = false;
            this.grid_DSChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_DSChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHangDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.giamSL,
            this.soLuongDataGridViewTextBoxColumn,
            this.tangSL,
            this.dataGridViewTextBoxColumn2,
            this.xoaTruong});
            this.grid_DSChiTiet.DataSource = this.infoHoaDonBindingSource1;
            this.grid_DSChiTiet.Location = new System.Drawing.Point(577, 0);
            this.grid_DSChiTiet.Name = "grid_DSChiTiet";
            this.grid_DSChiTiet.Size = new System.Drawing.Size(362, 222);
            this.grid_DSChiTiet.TabIndex = 2;
            this.grid_DSChiTiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_DSChiTiet_CellContentClick);
            // 
            // giamSL
            // 
            this.giamSL.HeaderText = "Giảm";
            this.giamSL.Name = "giamSL";
            this.giamSL.Text = "Giảm";
            this.giamSL.Width = 50;
            // 
            // tangSL
            // 
            this.tangSL.HeaderText = "Tăng";
            this.tangSL.Name = "tangSL";
            this.tangSL.Text = "Tăng";
            this.tangSL.Width = 50;
            // 
            // xoaTruong
            // 
            this.xoaTruong.HeaderText = "Xóa trường";
            this.xoaTruong.Name = "xoaTruong";
            this.xoaTruong.Text = "Xóa trường";
            this.xoaTruong.Width = 95;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(0, -6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(576, 228);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã hàng";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên hàng";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số lượng còn lại";
            this.columnHeader4.Width = 100;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(0, 267);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 185);
            this.panel3.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.txt_MaKhach);
            this.groupBox1.Controls.Add(this.txtMakhach);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSoDienThoai);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTenKhach);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtLoaiKhach);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SeaGreen;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Location = new System.Drawing.Point(201, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 33);
            this.button4.TabIndex = 14;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_MaKhach
            // 
            this.txt_MaKhach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_MaKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKhach.Location = new System.Drawing.Point(7, 20);
            this.txt_MaKhach.MaxLength = 50;
            this.txt_MaKhach.Name = "txt_MaKhach";
            this.txt_MaKhach.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txt_MaKhach.Size = new System.Drawing.Size(188, 30);
            this.txt_MaKhach.TabIndex = 13;
            this.txt_MaKhach.Text = "";
            this.txt_MaKhach.TextChanged += new System.EventHandler(this.txt_MaKhach_TextChanged);
            // 
            // txtMakhach
            // 
            this.txtMakhach.AutoSize = true;
            this.txtMakhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMakhach.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtMakhach.Location = new System.Drawing.Point(81, 86);
            this.txtMakhach.Name = "txtMakhach";
            this.txtMakhach.Size = new System.Drawing.Size(17, 16);
            this.txtMakhach.TabIndex = 12;
            this.txtMakhach.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.CadetBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(8, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Mã khách :";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.AutoSize = true;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtSoDienThoai.Location = new System.Drawing.Point(81, 159);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(17, 16);
            this.txtSoDienThoai.TabIndex = 10;
            this.txtSoDienThoai.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.CadetBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(34, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "SĐT :";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AutoSize = true;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtDiaChi.Location = new System.Drawing.Point(81, 134);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(17, 16);
            this.txtDiaChi.TabIndex = 8;
            this.txtDiaChi.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CadetBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(23, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Địa chỉ :";
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.AutoSize = true;
            this.txtTenKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhach.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtTenKhach.Location = new System.Drawing.Point(81, 110);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(17, 16);
            this.txtTenKhach.TabIndex = 6;
            this.txtTenKhach.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CadetBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(4, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên khách :";
            // 
            // txtLoaiKhach
            // 
            this.txtLoaiKhach.AutoSize = true;
            this.txtLoaiKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiKhach.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtLoaiKhach.Location = new System.Drawing.Point(81, 59);
            this.txtLoaiKhach.Name = "txtLoaiKhach";
            this.txtLoaiKhach.Size = new System.Drawing.Size(101, 16);
            this.txtLoaiKhach.TabIndex = 4;
            this.txtLoaiKhach.Text = "Mua qua đường";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(25, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Khách :";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Location = new System.Drawing.Point(290, 267);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(286, 185);
            this.panel4.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.cb_NhanVien);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(2, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhân viên";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // cb_NhanVien
            // 
            this.cb_NhanVien.AllowDrop = true;
            this.cb_NhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_NhanVien.ForeColor = System.Drawing.Color.DimGray;
            this.cb_NhanVien.FormattingEnabled = true;
            this.cb_NhanVien.ItemHeight = 24;
            this.cb_NhanVien.Location = new System.Drawing.Point(6, 19);
            this.cb_NhanVien.Name = "cb_NhanVien";
            this.cb_NhanVien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_NhanVien.Size = new System.Drawing.Size(271, 32);
            this.cb_NhanVien.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Controls.Add(this.groupBox3);
            this.panel5.Location = new System.Drawing.Point(579, 266);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(360, 185);
            this.panel5.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.richTextBox3);
            this.groupBox3.Controls.Add(this.lb_TienTraLai);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.lb_TongTien);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(2, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 185);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin đơn hàng";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.Location = new System.Drawing.Point(136, 66);
            this.richTextBox3.MaxLength = 50;
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox3.Size = new System.Drawing.Size(219, 30);
            this.richTextBox3.TabIndex = 14;
            this.richTextBox3.Text = "";
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // lb_TienTraLai
            // 
            this.lb_TienTraLai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TienTraLai.AutoSize = true;
            this.lb_TienTraLai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_TienTraLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TienTraLai.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_TienTraLai.Location = new System.Drawing.Point(137, 110);
            this.lb_TienTraLai.Name = "lb_TienTraLai";
            this.lb_TienTraLai.Size = new System.Drawing.Size(82, 31);
            this.lb_TienTraLai.TabIndex = 11;
            this.lb_TienTraLai.Text = "0.000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(12, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Tiền trả lại khách :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(25, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Tiền khách trả :";
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTien.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_TongTien.Location = new System.Drawing.Point(137, 20);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(82, 31);
            this.lb_TongTien.TabIndex = 6;
            this.lb_TongTien.Text = "0.000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(6, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Tổng tiền hóa đơn :";
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.Gray;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(376, 455);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(170, 37);
            this.button7.TabIndex = 15;
            this.button7.Text = "Hủy hóa đơn";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.Maroon;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(552, 455);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(199, 37);
            this.button6.TabIndex = 14;
            this.button6.Text = "Thanh toán và in";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.SeaGreen;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(757, 455);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 37);
            this.button5.TabIndex = 13;
            this.button5.Text = "Thanh toán";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // print_Dialog
            // 
            this.print_Dialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.print_Dialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.print_Dialog.ClientSize = new System.Drawing.Size(400, 300);
            this.print_Dialog.Enabled = true;
            this.print_Dialog.Icon = ((System.Drawing.Icon)(resources.GetObject("print_Dialog.Icon")));
            this.print_Dialog.Name = "print_Dialog";
            this.print_Dialog.Visible = false;
            // 
            // print_Document
            // 
            this.print_Document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.print_Document_PrintPage);
            // 
            // maHangDataGridViewTextBoxColumn
            // 
            this.maHangDataGridViewTextBoxColumn.DataPropertyName = "maHang";
            this.maHangDataGridViewTextBoxColumn.HeaderText = "maHang";
            this.maHangDataGridViewTextBoxColumn.Name = "maHangDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tenHang";
            this.dataGridViewTextBoxColumn1.HeaderText = "tenHang";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "soLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "soLuong";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "thanhTien";
            this.dataGridViewTextBoxColumn2.HeaderText = "thanhTien";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // infoHoaDonBindingSource1
            // 
            this.infoHoaDonBindingSource1.DataSource = typeof(QLBanHang.DAL.InfoHoaDon);
            // 
            // frm_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(939, 496);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_BanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_BanHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_BanHang_FormClosing);
            this.Load += new System.EventHandler(this.frm_BanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSChiTiet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoHoaDonBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label txtSoDienThoai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtTenKhach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtLoaiKhach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtMakhach;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lb_TienTraLai;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox txt_KeySearchHang;
        private System.Windows.Forms.Button btn_SearchHang;
        private System.Windows.Forms.ComboBox cb_resHang;
        private System.Windows.Forms.Button btn_KiemTraKho;
        private System.Windows.Forms.Button btn_ThemHang;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox txt_MaKhach;
        private System.Windows.Forms.ComboBox cb_NhanVien;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.DataGridView grid_DSChiTiet;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn giamSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn tangSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn xoaTruong;
        private System.Windows.Forms.BindingSource infoHoaDonBindingSource1;
        private System.Windows.Forms.PrintPreviewDialog print_Dialog;
        private System.Drawing.Printing.PrintDocument print_Document;
    }
}