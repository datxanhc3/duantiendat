using _1_DAL.Entities;
using _2_BUS.IServices;
using _2_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL
{
    public partial class frmSanPham : Form
    {
        ISanPhamServices _isanPhamServices;
        IQuanLyNhaCCServices _inhaCungCapServices;
        IHangDTService _ihangDTServices;
        ILoaiDTService _iloaiDTServices;
        IHoadonCTServices _ibillDetailServices;
        IDichVuServices _idichVuServices;
        Product product;
        string linkAnh = "";
        public frmSanPham()
        {
            InitializeComponent();
            product = new Product();
            _idichVuServices = new DichVuServices();
            _ibillDetailServices = new HoaDonCTServices();
            _isanPhamServices = new SanPhamServices();
            _ihangDTServices = new HangDTService();
            _iloaiDTServices = new LoaiDTService();
            _inhaCungCapServices = new QuanLyNhaCCServices();

        }

        private void btnShowSP_Click(object sender, EventArgs e)
        {
            dgvSanPhamSP.Rows.Clear();
            foreach (var sp in _isanPhamServices.GetAll())
            {

            }
            var sl = (from x in _isanPhamServices.GetAll() select x.Id).ToList().Count;
            var sll = sl + 1;
            string IdSanPham = "";
            #region dk

            if (sll < 10)
            {
                IdSanPham = "SP0000" + Convert.ToString(sll);
            }
            else if (sll < 100)
            {
                IdSanPham = "SP000" + Convert.ToString(sll);
            }
            else if (sll < 1000)
            {
                IdSanPham = "SP00" + Convert.ToString(sll);
            }
            else if (sll < 10000)
            {
                IdSanPham = "SP0" + Convert.ToString(sll);
            }
            else
            {
                IdSanPham = "SP" + Convert.ToString(sll);
            }

            #endregion
            #region list


            var list = (from sp in _isanPhamServices.GetAll()
                        join billD in _ibillDetailServices.GetAll() on sp.Id equals billD.ProductId
                        join loaidt in _iloaiDTServices.GetAll() on sp.PhoneTypeId equals loaidt.Id
                        join hangdt in _ihangDTServices.GetAll() on sp.PhoneCompanyId equals hangdt.Id
                        join nhacc in _inhaCungCapServices.GetAll() on billD.PromotionId equals nhacc.Id
                        select new
                        {
                            IDSanPham = IdSanPham,
                            TenSanPham = sp.Name,
                            Hang = hangdt.Name,
                            LoaiSanPham = loaidt.Name,
                            NhaCungCap = nhacc.Name,
                            SoLuong = sp.Quantity,
                            GiaNhap = sp.ImportPrice,
                            GiaBan = sp.Price,
                            ThoiGianBaoHanh = sp.WarrantyPeriod,
                            TrangThai = sp.Status == 1 ? "Còn" : "Hết",
                            MoTa = sp.Descriptions,
                            LinkAnh = sp.LinkAnh,
                        }).ToList();
            #endregion
            dgvSanPhamSP.DataSource = list;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                linkAnh = ofd.FileName;
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }

        }


        private void btnTimKiemSP_Click(object sender, EventArgs e)
        {
            foreach (var sp in _isanPhamServices.GetAll())
            {

            }

            #region dk
            var sl = (from x in _isanPhamServices.GetAll() select x.Id).ToList().Count;
            var sll = sl + 1;
            string IdSanPham = "";
            if (sll < 10)
            {
                IdSanPham = "SP0000" + Convert.ToString(sll);
            }
            else if (sll < 100)
            {
                IdSanPham = "SP000" + Convert.ToString(sll);
            }
            else if (sll < 1000)
            {
                IdSanPham = "SP00" + Convert.ToString(sll);
            }
            else if (sll < 10000)
            {
                IdSanPham = "SP0" + Convert.ToString(sll);
            }
            else
            {
                IdSanPham = "SP" + Convert.ToString(sll);
            }

            #endregion
            #region list


            var list = (from sp in _isanPhamServices.GetAll()
                        join billD in _ibillDetailServices.GetAll() on sp.Id equals billD.ProductId
                        join loaidt in _iloaiDTServices.GetAll() on sp.PhoneTypeId equals loaidt.Id
                        join hangdt in _ihangDTServices.GetAll() on sp.PhoneCompanyId equals hangdt.Id
                        join nhacc in _inhaCungCapServices.GetAll() on billD.PromotionId equals nhacc.Id
                        select new
                        {
                            IDSanPham = IdSanPham,
                            TenSanPham = sp.Name,
                            Hang = hangdt.Name,
                            LoaiSanPham = loaidt.Name,
                            NhaCungCap = nhacc.Name,
                            SoLuong = sp.Quantity,
                            GiaTien = sp.Price,
                            ThoiGianBaoHanh = sp.WarrantyPeriod,
                            TrangThai = sp.Status == 1 ? "Còn" : "Hết",
                            MoTa = sp.Descriptions,
                            LinkAnh = sp.LinkAnh,
                        }).ToList();
            #endregion
            if (cbbLocHangSP.Text == "Trống" && cbbLocLoaiSanPhamSP.Text == "Trống")
            {
                var timKiem = (from x in list where x.TenSanPham.StartsWith($"{txtTimKiemSP.Text}") || x.IDSanPham == txtTimKiemSP.Text select x).ToList();
                dgvSanPhamSP.DataSource = timKiem;

            }
            else if (cbbLocHangSP.Text == "Trống")
            {
                var timKiem = (from x in list where x.LoaiSanPham == cbbLocLoaiSanPhamSP.Text where x.TenSanPham.StartsWith($"{txtTimKiemSP.Text}") || x.IDSanPham == txtTimKiemSP.Text select x).ToList();
                dgvSanPhamSP.DataSource = timKiem;
            }
            else if (cbbLocLoaiSanPhamSP.Text == "Trống")
            {
                var timKiem = (from x in list where x.Hang == cbbLocHangSP.Text where x.TenSanPham.StartsWith($"{txtTimKiemSP.Text}") || x.IDSanPham == txtTimKiemSP.Text select x).ToList();
                dgvSanPhamSP.DataSource = timKiem;
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm mới không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var idLoai = (from loai in _iloaiDTServices.GetAll() where loai.Name == cbbLoaiSanPhamSP.Text select loai).FirstOrDefault();
                var idHang = (from hang in _iloaiDTServices.GetAll() where hang.Name == cbbLoaiSanPhamSP.Text select hang).FirstOrDefault();
                var idNhacc = (from nhacc in _iloaiDTServices.GetAll() where nhacc.Name == cbbLoaiSanPhamSP.Text select nhacc).FirstOrDefault();
                int trangThai = 0;
                if (rdConHangSP.Checked)
                {
                    trangThai = 1;
                }
                else if (rdHetHangSP.Checked)
                {
                    trangThai = 0;
                }

                if (int.Parse(txtGiaBan.Text) < int.Parse(txtGiaTienSP.Text))
                {
                    MessageBox.Show("Giá nhập không được lớn hơn giá bán.");
                }
                else
                {


                    string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                    File.Copy(linkAnh, Path.Combine(projectDirectory, "Pictures", Path.GetFileName(linkAnh)), true);
                    linkAnh = Path.Combine(projectDirectory, "Pictures", Path.GetFileName(linkAnh));
                    Product pproduct = new Product()
                    {
                        Id = Guid.NewGuid(),
                        Name = txtTenSanPhamSP.Text,
                        PhoneCompanyId = idHang.Id,
                        PhoneTypeId = idLoai.Id,
                        Status = trangThai,
                        SupplierDetailId = idNhacc.Id,
                        Quantity = ((int)nudSoLuongSP.Value),
                        Price = int.Parse(txtGiaBan.Text),
                        ImportPrice = int.Parse(txtGiaTienSP.Text),
                        WarrantyPeriod = txtThoiGianBaoHanhSP.Text,
                        Descriptions = txtMoTaSP.Text,
                        LinkAnh = linkAnh,
                    };
                    if (nudSoLuongSP.Value < 0)
                    {
                        MessageBox.Show("Số lượng không được bé hơn 0");
                    }
                    else
                    {
                        _isanPhamServices.Add(pproduct);
                        MessageBox.Show("Thêm thành công.");
                    }

                }
            }
        }
        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                #region list


                var list = (from sp in _isanPhamServices.GetAll()
                            join billD in _ibillDetailServices.GetAll() on sp.Id equals billD.ProductId
                            join loaidt in _iloaiDTServices.GetAll() on sp.PhoneTypeId equals loaidt.Id
                            join hangdt in _ihangDTServices.GetAll() on sp.PhoneCompanyId equals hangdt.Id
                            join nhacc in _inhaCungCapServices.GetAll() on billD.PromotionId equals nhacc.Id
                            select new
                            {
                                IDSanPham = sp.Id,
                                TenSanPham = sp.Name,
                                Hang = hangdt.Name,
                                LoaiSanPham = loaidt.Name,
                                NhaCungCap = nhacc.Name,
                                SoLuong = sp.Quantity,
                                GiaTien = sp.Price,
                                ThoiGianBaoHanh = sp.WarrantyPeriod,
                                TrangThai = sp.Status == 1 ? "Còn" : "Hết",
                                MoTa = sp.Descriptions,
                                LinkAnh = sp.LinkAnh,
                            }).ToList();
                #endregion
                var idLoai = (from loai in _iloaiDTServices.GetAll() where loai.Name == cbbLoaiSanPhamSP.Text select loai).FirstOrDefault();
                var idHang = (from hang in _iloaiDTServices.GetAll() where hang.Name == cbbLoaiSanPhamSP.Text select hang).FirstOrDefault();
                var idNhacc = (from nhacc in _iloaiDTServices.GetAll() where nhacc.Name == cbbLoaiSanPhamSP.Text select nhacc).FirstOrDefault();
                var id = (from idd in _isanPhamServices.GetAll()
                          where txtTenSanPhamSP.Text == idd.Name
                          && txtThoiGianBaoHanhSP.Text == idd.WarrantyPeriod
                          && txtMoTaSP.Text == idd.Descriptions
                          && nudSoLuongSP.Value == idd.Quantity
                          select idd.Id).FirstOrDefault();
                int trangThai = 0;
                if (rdConHangSP.Checked)
                {
                    trangThai = 1;
                }
                else if (rdHetHangSP.Checked)
                {
                    trangThai = 0;
                }
                string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                File.Copy(linkAnh, Path.Combine(projectDirectory, "Resources", "Product", Path.GetFileName(linkAnh)), true);
                linkAnh = Path.Combine(projectDirectory, "Resources", "Product", Path.GetFileName(linkAnh));
                if (txtIDSanPham.Text == "" || txtTenSanPhamSP.Text == "" || txtGiaBan.Text == "" || txtGiaTienSP.Text == "" || txtThoiGianBaoHanhSP.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                }
                else
                {
                    var sp1 = (from x in _isanPhamServices.GetAll() where x.Id == Guid.Parse(txtIDSanPham.Text) select x).FirstOrDefault();
                    sp1.Name = txtTenSanPhamSP.Text;
                    sp1.PhoneCompanyId = idHang.Id;
                    sp1.PhoneTypeId = idLoai.Id;
                    sp1.Status = trangThai;
                    sp1.SupplierDetailId = idNhacc.Id;
                    if (nudSoLuongSP.Value < 0)
                    {
                        MessageBox.Show("Số lượng không được bé hơn 0");
                    }
                    else
                    {
                        sp1.Quantity = ((int)nudSoLuongSP.Value);
                    }
                    sp1.ImportPrice = int.Parse(txtGiaTienSP.Text);
                    sp1.Price = int.Parse(txtGiaBan.Text);
                    sp1.WarrantyPeriod = txtThoiGianBaoHanhSP.Text;
                    sp1.Descriptions = txtMoTaSP.Text;
                    sp1.LinkAnh = linkAnh;
                    _isanPhamServices.Update(sp1);
                    MessageBox.Show("Sửa thành công.");
                }
            }
        }
        private void cbbHangSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbLoaiSanPhamSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbNhaCungCapSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iddddd_Click(object sender, EventArgs e)
        {

        }

        private void iddddd_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvSanPhamSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSanPhamSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dt = dgvSanPhamSP.Rows[e.RowIndex];
            txtIDSanPham.Text = dgvSanPhamSP.Rows[0].ToString();
            txtTenSanPhamSP.Text = dgvSanPhamSP.Rows[1].ToString();
            cbbHangSP.Text = dgvSanPhamSP.Rows[2].ToString();
            cbbLoaiSanPhamSP.Text = dgvSanPhamSP.Rows[3].ToString();
            cbbNhaCungCapSP.Text = dgvSanPhamSP.Rows[4].ToString();
            nudSoLuongSP.Value = int.Parse(dgvSanPhamSP.Rows[5].ToString());
            txtGiaTienSP.Text = dgvSanPhamSP.Rows[6].ToString();
            txtGiaBan.Text = dgvSanPhamSP.Rows[7].ToString();
            txtThoiGianBaoHanhSP.Text = dgvSanPhamSP.Rows[8].ToString();
            txtMoTaSP.Text = dgvSanPhamSP.Rows[9].ToString();
        }

        private void cbbLocLoaiSanPhamSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            var loai = (from x in _iloaiDTServices.GetAll() select x.Name).ToList();
            var hang = (from x in _ihangDTServices.GetAll() select x.Name).ToList();
            var ncc = (from x in _inhaCungCapServices.GetAll() select x.Name).ToList();
            cbbNhaCungCapSP.DataSource = ncc;
            cbbLocHangSP.DataSource = hang;
            cbbHangSP.DataSource = hang;
            cbbLoaiSanPhamSP.DataSource = loai;
            cbbLocLoaiSanPhamSP.DataSource = loai;
        }



        private void txtGiaTienSP_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtGiaTienSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void nudSoLuongSP_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}


