
namespace DoAnRapChieuPhim
{
    partial class AddPhongBan
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
            this.tbx_mapb = new System.Windows.Forms.TextBox();
            this.tbx_tenpb = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.err_mapb = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_tenpb = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err_mapb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_tenpb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng ban :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên phòng ban :";
            // 
            // tbx_mapb
            // 
            this.tbx_mapb.Location = new System.Drawing.Point(100, 34);
            this.tbx_mapb.Name = "tbx_mapb";
            this.tbx_mapb.Size = new System.Drawing.Size(137, 20);
            this.tbx_mapb.TabIndex = 2;
            this.tbx_mapb.Leave += new System.EventHandler(this.tbx_mapb_Leave);
            // 
            // tbx_tenpb
            // 
            this.tbx_tenpb.Location = new System.Drawing.Point(100, 90);
            this.tbx_tenpb.Name = "tbx_tenpb";
            this.tbx_tenpb.Size = new System.Drawing.Size(137, 20);
            this.tbx_tenpb.TabIndex = 3;
            this.tbx_tenpb.Leave += new System.EventHandler(this.tbx_tenpb_Leave);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 130);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(66, 58);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(84, 130);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(66, 58);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(156, 130);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(66, 58);
            this.btn_del.TabIndex = 6;
            this.btn_del.Text = "DEL";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // err_mapb
            // 
            this.err_mapb.ContainerControl = this;
            // 
            // err_tenpb
            // 
            this.err_tenpb.ContainerControl = this;
            // 
            // AddPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 200);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tbx_tenpb);
            this.Controls.Add(this.tbx_mapb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPhongBan";
            this.Text = "AddPhongBan";
            this.Load += new System.EventHandler(this.AddPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err_mapb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_tenpb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_mapb;
        private System.Windows.Forms.TextBox tbx_tenpb;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.ErrorProvider err_mapb;
        private System.Windows.Forms.ErrorProvider err_tenpb;
    }
}