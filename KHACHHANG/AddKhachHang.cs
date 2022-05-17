using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnRapChieuPhim
{
    public partial class AddKhachHang : Form
    {
        KHACHHANG kh = new KHACHHANG();
        int state;
        string makh, tenkh;
        bool giotinh;
        DateTime namsinh;
        bool loaikh;
        int diem;
        public AddKhachHang(int state, string makh, string tenkh, bool giotinh, DateTime namsinh, bool loai, int diem)
        {
            InitializeComponent();
            this.state = state;
            this.makh = makh;
            this.tenkh = tenkh;
            this.giotinh = giotinh;
            this.namsinh = namsinh;
            this.loaikh = loai;
            this.diem = diem;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tbx_tenkhach.Text.Trim() == "")
            {
                err_tenkhach.SetError(tbx_tenkhach, "Empty !");
            }
            else
            {
                //add//
                kh.AddKhachHang(tbx_makhach.Text, 
                                tbx_tenkhach.Text, 
                                rbtn_nam.Checked, 
                                dateTimePicker1.Value, 
                                cbx_VIP.Checked, 
                                Convert.ToInt32(tbx_diem.Text));
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (tbx_tenkhach.Text.Trim() == "")
            {
                err_tenkhach.SetError(tbx_tenkhach, "Empty !");
            }
            else
            {
                //update//
                kh.UpdateKhachHang(tbx_makhach.Text,
                                tbx_tenkhach.Text,
                                rbtn_nam.Checked,
                                dateTimePicker1.Value,
                                cbx_VIP.Checked,
                                Convert.ToInt32(tbx_diem.Text));
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            //del//
            kh.DelKhachHang(tbx_makhach.Text);
        }

        private void tbx_tenkhach_Leave(object sender, EventArgs e)
        {
            if(tbx_tenkhach.Text.Trim() == "")
            {
                err_tenkhach.SetError(tbx_tenkhach, "Empty !");
            }
        }

        private void tbx_diem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void AddKhachHang_Load(object sender, EventArgs e)
        {
            switch (state)
            {
                case 1: //ADD
                    {
                        btn_del.Enabled = false;
                        btn_del.Visible = false;
                        btn_edit.Enabled = false;
                        btn_edit.Visible = false;
                        string ma = "KH" + DateTime.Now.Month.ToString()
                                + DateTime.Now.Day.ToString()
                                + DateTime.Now.Hour.ToString()
                                + DateTime.Now.Minute.ToString()
                                + DateTime.Now.Second.ToString();
                        tbx_makhach.Text = ma;
                        break;
                    }
                case 2: //DEL, UPDATE
                    {
                        btn_add.Enabled = false;
                        btn_add.Visible = false;
                        tbx_makhach.Text = makh;
                        tbx_tenkhach.Text = tenkh;
                        rbtn_nam.Checked = (giotinh) ? true : false;
                        dateTimePicker1.Value = namsinh;
                        cbx_VIP.Checked = (loaikh) ? true : false;
                        tbx_diem.Text = diem.ToString();
                        break;
                    }
            }
        }
    }
}
