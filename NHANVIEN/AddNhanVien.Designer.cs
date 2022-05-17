
namespace DoAnRapChieuPhim
{
    partial class AddNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_manv = new System.Windows.Forms.TextBox();
            this.tbx_tennv = new System.Windows.Forms.TextBox();
            this.tbx_sdt = new System.Windows.Forms.TextBox();
            this.tbx_diachi = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbtn_nam = new System.Windows.Forms.RadioButton();
            this.rbtn_nu = new System.Windows.Forms.RadioButton();
            this.cbx_mapb = new System.Windows.Forms.ComboBox();
            this.err_ten = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_mapb = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_sdt = new System.Windows.Forms.ErrorProvider(this.components);
            this.doAnRapChieuPhim03DataSet14 = new DoAnRapChieuPhim.DoAnRapChieuPhim03DataSet14();
            this.pHONGBANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGBANTableAdapter = new DoAnRapChieuPhim.DoAnRapChieuPhim03DataSet14TableAdapters.PHONGBANTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.err_ten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_mapb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_sdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnRapChieuPhim03DataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã phòng ban :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Năm sinh :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa chỉ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "SDT :";
            // 
            // tbx_manv
            // 
            this.tbx_manv.Location = new System.Drawing.Point(96, 26);
            this.tbx_manv.Name = "tbx_manv";
            this.tbx_manv.ReadOnly = true;
            this.tbx_manv.Size = new System.Drawing.Size(174, 20);
            this.tbx_manv.TabIndex = 7;
            // 
            // tbx_tennv
            // 
            this.tbx_tennv.Location = new System.Drawing.Point(96, 68);
            this.tbx_tennv.Name = "tbx_tennv";
            this.tbx_tennv.Size = new System.Drawing.Size(174, 20);
            this.tbx_tennv.TabIndex = 8;
            this.tbx_tennv.Leave += new System.EventHandler(this.tbx_tennv_Leave);
            // 
            // tbx_sdt
            // 
            this.tbx_sdt.Location = new System.Drawing.Point(96, 253);
            this.tbx_sdt.Name = "tbx_sdt";
            this.tbx_sdt.Size = new System.Drawing.Size(174, 20);
            this.tbx_sdt.TabIndex = 9;
            this.tbx_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_sdt_KeyPress);
            this.tbx_sdt.Leave += new System.EventHandler(this.tbx_sdt_Leave);
            // 
            // tbx_diachi
            // 
            this.tbx_diachi.Location = new System.Drawing.Point(96, 299);
            this.tbx_diachi.Multiline = true;
            this.tbx_diachi.Name = "tbx_diachi";
            this.tbx_diachi.Size = new System.Drawing.Size(174, 73);
            this.tbx_diachi.TabIndex = 10;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 381);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(70, 65);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(135, 378);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(70, 65);
            this.btn_edit.TabIndex = 12;
            this.btn_edit.Text = "UPDATE";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(254, 378);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(70, 65);
            this.btn_del.TabIndex = 13;
            this.btn_del.Text = "DELETE";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 204);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // rbtn_nam
            // 
            this.rbtn_nam.AutoSize = true;
            this.rbtn_nam.Checked = true;
            this.rbtn_nam.Location = new System.Drawing.Point(96, 163);
            this.rbtn_nam.Name = "rbtn_nam";
            this.rbtn_nam.Size = new System.Drawing.Size(47, 17);
            this.rbtn_nam.TabIndex = 15;
            this.rbtn_nam.TabStop = true;
            this.rbtn_nam.Text = "Nam";
            this.rbtn_nam.UseVisualStyleBackColor = true;
            // 
            // rbtn_nu
            // 
            this.rbtn_nu.AutoSize = true;
            this.rbtn_nu.Location = new System.Drawing.Point(185, 163);
            this.rbtn_nu.Name = "rbtn_nu";
            this.rbtn_nu.Size = new System.Drawing.Size(39, 17);
            this.rbtn_nu.TabIndex = 16;
            this.rbtn_nu.Text = "Nữ";
            this.rbtn_nu.UseVisualStyleBackColor = true;
            // 
            // cbx_mapb
            // 
            this.cbx_mapb.DataSource = this.pHONGBANBindingSource;
            this.cbx_mapb.DisplayMember = "TenPB";
            this.cbx_mapb.FormattingEnabled = true;
            this.cbx_mapb.Location = new System.Drawing.Point(96, 114);
            this.cbx_mapb.Name = "cbx_mapb";
            this.cbx_mapb.Size = new System.Drawing.Size(174, 21);
            this.cbx_mapb.TabIndex = 17;
            this.cbx_mapb.ValueMember = "MaPB";
            // 
            // err_ten
            // 
            this.err_ten.ContainerControl = this;
            // 
            // err_mapb
            // 
            this.err_mapb.ContainerControl = this;
            // 
            // err_sdt
            // 
            this.err_sdt.ContainerControl = this;
            // 
            // doAnRapChieuPhim03DataSet14
            // 
            this.doAnRapChieuPhim03DataSet14.DataSetName = "DoAnRapChieuPhim03DataSet14";
            this.doAnRapChieuPhim03DataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHONGBANBindingSource
            // 
            this.pHONGBANBindingSource.DataMember = "PHONGBAN";
            this.pHONGBANBindingSource.DataSource = this.doAnRapChieuPhim03DataSet14;
            // 
            // pHONGBANTableAdapter
            // 
            this.pHONGBANTableAdapter.ClearBeforeFill = true;
            // 
            // AddNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 452);
            this.Controls.Add(this.cbx_mapb);
            this.Controls.Add(this.rbtn_nu);
            this.Controls.Add(this.rbtn_nam);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tbx_diachi);
            this.Controls.Add(this.tbx_sdt);
            this.Controls.Add(this.tbx_tennv);
            this.Controls.Add(this.tbx_manv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNhanVien";
            this.Text = "AddNhanVien";
            this.Load += new System.EventHandler(this.AddNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err_ten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_mapb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_sdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnRapChieuPhim03DataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_manv;
        private System.Windows.Forms.TextBox tbx_tennv;
        private System.Windows.Forms.TextBox tbx_sdt;
        private System.Windows.Forms.TextBox tbx_diachi;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rbtn_nam;
        private System.Windows.Forms.RadioButton rbtn_nu;
        private System.Windows.Forms.ComboBox cbx_mapb;
        private System.Windows.Forms.ErrorProvider err_ten;
        private System.Windows.Forms.ErrorProvider err_mapb;
        private System.Windows.Forms.ErrorProvider err_sdt;
        private DoAnRapChieuPhim03DataSet14 doAnRapChieuPhim03DataSet14;
        private System.Windows.Forms.BindingSource pHONGBANBindingSource;
        private DoAnRapChieuPhim03DataSet14TableAdapters.PHONGBANTableAdapter pHONGBANTableAdapter;
    }
}