
namespace DoAnRapChieuPhim
{
    partial class AddPhongChieu
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
            this.tbx_maphongchieu = new System.Windows.Forms.TextBox();
            this.tbx_succhua = new System.Windows.Forms.TextBox();
            this.cbx_trangthai = new System.Windows.Forms.CheckBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.err_mapc = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_succhua = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err_mapc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_succhua)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng chiếu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sức chứa :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng thái :";
            // 
            // tbx_maphongchieu
            // 
            this.tbx_maphongchieu.Location = new System.Drawing.Point(108, 19);
            this.tbx_maphongchieu.Name = "tbx_maphongchieu";
            this.tbx_maphongchieu.Size = new System.Drawing.Size(139, 20);
            this.tbx_maphongchieu.TabIndex = 3;
            this.tbx_maphongchieu.Leave += new System.EventHandler(this.tbx_maphongchieu_Leave);
            // 
            // tbx_succhua
            // 
            this.tbx_succhua.Location = new System.Drawing.Point(108, 65);
            this.tbx_succhua.Name = "tbx_succhua";
            this.tbx_succhua.ReadOnly = true;
            this.tbx_succhua.Size = new System.Drawing.Size(139, 20);
            this.tbx_succhua.TabIndex = 4;
            this.tbx_succhua.Text = "10";
            this.tbx_succhua.Leave += new System.EventHandler(this.tbx_succhua_Leave);
            // 
            // cbx_trangthai
            // 
            this.cbx_trangthai.AutoSize = true;
            this.cbx_trangthai.Checked = true;
            this.cbx_trangthai.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_trangthai.Location = new System.Drawing.Point(108, 114);
            this.cbx_trangthai.Name = "cbx_trangthai";
            this.cbx_trangthai.Size = new System.Drawing.Size(77, 17);
            this.cbx_trangthai.TabIndex = 5;
            this.cbx_trangthai.Text = "Hoạt động";
            this.cbx_trangthai.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 172);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 69);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(93, 172);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 69);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(174, 172);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 69);
            this.btn_del.TabIndex = 8;
            this.btn_del.Text = "DELETE";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // err_mapc
            // 
            this.err_mapc.ContainerControl = this;
            // 
            // err_succhua
            // 
            this.err_succhua.ContainerControl = this;
            // 
            // AddPhongChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 253);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cbx_trangthai);
            this.Controls.Add(this.tbx_succhua);
            this.Controls.Add(this.tbx_maphongchieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPhongChieu";
            this.Text = "AddPhongChieu";
            this.Load += new System.EventHandler(this.AddPhongChieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err_mapc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_succhua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_maphongchieu;
        private System.Windows.Forms.TextBox tbx_succhua;
        private System.Windows.Forms.CheckBox cbx_trangthai;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.ErrorProvider err_mapc;
        private System.Windows.Forms.ErrorProvider err_succhua;
    }
}