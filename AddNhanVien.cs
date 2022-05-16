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
    public partial class AddNhanVien : Form
    {
        int state;
        string manv;
        string tennv;
        string mapb;
        bool gioitinh;
        DateTime ngaysinh;
        string sdt;
        string diachi;
        public AddNhanVien(int state, string manv, string tennv, string mapb, bool gioitinh, DateTime ngaysinh, string sdt, string diachi)
        {
            InitializeComponent();
            this.state = state;
            this.manv = manv;
            this.tennv = tennv;
            this.mapb = mapb;
            this.gioitinh = gioitinh;
            this.ngaysinh = ngaysinh;
            this.sdt = sdt;
            this.diachi = diachi;
        }

        private void AddNhanVien_Load(object sender, EventArgs e)
        {
            switch (state)
            {
                case 1: //ADD
                    {
                        btn_del.Enabled = false;
                        btn_del.Visible = false;
                        btn_edit.Enabled = false;
                        btn_edit.Visible = false;
                        string ma = "NV" + DateTime.Now.Month.ToString()
                                         + DateTime.Now.Day.ToString()
                                         + DateTime.Now.Hour.ToString()
                                         + DateTime.Now.Minute.ToString()
                                         + DateTime.Now.Second.ToString();
                        tbx_manv.Text = ma;
                        break;
                    }
                case 2: //DEL, UPDATE
                    {
                        btn_add.Enabled = false;
                        btn_add.Visible = false;
                        tbx_tennv.Text = tennv;
                        tbx_diachi.Text = diachi;
                        tbx_sdt.Text = sdt;
                        tbx_manv.Text = manv;
                        dateTimePicker1.Value = ngaysinh;
                        rbtn_nam.Checked = (gioitinh) ? true : false;
                        //thieu combo box//
                        break;
                    }
            }
        }

        private void tbx_tennv_Leave(object sender, EventArgs e)
        {
            if (tbx_tennv.Text.Trim() == "")
            {
                err_ten.SetError(tbx_tennv, "Empty !");
            }
        }

        private void tbx_sdt_Leave(object sender, EventArgs e)
        {
            if(tbx_sdt.Text.Trim() == "")
            {
                err_sdt.SetError(tbx_sdt, "Empty !");
            }
        }

        private void tbx_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tbx_sdt.Text.Trim() == "" || tbx_tennv.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền đủ thông tin !");
            }
            else
            {
                //add
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (tbx_sdt.Text.Trim() == "" || tbx_tennv.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền đủ thông tin !");
            }
            else
            {
                //update
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            //del//
        }
    }
}
