
namespace DoAnRapChieuPhim
{
    partial class AddPhim
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
            this.lable3 = new System.Windows.Forms.Label();
            this.tbx_maphim = new System.Windows.Forms.TextBox();
            this.tbx_tenphim = new System.Windows.Forms.TextBox();
            this.tbx_thoiluong = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.err_maphim = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_tenphim = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_thoiluong = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err_maphim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_tenphim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_thoiluong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phim  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên phim :";
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Location = new System.Drawing.Point(12, 120);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(63, 13);
            this.lable3.TabIndex = 2;
            this.lable3.Text = "Thời lượng :";
            // 
            // tbx_maphim
            // 
            this.tbx_maphim.Location = new System.Drawing.Point(74, 19);
            this.tbx_maphim.Name = "tbx_maphim";
            this.tbx_maphim.Size = new System.Drawing.Size(118, 20);
            this.tbx_maphim.TabIndex = 3;
            this.tbx_maphim.Leave += new System.EventHandler(this.tbx_maphim_Leave);
            // 
            // tbx_tenphim
            // 
            this.tbx_tenphim.Location = new System.Drawing.Point(74, 67);
            this.tbx_tenphim.Name = "tbx_tenphim";
            this.tbx_tenphim.Size = new System.Drawing.Size(118, 20);
            this.tbx_tenphim.TabIndex = 4;
            this.tbx_tenphim.Leave += new System.EventHandler(this.tbx_tenphim_Leave);
            // 
            // tbx_thoiluong
            // 
            this.tbx_thoiluong.Location = new System.Drawing.Point(74, 117);
            this.tbx_thoiluong.Name = "tbx_thoiluong";
            this.tbx_thoiluong.Size = new System.Drawing.Size(118, 20);
            this.tbx_thoiluong.TabIndex = 5;
            this.tbx_thoiluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_thoiluong_KeyPress);
            this.tbx_thoiluong.Leave += new System.EventHandler(this.tbx_thoiluong_Leave);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(15, 174);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(60, 57);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(81, 174);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(60, 57);
            this.btn_del.TabIndex = 7;
            this.btn_del.Text = "DEL";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(147, 174);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(60, 57);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // err_maphim
            // 
            this.err_maphim.ContainerControl = this;
            // 
            // err_tenphim
            // 
            this.err_tenphim.ContainerControl = this;
            // 
            // err_thoiluong
            // 
            this.err_thoiluong.ContainerControl = this;
            // 
            // AddPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 243);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tbx_thoiluong);
            this.Controls.Add(this.tbx_tenphim);
            this.Controls.Add(this.tbx_maphim);
            this.Controls.Add(this.lable3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPhim";
            this.Text = "AddPhim";
            this.Load += new System.EventHandler(this.AddPhim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err_maphim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_tenphim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_thoiluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.TextBox tbx_maphim;
        private System.Windows.Forms.TextBox tbx_tenphim;
        private System.Windows.Forms.TextBox tbx_thoiluong;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ErrorProvider err_maphim;
        private System.Windows.Forms.ErrorProvider err_tenphim;
        private System.Windows.Forms.ErrorProvider err_thoiluong;
    }
}