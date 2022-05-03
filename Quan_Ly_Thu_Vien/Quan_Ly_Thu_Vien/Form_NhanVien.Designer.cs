namespace Quan_Ly_Thu_Vien
{
    partial class Form_NhanVien
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPhongban = new System.Windows.Forms.Button();
            this.mtnNgaySinh = new System.Windows.Forms.MonthCalendar();
            this.btnXoaForm = new System.Windows.Forms.Button();
            this.btn_ngaysinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtChucvu = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.cbbPhongban = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdBKhac = new System.Windows.Forms.RadioButton();
            this.rdBNu = new System.Windows.Forms.RadioButton();
            this.rdBNam = new System.Windows.Forms.RadioButton();
            this.l = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttennhanvien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmanhanvien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phongBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Quan_Ly_Thu_Vien.DataSet1();
            this.lsvND = new System.Windows.Forms.ListView();
            this.clhmanguoidung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhhoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhngayssinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmgioitinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDiachi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDienthoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhChucvu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lhPhongban = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sqlCmd = new System.Data.SqlClient.SqlCommand();
            this.sqlCnn = new System.Data.SqlClient.SqlConnection();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phongBanTableAdapter = new Quan_Ly_Thu_Vien.DataSet1TableAdapters.PhongBanTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.btnPhongban);
            this.groupBox1.Controls.Add(this.mtnNgaySinh);
            this.groupBox1.Controls.Add(this.btnXoaForm);
            this.groupBox1.Controls.Add(this.btn_ngaysinh);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtChucvu);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNgaySinh);
            this.groupBox1.Controls.Add(this.cbbPhongban);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdBKhac);
            this.groupBox1.Controls.Add(this.rdBNu);
            this.groupBox1.Controls.Add(this.rdBNam);
            this.groupBox1.Controls.Add(this.l);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtdienthoai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txttennhanvien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmanhanvien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 342);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin người dùng";
            // 
            // btnPhongban
            // 
            this.btnPhongban.Location = new System.Drawing.Point(354, 185);
            this.btnPhongban.Name = "btnPhongban";
            this.btnPhongban.Size = new System.Drawing.Size(47, 27);
            this.btnPhongban.TabIndex = 60;
            this.btnPhongban.Text = "...";
            this.btnPhongban.UseVisualStyleBackColor = true;
            this.btnPhongban.Click += new System.EventHandler(this.btnPhongban_Click);
            // 
            // mtnNgaySinh
            // 
            this.mtnNgaySinh.Location = new System.Drawing.Point(627, 81);
            this.mtnNgaySinh.Name = "mtnNgaySinh";
            this.mtnNgaySinh.TabIndex = 59;
            this.mtnNgaySinh.Visible = false;
            this.mtnNgaySinh.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mtnNgaySinh_DateSelected);
            // 
            // btnXoaForm
            // 
            this.btnXoaForm.Location = new System.Drawing.Point(449, 272);
            this.btnXoaForm.Name = "btnXoaForm";
            this.btnXoaForm.Size = new System.Drawing.Size(114, 48);
            this.btnXoaForm.TabIndex = 58;
            this.btnXoaForm.Text = "Xóa Form";
            this.btnXoaForm.UseVisualStyleBackColor = true;
            this.btnXoaForm.Click += new System.EventHandler(this.btnXoaForm_Click);
            // 
            // btn_ngaysinh
            // 
            this.btn_ngaysinh.Location = new System.Drawing.Point(812, 43);
            this.btn_ngaysinh.Name = "btn_ngaysinh";
            this.btn_ngaysinh.Size = new System.Drawing.Size(32, 26);
            this.btn_ngaysinh.TabIndex = 57;
            this.btn_ngaysinh.Text = "...";
            this.btn_ngaysinh.UseVisualStyleBackColor = true;
            this.btn_ngaysinh.Click += new System.EventHandler(this.btn_ngaysinh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(625, 272);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(114, 48);
            this.btnThoat.TabIndex = 51;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(82, 272);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 48);
            this.btnThem.TabIndex = 49;
            this.btnThem.Text = "Thêm/ Sửa";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtChucvu
            // 
            this.txtChucvu.Location = new System.Drawing.Point(181, 140);
            this.txtChucvu.Name = "txtChucvu";
            this.txtChucvu.Size = new System.Drawing.Size(218, 26);
            this.txtChucvu.TabIndex = 56;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(264, 272);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(114, 48);
            this.btnXoa.TabIndex = 50;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(30, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 24);
            this.label8.TabIndex = 55;
            this.label8.Text = "Chức vụ";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(627, 44);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(166, 26);
            this.txtNgaySinh.TabIndex = 54;
            // 
            // cbbPhongban
            // 
            this.cbbPhongban.FormattingEnabled = true;
            this.cbbPhongban.Location = new System.Drawing.Point(180, 184);
            this.cbbPhongban.Name = "cbbPhongban";
            this.cbbPhongban.Size = new System.Drawing.Size(160, 28);
            this.cbbPhongban.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(30, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "Phòng ban";
            // 
            // rdBKhac
            // 
            this.rdBKhac.AutoSize = true;
            this.rdBKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBKhac.Location = new System.Drawing.Point(797, 89);
            this.rdBKhac.Margin = new System.Windows.Forms.Padding(2);
            this.rdBKhac.Name = "rdBKhac";
            this.rdBKhac.Size = new System.Drawing.Size(63, 24);
            this.rdBKhac.TabIndex = 48;
            this.rdBKhac.TabStop = true;
            this.rdBKhac.Text = "Khác";
            this.rdBKhac.UseVisualStyleBackColor = true;
            // 
            // rdBNu
            // 
            this.rdBNu.AutoSize = true;
            this.rdBNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBNu.Location = new System.Drawing.Point(720, 90);
            this.rdBNu.Margin = new System.Windows.Forms.Padding(2);
            this.rdBNu.Name = "rdBNu";
            this.rdBNu.Size = new System.Drawing.Size(47, 24);
            this.rdBNu.TabIndex = 47;
            this.rdBNu.TabStop = true;
            this.rdBNu.Text = "Nữ";
            this.rdBNu.UseVisualStyleBackColor = true;
            // 
            // rdBNam
            // 
            this.rdBNam.AutoSize = true;
            this.rdBNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBNam.Location = new System.Drawing.Point(624, 90);
            this.rdBNam.Margin = new System.Windows.Forms.Padding(2);
            this.rdBNam.Name = "rdBNam";
            this.rdBNam.Size = new System.Drawing.Size(60, 24);
            this.rdBNam.TabIndex = 46;
            this.rdBNam.TabStop = true;
            this.rdBNam.Text = "Nam";
            this.rdBNam.UseVisualStyleBackColor = true;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(180, 151);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(0, 20);
            this.l.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(473, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 42;
            this.label7.Text = "Giới tính";
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(625, 182);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(218, 26);
            this.txtdienthoai.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(474, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Điện thoại";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(625, 137);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(218, 26);
            this.txtdiachi.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(474, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(475, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh";
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.Location = new System.Drawing.Point(180, 83);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.Size = new System.Drawing.Size(218, 26);
            this.txttennhanvien.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(28, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên";
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.Location = new System.Drawing.Point(180, 32);
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(218, 26);
            this.txtmanhanvien.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(28, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã người dùng";
            // 
            // phongBanBindingSource
            // 
            this.phongBanBindingSource.DataMember = "PhongBan";
            this.phongBanBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lsvND
            // 
            this.lsvND.BackColor = System.Drawing.Color.Lavender;
            this.lsvND.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhmanguoidung,
            this.clhhoten,
            this.clhngayssinh,
            this.clmgioitinh,
            this.clhDiachi,
            this.clhDienthoai,
            this.clhChucvu,
            this.lhPhongban});
            this.lsvND.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvND.HideSelection = false;
            this.lsvND.Location = new System.Drawing.Point(12, 374);
            this.lsvND.Name = "lsvND";
            this.lsvND.Size = new System.Drawing.Size(884, 201);
            this.lsvND.TabIndex = 26;
            this.lsvND.UseCompatibleStateImageBehavior = false;
            this.lsvND.View = System.Windows.Forms.View.Details;
            this.lsvND.SelectedIndexChanged += new System.EventHandler(this.lsvND_SelectedIndexChanged);
            this.lsvND.DoubleClick += new System.EventHandler(this.lsvND_DoubleClick);
            // 
            // clhmanguoidung
            // 
            this.clhmanguoidung.Text = "Mã người dùng";
            this.clhmanguoidung.Width = 92;
            // 
            // clhhoten
            // 
            this.clhhoten.Text = "Họ và tên";
            this.clhhoten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhhoten.Width = 115;
            // 
            // clhngayssinh
            // 
            this.clhngayssinh.Text = "Ngày sinh";
            this.clhngayssinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhngayssinh.Width = 80;
            // 
            // clmgioitinh
            // 
            this.clmgioitinh.Text = "Giới tính";
            this.clmgioitinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clhDiachi
            // 
            this.clhDiachi.Text = "Địa chỉ";
            this.clhDiachi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhDiachi.Width = 96;
            // 
            // clhDienthoai
            // 
            this.clhDienthoai.Text = "Điện thoại";
            this.clhDienthoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhDienthoai.Width = 121;
            // 
            // clhChucvu
            // 
            this.clhChucvu.Text = "Chức vụ";
            this.clhChucvu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhChucvu.Width = 87;
            // 
            // lhPhongban
            // 
            this.lhPhongban.Text = "Phòng ban";
            this.lhPhongban.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lhPhongban.Width = 93;
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
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // phongBanTableAdapter
            // 
            this.phongBanTableAdapter.ClearBeforeFill = true;
            // 
            // Form_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(908, 587);
            this.Controls.Add(this.lsvND);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_NhanVien";
            this.Text = "Quản Lý Người Dùng";
            this.Load += new System.EventHandler(this.Form_NhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttennhanvien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmanhanvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdBKhac;
        private System.Windows.Forms.RadioButton rdBNu;
        private System.Windows.Forms.RadioButton rdBNam;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbPhongban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ngaysinh;
        private System.Windows.Forms.TextBox txtChucvu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.Button btnXoaForm;
        private System.Windows.Forms.ListView lsvND;
        private System.Windows.Forms.ColumnHeader clhmanguoidung;
        private System.Windows.Forms.ColumnHeader clhhoten;
        private System.Windows.Forms.ColumnHeader clhngayssinh;
        private System.Windows.Forms.ColumnHeader clmgioitinh;
        private System.Windows.Forms.ColumnHeader clhDiachi;
        private System.Windows.Forms.ColumnHeader clhDienthoai;
        private System.Windows.Forms.ColumnHeader clhChucvu;
        private System.Windows.Forms.ColumnHeader lhPhongban;
        private System.Windows.Forms.MonthCalendar mtnNgaySinh;
        private System.Data.SqlClient.SqlCommand sqlCmd;
        private System.Data.SqlClient.SqlConnection sqlCnn;
        private System.Windows.Forms.Button btnPhongban;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource phongBanBindingSource;
        private DataSet1TableAdapters.PhongBanTableAdapter phongBanTableAdapter;
    }
}