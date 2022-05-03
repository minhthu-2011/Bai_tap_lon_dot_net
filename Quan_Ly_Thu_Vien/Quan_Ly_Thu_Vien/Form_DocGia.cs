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
    public partial class Form_DocGia : Form
    {
        public Form_DocGia()
        {
            InitializeComponent();
            ShowList();
        }
        class DocGia
        {
            string MaDG;
            string HoTenDG;
            string NgaySinhDG;
            string GioiTinh;


            public string MA_DG
            {
                get { return MaDG; }
                set { MaDG = value; }
            }
            public string HOTEN_DG
            {
                get { return HoTenDG; }
                set { HoTenDG = value; }
            }

            public string NGAYSINH_DG
            {
                get { return NgaySinhDG; }
                set { NgaySinhDG = value; }
            }
            public string GIOITINH_DG
            {
                get { return GioiTinh; }
                set { GioiTinh = value; }
            }
        }
        private string timDocGia(DocGia dg)
        {
            sqlCnn.Open();
            sqlCmd.CommandText = "SELECT * FROM DocGia WHERE MaDG ='" + dg.MA_DG + "' ";

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
            lsvDocGia.Items.Clear();
            sqlCnn.Open();
            sqlCmd.CommandText = "SELECT * FROM DocGia";
            SqlDataReader rd = sqlCmd.ExecuteReader();
            while (rd.Read() == true)
            {

                ListViewItem lvi = lsvDocGia.Items.Add(rd.GetString(0));
                lvi.SubItems.Add(rd.GetString(1));
                lvi.SubItems.Add(rd.GetDateTime(2).ToShortDateString());
                lvi.SubItems.Add(rd.GetString(3));

            }

            sqlCnn.Close();

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtmadocgia.Text.Trim() == "" && txttendocgia.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DocGia dg = new DocGia();
                dg.MA_DG = txtmadocgia.Text;
                dg.HOTEN_DG = txttendocgia.Text;
                dg.NGAYSINH_DG = txtNgaySinh.Text;
                if (rdBNam.Checked == true)
                    dg.GIOITINH_DG = "Nam";
                else if (rdBNu.Checked == true)
                    dg.GIOITINH_DG = "Nữ";
                else
                    dg.GIOITINH_DG = "Khac";
                String t = timDocGia(dg);
                sqlCnn.Open();
                if (t == "")
                {
                    sqlCmd.CommandText = "INSERT INTO DocGia(MaDG, HoTenDG, NgaySinhDG, GioiTinh)" +
                      "VALUES ( '" + dg.MA_DG + "', '" + dg.HOTEN_DG + "', '" + dg.NGAYSINH_DG + "', ' " + dg.GIOITINH_DG + "')";
                }
                else
                {
                    sqlCmd.CommandText = "UPDATE DocGia SET "  +
                        "HoTenDG = '" + dg.HOTEN_DG + "' "
                        + "NgaySinhDG = '" + dg.NGAYSINH_DG + "' "
                        + "GioiTinh = '" + dg.GIOITINH_DG + "' "
                        + "WHERE MaDG = " + " ";
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

        private void btnXoaForm_Click(object sender, EventArgs e)
        {
            txtmadocgia.Text = "";
            txttendocgia.Text = "";
            txtNgaySinh.Text = "";
            rdBNam.Checked = true;
            rdBNu.Checked = false;
            rdBKhac.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DocGia dg = new DocGia();
            dg.MA_DG = txtmadocgia.Text;
            dg.HOTEN_DG = txttendocgia.Text;
            dg.NGAYSINH_DG = txtNgaySinh.Text;
            if (rdBNam.Checked == true)
                dg.GIOITINH_DG = "Nam";
            else if (rdBNu.Checked == true)
                dg.GIOITINH_DG = "Nữ";
            else
                dg.GIOITINH_DG = "Khac";
            String t = timDocGia(dg);
            
            if (t == "")
            {
                sqlCmd.CommandText = "INSERT INTO DocGia(MaDG, HoTenDG, NgaySinhDG, GioiTinh )" +
                  "VALUES ( '" + dg.MA_DG + "', '" + dg.HOTEN_DG + "', '" + dg.NGAYSINH_DG + "', ' " + dg.GIOITINH_DG + "')";
            }
            else
            {
                sqlCnn.Open();
                sqlCmd.CommandText = "DELETE FROM DocGia WHERE MaDG = '" + dg.MA_DG + "'";
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

        private void btnNgaySinh_Click(object sender, EventArgs e)
        {
            mnth_NgaySinh.Visible = true;
        }

        private void mnth_NgaySinh_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtNgaySinh.Text = mnth_NgaySinh.SelectionStart.ToShortDateString();
            mnth_NgaySinh.Visible = false;
        }

        //private void lsvDocGia_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int t = lsvDocGia.SelectedItems.Count;
        //    if (t > 0)
        //    {
        //        ListViewItem lvi = lsvDocGia.SelectedItems[0];
        //        txtmadocgia.Text = lvi.SubItems[0].Text;
        //        txttendocgia.Text = lvi.SubItems[1].Text;
        //        txtNgaySinh.Text = lvi.SubItems[2].Text;

        //        if (lvi.SubItems[3].Text == "Nam")
        //            rdBNam.Checked = true;
        //        else if (lvi.SubItems[3].Text == "Nữ")
        //            rdBNu.Checked = true;
        //        else
        //            rdBKhac.Checked = true;

        //    }
        //    else
        //    {
                
        //    }
        //}

        private void lsvDocGia_DoubleClick(object sender, EventArgs e)
        {
            int t = lsvDocGia.SelectedItems.Count;
            if (t > 0)
            {
                ListViewItem lvi = lsvDocGia.SelectedItems[0];
                txtmadocgia.Text = lvi.SubItems[0].Text;
                txttendocgia.Text = lvi.SubItems[1].Text;
                txtNgaySinh.Text = lvi.SubItems[2].Text;

                if (lvi.SubItems[3].Text == "Nam")
                    rdBNam.Checked = true;
                else if (lvi.SubItems[3].Text == "Nữ")
                    rdBNu.Checked = true;
                else
                    rdBKhac.Checked = true;

            }
            else
            {

            }
        }
    }
}

