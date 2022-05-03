namespace Quan_Ly_Thu_Vien
{
    partial class Form_PhongBan
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXOa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlCmd = new System.Data.SqlClient.SqlCommand();
            this.sqlCnn = new System.Data.SqlClient.SqlConnection();
            this.lsvPhongBan = new System.Windows.Forms.ListView();
            this.clmMaPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTenPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmChucVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.txtChucVu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXOa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.txtMaPhong);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTenPhong);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(10, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 227);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phòng ban";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(210, 155);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(147, 26);
            this.txtChucVu.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(71, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "Chức vụ";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(451, 139);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(160, 42);
            this.btnThoat.TabIndex = 38;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXOa
            // 
            this.btnXOa.Location = new System.Drawing.Point(451, 86);
            this.btnXOa.Name = "btnXOa";
            this.btnXOa.Size = new System.Drawing.Size(160, 45);
            this.btnXOa.TabIndex = 37;
            this.btnXOa.Text = "Xóa";
            this.btnXOa.UseVisualStyleBackColor = true;
            this.btnXOa.Click += new System.EventHandler(this.btnXOa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(451, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(160, 46);
            this.btnThem.TabIndex = 36;
            this.btnThem.Text = "Thêm/ Sửa";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(210, 54);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(147, 26);
            this.txtMaPhong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(79, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phòng";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(210, 107);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(147, 26);
            this.txtTenPhong.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(71, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên phòng";
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
            // lsvPhongBan
            // 
            this.lsvPhongBan.BackColor = System.Drawing.Color.Lavender;
            this.lsvPhongBan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmMaPhong,
            this.clmTenPhong,
            this.clmChucVu});
            this.lsvPhongBan.HideSelection = false;
            this.lsvPhongBan.Location = new System.Drawing.Point(12, 252);
            this.lsvPhongBan.Name = "lsvPhongBan";
            this.lsvPhongBan.Size = new System.Drawing.Size(663, 165);
            this.lsvPhongBan.TabIndex = 40;
            this.lsvPhongBan.UseCompatibleStateImageBehavior = false;
            this.lsvPhongBan.View = System.Windows.Forms.View.Details;
            // 
            // clmMaPhong
            // 
            this.clmMaPhong.Text = "Mã Phòng";
            this.clmMaPhong.Width = 121;
            // 
            // clmTenPhong
            // 
            this.clmTenPhong.Text = "Tên Phòng";
            this.clmTenPhong.Width = 215;
            // 
            // clmChucVu
            // 
            this.clmChucVu.Text = "Chức Vụ";
            this.clmChucVu.Width = 322;
            // 
            // Form_PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(687, 429);
            this.Controls.Add(this.lsvPhongBan);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_PhongBan";
            this.Text = "QUẢN LÝ PHÒNG BAN";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXOa;
        private System.Windows.Forms.Button btnThem;
        private System.Data.SqlClient.SqlCommand sqlCmd;
        private System.Data.SqlClient.SqlConnection sqlCnn;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lsvPhongBan;
        private System.Windows.Forms.ColumnHeader clmMaPhong;
        private System.Windows.Forms.ColumnHeader clmTenPhong;
        private System.Windows.Forms.ColumnHeader clmChucVu;
    }
}