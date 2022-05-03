using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Thu_Vien
{
    public partial class Form_NhanVien : Form
    {
        public Form_NhanVien()
        {
            InitializeComponent();
            ShowList();
        }
        class NguoiDung
        {
            string MaND;
            string HoTenND;
            string NgaySinh;
            string GioiTinh;
            string DiaChi;
            string DienThoai;
            string ChucVu;
            string PhongBan;


            public string MA_ND
            {
                get { return MaND; }
                set { MaND = value; }
            }
            public string HOTEN_ND
            {
                get { return HoTenND; }
                set { HoTenND = value; }
            }

            public string NGAYSINH
            {
                get { return NgaySinh; }
                set { NgaySinh = value; }
            }
            public string GIOITINH_ND
            {
                get { return GioiTinh; }
                set { GioiTinh = value; }
            }

            public string DIACHI
            {
                get { return DiaChi; }
                set { DiaChi = value; }
            }

            public string DIENTHOAI
            {
                get { return DienThoai; }
                set { DienThoai = value; }
            }
            public string CHUCVU
            {
                get { return ChucVu; }
                set { ChucVu = value; }
            }

            public string PHONGBAN
            {
                get { return PhongBan; }
                set { PhongBan = value; }
            }

        }


        private void btnXoaForm_Click(object sender, EventArgs e)
        {
            txtmanhanvien.Text = "";
            txttennhanvien.Text = "";
            txtNgaySinh.Text = "";
            rdBNam.Checked = true;
            rdBNu.Checked = false;
            rdBKhac.Checked = false;
            txtdiachi.Text = "";
            txtChucvu.Text = "";
            txtdienthoai.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            this.Close();
            
        }
        private string timNhanVien(NguoiDung nv)
        {
            sqlCnn.Open();
            sqlCmd.CommandText = "SELECT * FROM NguoiDung WHERE MaND ='" + nv.MA_ND + "' ";

            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            String kq = "";
            if (sqlReader.Read() == true)
            {
                kq = sqlReader.GetString(0);

            }

            sqlCnn.Close();
            return kq;
        }
        private void ShowList()
        {
            lsvND.Items.Clear();
            sqlCnn.Open();
            sqlCmd.CommandText = "SELECT * FROM NguoiDung";
            SqlDataReader rd = sqlCmd.ExecuteReader();
            while (rd.Read() == true)
            {

                ListViewItem lvi = lsvND.Items.Add(rd.GetString(0));
                lvi.SubItems.Add(rd.GetString(1));
                lvi.SubItems.Add(rd.GetDateTime(2).ToShortDateString());
                lvi.SubItems.Add(rd.GetString(3));
                lvi.SubItems.Add(rd.GetString(4));
                lvi.SubItems.Add(rd.GetString(5));
                lvi.SubItems.Add(rd.GetString(6));
                lvi.SubItems.Add(rd.GetString(7));



            }
            LoadCmbMaPB();
            sqlCnn.Close();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtmanhanvien.Text.Trim() == "" && txttennhanvien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                NguoiDung dg = new NguoiDung();
                dg.MA_ND = txtmanhanvien.Text;
                dg.HOTEN_ND = txttennhanvien.Text;
                dg.NGAYSINH = txtNgaySinh.Text;
                if (rdBNam.Checked == true)
                    dg.GIOITINH_ND = "Nam";
                else if (rdBNu.Checked == true)
                    dg.GIOITINH_ND = "Nữ";
                else
                    dg.GIOITINH_ND = "Khac";
                dg.DIACHI = txtdiachi.Text;
                dg.CHUCVU = txtChucvu.Text;
                dg.DIENTHOAI = txtdienthoai.Text;

                String t = timNhanVien(dg);
                sqlCnn.Open();
                if (t == "")
                {
                    sqlCmd.CommandText = "INSERT INTO NguoiDung(MaND, HoTenND, NgaySinh, GioiTinh,DiaChi,DienThoai, ChucVu,PhongBan)" +
                      "VALUES ( '" + dg.MA_ND + "', '" + dg.HOTEN_ND + "', '" + dg.NGAYSINH + "', ' " + dg.GIOITINH_ND + "', ' " + dg.DIACHI + "', ' " + dg.DIENTHOAI + "', ' " + dg.CHUCVU + "', ' " + dg.PHONGBAN + "')";
                }
                else
                {
                    sqlCmd.CommandText = "UPDATE NguoiDung SET " +
                            "HoTenND = '" + dg.HOTEN_ND + "' "
                        + "NgaySinh= '" + dg.NGAYSINH + "' "

                        + "GioiTinh = '" + dg.GIOITINH_ND + "' "
                        + "DiaChi = '" + dg.DIACHI + "' "
                        + "DienThoai = '" + dg.DIENTHOAI + "' "
                        + "ChucVu = '" + dg.CHUCVU + "' "
                        + "PhongBan = '" + dg.PHONGBAN + "' "
                        + "WHERE MaND = " + " ";
                }
                int kq = sqlCmd.ExecuteNonQuery();
                if (kq != 0)
                {
                    MessageBox.Show("Insert or Update is OK", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Insert or Update is Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                sqlCnn.Close();
                ShowList();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NguoiDung dg = new NguoiDung();
            dg.MA_ND = txtmanhanvien.Text;
            dg.HOTEN_ND = txttennhanvien.Text;
            dg.NGAYSINH = txtNgaySinh.Text;
            if (rdBNam.Checked == true)
                dg.GIOITINH_ND = "Nam";
            else if (rdBNu.Checked == true)
                dg.GIOITINH_ND = "Nữ";
            else
                dg.GIOITINH_ND = "Khac";
            dg.DIACHI = txtdiachi.Text;
            dg.CHUCVU = txtChucvu.Text;
            dg.DIENTHOAI = txtdienthoai.Text;
            dg.PHONGBAN = cbbPhongban.Text;
            String t = timNhanVien(dg);

            if (t == "")
            { 
                sqlCmd.CommandText = "INSERT INTO NguoiDung(MaND, HoTenND, NgaySinhND, GioiTinh, DiaChi, ChucVu,DienThoai,PhongBan )" +
                  "VALUES ( '" + dg.MA_ND + "', '" + dg.HOTEN_ND + "', '" + dg.NGAYSINH + "', ' " + dg.GIOITINH_ND + "', ' " + dg.DIACHI + "', ' " + dg.DIENTHOAI + "', ' " + dg.CHUCVU + "', ' " + dg.PHONGBAN + "')";
            }
            else
            {
                sqlCnn.Open();
                sqlCmd.CommandText = "DELETE FROM NguoiDung WHERE MaND = '" + dg.MA_ND + "'";
                int kq = sqlCmd.ExecuteNonQuery();
                if (kq != 0)
                {
                    MessageBox.Show("Delete is OK", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete is Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            sqlCnn.Close();
            ShowList();
        }

        private void mtnNgaySinh_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtNgaySinh.Text = mtnNgaySinh.SelectionStart.ToShortDateString();
            mtnNgaySinh.Visible = false;
        }

        private void btn_ngaysinh_Click(object sender, EventArgs e)
        {
            mtnNgaySinh.Visible = true;
        }

        private void lsvND_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPhongban_Click(object sender, EventArgs e)
        {
            Form_PhongBan formPhongBan = new Form_PhongBan();
            formPhongBan.Show();

        }
        KetNoi t = new KetNoi();

        public void LoadCmbMaPB()
        {
            DataTable dt = t.docdulieu("SELECT * FROM PhongBan");
            cbbPhongban.DataSource = dt;
            cbbPhongban.DisplayMember = "MaPhong";
            cbbPhongban.ValueMember = "MaPhong";
        }

        private void Form_NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.PhongBan' table. You can move, or remove it, as needed.
            this.phongBanTableAdapter.Fill(this.dataSet1.PhongBan);
            LoadCmbMaPB();

        }

        private void lsvND_DoubleClick(object sender, EventArgs e)
        {
            int t = lsvND.SelectedItems.Count;
            if (t > 0)
            {
                ListViewItem lvi = lsvND.SelectedItems[0];
                txtmanhanvien.Text = lvi.SubItems[0].Text;
                txttennhanvien.Text = lvi.SubItems[1].Text;
                txtNgaySinh.Text = lvi.SubItems[2].Text;

                if (lvi.SubItems[3].Text == "Nam")
                    rdBNam.Checked = true;
                else if (lvi.SubItems[3].Text == "Nữ")
                    rdBNu.Checked = true;
                else
                    rdBKhac.Checked = true;
                
                txtdiachi.Text = lvi.SubItems[4].Text;
                txtdienthoai.Text = lvi.SubItems[5].Text;
                txtChucvu.Text = lvi.SubItems[6].Text;
                cbbPhongban.Text = lvi.SubItems[7].Text;
              

            }
            else
            {

            }
        }
    }
}
