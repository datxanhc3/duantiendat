namespace _3_PL
{
    partial class frmQUANLYKM
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            btxoaKM = new Button();
            btXUatex = new Button();
            btSUa = new Button();
            btThemKM = new Button();
            groupBox3 = new GroupBox();
            groupBox5 = new GroupBox();
            label9 = new Label();
            label6 = new Label();
            dtngaybatdau = new DateTimePicker();
            dtngaykethuc = new DateTimePicker();
            btTimkiemKMTheoTime = new Button();
            btresetdatagv = new Button();
            dtgv = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            NGAYBATDAU = new DataGridViewTextBoxColumn();
            NGAYKETTHUC = new DataGridViewTextBoxColumn();
            DIENRAKM = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            btcliar = new Button();
            dtngaybatdauv = new DateTimePicker();
            dtngaybatdaua = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            tbptKM = new TextBox();
            tbTenKM = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightBlue;
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 1);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(1075, 681);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.DarkGray;
            groupBox4.Controls.Add(btxoaKM);
            groupBox4.Controls.Add(btXUatex);
            groupBox4.Controls.Add(btSUa);
            groupBox4.Controls.Add(btThemKM);
            groupBox4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.Black;
            groupBox4.Location = new Point(631, 108);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(403, 173);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "CHỨC NĂNG";
            // 
            // btxoaKM
            // 
            btxoaKM.BackColor = Color.Silver;
            btxoaKM.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btxoaKM.ForeColor = Color.Black;
            btxoaKM.Location = new Point(22, 42);
            btxoaKM.Margin = new Padding(4, 3, 4, 3);
            btxoaKM.Name = "btxoaKM";
            btxoaKM.Size = new Size(161, 41);
            btxoaKM.TabIndex = 7;
            btxoaKM.Text = "XÓA KHUYẾN MÃI";
            btxoaKM.UseVisualStyleBackColor = false;
            btxoaKM.Click += button7_Click;
            // 
            // btXUatex
            // 
            btXUatex.BackColor = Color.Silver;
            btXUatex.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btXUatex.ForeColor = Color.Black;
            btXUatex.Location = new Point(223, 107);
            btXUatex.Margin = new Padding(4, 3, 4, 3);
            btXUatex.Name = "btXUatex";
            btXUatex.Size = new Size(161, 41);
            btXUatex.TabIndex = 6;
            btXUatex.Text = "Xuất THÔNG TIN KM";
            btXUatex.UseVisualStyleBackColor = false;
            btXUatex.Click += button5_Click;
            // 
            // btSUa
            // 
            btSUa.BackColor = Color.Silver;
            btSUa.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btSUa.ForeColor = Color.Black;
            btSUa.Location = new Point(223, 41);
            btSUa.Margin = new Padding(4, 3, 4, 3);
            btSUa.Name = "btSUa";
            btSUa.Size = new Size(161, 41);
            btSUa.TabIndex = 4;
            btSUa.Text = "Sửa Khuyến Mãi";
            btSUa.UseVisualStyleBackColor = false;
            btSUa.Click += button2_Click;
            // 
            // btThemKM
            // 
            btThemKM.BackColor = Color.Silver;
            btThemKM.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btThemKM.ForeColor = Color.Black;
            btThemKM.Location = new Point(22, 107);
            btThemKM.Margin = new Padding(4, 3, 4, 3);
            btThemKM.Name = "btThemKM";
            btThemKM.Size = new Size(161, 41);
            btThemKM.TabIndex = 5;
            btThemKM.Text = "Thêm Khuyến Mãi";
            btThemKM.UseVisualStyleBackColor = false;
            btThemKM.Click += button3_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Gray;
            groupBox3.Controls.Add(groupBox5);
            groupBox3.Controls.Add(btresetdatagv);
            groupBox3.Controls.Add(dtgv);
            groupBox3.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(0, 330);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(1060, 345);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh Sách Khuyến Mãi";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(dtngaybatdau);
            groupBox5.Controls.Add(dtngaykethuc);
            groupBox5.Controls.Add(btTimkiemKMTheoTime);
            groupBox5.Location = new Point(24, 21);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(656, 45);
            groupBox5.TabIndex = 17;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tìm Kiếm Khuyến Mãi Theo Thời Gian";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 20);
            label9.Name = "label9";
            label9.Size = new Size(83, 14);
            label9.TabIndex = 18;
            label9.Text = "Ngày Bắt Đầu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(241, 20);
            label6.Name = "label6";
            label6.Size = new Size(92, 14);
            label6.TabIndex = 17;
            label6.Text = "Ngày Kết Thúc:";
            // 
            // dtngaybatdau
            // 
            dtngaybatdau.CustomFormat = "dd/MM/yyyy";
            dtngaybatdau.Format = DateTimePickerFormat.Custom;
            dtngaybatdau.Location = new Point(116, 17);
            dtngaybatdau.Name = "dtngaybatdau";
            dtngaybatdau.RightToLeftLayout = true;
            dtngaybatdau.Size = new Size(119, 22);
            dtngaybatdau.TabIndex = 16;
            // 
            // dtngaykethuc
            // 
            dtngaykethuc.CustomFormat = "dd/MM/yyyy";
            dtngaykethuc.Format = DateTimePickerFormat.Custom;
            dtngaykethuc.Location = new Point(339, 14);
            dtngaykethuc.Name = "dtngaykethuc";
            dtngaykethuc.Size = new Size(119, 22);
            dtngaykethuc.TabIndex = 16;
            // 
            // btTimkiemKMTheoTime
            // 
            btTimkiemKMTheoTime.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btTimkiemKMTheoTime.Location = new Point(477, 14);
            btTimkiemKMTheoTime.Margin = new Padding(4, 3, 4, 3);
            btTimkiemKMTheoTime.Name = "btTimkiemKMTheoTime";
            btTimkiemKMTheoTime.Size = new Size(164, 25);
            btTimkiemKMTheoTime.TabIndex = 3;
            btTimkiemKMTheoTime.Text = "TÌM KIẾM KHUYẾN MÃI THEO THỜI GIAN";
            btTimkiemKMTheoTime.UseVisualStyleBackColor = true;
            btTimkiemKMTheoTime.Click += button1_Click;
            // 
            // btresetdatagv
            // 
            btresetdatagv.Location = new Point(703, 30);
            btresetdatagv.Name = "btresetdatagv";
            btresetdatagv.Size = new Size(168, 36);
            btresetdatagv.TabIndex = 16;
            btresetdatagv.Text = "Refresh";
            btresetdatagv.UseVisualStyleBackColor = true;
            btresetdatagv.Click += button4_Click_1;
            // 
            // dtgv
            // 
            dtgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv.Columns.AddRange(new DataGridViewColumn[] { STT, ID, NGAYBATDAU, NGAYKETTHUC, DIENRAKM, dataGridViewTextBoxColumn1 });
            dtgv.Location = new Point(14, 85);
            dtgv.Name = "dtgv";
            dtgv.ReadOnly = true;
            dtgv.RowTemplate.Height = 25;
            dtgv.Size = new Size(1046, 253);
            dtgv.TabIndex = 9;
            dtgv.CellClick += dataGridView1_CellClick;
            dtgv.CellContentClick += dtgv_CellContentClick;
            dtgv.RowPostPaint += dtgv_RowPostPaint;
            // 
            // STT
            // 
            STT.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            STT.FillWeight = 146.1039F;
            STT.HeaderText = "STT";
            STT.Name = "STT";
            STT.ReadOnly = true;
            STT.Width = 55;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID.DataPropertyName = "Id";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 45;
            // 
            // NGAYBATDAU
            // 
            NGAYBATDAU.DataPropertyName = "Name";
            NGAYBATDAU.FillWeight = 88.47403F;
            NGAYBATDAU.HeaderText = "TÊN KHUYẾN MÃI";
            NGAYBATDAU.Name = "NGAYBATDAU";
            NGAYBATDAU.ReadOnly = true;
            // 
            // NGAYKETTHUC
            // 
            NGAYKETTHUC.DataPropertyName = "CreateDate";
            NGAYKETTHUC.FillWeight = 88.47403F;
            NGAYKETTHUC.HeaderText = "NGÀY BẮT ĐẦU";
            NGAYKETTHUC.Name = "NGAYKETTHUC";
            NGAYKETTHUC.ReadOnly = true;
            // 
            // DIENRAKM
            // 
            DIENRAKM.DataPropertyName = "EndDate";
            DIENRAKM.FillWeight = 88.47403F;
            DIENRAKM.HeaderText = "NGÀY KẾT THÚC";
            DIENRAKM.Name = "DIENRAKM";
            DIENRAKM.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Index";
            dataGridViewTextBoxColumn1.FillWeight = 88.47403F;
            dataGridViewTextBoxColumn1.HeaderText = "% KHUYẾN MÃI";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Gray;
            groupBox2.Controls.Add(btcliar);
            groupBox2.Controls.Add(dtngaybatdauv);
            groupBox2.Controls.Add(dtngaybatdaua);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(tbptKM);
            groupBox2.Controls.Add(tbTenKM);
            groupBox2.Location = new Point(13, 38);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(591, 286);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin KM";
            // 
            // btcliar
            // 
            btcliar.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btcliar.Location = new Point(466, 41);
            btcliar.Name = "btcliar";
            btcliar.Size = new Size(105, 33);
            btcliar.TabIndex = 8;
            btcliar.Text = "Làm Mới";
            btcliar.UseVisualStyleBackColor = true;
            btcliar.Click += button8_Click;
            btcliar.MouseDown += button8_MouseDown;
            // 
            // dtngaybatdauv
            // 
            dtngaybatdauv.CustomFormat = "dd/MM/yyyy";
            dtngaybatdauv.Format = DateTimePickerFormat.Custom;
            dtngaybatdauv.Location = new Point(155, 162);
            dtngaybatdauv.Name = "dtngaybatdauv";
            dtngaybatdauv.Size = new Size(119, 23);
            dtngaybatdauv.TabIndex = 15;
            // 
            // dtngaybatdaua
            // 
            dtngaybatdaua.CustomFormat = "dd/MM/yyyy";
            dtngaybatdaua.Format = DateTimePickerFormat.Custom;
            dtngaybatdaua.Location = new Point(155, 101);
            dtngaybatdaua.Name = "dtngaybatdaua";
            dtngaybatdaua.RightToLeftLayout = true;
            dtngaybatdaua.Size = new Size(119, 23);
            dtngaybatdaua.TabIndex = 14;
            dtngaybatdaua.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 211);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 18);
            label5.TabIndex = 13;
            label5.Text = "SỐ %:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 162);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 18);
            label4.TabIndex = 12;
            label4.Text = "Ngày Kết Thúc:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(19, 106);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(103, 18);
            label8.TabIndex = 11;
            label8.Text = "Ngày Bắt Đầu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(19, 48);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(118, 18);
            label7.TabIndex = 10;
            label7.Text = "Tên Khuyến Mãi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 87);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 6;
            // 
            // tbptKM
            // 
            tbptKM.Location = new Point(155, 209);
            tbptKM.Margin = new Padding(4, 3, 4, 3);
            tbptKM.Name = "tbptKM";
            tbptKM.Size = new Size(241, 23);
            tbptKM.TabIndex = 4;
            // 
            // tbTenKM
            // 
            tbTenKM.Location = new Point(155, 47);
            tbTenKM.Margin = new Padding(4, 3, 4, 3);
            tbTenKM.Name = "tbTenKM";
            tbTenKM.Size = new Size(241, 23);
            tbTenKM.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(479, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 16);
            label1.TabIndex = 1;
            label1.Text = "THÔNG TIN KHUYẾN MÃI";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmQUANLYKM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 681);
            Controls.Add(groupBox1);
            Name = "frmQUANLYKM";
            Text = "frmQUANLYKM";
            Load += frmQUANLYKM_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btXUatex;
        private GroupBox groupBox3;
        private Button btThemKM;
        private Button btSUa;
        private Button btTimkiemKMTheoTime;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label3;
        private TextBox tbptKM;
        private TextBox tbTenKM;
        private Label label1;
        private DateTimePicker dtngaybatdauv;
        private DateTimePicker dtngaybatdaua;
        private DataGridView dtgv;
        private Button btxoaKM;
        private Button btcliar;
        private Button btresetdatagv;
        private ErrorProvider errorProvider1;
        private GroupBox groupBox4;
        private DateTimePicker dtngaybatdau;
        private DateTimePicker dtngaykethuc;
        private GroupBox groupBox5;
        private Label label9;
        private Label label6;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NGAYBATDAU;
        private DataGridViewTextBoxColumn NGAYKETTHUC;
        private DataGridViewTextBoxColumn DIENRAKM;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}