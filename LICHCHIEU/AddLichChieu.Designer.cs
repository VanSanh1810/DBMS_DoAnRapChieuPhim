
namespace DoAnRapChieuPhim
{
    partial class AddLichChieu
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
            this.tbx_malc = new System.Windows.Forms.TextBox();
            this.tbx_sotien = new System.Windows.Forms.TextBox();
            this.cbx_maphim = new System.Windows.Forms.ComboBox();
            this.cbx_mapc = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.err_malc = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_sotien = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err_malc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_sotien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lịch chiếu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phim :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã phòng chiếu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày khởi chiếu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số tiền :";
            // 
            // tbx_malc
            // 
            this.tbx_malc.Location = new System.Drawing.Point(113, 32);
            this.tbx_malc.Name = "tbx_malc";
            this.tbx_malc.ReadOnly = true;
            this.tbx_malc.Size = new System.Drawing.Size(158, 20);
            this.tbx_malc.TabIndex = 5;
            // 
            // tbx_sotien
            // 
            this.tbx_sotien.Location = new System.Drawing.Point(113, 263);
            this.tbx_sotien.Name = "tbx_sotien";
            this.tbx_sotien.Size = new System.Drawing.Size(158, 20);
            this.tbx_sotien.TabIndex = 6;
            this.tbx_sotien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_sotien_KeyPress);
            this.tbx_sotien.Leave += new System.EventHandler(this.tbx_sotien_Leave);
            // 
            // cbx_maphim
            // 
            this.cbx_maphim.FormattingEnabled = true;
            this.cbx_maphim.Location = new System.Drawing.Point(113, 90);
            this.cbx_maphim.Name = "cbx_maphim";
            this.cbx_maphim.Size = new System.Drawing.Size(158, 21);
            this.cbx_maphim.TabIndex = 7;
            // 
            // cbx_mapc
            // 
            this.cbx_mapc.FormattingEnabled = true;
            this.cbx_mapc.Location = new System.Drawing.Point(113, 148);
            this.cbx_mapc.Name = "cbx_mapc";
            this.cbx_mapc.Size = new System.Drawing.Size(158, 21);
            this.cbx_mapc.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 202);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(15, 361);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 74);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(113, 361);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 74);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(209, 361);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 74);
            this.btn_del.TabIndex = 12;
            this.btn_del.Text = "DELETE";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // err_malc
            // 
            this.err_malc.ContainerControl = this;
            // 
            // err_sotien
            // 
            this.err_sotien.ContainerControl = this;
            // 
            // AddLichChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 447);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbx_mapc);
            this.Controls.Add(this.cbx_maphim);
            this.Controls.Add(this.tbx_sotien);
            this.Controls.Add(this.tbx_malc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddLichChieu";
            this.Text = "AddLichChieu";
            this.Load += new System.EventHandler(this.AddLichChieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err_malc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_sotien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_malc;
        private System.Windows.Forms.TextBox tbx_sotien;
        private System.Windows.Forms.ComboBox cbx_maphim;
        private System.Windows.Forms.ComboBox cbx_mapc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.ErrorProvider err_malc;
        private System.Windows.Forms.ErrorProvider err_sotien;
    }
}