using _1_DAL.Entities;
using _2_BUS.IServices;
using _2_BUS.Services;
using System.Data;
using System.Windows.Forms;

namespace FrmDuAn1
{
    public partial class frmBanHang : Form
    {
        private IHoaDonServices hoaDonServices;
        private IHoadonCTServices hoaDonCTServices;
        Bill hoadon;
        BillDetail hoaDonCT;
        private ISanPhamServices sanPhamServices;
        private IHangDTService hangDTServices;
        private ILoaiDTService loaiDTServices;
        private IDichVuServices dichVuServices;
        private IQuanLyKMServices khuyenMaiServices;
        private INhanVienServices nhanVienServices;
        private IKhachHangServices khachHangServices;
        Custommer khachHang;
        public frmBanHang()
        {
            InitializeComponent();
            hoaDonServices = new HoaDonServices();
            hoaDonCTServices = new HoaDonCTServices();
            hoadon = new Bill();
            hoaDonCT = new BillDetail();
            sanPhamServices = new SanPhamServices();
            hangDTServices = new HangDTService();
            loaiDTServices = new LoaiDTService();
            dichVuServices = new DichVuServices();
            khuyenMaiServices = new QlkhuyenmaiServices();
            nhanVienServices = new NhanVienServices();
            khachHangServices = new KhachHangServices();
            khachHang = new Custommer();
            LoadDataBanHang();
        }
        private string message;
        public frmBanHang(string Message) : this()
        {
            message = Message;


        }
        public void LoadDataBanHang()
        {
            foreach (var x in hangDTServices.GetAll())
            {
                cbbHangSp.Items.Insert(0, x.Name);
            }
            foreach (var x in loaiDTServices.GetAll())
            {
                cbbLoaiDt.Items.Add(x.Name);
            }
            foreach (var x in khuyenMaiServices.GetAll())
            {
                cbbKhuyenMai.Items.Add(x.Name);
            }
            foreach (var x in sanPhamServices.GetAll())
            {
                dgvSp.Rows.Add(x.Id, x.Name, x.Price);
            }
        }

        private void BanHang_Load(object sender, EventArgs e)
        {

        }

        private void dgvSp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSp.Rows[e.RowIndex].Cells[0].Value != null && dgvSp.Rows[e.RowIndex].Cells[1].Value != null && dgvSp.Rows[e.RowIndex].Cells[2].Value != null)
            {
                //if (dgvSp.Rows[e.RowIndex].Cells[0].Value != dgvGioHang.Rows[e.RowIndex].Cells[0].Value)
                //{
                //MessageBox.Show();
                dgvGioHang.Rows.Add(
                    dgvSp.Rows[e.RowIndex].Cells[0].Value,
                    dgvSp.Rows[e.RowIndex].Cells[1].Value,
                    dgvSp.Rows[e.RowIndex].Cells[2].Value,
                    int.Parse("1"),
                    dgvSp.Rows[e.RowIndex].Cells[2].Value);

                //}
                //else MessageBox.Show("Bạn đã thêm sản phẩm này vào giỏ hàng");
            }
            else MessageBox.Show("Bạn không thể thêm sản phẩm này");

