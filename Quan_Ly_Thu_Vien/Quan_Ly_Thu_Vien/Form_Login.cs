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
    public partial class Form_Login : Form
    {
        public int loginStatus;
        public Form_Login()
        {
            InitializeComponent();
            loginStatus = 0;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            sqlCnn.Open();
            sqlCmd.CommandText = "SELECT * FROM Login WHERE username='" +
                txtUser.Text + "' AND pass='" + txtPass.Text + "' ";

            SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();

            if (sqlDataReader.Read() == true)
            {
               loginStatus = sqlDataReader.GetInt32(3);
                MessageBox.Show("Thành công" +loginStatus, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or Password is wrong!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            sqlCnn.Close();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            this.Close();
        }
    }
    
}
