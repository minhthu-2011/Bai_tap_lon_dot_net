namespace Quan_Ly_Thu_Vien
{
    partial class Form_TheLoaiSach
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
            this.thoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.txttentheloai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmatheloai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvTheLoai = new System.Windows.Forms.ListView();
            this.clmMaTheLoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTheloai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sqlCmd = new System.Data.SqlClient.SqlCommand();
            this.sqlCnn = new System.Data.SqlClient.SqlConnection();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.thoat);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.them);
            this.groupBox2.Controls.Add(this.txttentheloai);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtmatheloai);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(22, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 173);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin thể loại";
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(503, 120);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(111, 47);
            this.thoat.TabIndex = 38;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(327, 121);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(114, 47);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(107, 121);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(160, 45);
            this.them.TabIndex = 36;
            this.them.Text = "Thêm/ Sửa";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // txttentheloai
            // 
            this.txttentheloai.Location = new System.Drawing.Point(519, 51);
            this.txttentheloai.Name = "txttentheloai";
            this.txttentheloai.Size = new System.Drawing.Size(147, 26);
            this.txttentheloai.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(388, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên thể loại";
            // 
            // txtmatheloai
            // 
            this.txtmatheloai.Location = new System.Drawing.Point(156, 52);
            this.txtmatheloai.Name = "txtmatheloai";
            this.txtmatheloai.Size = new System.Drawing.Size(147, 26);
            this.txtmatheloai.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thể loại";
            // 
            // lsvTheLoai
            // 
            this.lsvTheLoai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmMaTheLoai,
            this.clmTheloai});
            this.lsvTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvTheLoai.HideSelection = false;
            this.lsvTheLoai.Location = new System.Drawing.Point(149, 220);
            this.lsvTheLoai.Name = "lsvTheLoai";
            this.lsvTheLoai.Size = new System.Drawing.Size(454, 229);
            this.lsvTheLoai.TabIndex = 27;
            this.lsvTheLoai.UseCompatibleStateImageBehavior = false;
            this.lsvTheLoai.View = System.Windows.Forms.View.Details;
            this.lsvTheLoai.DoubleClick += new System.EventHandler(this.lsvTheLoai_DoubleClick);
            // 
            // clmMaTheLoai
            // 
            this.clmMaTheLoai.Text = "Mã Thể Loại";
            this.clmMaTheLoai.Width = 133;
            // 
            // clmTheloai
            // 
            this.clmTheloai.Text = "Tên thể loại";
            this.clmTheloai.Width = 189;
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
            // Form_TheLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(768, 494);
            this.Controls.Add(this.lsvTheLoai);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_TheLoaiSach";
            this.Text = "Quản Lý Thể Loại Sách";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txttentheloai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmatheloai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.ListView lsvTheLoai;
        private System.Windows.Forms.ColumnHeader clmMaTheLoai;
        private System.Windows.Forms.ColumnHeader clmTheloai;
        private System.Data.SqlClient.SqlCommand sqlCmd;
        private System.Data.SqlClient.SqlConnection sqlCnn;
    }
}