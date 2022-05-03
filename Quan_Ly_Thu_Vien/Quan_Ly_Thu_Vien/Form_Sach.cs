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
    public partial class Form_Sach : Form
    {
        public Form_Sach()
        {
            InitializeComponent();
            ShowList();
        }
        class Sach
        {
            string MaS;
            string TenS;
            string MaTL;
            string TacGia;
            string SoLuong;
           


            public string MASACH
            {
                get { return MaS; }
                set { MaS = value; }
            }
            public string TENSACH
            {
                get { return TenS; }
                set { TenS = value; }
            }

            public string MATHELOAI
            {
                get { return MaTL; }
                set { MaTL = value; }
            }
            public string TACGIA
            {
                get { return TacGia; }
                set { TacGia = value; }
            }

            public string SOLUONG
            {
                get { return SoLuong; }
                set { SoLuong = value; }
            }

           
        }
        private string timSach(Sach s)
        {
            sqlCnn.Open();
            sqlCmd.CommandText = "SELECT * FROM Sach WHERE MaS ='" + s.MASACH + "' ";

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
            lsvSach.Items.Clear();
            sqlCnn.Open();
            sqlCmd.CommandText = "SELECT * FROM Sach";
            SqlDataReader rd = sqlCmd.ExecuteReader();
            while (rd.Read() == true)
            {

                ListViewItem lvi = lsvSach.Items.Add(rd.GetString(0));
                lvi.SubItems.Add(rd.GetString(1));
                lvi.SubItems.Add(rd.GetString(2));
                lvi.SubItems.Add(rd.GetString(3));
                lvi.SubItems.Add(rd.GetString(4));
               
            }

            sqlCnn.Close();

        }
        private void them_Click(object sender, EventArgs e)
        {
            if (txtmasach.Text.Trim() == "" && txtTenSach.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Sach dg = new Sach();
                dg.MASACH = txtmasach.Text;
                dg.TENSACH = txtTenSach.Text;
                dg.MATHELOAI = cbbTHeLoai.Text;
                dg.TACGIA = txtTacGia.Text;
                dg.SOLUONG = txtSoluong.Text;

                String t = timSach(dg);
                sqlCnn.Open();
                if (t == "")
                {
                    sqlCmd.CommandText = "INSERT INTO Sach(MaS, TenS, MaTL, TacGia,SoLuong)" +
                      "VALUES ( '" + dg.MASACH + "', '" + dg.TENSACH + "', '" + dg.MATHELOAI + "', ' " + dg.TACGIA + "', ' " + dg.SOLUONG + "')";
                }

                else
                {
                    sqlCmd.CommandText = "UPDATE Sach SET " 
                        + "TenS = '" + dg.TENSACH + "', "
                        + "MaTL = '" + dg.MATHELOAI + "', "
                        + "TacGia = '" + dg.TACGIA + "', "
                        + "SoLuong = '" + dg.SOLUONG + "' "
                        + "WHERE MaS = '" + dg.MASACH+ "' ";
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

        private void xoa_Click(object sender, EventArgs e)
        {
            Sach dg = new Sach();
            dg.MASACH = txtmasach.Text;
            dg.TENSACH = txtTenSach.Text;
            dg.MATHELOAI = cbbTHeLoai.Text;
            dg.TACGIA = txtTacGia.Text;
            dg.SOLUONG = txtSoluong.Text;

            String t = timSach(dg);

            if (t == "")
            {
                sqlCmd.CommandText = "INSERT INTO Sach(MaS, TenS, MaTL, TacGia,SoLuong)" +
                      "VALUES ( '" + dg.MASACH + "', '" + dg.TENSACH + "', '" + dg.MATHELOAI + "', ' " + dg.TACGIA + "', ' " + dg.SOLUONG + "')";
            }
            else
            {
                sqlCnn.Open();
                sqlCmd.CommandText = "DELETE FROM Sach WHERE MaS = '" + dg.MASACH + "'";
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

        private void btnXoaForm_Click(object sender, EventArgs e)
        {
            txtmasach.Text = "";
            txtTenSach.Text = "";
            txtTacGia.Text = "";
           
            txtSoluong.Text = "";
        }

        private void Form_Sach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.TheLoai' table. You can move, or remove it, as needed.
            this.theLoaiTableAdapter.Fill(this.dataSet1.TheLoai);

        }

        private void lsvSach_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            this.Close();
        }

        private void lsvSach_DoubleClick(object sender, EventArgs e)
        {

            int t = lsvSach.SelectedItems.Count;
            if (t > 0)
            {
                ListViewItem lvi = lsvSach.SelectedItems[0];
                txtmasach.Text = lvi.SubItems[0].Text;
                txtTenSach.Text = lvi.SubItems[1].Text;
                cbbTHeLoai.Text = lvi.SubItems[2].Text;
                txtSoluong.Text = lvi.SubItems[3].Text;


            }
            else
            {

            }
        }
    }
}
