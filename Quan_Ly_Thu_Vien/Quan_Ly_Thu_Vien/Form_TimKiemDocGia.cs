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
    public partial class Form_TimKiemDocGia : Form
    {
        public Form_TimKiemDocGia()
        {
            InitializeComponent();
        }
        KetNoi t = new KetNoi();
        private void ShowList()
        {
            DataTable dt = t.docdulieu("select * from DocGia");
          //  l.Text = dt.Rows.Count.ToString();

            if (dt != null)
            {
                gridview.DataSource = dt;
            }
            gridview.Columns[0].HeaderText = "Mã độc giả";
            gridview.Columns[1].HeaderText = "Họ và tên";
            gridview.Columns[2].HeaderText = "Ngày sinh";
            gridview.Columns[3].HeaderText = "Giới tính";




            gridview.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            gridview.Enabled = true;

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (txttimkiem.Text.Trim() == "" )
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable dt5 = t.docdulieu("SELECT * FROM DocGia WHERE (MaDG like N'%" + txttimkiem.Text + "%')");
                DataTable dt6 = t.docdulieu("SELECT * FROM DocGia WHERE (HoTenDG like N'%" + txttimkiem.Text + "%')");
                if (rd_madocgia.Checked == true)
                {
                    gridview.DataSource = dt5;
                }
                else gridview.DataSource = dt6;

            }
        }

        private void Form_TimKiemDocGia_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            this.Close();
        }
    }
}
