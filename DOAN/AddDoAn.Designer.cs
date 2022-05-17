
namespace DoAnRapChieuPhim
{
    partial class AddDoAn
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
            this.tbx_madoan = new System.Windows.Forms.TextBox();
            this.tbx__tenmon = new System.Windows.Forms.TextBox();
            this.tbx_giatien = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.err_madoan = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_tenmon = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_giatien = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err_madoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_tenmon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_giatien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đồ ăn :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên món :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá tiền :";
            // 
            // tbx_madoan
            // 
            this.tbx_madoan.Location = new System.Drawing.Point(77, 23);
            this.tbx_madoan.Name = "tbx_madoan";
            this.tbx_madoan.Size = new System.Drawing.Size(129, 20);
            this.tbx_madoan.TabIndex = 3;
            this.tbx_madoan.Leave += new System.EventHandler(this.tbx_madoan_Leave);
            // 
            // tbx__tenmon
            // 
            this.tbx__tenmon.Location = new System.Drawing.Point(77, 63);
            this.tbx__tenmon.Name = "tbx__tenmon";
            this.tbx__tenmon.Size = new System.Drawing.Size(129, 20);
            this.tbx__tenmon.TabIndex = 4;
            this.tbx__tenmon.Leave += new System.EventHandler(this.tbx__tenmon_Leave);
            // 
            // tbx_giatien
            // 
            this.tbx_giatien.Location = new System.Drawing.Point(77, 104);
            this.tbx_giatien.Name = "tbx_giatien";
            this.tbx_giatien.Size = new System.Drawing.Size(129, 20);
            this.tbx_giatien.TabIndex = 5;
            this.tbx_giatien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_giatien_KeyPress);
            this.tbx_giatien.Leave += new System.EventHandler(this.tbx_giatien_Leave);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(15, 160);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 64);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(96, 160);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 64);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(177, 160);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 64);
            this.btn_del.TabIndex = 8;
            this.btn_del.Text = "DELETE";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // err_madoan
            // 
            this.err_madoan.ContainerControl = this;
            // 
            // err_tenmon
            // 
            this.err_tenmon.ContainerControl = this;
            // 
            // err_giatien
            // 
            this.err_giatien.ContainerControl = this;
            // 
            // AddDoAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 236);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tbx_giatien);
            this.Controls.Add(this.tbx__tenmon);
            this.Controls.Add(this.tbx_madoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddDoAn";
            this.Text = "AddDoAn";
            this.Load += new System.EventHandler(this.AddDoAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err_madoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_tenmon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_giatien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_madoan;
        private System.Windows.Forms.TextBox tbx__tenmon;
        private System.Windows.Forms.TextBox tbx_giatien;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.ErrorProvider err_madoan;
        private System.Windows.Forms.ErrorProvider err_tenmon;
        private System.Windows.Forms.ErrorProvider err_giatien;
    }
}