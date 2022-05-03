namespace Quan_Ly_Thu_Vien
{
    partial class Form_TimKiemSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdBTacGia = new System.Windows.Forms.RadioButton();
            this.rdBTenSach = new System.Windows.Forms.RadioButton();
            this.rdBMaSach = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.sqlCmd = new System.Data.SqlClient.SqlCommand();
            this.sqlCnn = new System.Data.SqlClient.SqlConnection();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // rdBTacGia
            // 
            this.rdBTacGia.AutoSize = true;
            this.rdBTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdBTacGia.Location = new System.Drawing.Point(385, 106);
            this.rdBTacGia.Name = "rdBTacGia";
            this.rdBTacGia.Size = new System.Drawing.Size(78, 24);
            this.rdBTacGia.TabIndex = 47;
            this.rdBTacGia.TabStop = true;
            this.rdBTacGia.Text = "Tác giả";
            this.rdBTacGia.UseVisualStyleBackColor = true;
            // 
            // rdBTenSach
            // 
            this.rdBTenSach.AutoSize = true;
            this.rdBTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdBTenSach.Location = new System.Drawing.Point(385, 76);
            this.rdBTenSach.Name = "rdBTenSach";
            this.rdBTenSach.Size = new System.Drawing.Size(92, 24);
            this.rdBTenSach.TabIndex = 46;
            this.rdBTenSach.TabStop = true;
            this.rdBTenSach.Text = "Tên sách";
            this.rdBTenSach.UseVisualStyleBackColor = true;
            // 
            // rdBMaSach
            // 
            this.rdBMaSach.AutoSize = true;
            this.rdBMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdBMaSach.Location = new System.Drawing.Point(385, 46);
            this.rdBMaSach.Name = "rdBMaSach";
            this.rdBMaSach.Size = new System.Drawing.Size(87, 24);
            this.rdBMaSach.TabIndex = 45;
            this.rdBMaSach.TabStop = true;
            this.rdBMaSach.Text = "Mã sách";
            this.rdBMaSach.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.LightGray;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Location = new System.Drawing.Point(550, 48);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(96, 73);
            this.btnTimKiem.TabIndex = 44;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(88, 75);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(188, 20);
            this.txtTimKiem.TabIndex = 43;
            // 
            // gridview
            // 
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Location = new System.Drawing.Point(31, 154);
            this.gridview.Name = "gridview";
            this.gridview.Size = new System.Drawing.Size(750, 275);
            this.gridview.TabIndex = 48;
            // 
            // sqlCmd
            // 
            this.sqlCmd.Connection = this.sqlCnn;
            // 
            // sqlCnn
            // 
            this.sqlCnn.ConnectionString = "Data Source=DESKTOP-MED98D0;Initial Catalog=QL_ThuVien;Integrated Security=True";
            this.sqlCnn.FireInfoMessageEventOnUserErrors = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightGray;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(664, 48);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 73);
            this.btnThoat.TabIndex = 49;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Nhập từ cần tìm";
            // 
            // Form_TimKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.rdBTacGia);
            this.Controls.Add(this.rdBTenSach);
            this.Controls.Add(this.rdBMaSach);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Name = "Form_TimKiemSach";
            this.Text = "Form_TimKiemSach";
            this.Load += new System.EventHandler(this.Form_TimKiemSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdBTacGia;
        private System.Windows.Forms.RadioButton rdBTenSach;
        private System.Windows.Forms.RadioButton rdBMaSach;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView gridview;
        private System.Data.SqlClient.SqlCommand sqlCmd;
        private System.Data.SqlClient.SqlConnection sqlCnn;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
    }
}