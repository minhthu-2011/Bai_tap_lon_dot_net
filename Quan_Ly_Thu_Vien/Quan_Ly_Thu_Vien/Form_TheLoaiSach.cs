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
    public partial class Form_TheLoaiSach : Form
    {
        public Form_TheLoaiSach()
        {
            InitializeComponent();
            ShowList();
        }
        class TheLoai
        {
            string MaTL;
            string TenTL;



            public string MATHELOAI
            {
                get { return MaTL; }
                set { MaTL = value; }
            }
            public string TENTHELOAI
            {
                get { return TenTL; }
                set { TenTL = value; }
            }

        }
        private string timTheLoai(TheLoai s)
        {
            sqlCnn.Open();
            sqlCmd.CommandText = "SELECT * FROM NguoiDung WHERE MaND ='" + s.MATHELOAI + "' ";

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
            lsvTheLoai.Items.Clear();
            sqlCnn.Open();
            sqlCmd.CommandText = "SELECT * FROM TheLoai";
            SqlDataReader rd = sqlCmd.ExecuteReader();
            while (rd.Read() == true)
            {

                ListViewItem lvi = lsvTheLoai.Items.Add(rd.GetString(0));
                lvi.SubItems.Add(rd.GetString(1));

            }

            sqlCnn.Close();

        }
        private void them_Click(object sender, EventArgs e)
        {
            if (txtmatheloai.Text.Trim() == "" && txttentheloai.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TheLoai dg = new TheLoai();
                dg.TENTHELOAI = txttentheloai.Text;
                dg.MATHELOAI = txtmatheloai.Text;

                String t = timTheLoai(dg);
                sqlCnn.Open();
                if (t == "")
                {
                    
                    sqlCmd.CommandText = "INSERT INTO TheLoai(MaTL,TenTL)" +
                      "VALUES ( '" + dg.MATHELOAI + "', '" + dg.TENTHELOAI + "')";
                }
                else
                {
                    sqlCmd.CommandText = "UPDATE TheLoai SET " +
                        "TenTL = '" + dg.TENTHELOAI + "' "

                        + "WHERE MaTL = '" + dg.MATHELOAI + "' ";
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

      

        private void thoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            this.Close();
        }

       

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtmatheloai.Text = "";
            txttentheloai.Text = "";
        }

        private void lsvTheLoai_DoubleClick(object sender, EventArgs e)
        {
            int t = lsvTheLoai.SelectedItems.Count;
            if (t > 0)
            {
                ListViewItem lvi = lsvTheLoai.SelectedItems[0];
                txtmatheloai.Text = lvi.SubItems[0].Text;
                txttentheloai.Text = lvi.SubItems[1].Text;
            }
            else
            {

            }
        }
    }
}
