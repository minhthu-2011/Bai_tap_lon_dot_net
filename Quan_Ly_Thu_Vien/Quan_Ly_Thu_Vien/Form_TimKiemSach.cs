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
    public partial class Form_TimKiemSach : Form
    {
        public Form_TimKiemSach()
        {
            InitializeComponent();
        }
        KetNoi t = new KetNoi();
        private void ShowList()
        {
            DataTable dt = t.docdulieu("select * from Sach");
            //  l.Text = dt.Rows.Count.ToString();

            if (dt != null)
            {
                gridview.DataSource = dt;
            }
            gridview.Columns[0].HeaderText = "Mã Sách ";
            gridview.Columns[1].HeaderText = "Tên Sách";
            gridview.Columns[2].HeaderText = "Mã thể loại";
            gridview.Columns[3].HeaderText = "Tác Giả ";
            gridview.Columns[4].HeaderText = "Số lượng";




            gridview.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            gridview.Enabled = true;

        }
      

        private void Form_TimKiemSach_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (txtTimKiem.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable dt5 = t.docdulieu("SELECT * FROM Sach WHERE (MaS like N'%" + txtTimKiem.Text + "%')");
                DataTable dt6 = t.docdulieu("SELECT * FROM Sach WHERE (TenS like N'%" + txtTimKiem.Text + "%')");
                DataTable dt7 = t.docdulieu("SELECT * FROM Sach WHERE (TacGia like N'%" + txtTimKiem.Text + "%')");
                if (rdBMaSach.Checked == true)
                {
                    gridview.DataSource = dt5;
                }
                else if (rdBTenSach.Checked == true)
                {
                    gridview.DataSource = dt6;
                }
                else
                {
                    gridview.DataSource = dt7;
                }


            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            this.Close();
        }
    }
}
