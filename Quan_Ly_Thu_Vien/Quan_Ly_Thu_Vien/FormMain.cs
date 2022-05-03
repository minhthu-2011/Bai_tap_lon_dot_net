using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Thu_Vien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HeThongToolStripMenuItem.Enabled = true;
            DangNhapToolStripMenuItem.Enabled = true;
            ThoatToolStripMenuItem.Enabled = true;

            MuonTraSachToolStripMenuItem.Enabled = false;
            QuanLyToolStripMenuItem.Enabled = false;
            DocGiaToolStripMenuItem.Enabled = false;
            SachToolStripMenuItem.Enabled = false;
            NhomSachToolStripMenuItem.Enabled = false;
            NguoiDungToolStripMenuItem.Visible = false;
            NhomNguoiDungToolStripMenuItem.Visible = false;


            MuonTraSachToolStripMenuItem.Enabled = false;
            MuonTraSachToolStripMenuItem.Visible = false;
          
            TimKiemToolStripMenuItem.Visible = false;
            TKDocGiaToolStripMenuItem.Visible = false;
            TKSachToolStripMenuItem.Visible = false;


        }

        private void DocGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DocGia  Form  = new Form_DocGia();
            Form.Show();
        }

        private void SachToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form_Sach Form = new Form_Sach();
            Form.Show();
        }

        private void NhomSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TheLoaiSach Form = new Form_TheLoaiSach();
            Form.Show();
        }

        private void NguoiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_NhanVien Form = new Form_NhanVien();
            Form.Show();
        }

        private void NhomNguoiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_PhongBan Form = new Form_PhongBan();
            Form.Show();
        }

        private void quảnLýMượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_MuonSach Form = new Form_MuonSach();
            Form.Show();
        }

        private void quảnLýTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TraSach Form = new Form_TraSach();
            Form.Show();
        }

        private void TKSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TimKiemSach Form = new Form_TimKiemSach();
            Form.Show();
        }

        private void TKDocGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TimKiemDocGia Form = new Form_TimKiemDocGia();
            Form.Show();
        }
        public static string Username = string.Empty;
        private void DangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            login.Show();
           
  
            if (login.loginStatus == 1) //admin

            {

                
                

                HeThongToolStripMenuItem.Enabled = true;
                DangNhapToolStripMenuItem.Enabled = true;
                ThoatToolStripMenuItem.Enabled = true;

                QuanLyToolStripMenuItem.Enabled = true;
                DocGiaToolStripMenuItem.Enabled = true;
                SachToolStripMenuItem.Enabled = true;
                NhomSachToolStripMenuItem.Enabled = true;
                NguoiDungToolStripMenuItem.Enabled = true;
                NguoiDungToolStripMenuItem.Visible = true;
                NhomNguoiDungToolStripMenuItem.Enabled = true;

                MuonTraSachToolStripMenuItem.Visible = true;
                quảnLýMượnSáchToolStripMenuItem.Enabled = true;
                quảnLýTrảSáchToolStripMenuItem.Enabled = true;

                TimKiemToolStripMenuItem.Visible = true;
                TKDocGiaToolStripMenuItem.Visible = true;
                TKSachToolStripMenuItem.Visible = true;

                HeThongToolStripMenuItem.Enabled = true;
                DangNhapToolStripMenuItem.Enabled = true;
                ThoatToolStripMenuItem.Enabled = true;

                QuanLyToolStripMenuItem.Enabled = true;
                DocGiaToolStripMenuItem.Enabled = true;
                SachToolStripMenuItem.Enabled = true;
                NhomSachToolStripMenuItem.Enabled = true;
                NguoiDungToolStripMenuItem.Enabled = true;
                NhomNguoiDungToolStripMenuItem.Enabled = true;

                MuonTraSachToolStripMenuItem.Enabled = true;
                quảnLýMượnSáchToolStripMenuItem.Enabled = true;
                quảnLýTrảSáchToolStripMenuItem.Enabled = true;

                TimKiemToolStripMenuItem.Enabled = true;
                TKDocGiaToolStripMenuItem.Enabled = true;
                TKSachToolStripMenuItem.Enabled = true;


            }
            else
            {
                

                HeThongToolStripMenuItem.Enabled = true;
                DangNhapToolStripMenuItem.Enabled = true;
                ThoatToolStripMenuItem.Enabled = true;

                QuanLyToolStripMenuItem.Enabled = true;
                DocGiaToolStripMenuItem.Enabled = true;
                SachToolStripMenuItem.Enabled = true;
                NhomSachToolStripMenuItem.Enabled = true;
                NguoiDungToolStripMenuItem.Enabled = true;
                NguoiDungToolStripMenuItem.Visible = true;
                NhomNguoiDungToolStripMenuItem.Enabled = true;

                MuonTraSachToolStripMenuItem.Visible = true;
                quảnLýMượnSáchToolStripMenuItem.Enabled = true;
                quảnLýTrảSáchToolStripMenuItem.Enabled = true;

                TimKiemToolStripMenuItem.Visible = true;
                TKDocGiaToolStripMenuItem.Visible = true;
                TKSachToolStripMenuItem.Visible = true;

                HeThongToolStripMenuItem.Enabled = true;
                DangNhapToolStripMenuItem.Enabled = true;
                ThoatToolStripMenuItem.Enabled = true;

                QuanLyToolStripMenuItem.Enabled = true;
                DocGiaToolStripMenuItem.Enabled = true;
                SachToolStripMenuItem.Enabled = true;
                NhomSachToolStripMenuItem.Enabled = true;
                NguoiDungToolStripMenuItem.Enabled = true;
                NhomNguoiDungToolStripMenuItem.Enabled = true;

                MuonTraSachToolStripMenuItem.Enabled = true;
                quảnLýMượnSáchToolStripMenuItem.Enabled = true;
                quảnLýTrảSáchToolStripMenuItem.Enabled = true;

                TimKiemToolStripMenuItem.Enabled = true;
                TKDocGiaToolStripMenuItem.Enabled = true;
                TKSachToolStripMenuItem.Enabled = true;
            }
            /*else if (login.loginStatus == 2) //giamdoc
            {


                lblUserr.Visible = true;
                label1.Visible = true;

                HeThongToolStripMenuItem.Enabled = true;
                DangNhapToolStripMenuItem.Enabled = true;
                ThoatToolStripMenuItem.Enabled = true;

                QuanLyToolStripMenuItem.Enabled = false;
                DocGiaToolStripMenuItem.Enabled = false;
                SachToolStripMenuItem.Enabled = false;
                NhomSachToolStripMenuItem.Enabled = false;
                NguoiDungToolStripMenuItem.Enabled = false;
                NhomNguoiDungToolStripMenuItem.Enabled = false;

                MuonTraSachToolStripMenuItem.Enabled = false;
                quảnLýMượnSáchToolStripMenuItem.Enabled = false;
                quảnLýTrảSáchToolStripMenuItem.Enabled = false;

                TimKiemToolStripMenuItem.Enabled = false;
                TKDocGiaToolStripMenuItem.Enabled = false;
                TKSachToolStripMenuItem.Enabled = false;



                HeThongToolStripMenuItem.Enabled = true;
                DangNhapToolStripMenuItem.Enabled = true;
                ThoatToolStripMenuItem.Enabled = true;

                QuanLyToolStripMenuItem.Visible = true;
                DocGiaToolStripMenuItem.Visible = true;
                SachToolStripMenuItem.Visible = true;
                NhomSachToolStripMenuItem.Visible = true;
                NguoiDungToolStripMenuItem.Visible = true;
                NhomNguoiDungToolStripMenuItem.Visible = true;

                MuonTraSachToolStripMenuItem.Enabled = false;
                quảnLýMượnSáchToolStripMenuItem.Enabled = false;
                quảnLýTrảSáchToolStripMenuItem.Enabled = false;

                TimKiemToolStripMenuItem.Enabled = false;
                TKDocGiaToolStripMenuItem.Enabled = false;
                TKSachToolStripMenuItem.Enabled = false;

            }
            else  //thu thu
            {


                lblUserr.Visible = true;
                label1.Visible = true;

                HeThongToolStripMenuItem.Enabled = true;
                DangNhapToolStripMenuItem.Enabled = true;
                ThoatToolStripMenuItem.Enabled = true;

                QuanLyToolStripMenuItem.Enabled = true;
                DocGiaToolStripMenuItem.Enabled = true;
                SachToolStripMenuItem.Enabled = true;
                NhomSachToolStripMenuItem.Enabled = true;
                NguoiDungToolStripMenuItem.Visible = false;
                NhomNguoiDungToolStripMenuItem.Visible = false;

                MuonTraSachToolStripMenuItem.Enabled = true;
                quảnLýMượnSáchToolStripMenuItem.Visible = true;
                quảnLýTrảSáchToolStripMenuItem.Visible = true;

                TimKiemToolStripMenuItem.Visible = true;
                TKDocGiaToolStripMenuItem.Visible = true;
                TKSachToolStripMenuItem.Visible = true;

            }*/
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
