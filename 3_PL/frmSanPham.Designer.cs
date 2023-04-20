namespace _3_PL
{
    partial class frmSanPham
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
            this.txtThoiGianBaoHanhSP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbNhaCungCapSP = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTimKiemSP = new System.Windows.Forms.TextBox();
            this.cbbLocLoaiSanPhamSP = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTimKiemSP = new System.Windows.Forms.Button();
            this.cbbLocHangSP = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvSanPhamSP = new System.Windows.Forms.DataGridView();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnShowSP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdHetHangSP = new System.Windows.Forms.RadioButton();
            this.rdConHangSP = new System.Windows.Forms.RadioButton();
            this.cbbLoaiSanPhamSP = new System.Windows.Forms.ComboBox();
            this.cbbHangSP = new System.Windows.Forms.ComboBox();
            this.txtMoTaSP = new System.Windows.Forms.TextBox();
            this.txtGiaTienSP = new System.Windows.Forms.TextBox();
            this.txtTenSanPhamSP = new System.Windows.Forms.TextBox();
            this.txtIDSanPham = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSoLuongSP = new System.Windows.Forms.NumericUpDown();
            this.iddddd = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.IDSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongSP)).BeginInit();
            this.SuspendLayout();
            // 
            // txtThoiGianBaoHanhSP
            // 
            this.txtThoiGianBaoHanhSP.Location = new System.Drawing.Point(153, 251);
            this.txtThoiGianBaoHanhSP.Name = "txtThoiGianBaoHanhSP";
            this.txtThoiGianBaoHanhSP.Size = new System.Drawing.Size(412, 27);
            this.txtThoiGianBaoHanhSP.TabIndex = 92;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 20);
            this.label12.TabIndex = 91;
            this.label12.Text = "Thời gian bảo hành :";
            // 
            // cbbNhaCungCapSP
            // 
            this.cbbNhaCungCapSP.FormattingEnabled = true;
            this.cbbNhaCungCapSP.Items.AddRange(new object[] {
            "Trống",
            "A"});
            this.cbbNhaCungCapSP.Location = new System.Drawing.Point(153, 176);
            this.cbbNhaCungCapSP.Name = "cbbNhaCungCapSP";
            this.cbbNhaCungCapSP.Size = new System.Drawing.Size(284, 28);
            this.cbbNhaCungCapSP.TabIndex = 90;
            this.cbbNhaCungCapSP.Text = "Trống";
            this.cbbNhaCungCapSP.SelectedIndexChanged += new System.EventHandler(this.cbbNhaCungCapSP_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 89;
            this.label11.Text = "Nhà cung cấp :";
            // 
            // txtTimKiemSP
            // 
            this.txtTimKiemSP.Location = new System.Drawing.Point(4, 346);
            this.txtTimKiemSP.Name = "txtTimKiemSP";
            this.txtTimKiemSP.PlaceholderText = "Nhập mã hoặc tên sản phẩm";
            this.txtTimKiemSP.Size = new System.Drawing.Size(430, 27);
            this.txtTimKiemSP.TabIndex = 87;
            // 
            // cbbLocLoaiSanPhamSP
            // 
            this.cbbLocLoaiSanPhamSP.FormattingEnabled = true;
            this.cbbLocLoaiSanPhamSP.Location = new System.Drawing.Point(122, 379);
            this.cbbLocLoaiSanPhamSP.Name = "cbbLocLoaiSanPhamSP";
            this.cbbLocLoaiSanPhamSP.Size = new System.Drawing.Size(151, 28);
            this.cbbLocLoaiSanPhamSP.TabIndex = 77;
            this.cbbLocLoaiSanPhamSP.Text = "Trống";
            this.cbbLocLoaiSanPhamSP.SelectedIndexChanged += new System.EventHandler(this.cbbLocLoaiSanPhamSP_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 20);
            this.label10.TabIndex = 69;
            this.label10.Text = "Hãng sản phẩm :";
            // 
            // btnTimKiemSP
            // 
            this.btnTimKiemSP.Location = new System.Drawing.Point(452, 334);
            this.btnTimKiemSP.Name = "btnTimKiemSP";
            this.btnTimKiemSP.Size = new System.Drawing.Size(113, 39);
            this.btnTimKiemSP.TabIndex = 86;
            this.btnTimKiemSP.Text = "TÌm kiếm";
            this.btnTimKiemSP.UseVisualStyleBackColor = true;
            this.btnTimKiemSP.Click += new System.EventHandler(this.btnTimKiemSP_Click);
            // 
            // cbbLocHangSP
            // 
            this.cbbLocHangSP.FormattingEnabled = true;
            this.cbbLocHangSP.Location = new System.Drawing.Point(416, 379);
            this.cbbLocHangSP.Name = "cbbLocHangSP";
            this.cbbLocHangSP.Size = new System.Drawing.Size(151, 28);
            this.cbbLocHangSP.TabIndex = 78;
            this.cbbLocHangSP.Text = "Trống";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 85;
            this.label8.Text = "Số lượng :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 70;
            this.label9.Text = "Loại sản phẩm :";
            // 
            // dgvSanPhamSP
            // 
            this.dgvSanPhamSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPhamSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPhamSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSanPham,
            this.TenSanPham,
            this.Hang,
            this.LoaiSanPham,
            this.NhaCungCap,
            this.SoLuong,
            this.GiaNhap,
            this.GiaBan,
            this.ThoiGianBaoHanh,
            this.TrangThai,
            this.MoTa,
            this.Column5});
            this.dgvSanPhamSP.Location = new System.Drawing.Point(10, 419);
            this.dgvSanPhamSP.Name = "dgvSanPhamSP";
            this.dgvSanPhamSP.RowHeadersWidth = 51;
            this.dgvSanPhamSP.RowTemplate.Height = 29;
            this.dgvSanPhamSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPhamSP.Size = new System.Drawing.Size(772, 196);
            this.dgvSanPhamSP.TabIndex = 84;
            this.dgvSanPhamSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPhamSP_CellClick);
            this.dgvSanPhamSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPhamSP_CellContentClick);
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.Location = new System.Drawing.Point(700, 247);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(82, 37);
            this.btnSuaSP.TabIndex = 83;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.UseVisualStyleBackColor = true;
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(609, 247);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(82, 37);
            this.btnThemSP.TabIndex = 82;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnShowSP
            // 
            this.btnShowSP.Location = new System.Drawing.Point(609, 204);
            this.btnShowSP.Name = "btnShowSP";
            this.btnShowSP.Size = new System.Drawing.Size(173, 37);
            this.btnShowSP.TabIndex = 81;
            this.btnShowSP.Text = "Show";
            this.btnShowSP.UseVisualStyleBackColor = true;
            this.btnShowSP.Click += new System.EventHandler(this.btnShowSP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(609, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 148);
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdHetHangSP);
            this.groupBox1.Controls.Add(this.rdConHangSP);
            this.groupBox1.Location = new System.Drawing.Point(443, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 83);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trạng thái";
            // 
            // rdHetHangSP
            // 
            this.rdHetHangSP.AutoSize = true;
            this.rdHetHangSP.Location = new System.Drawing.Point(18, 53);
            this.rdHetHangSP.Name = "rdHetHangSP";
            this.rdHetHangSP.Size = new System.Drawing.Size(91, 24);
            this.rdHetHangSP.TabIndex = 1;
            this.rdHetHangSP.TabStop = true;
            this.rdHetHangSP.Text = "Hết hàng";
            this.rdHetHangSP.UseVisualStyleBackColor = true;
            // 
            // rdConHangSP
            // 
            this.rdConHangSP.AutoSize = true;
            this.rdConHangSP.Location = new System.Drawing.Point(18, 26);
            this.rdConHangSP.Name = "rdConHangSP";
            this.rdConHangSP.Size = new System.Drawing.Size(93, 24);
            this.rdConHangSP.TabIndex = 0;
            this.rdConHangSP.TabStop = true;
            this.rdConHangSP.Text = "Còn hàng";
            this.rdConHangSP.UseVisualStyleBackColor = true;
            // 
            // cbbLoaiSanPhamSP
            // 
            this.cbbLoaiSanPhamSP.FormattingEnabled = true;
            this.cbbLoaiSanPhamSP.Items.AddRange(new object[] {
            "Trống ",
            "A"});
            this.cbbLoaiSanPhamSP.Location = new System.Drawing.Point(153, 142);
            this.cbbLoaiSanPhamSP.Name = "cbbLoaiSanPhamSP";
            this.cbbLoaiSanPhamSP.Size = new System.Drawing.Size(284, 28);
            this.cbbLoaiSanPhamSP.TabIndex = 76;
            this.cbbLoaiSanPhamSP.Text = "Trống";
            this.cbbLoaiSanPhamSP.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiSanPhamSP_SelectedIndexChanged);
            // 
            // cbbHangSP
            // 
            this.cbbHangSP.FormattingEnabled = true;
            this.cbbHangSP.Items.AddRange(new object[] {
            "Trống",
            "A"});
            this.cbbHangSP.Location = new System.Drawing.Point(153, 108);
            this.cbbHangSP.Name = "cbbHangSP";
            this.cbbHangSP.Size = new System.Drawing.Size(284, 28);
            this.cbbHangSP.TabIndex = 75;
            this.cbbHangSP.Text = "Trống";
            this.cbbHangSP.SelectedIndexChanged += new System.EventHandler(this.cbbHangSP_SelectedIndexChanged);
            // 
            // txtMoTaSP
            // 
            this.txtMoTaSP.Location = new System.Drawing.Point(153, 291);
            this.txtMoTaSP.Multiline = true;
            this.txtMoTaSP.Name = "txtMoTaSP";
            this.txtMoTaSP.Size = new System.Drawing.Size(412, 37);
            this.txtMoTaSP.TabIndex = 74;
            // 
            // txtGiaTienSP
            // 
            this.txtGiaTienSP.Location = new System.Drawing.Point(362, 217);
            this.txtGiaTienSP.Name = "txtGiaTienSP";
            this.txtGiaTienSP.Size = new System.Drawing.Size(62, 27);
            this.txtGiaTienSP.TabIndex = 73;
            this.txtGiaTienSP.TextChanged += new System.EventHandler(this.txtGiaTienSP_TextChanged);
            this.txtGiaTienSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaTienSP_KeyPress);
            // 
            // txtTenSanPhamSP
            // 
            this.txtTenSanPhamSP.Location = new System.Drawing.Point(153, 75);
            this.txtTenSanPhamSP.Name = "txtTenSanPhamSP";
            this.txtTenSanPhamSP.Size = new System.Drawing.Size(356, 27);
            this.txtTenSanPhamSP.TabIndex = 72;
            // 
            // txtIDSanPham
            // 
            this.txtIDSanPham.Location = new System.Drawing.Point(153, 43);
            this.txtIDSanPham.Name = "txtIDSanPham";
            this.txtIDSanPham.ReadOnly = true;
            this.txtIDSanPham.Size = new System.Drawing.Size(152, 27);
            this.txtIDSanPham.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "Mô tả :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 67;
            this.label6.Text = "Giá nhập :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 66;
            this.label7.Text = "Loại sản phẩm :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Hãng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Tên sản phẩm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "IDSanPham :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 38);
            this.label1.TabIndex = 62;
            this.label1.Text = "Quản lý sản phẩm";
            // 
            // nudSoLuongSP
            // 
            this.nudSoLuongSP.Location = new System.Drawing.Point(153, 215);
            this.nudSoLuongSP.Name = "nudSoLuongSP";
            this.nudSoLuongSP.Size = new System.Drawing.Size(129, 27);
            this.nudSoLuongSP.TabIndex = 88;
            this.nudSoLuongSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudSoLuongSP_KeyPress);
            // 
            // iddddd
            // 
            this.iddddd.AutoSize = true;
            this.iddddd.ForeColor = System.Drawing.Color.LightBlue;
            this.iddddd.Location = new System.Drawing.Point(4, 33);
            this.iddddd.Name = "iddddd";
            this.iddddd.Size = new System.Drawing.Size(92, 20);
            this.iddddd.TabIndex = 93;
            this.iddddd.Text = "IDSanPham :";
            this.iddddd.TextChanged += new System.EventHandler(this.iddddd_TextChanged);
            this.iddddd.Click += new System.EventHandler(this.iddddd_Click);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(503, 214);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(62, 27);
            this.txtGiaBan.TabIndex = 95;
            this.txtGiaBan.TextChanged += new System.EventHandler(this.txtGiaBan_TextChanged);
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(430, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 20);
            this.label13.TabIndex = 94;
            this.label13.Text = "Giá bán :";
            // 
            // IDSanPham
            // 
            this.IDSanPham.DataPropertyName = "IDSanPham";
            this.IDSanPham.HeaderText = "IDSanPham";
            this.IDSanPham.MinimumWidth = 6;
            this.IDSanPham.Name = "IDSanPham";
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "TenSanPham";
            this.TenSanPham.MinimumWidth = 6;
            this.TenSanPham.Name = "TenSanPham";
            // 
            // Hang
            // 
            this.Hang.DataPropertyName = "Hang";
            this.Hang.HeaderText = "Hang";
            this.Hang.MinimumWidth = 6;
            this.Hang.Name = "Hang";
            // 
            // LoaiSanPham
            // 
            this.LoaiSanPham.DataPropertyName = "LoaiSanPham";
            this.LoaiSanPham.HeaderText = "LoaiSanPham";
            this.LoaiSanPham.MinimumWidth = 6;
            this.LoaiSanPham.Name = "LoaiSanPham";
            // 
            // NhaCungCap
            // 
            this.NhaCungCap.DataPropertyName = "NhaCungCap";
            this.NhaCungCap.HeaderText = "NhaCungCap";
            this.NhaCungCap.MinimumWidth = 6;
            this.NhaCungCap.Name = "NhaCungCap";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "SoLuong";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "GiaNhap";
            this.GiaNhap.MinimumWidth = 6;
            this.GiaNhap.Name = "GiaNhap";
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "GiaBan";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            // 
            // ThoiGianBaoHanh
            // 
            this.ThoiGianBaoHanh.DataPropertyName = "ThoiGianBaoHanh";
            this.ThoiGianBaoHanh.HeaderText = "ThoiGianBaoHanh";
            this.ThoiGianBaoHanh.MinimumWidth = 6;
            this.ThoiGianBaoHanh.Name = "ThoiGianBaoHanh";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "TrangThai";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "MoTa";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "LinkAnh";
            this.Column5.FillWeight = 6F;
            this.Column5.HeaderText = "LinkAnh";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(793, 628);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtThoiGianBaoHanhSP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbbNhaCungCapSP);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTimKiemSP);
            this.Controls.Add(this.cbbLocLoaiSanPhamSP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnTimKiemSP);
            this.Controls.Add(this.nudSoLuongSP);
            this.Controls.Add(this.cbbLocHangSP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvSanPhamSP);
            this.Controls.Add(this.btnSuaSP);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.btnShowSP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbLoaiSanPhamSP);
            this.Controls.Add(this.cbbHangSP);
            this.Controls.Add(this.txtMoTaSP);
            this.Controls.Add(this.txtGiaTienSP);
            this.Controls.Add(this.txtTenSanPhamSP);
            this.Controls.Add(this.txtIDSanPham);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iddddd);
            this.Name = "frmSanPham";
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtThoiGianBaoHanhSP;
        private Label label12;
        private ComboBox cbbNhaCungCapSP;
        private Label label11;
        private TextBox txtTimKiemSP;
        private ComboBox cbbLocLoaiSanPhamSP;
        private Label label10;
        private Button btnTimKiemSP;
        private ComboBox cbbLocHangSP;
        private Label label8;
        private Label label9;
        private DataGridView dgvSanPhamSP;
        private Button btnSuaSP;
        private Button btnThemSP;
        private Button btnShowSP;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private RadioButton rdHetHangSP;
        private RadioButton rdConHangSP;
        private ComboBox cbbLoaiSanPhamSP;
        private ComboBox cbbHangSP;
        private TextBox txtMoTaSP;
        private TextBox txtGiaTienSP;
        private TextBox txtTenSanPhamSP;
        private TextBox txtIDSanPham;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown nudSoLuongSP;
        private Label iddddd;
        private DataGridViewTextBoxColumn IDSanPham;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn Hang;
        private DataGridViewTextBoxColumn LoaiSanPham;
        private DataGridViewTextBoxColumn NhaCungCap;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn GiaNhap;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewTextBoxColumn ThoiGianBaoHanh;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewTextBoxColumn MoTa;
        private DataGridViewTextBoxColumn Column5;
        private TextBox txtGiaBan;
        private Label label13;
    }
}