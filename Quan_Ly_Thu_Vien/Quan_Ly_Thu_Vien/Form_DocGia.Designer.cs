namespace Quan_Ly_Thu_Vien
{
    partial class Form_DocGia
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
            this.l = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvDocGia = new System.Windows.Forms.ListView();
            this.clhMaDocGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhHoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mnth_NgaySinh = new System.Windows.Forms.MonthCalendar();
            this.rdBKhac = new System.Windows.Forms.RadioButton();
            this.btnXoaForm = new System.Windows.Forms.Button();
            this.rdBNam = new System.Windows.Forms.RadioButton();
            this.rdBNu = new System.Windows.Forms.RadioButton();
            this.btnNgaySinh = new System.Windows.Forms.Button();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txttendocgia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmadocgia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sqlCmd = new System.Data.SqlClient.SqlCommand();
            this.sqlCnn = new System.Data.SqlClient.SqlConnection();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(380, 349);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(0, 13);
            this.l.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.lsvDocGia);
            this.groupBox1.Controls.Add(this.mnth_NgaySinh);
            this.groupBox1.Controls.Add(this.rdBKhac);
            this.groupBox1.Controls.Add(this.btnXoaForm);
            this.groupBox1.Controls.Add(this.rdBNam);
            this.groupBox1.Controls.Add(this.rdBNu);
            this.groupBox1.Controls.Add(this.btnNgaySinh);
            this.groupBox1.Controls.Add(this.txtNgaySinh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txttendocgia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmadocgia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 504);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Độc giả";
            // 
            // lsvDocGia
            // 
            this.lsvDocGia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhMaDocGia,
            this.clhHoten,
            this.clhNgaySinh,
            this.clhGioiTinh});
            this.lsvDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvDocGia.HideSelection = false;
            this.lsvDocGia.Location = new System.Drawing.Point(33, 240);
            this.lsvDocGia.Name = "lsvDocGia";
            this.lsvDocGia.Size = new System.Drawing.Size(645, 237);
            this.lsvDocGia.TabIndex = 55;
            this.lsvDocGia.UseCompatibleStateImageBehavior = false;
            this.lsvDocGia.View = System.Windows.Forms.View.Details;
            
            this.lsvDocGia.DoubleClick += new System.EventHandler(this.lsvDocGia_DoubleClick);
            // 
            // clhMaDocGia
            // 
            this.clhMaDocGia.Text = "Mã độc giả";
            this.clhMaDocGia.Width = 118;
            // 
            // clhHoten
            // 
            this.clhHoten.Text = "Họ và tên";
            this.clhHoten.Width = 165;
            // 
            // clhNgaySinh
            // 
            this.clhNgaySinh.Text = "Ngày sinh";
            this.clhNgaySinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhNgaySinh.Width = 134;
            // 
            // clhGioiTinh
            // 
            this.clhGioiTinh.Text = "Giới tính";
            this.clhGioiTinh.Width = 96;
            // 
            // mnth_NgaySinh
            // 
            this.mnth_NgaySinh.Location = new System.Drawing.Point(366, 125);
            this.mnth_NgaySinh.Name = "mnth_NgaySinh";
            this.mnth_NgaySinh.TabIndex = 54;
            this.mnth_NgaySinh.Visible = false;
            this.mnth_NgaySinh.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mnth_NgaySinh_DateSelected);
            // 
            // rdBKhac
            // 
            this.rdBKhac.AutoSize = true;
            this.rdBKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBKhac.Location = new System.Drawing.Point(333, 169);
            this.rdBKhac.Name = "rdBKhac";
            this.rdBKhac.Size = new System.Drawing.Size(60, 22);
            this.rdBKhac.TabIndex = 53;
            this.rdBKhac.TabStop = true;
            this.rdBKhac.Text = "Khác";
            this.rdBKhac.UseVisualStyleBackColor = true;
            // 
            // btnXoaForm
            // 
            this.btnXoaForm.Location = new System.Drawing.Point(562, 35);
            this.btnXoaForm.Name = "btnXoaForm";
            this.btnXoaForm.Size = new System.Drawing.Size(86, 58);
            this.btnXoaForm.TabIndex = 52;
            this.btnXoaForm.Text = "Xóa Form";
            this.btnXoaForm.UseVisualStyleBackColor = true;
            this.btnXoaForm.Click += new System.EventHandler(this.btnXoaForm_Click);
            // 
            // rdBNam
            // 
            this.rdBNam.AutoSize = true;
            this.rdBNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBNam.Location = new System.Drawing.Point(246, 169);
            this.rdBNam.Name = "rdBNam";
            this.rdBNam.Size = new System.Drawing.Size(58, 22);
            this.rdBNam.TabIndex = 51;
            this.rdBNam.TabStop = true;
            this.rdBNam.Text = "Nam";
            this.rdBNam.UseVisualStyleBackColor = true;
            // 
            // rdBNu
            // 
            this.rdBNu.AutoSize = true;
            this.rdBNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBNu.Location = new System.Drawing.Point(146, 169);
            this.rdBNu.Name = "rdBNu";
            this.rdBNu.Size = new System.Drawing.Size(45, 22);
            this.rdBNu.TabIndex = 50;
            this.rdBNu.TabStop = true;
            this.rdBNu.Text = "Nữ";
            this.rdBNu.UseVisualStyleBackColor = true;
            // 
            // btnNgaySinh
            // 
            this.btnNgaySinh.Location = new System.Drawing.Point(366, 130);
            this.btnNgaySinh.Name = "btnNgaySinh";
            this.btnNgaySinh.Size = new System.Drawing.Size(46, 23);
            this.btnNgaySinh.TabIndex = 49;
            this.btnNgaySinh.Text = "...";
            this.btnNgaySinh.UseVisualStyleBackColor = true;
            this.btnNgaySinh.Click += new System.EventHandler(this.btnNgaySinh_Click);
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(146, 129);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(214, 24);
            this.txtNgaySinh.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(14, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Giới tính";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(562, 111);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 58);
            this.btnThoat.TabIndex = 40;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(446, 111);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 58);
            this.btnXoa.TabIndex = 39;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(446, 35);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 58);
            this.btnThem.TabIndex = 37;
            this.btnThem.Text = "Thêm/Sửa";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(14, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh";
            // 
            // txttendocgia
            // 
            this.txttendocgia.Location = new System.Drawing.Point(146, 89);
            this.txttendocgia.Name = "txttendocgia";
            this.txttendocgia.Size = new System.Drawing.Size(272, 24);
            this.txttendocgia.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(14, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên";
            // 
            // txtmadocgia
            // 
            this.txtmadocgia.Location = new System.Drawing.Point(146, 43);
            this.txtmadocgia.Name = "txtmadocgia";
            this.txtmadocgia.Size = new System.Drawing.Size(272, 24);
            this.txtmadocgia.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã độc giả";
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
            // Form_DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 535);
            this.Controls.Add(this.l);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_DocGia";
            this.Text = "Quản Lý Độc Giả";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvDocGia;
        private System.Windows.Forms.ColumnHeader clhMaDocGia;
        private System.Windows.Forms.ColumnHeader clhHoten;
        private System.Windows.Forms.ColumnHeader clhNgaySinh;
        private System.Windows.Forms.ColumnHeader clhGioiTinh;
        private System.Windows.Forms.MonthCalendar mnth_NgaySinh;
        private System.Windows.Forms.RadioButton rdBKhac;
        private System.Windows.Forms.Button btnXoaForm;
        private System.Windows.Forms.RadioButton rdBNam;
        private System.Windows.Forms.RadioButton rdBNu;
        private System.Windows.Forms.Button btnNgaySinh;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttendocgia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmadocgia;
        private System.Windows.Forms.Label label2;
        private System.Data.SqlClient.SqlCommand sqlCmd;
        private System.Data.SqlClient.SqlConnection sqlCnn;
    }
}