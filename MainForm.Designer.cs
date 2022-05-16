
namespace DoAnRapChieuPhim
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lb_username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_thongke = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_add_phim = new System.Windows.Forms.Button();
            this.button_refresh_phim = new System.Windows.Forms.Button();
            this.dataGridView_phim = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_refresh_phongchieu = new System.Windows.Forms.Button();
            this.button_add_phongchieu = new System.Windows.Forms.Button();
            this.dataGridView_phongchieu = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button_refresh_khachhang = new System.Windows.Forms.Button();
            this.button_add_khachhang = new System.Windows.Forms.Button();
            this.dataGridView_khachhang = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button_refresh_nhanvien = new System.Windows.Forms.Button();
            this.button_add_nhanvien = new System.Windows.Forms.Button();
            this.dataGridView_nhanvien = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button_refresh_doan = new System.Windows.Forms.Button();
            this.button_add_doan = new System.Windows.Forms.Button();
            this.dataGridView_doan = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button_refresh_ve = new System.Windows.Forms.Button();
            this.button_add_ve = new System.Windows.Forms.Button();
            this.dataGridView_ve = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phim)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phongchieu)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_khachhang)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nhanvien)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doan)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ve)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.lb_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 426);
            this.panel1.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_logout.Location = new System.Drawing.Point(56, 386);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 37);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Log out";
            this.btn_logout.UseVisualStyleBackColor = false;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(82, 168);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(67, 13);
            this.lb_username.TabIndex = 4;
            this.lb_username.Text = "Welcome, ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome, ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DoAnRapChieuPhim.Properties.Resources.Sanh;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 162);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_thongke);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(220, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 426);
            this.panel2.TabIndex = 1;
            // 
            // button_thongke
            // 
            this.button_thongke.BackColor = System.Drawing.Color.Plum;
            this.button_thongke.Location = new System.Drawing.Point(7, 382);
            this.button_thongke.Name = "button_thongke";
            this.button_thongke.Size = new System.Drawing.Size(411, 41);
            this.button_thongke.TabIndex = 1;
            this.button_thongke.Text = "Thống kê";
            this.button_thongke.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(7, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(422, 377);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.button_add_phim);
            this.tabPage1.Controls.Add(this.button_refresh_phim);
            this.tabPage1.Controls.Add(this.dataGridView_phim);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(414, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phim";
            // 
            // button_add_phim
            // 
            this.button_add_phim.BackColor = System.Drawing.Color.Lime;
            this.button_add_phim.Location = new System.Drawing.Point(6, 309);
            this.button_add_phim.Name = "button_add_phim";
            this.button_add_phim.Size = new System.Drawing.Size(93, 36);
            this.button_add_phim.TabIndex = 2;
            this.button_add_phim.Text = "Add";
            this.button_add_phim.UseVisualStyleBackColor = false;
            // 
            // button_refresh_phim
            // 
            this.button_refresh_phim.BackColor = System.Drawing.Color.Aqua;
            this.button_refresh_phim.Location = new System.Drawing.Point(330, 309);
            this.button_refresh_phim.Name = "button_refresh_phim";
            this.button_refresh_phim.Size = new System.Drawing.Size(75, 36);
            this.button_refresh_phim.TabIndex = 1;
            this.button_refresh_phim.Text = "Refresh";
            this.button_refresh_phim.UseVisualStyleBackColor = false;
            // 
            // dataGridView_phim
            // 
            this.dataGridView_phim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_phim.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_phim.Name = "dataGridView_phim";
            this.dataGridView_phim.Size = new System.Drawing.Size(399, 297);
            this.dataGridView_phim.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.button_refresh_phongchieu);
            this.tabPage2.Controls.Add(this.button_add_phongchieu);
            this.tabPage2.Controls.Add(this.dataGridView_phongchieu);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(414, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phòng chiếu";
            // 
            // button_refresh_phongchieu
            // 
            this.button_refresh_phongchieu.BackColor = System.Drawing.Color.Aqua;
            this.button_refresh_phongchieu.Location = new System.Drawing.Point(330, 309);
            this.button_refresh_phongchieu.Name = "button_refresh_phongchieu";
            this.button_refresh_phongchieu.Size = new System.Drawing.Size(75, 36);
            this.button_refresh_phongchieu.TabIndex = 4;
            this.button_refresh_phongchieu.Text = "Refresh";
            this.button_refresh_phongchieu.UseVisualStyleBackColor = false;
            // 
            // button_add_phongchieu
            // 
            this.button_add_phongchieu.BackColor = System.Drawing.Color.Lime;
            this.button_add_phongchieu.Location = new System.Drawing.Point(6, 309);
            this.button_add_phongchieu.Name = "button_add_phongchieu";
            this.button_add_phongchieu.Size = new System.Drawing.Size(93, 36);
            this.button_add_phongchieu.TabIndex = 3;
            this.button_add_phongchieu.Text = "Add";
            this.button_add_phongchieu.UseVisualStyleBackColor = false;
            // 
            // dataGridView_phongchieu
            // 
            this.dataGridView_phongchieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_phongchieu.Location = new System.Drawing.Point(6, 3);
            this.dataGridView_phongchieu.Name = "dataGridView_phongchieu";
            this.dataGridView_phongchieu.Size = new System.Drawing.Size(402, 297);
            this.dataGridView_phongchieu.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button_refresh_khachhang);
            this.tabPage3.Controls.Add(this.button_add_khachhang);
            this.tabPage3.Controls.Add(this.dataGridView_khachhang);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(414, 351);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Khách hàng";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button_refresh_khachhang
            // 
            this.button_refresh_khachhang.BackColor = System.Drawing.Color.Aqua;
            this.button_refresh_khachhang.Location = new System.Drawing.Point(332, 306);
            this.button_refresh_khachhang.Name = "button_refresh_khachhang";
            this.button_refresh_khachhang.Size = new System.Drawing.Size(75, 36);
            this.button_refresh_khachhang.TabIndex = 4;
            this.button_refresh_khachhang.Text = "Refresh";
            this.button_refresh_khachhang.UseVisualStyleBackColor = false;
            // 
            // button_add_khachhang
            // 
            this.button_add_khachhang.BackColor = System.Drawing.Color.Lime;
            this.button_add_khachhang.Location = new System.Drawing.Point(8, 306);
            this.button_add_khachhang.Name = "button_add_khachhang";
            this.button_add_khachhang.Size = new System.Drawing.Size(93, 36);
            this.button_add_khachhang.TabIndex = 3;
            this.button_add_khachhang.Text = "Add";
            this.button_add_khachhang.UseVisualStyleBackColor = false;
            // 
            // dataGridView_khachhang
            // 
            this.dataGridView_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_khachhang.Location = new System.Drawing.Point(8, 3);
            this.dataGridView_khachhang.Name = "dataGridView_khachhang";
            this.dataGridView_khachhang.Size = new System.Drawing.Size(399, 297);
            this.dataGridView_khachhang.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage4.Controls.Add(this.button_refresh_nhanvien);
            this.tabPage4.Controls.Add(this.button_add_nhanvien);
            this.tabPage4.Controls.Add(this.dataGridView_nhanvien);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(414, 351);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Nhân viên";
            // 
            // button_refresh_nhanvien
            // 
            this.button_refresh_nhanvien.BackColor = System.Drawing.Color.Aqua;
            this.button_refresh_nhanvien.Location = new System.Drawing.Point(332, 306);
            this.button_refresh_nhanvien.Name = "button_refresh_nhanvien";
            this.button_refresh_nhanvien.Size = new System.Drawing.Size(75, 36);
            this.button_refresh_nhanvien.TabIndex = 4;
            this.button_refresh_nhanvien.Text = "Refresh";
            this.button_refresh_nhanvien.UseVisualStyleBackColor = false;
            // 
            // button_add_nhanvien
            // 
            this.button_add_nhanvien.BackColor = System.Drawing.Color.Lime;
            this.button_add_nhanvien.Location = new System.Drawing.Point(8, 306);
            this.button_add_nhanvien.Name = "button_add_nhanvien";
            this.button_add_nhanvien.Size = new System.Drawing.Size(93, 36);
            this.button_add_nhanvien.TabIndex = 3;
            this.button_add_nhanvien.Text = "Add";
            this.button_add_nhanvien.UseVisualStyleBackColor = false;
            // 
            // dataGridView_nhanvien
            // 
            this.dataGridView_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_nhanvien.Location = new System.Drawing.Point(8, 3);
            this.dataGridView_nhanvien.Name = "dataGridView_nhanvien";
            this.dataGridView_nhanvien.Size = new System.Drawing.Size(399, 297);
            this.dataGridView_nhanvien.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage5.Controls.Add(this.button_refresh_doan);
            this.tabPage5.Controls.Add(this.button_add_doan);
            this.tabPage5.Controls.Add(this.dataGridView_doan);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(414, 351);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Đồ ăn";
            // 
            // button_refresh_doan
            // 
            this.button_refresh_doan.BackColor = System.Drawing.Color.Aqua;
            this.button_refresh_doan.Location = new System.Drawing.Point(332, 306);
            this.button_refresh_doan.Name = "button_refresh_doan";
            this.button_refresh_doan.Size = new System.Drawing.Size(75, 36);
            this.button_refresh_doan.TabIndex = 4;
            this.button_refresh_doan.Text = "Refresh";
            this.button_refresh_doan.UseVisualStyleBackColor = false;
            // 
            // button_add_doan
            // 
            this.button_add_doan.BackColor = System.Drawing.Color.Lime;
            this.button_add_doan.Location = new System.Drawing.Point(8, 306);
            this.button_add_doan.Name = "button_add_doan";
            this.button_add_doan.Size = new System.Drawing.Size(93, 36);
            this.button_add_doan.TabIndex = 3;
            this.button_add_doan.Text = "Add";
            this.button_add_doan.UseVisualStyleBackColor = false;
            // 
            // dataGridView_doan
            // 
            this.dataGridView_doan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_doan.Location = new System.Drawing.Point(8, 3);
            this.dataGridView_doan.Name = "dataGridView_doan";
            this.dataGridView_doan.Size = new System.Drawing.Size(399, 297);
            this.dataGridView_doan.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage6.Controls.Add(this.button_refresh_ve);
            this.tabPage6.Controls.Add(this.button_add_ve);
            this.tabPage6.Controls.Add(this.dataGridView_ve);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(414, 351);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Vé";
            // 
            // button_refresh_ve
            // 
            this.button_refresh_ve.BackColor = System.Drawing.Color.Aqua;
            this.button_refresh_ve.Location = new System.Drawing.Point(332, 306);
            this.button_refresh_ve.Name = "button_refresh_ve";
            this.button_refresh_ve.Size = new System.Drawing.Size(75, 36);
            this.button_refresh_ve.TabIndex = 4;
            this.button_refresh_ve.Text = "Refresh";
            this.button_refresh_ve.UseVisualStyleBackColor = false;
            // 
            // button_add_ve
            // 
            this.button_add_ve.BackColor = System.Drawing.Color.Lime;
            this.button_add_ve.Location = new System.Drawing.Point(8, 306);
            this.button_add_ve.Name = "button_add_ve";
            this.button_add_ve.Size = new System.Drawing.Size(93, 36);
            this.button_add_ve.TabIndex = 3;
            this.button_add_ve.Text = "Add";
            this.button_add_ve.UseVisualStyleBackColor = false;
            // 
            // dataGridView_ve
            // 
            this.dataGridView_ve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ve.Location = new System.Drawing.Point(8, 3);
            this.dataGridView_ve.Name = "dataGridView_ve";
            this.dataGridView_ve.Size = new System.Drawing.Size(399, 297);
            this.dataGridView_ve.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phim)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phongchieu)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_khachhang)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nhanvien)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doan)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ve)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_thongke;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_add_phim;
        private System.Windows.Forms.Button button_refresh_phim;
        private System.Windows.Forms.DataGridView dataGridView_phim;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Button button_add_phongchieu;
        private System.Windows.Forms.DataGridView dataGridView_phongchieu;
        private System.Windows.Forms.Button button_add_khachhang;
        private System.Windows.Forms.DataGridView dataGridView_khachhang;
        private System.Windows.Forms.Button button_add_nhanvien;
        private System.Windows.Forms.DataGridView dataGridView_nhanvien;
        private System.Windows.Forms.Button button_add_doan;
        private System.Windows.Forms.DataGridView dataGridView_doan;
        private System.Windows.Forms.Button button_add_ve;
        private System.Windows.Forms.DataGridView dataGridView_ve;
        private System.Windows.Forms.Button button_refresh_phongchieu;
        private System.Windows.Forms.Button button_refresh_khachhang;
        private System.Windows.Forms.Button button_refresh_nhanvien;
        private System.Windows.Forms.Button button_refresh_doan;
        private System.Windows.Forms.Button button_refresh_ve;
    }
}

