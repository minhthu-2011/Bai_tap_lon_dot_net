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
    public partial class Form_PhongBan : Form
    {
        public Form_PhongBan()
        {
            InitializeComponent();
            ShowList();

        }
        class PhongBan {

            string MaPhong;
            string TenPhong;
            string ChucVu;
            

            public string MAPHONG
            {
                get { return MaPhong; }
                set { MaPhong = value; }
            }
            public string TENPHONG
            {
                get { return TenPhong; }
                set { TenPhong = value; }
            }
            public string CHUCVU
            {
                get { return ChucVu; }
                set { ChucVu = value; }
            }

        }
        private string timPhongBan(PhongBan p)
        {
            sqlCnn.Open();
            sqlCmd.CommandText = "SELECT * FROM PhongBan WHERE MaPhong ='" + p.MAPHONG + "' ";

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
            lsvPhongBan.Items.Clear();
            sqlCnn.Open();
            sqlCmd.CommandText = "SELECT * FROM PhongBan";
            SqlDataReader rd = sqlCmd.ExecuteReader();
            while (rd.Read() == true)
            {

                ListViewItem lvi = lsvPhongBan.Items.Add(rd.GetString(0));
                lvi.SubItems.Add(rd.GetString(1));
                lvi.SubItems.Add(rd.GetString(2));

            }

            sqlCnn.Close();

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.Trim() == "" && txtTenPhong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                PhongBan dg = new PhongBan();
                dg.MAPHONG = txtMaPhong.Text;
                dg.TENPHONG = txtTenPhong.Text;
                dg.CHUCVU = txtChucVu.Text;
                String t = timPhongBan(dg);
                sqlCnn.Open();
                if (t == "")
                {
                    sqlCmd.CommandText = "INSERT INTO PhongBan(MaPhong,TenPhong,ChucVu)" +
                      "VALUES ( '" + dg.MAPHONG + "', '" + dg.TENPHONG + "', '"  + dg.CHUCVU + "')";
                }
                else
                {
                    sqlCmd.CommandText = "UPDATE PhongBan SET " +
                        "TenPhong = '" + dg.TENPHONG + "' "
                        + "ChucVu = '" + dg.CHUCVU + "' "
                        + "WHERE MaPhong = '" + dg.MAPHONG+ "' ";
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

        private void btnXOa_Click(object sender, EventArgs e)
        {
            PhongBan dg = new PhongBan();
            dg.MAPHONG = txtMaPhong.Text;
            dg.TENPHONG = txtTenPhong.Text;

            String t = timPhongBan(dg);
    
            if (t == "")
            {
                sqlCmd.CommandText = "INSERT INTO PhongBan(MaPhong,TenPhong,ChucVu)" +
                  "VALUES ( '" + dg.MAPHONG + "', '" + dg.TENPHONG + "', '" + dg.CHUCVU + "')";
            }
            else
            {
                sqlCnn.Open();
                sqlCmd.CommandText = "DELETE FROM PhongBan WHERE MaPhong = '" + dg.MAPHONG + "'";
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            this.Close();
        }
    }
}
