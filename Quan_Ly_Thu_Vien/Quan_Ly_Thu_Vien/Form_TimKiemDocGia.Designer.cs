namespace Quan_Ly_Thu_Vien
{
    partial class Form_TimKiemDocGia
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
            this.rd_tendocgia = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.rd_madocgia = new System.Windows.Forms.RadioButton();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.sqlCmd = new System.Data.SqlClient.SqlCommand();
            this.sqlCnn = new System.Data.SqlClient.SqlConnection();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // rd_tendocgia
            // 
            this.rd_tendocgia.AutoSize = true;
            this.rd_tendocgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rd_tendocgia.Location = new System.Drawing.Point(337, 72);
            this.rd_tendocgia.Name = "rd_tendocgia";
            this.rd_tendocgia.Size = new System.Drawing.Size(109, 24);
            this.rd_tendocgia.TabIndex = 51;
            this.rd_tendocgia.TabStop = true;
            this.rd_tendocgia.Text = "Tên độc giả";
            this.rd_tendocgia.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(544, 44);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 45);
            this.btnTimKiem.TabIndex = 50;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // rd_madocgia
            // 
            this.rd_madocgia.AutoSize = true;
            this.rd_madocgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rd_madocgia.Location = new System.Drawing.Point(337, 39);
            this.rd_madocgia.Name = "rd_madocgia";
            this.rd_madocgia.Size = new System.Drawing.Size(104, 24);
            this.rd_madocgia.TabIndex = 48;
            this.rd_madocgia.TabStop = true;
            this.rd_madocgia.Text = "Mã độc giả";
            this.rd_madocgia.UseVisualStyleBackColor = true;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(80, 55);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(206, 20);
            this.txttimkiem.TabIndex = 49;
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
            // gridview
            // 
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Location = new System.Drawing.Point(108, 158);
            this.gridview.Name = "gridview";
            this.gridview.Size = new System.Drawing.Size(548, 192);
            this.gridview.TabIndex = 52;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(544, 108);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 44);
            this.btnThoat.TabIndex = 53;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nhập từ cần tìm";
            // 
            // Form_TimKiemDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.rd_tendocgia);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.rd_madocgia);
            this.Controls.Add(this.txttimkiem);
            this.Name = "Form_TimKiemDocGia";
            this.Text = "Form_TimKiemDocGia";
            this.Load += new System.EventHandler(this.Form_TimKiemDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rd_tendocgia;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.RadioButton rd_madocgia;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Data.SqlClient.SqlCommand sqlCmd;
        private System.Data.SqlClient.SqlConnection sqlCnn;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
    }
}