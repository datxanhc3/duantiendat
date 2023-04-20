using _2_BUS.IServices;
using _2_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL.Entities;

namespace _3_PL
{
    public partial class frmQuenMatKhau : Form
    {
        private INhanVienServices _inhanvienservice;
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void SendMail(string email, string pw)
        {
            MailAddress Tu = new MailAddress("linhntph21637@fpt.edu.vn", "Admin");
            MailAddress Den = new MailAddress(email, "User");
            const string TieuDe = "Reset mật khẩu app quản lý bán điện thoại thông minh";
            string NoiDung = @"Bạn đã yêu cầu đổi mật khẩu. Mật khẩu mới của bạn là: <b>" + pw + "</b>";

            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage(Tu.Address, Den.Address, TieuDe, NoiDung);
            msg.IsBodyHtml = true;

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("linhntph21637@fpt.edu.vn", "linhntph21637123456789"),
                EnableSsl = true
            };

            try
            {
                client.Send(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public frmQuenMatKhau()
        {
            InitializeComponent();
            _inhanvienservice = new NhanVienServices();
            this.CenterToScreen();
        }

        private void btn_resetpassword_Click(object sender, EventArgs e)
        {
            var em = _inhanvienservice.GetAll().FirstOrDefault(x => x.Email == txb_email.Text && x.Name == txb_name.Text);
            if (em == null)
            {
                MessageBox.Show("Không tìm thấy email và tên trùng khớp. Vui lòng kiểm tra lại");
            }
            else
            {
                string random = RandomString(6);
                em.PassWord = random;
                _inhanvienservice.Update(em);

                SendMail(txb_email.Text, random);
                MessageBox.Show("Reset mật khẩu thành công. Vui lòng kiểm tra email");
                this.Close();
            }
        }
    }
}