            //if (dgvSp.Rows[e.RowIndex].Cells[0].Value != null && dgvSp.Rows[e.RowIndex].Cells[1].Value != null && dgvSp.Rows[e.RowIndex].Cells[2].Value != null)
            //{
            //    for (int i = 0; i < dgvGioHang.RowCount; i++)
            //    {
            //        if (dgvGioHang.Rows[i].Cells[0].Value != dgvSp.Rows[e.RowIndex].Cells[0].Value)
            //        {
            //            dgvGioHang.Rows.Add(
            //                dgvSp.Rows[e.RowIndex].Cells[0].Value,
            //                dgvSp.Rows[e.RowIndex].Cells[1].Value,
            //                dgvSp.Rows[e.RowIndex].Cells[2].Value,
            //                int.Parse("1"),
            //                dgvSp.Rows[e.RowIndex].Cells[2].Value);
            //        }
            //        else MessageBox.Show("Bạn đã thêm sản phẩm này vào giỏ hàng");
            //        return;
            //    }
            //}
            //else MessageBox.Show("Bạn không thể thêm sản phẩm này");
        }

        private void btnXoaSp_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow x in dgvGioHang.SelectedRows)
            {
                dgvGioHang.Rows.Remove(x);
            }
        }

        private void btnXoaGioHang_Click(object sender, EventArgs e)
        {
            dgvGioHang.Rows.Clear();
        }

        private void btnTangSoLuong_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(dgvGioHang.SelectedRows[0].Cells[3].Value.ToString());
            sl++;
            dgvGioHang.SelectedRows[0].Cells[3].Value = sl;
            float dongia = float.Parse(dgvGioHang.SelectedRows[0].Cells[2].Value.ToString());
            dgvGioHang.SelectedRows[0].Cells[4].Value = float.Parse(sl.ToString()) * dongia;
        }

        private void btnGiamSoLuong_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(dgvGioHang.SelectedRows[0].Cells[3].Value.ToString());
            if (sl > 1)
            {
                sl--;
            }
            else MessageBox.Show("Số lượng không thể nhỏ hơn 1");
            dgvGioHang.SelectedRows[0].Cells[3].Value = sl;
            float dongia = float.Parse(dgvGioHang.SelectedRows[0].Cells[2].Value.ToString());
            dgvGioHang.SelectedRows[0].Cells[4].Value = float.Parse(sl.ToString()) * dongia;
        }

        private void btnThemVaoGioHang_Click(object sender, EventArgs e)
        {
            int sc = dgvGioHang.Rows.Count;
            int sl = 0;
            for (int i = 0; i < sc - 1; i++)
            {
                var a = dgvGioHang.Rows[i].Cells[3].Value.ToString();
                sl += int.Parse(a);
            }
            txtSlSp.Text = sl.ToString();
            float tongtien = 0;
            for (int i = 0; i < sc - 1; i++)
            {
                var o = dgvGioHang.Rows[i].Cells[4].Value.ToString();
                tongtien += float.Parse(o);
            }
            txtTongTien.Text = tongtien.ToString();
        }

        private void btnTkSp_Click(object sender, EventArgs e)
        {
            dgvSp.Rows.Clear();
            var sp = sanPhamServices.GetAll().Where(x => x.Name == txtTkSp.Text).ToList();
            foreach (var x in sp)
            {
                dgvSp.Rows.Add(x.Id, x.Name, x.Price);
            }
        }

        private void cbbHangSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvSp.Rows.Clear();
            var idhang = hangDTServices.GetAll().Where(x => x.Name == cbbHangSp.Text).Select(x => x.Id).First();
            var hangsp = sanPhamServices.GetAll().Where(x => x.PhoneCompanyId == idhang).ToList();
            foreach (var x in hangsp)
            {
                dgvSp.Rows.Add(x.Id, x.Name, x.Price);
            }
        }

        private void cbbLoaiDt_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvSp.Rows.Clear();
            var idloai = loaiDTServices.GetAll().Where(x => x.Name == cbbLoaiDt.Text).Select(x => x.Id).First();
            var loaiDT = sanPhamServices.GetAll().Where(x => x.PhoneTypeId == idloai).ToList();
            foreach (var x in loaiDT)
            {
                dgvSp.Rows.Add(x.Id, x.Name, x.Price);
            }
        }

        private void cbbKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            float chiso = khuyenMaiServices.GetAll().Where(x => x.Name == cbbKhuyenMai.Text).Select(x => x.Index).First();
            float phantramgiam = chiso / 100;
            float x = float.Parse(txtTongTien.Text);
            float giamgia = x * phantramgiam;
            txtGiamGia.Text = giamgia.ToString();
            txtKhachPhaiTra.Text = (float.Parse(txtTongTien.Text) - float.Parse(txtGiamGia.Text)).ToString();
        }

        private void txtKhachThanhToan_TextChanged(object sender, EventArgs e)
        {

            if (txtKhachThanhToan.Text != "")
            {
                txtTienThua.Text = (float.Parse(txtKhachThanhToan.Text) - float.Parse(txtKhachPhaiTra.Text)).ToString();
            }
            else
            {
                txtTienThua.Text = "";
            }
        }

        private void btnHuyDonHang_Click(object sender, EventArgs e)
        {
            dgvGioHang.Rows.Clear();
            txtTenKh.Clear();
            txtSdtKh.Clear();
            //txtGioiTinh.Clear();
            txtDiaChi.Clear();
            txtSlSp.Clear();
            txtTongTien.Clear();
            //cbbKhuyenMai.Text.Remove(cbbKhuyenMai.SelectedText[0]);
            txtGiamGia.Clear();
            txtKhachPhaiTra.Clear();
            txtKhachThanhToan.Clear();
            txtTienThua.Clear();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            khachHang = new Custommer()
            {
                Id = Guid.NewGuid(),
                Name = txtTenKh.Text,
                PhoneNumber = txtSdtKh.Text,
                Sex = (rbNam.Checked) ? true : false,
                Address = txtDiaChi.Text,
            };
            khachHangServices.Add(khachHang);


            var idnhanvien = nhanVienServices.GetAll().Where(x => x.UserName == message).Select(x => x.Id).First();
            hoadon.Id = Guid.NewGuid();
            hoadon.EmployeeId = idnhanvien;
            hoadon.CustommerId = khachHang.Id;
            hoadon.Note = "";
            hoadon.CreateDate = DateTime.Now;
            hoadon.TotalPrice = decimal.Parse(txtTongTien.Text);
            hoaDonServices.Add(hoadon);

            for (int i = 0; i < dgvGioHang.Rows.Count - 1; i++)
            {
                hoaDonCT.Id = Guid.NewGuid();
                hoaDonCT.ServiceId = dichVuServices.GetAll().Select(x => x.Id).First();
                hoaDonCT.BillId = hoadon.Id;
                hoaDonCT.ProductId = Guid.Parse(dgvGioHang.Rows[i].Cells[0].Value.ToString());
                var km = khuyenMaiServices.GetAll().Where(x => x.Name == cbbKhuyenMai.Text).Select(x => x.Id).First();
                hoaDonCT.PromotionId = km;
                hoaDonCT.Quantity = int.Parse(dgvGioHang.Rows[i].Cells[3].Value.ToString());
                hoaDonCT.IntoMoney = decimal.Parse(dgvGioHang.Rows[i].Cells[4].Value.ToString());
                hoaDonCTServices.Add(hoaDonCT);
            }
            MessageBox.Show("Thêm thành công");
            btnHuyDonHang_Click(sender, e);
        }

        private void dgvGioHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //var sl= dgvGioHang.Rows[e.RowIndex].Cells[3].Value;
            //if (sl != null)
            //{
            //    //dgvGioHang.Rows[e.RowIndex].Cells[4].Value =
            //    var dg = float.Parse(dgvGioHang.Rows[e.RowIndex].Cells[2].Value.ToString());
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();


            frmHoaDon frmHoaDon = new frmHoaDon();
            frmHoaDon.ShowDialog();

            //fnv.ShowDialog();
            this.Close();
        }
    }
}