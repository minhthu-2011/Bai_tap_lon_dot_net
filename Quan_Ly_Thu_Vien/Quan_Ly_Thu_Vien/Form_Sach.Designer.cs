namespace Quan_Ly_Thu_Vien
{
    partial class Form_Sach
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoaForm = new System.Windows.Forms.Button();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.thoat = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.cbbTHeLoai = new System.Windows.Forms.ComboBox();
            this.theLoaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Quan_Ly_Thu_Vien.DataSet1();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvSach = new System.Windows.Forms.ListView();
            this.clmMaSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMaTheLoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTacGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSoLUong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sqlCmd = new System.Data.SqlClient.SqlCommand();
            this.sqlCnn = new System.Data.SqlClient.SqlConnection();
            this.theLoaiTableAdapter = new Quan_Ly_Thu_Vien.DataSet1TableAdapters.TheLoaiTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.btnXoaForm);
            this.groupBox2.Controls.Add(this.txtTacGia);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.thoat);
            this.groupBox2.Controls.Add(this.xoa);
            this.groupBox2.Controls.Add(this.them);
            this.groupBox2.Controls.Add(this.cbbTHeLoai);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSoluong);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTenSach);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtmasach);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(18, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 277);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sách";
            // 
            // btnXoaForm
            // 
            this.btnXoaForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaForm.Location = new System.Drawing.Point(566, 25);
            this.btnXoaForm.Name = "btnXoaForm";
            this.btnXoaForm.Size = new System.Drawing.Size(91, 56);
            this.btnXoaForm.TabIndex = 43;
            this.btnXoaForm.Text = "Xóa Form";
            this.btnXoaForm.UseVisualStyleBackColor = true;
            this.btnXoaForm.Click += new System.EventHandler(this.btnXoaForm_Click);
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(138, 174);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(165, 26);
            this.txtTacGia.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(34, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tác giả";
            // 
            // thoat
            // 
            this.thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thoat.Location = new System.Drawing.Point(669, 25);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(76, 56);
            this.thoat.TabIndex = 35;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // xoa
            // 
            this.xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xoa.Location = new System.Drawing.Point(469, 23);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(91, 56);
            this.xoa.TabIndex = 34;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // them
            // 
            this.them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.them.Location = new System.Drawing.Point(347, 25);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(104, 54);
            this.them.TabIndex = 32;
            this.them.Text = "Thêm/ Sửa";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // cbbTHeLoai
            // 
            this.cbbTHeLoai.DataSource = this.theLoaiBindingSource;
            this.cbbTHeLoai.DisplayMember = "MaTL";
            this.cbbTHeLoai.FormattingEnabled = true;
            this.cbbTHeLoai.Location = new System.Drawing.Point(138, 124);
            this.cbbTHeLoai.Name = "cbbTHeLoai";
            this.cbbTHeLoai.Size = new System.Drawing.Size(165, 28);
            this.cbbTHeLoai.TabIndex = 9;
            // 
            // theLoaiBindingSource
            // 
            this.theLoaiBindingSource.DataMember = "TheLoai";
            this.theLoaiBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(19, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã thể loại";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(138, 223);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(165, 26);
            this.txtSoluong.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(34, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(138, 80);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(188, 26);
            this.txtTenSach.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(43, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sách";
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(138, 34);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(188, 26);
            this.txtmasach.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            // 
            // lsvSach
            // 
            this.lsvSach.BackColor = System.Drawing.Color.Lavender;
            this.lsvSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmMaSach,
            this.clmTenSach,
            this.clmMaTheLoai,
            this.clmTacGia,
            this.clmSoLUong});
            this.lsvSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvSach.HideSelection = false;
            this.lsvSach.Location = new System.Drawing.Point(18, 302);
            this.lsvSach.Name = "lsvSach";
            this.lsvSach.Size = new System.Drawing.Size(761, 282);
            this.lsvSach.TabIndex = 25;
            this.lsvSach.UseCompatibleStateImageBehavior = false;
            this.lsvSach.View = System.Windows.Forms.View.Details;
            this.lsvSach.SelectedIndexChanged += new System.EventHandler(this.lsvSach_SelectedIndexChanged);
            this.lsvSach.DoubleClick += new System.EventHandler(this.lsvSach_DoubleClick);
            // 
            // clmMaSach
            // 
            this.clmMaSach.Text = "Mã Sách";
            this.clmMaSach.Width = 96;
            // 
            // clmTenSach
            // 
            this.clmTenSach.Text = "Tên Sách";
            this.clmTenSach.Width = 281;
            // 
            // clmMaTheLoai
            // 
            this.clmMaTheLoai.Text = "Mã Thể Loại";
            this.clmMaTheLoai.Width = 97;
            // 
            // clmTacGia
            // 
            this.clmTacGia.Text = "Tác Giả";
            this.clmTacGia.Width = 184;
            // 
            // clmSoLUong
            // 
            this.clmSoLUong.Text = "Số Lượng";
            this.clmSoLUong.Width = 98;
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
            // theLoaiTableAdapter
            // 
            this.theLoaiTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 596);
            this.Controls.Add(this.lsvSach);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Sach";
            this.Text = "QUẢN LÝ SÁCH";
            this.Load += new System.EventHandler(this.Form_Sach_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.ComboBox cbbTHeLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lsvSach;
        private System.Windows.Forms.ColumnHeader clmMaSach;
        private System.Windows.Forms.ColumnHeader clmTenSach;
        private System.Windows.Forms.ColumnHeader clmMaTheLoai;
        private System.Windows.Forms.ColumnHeader clmTacGia;
        private System.Windows.Forms.ColumnHeader clmSoLUong;
        private System.Windows.Forms.Button btnXoaForm;
        private System.Data.SqlClient.SqlCommand sqlCmd;
        private System.Data.SqlClient.SqlConnection sqlCnn;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource theLoaiBindingSource;
        private DataSet1TableAdapters.TheLoaiTableAdapter theLoaiTableAdapter;
    }
}