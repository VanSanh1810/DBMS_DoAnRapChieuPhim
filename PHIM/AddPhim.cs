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
    public partial class AddPhim : Form
    {
        PHIM ph = new PHIM();
        int state;
        string maphim, tenphim;
        int thoiluong;
        public AddPhim(int state, string maphim, string tenphim, int thoiluong)
        {
            InitializeComponent();
            this.state = state;
            this.maphim = maphim;
            this.tenphim = tenphim;
            this.thoiluong = thoiluong;
        }
        private void AddPhim_Load(object sender, EventArgs e)
        {
            switch (state)
            {
                case 1: //ADD
                    {
                        btn_del.Enabled = false;
                        btn_update.Enabled = false;
                        btn_update.Visible = false;
                        btn_del.Visible = false;
                        break;
                    }
                case 2: //DEL, UPDATE
                    {
                        btn_add.Enabled = false;
                        btn_add.Visible = false;
                        tbx_maphim.Text = maphim;
                        tbx_maphim.ReadOnly = true;
                        tbx_tenphim.Text = tenphim;
                        tbx_thoiluong.Text = thoiluong.ToString().Trim();
                        tbx_thoiluong.Enabled = true;
                        break;
                    }
            }
        }

        private void tbx_thoiluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbx_maphim_Leave(object sender, EventArgs e)
        {
            if (tbx_maphim.Text.Trim() == "")
            {
                err_maphim.SetError(tbx_maphim, "Empty !!");
            }
            else
            {
                err_maphim.Clear();
                //////CHeck ton tai///////
            }
        }

        private void tbx_tenphim_Leave(object sender, EventArgs e)
        {
            if (tbx_tenphim.Text.Trim() == "")
            {
                err_tenphim.SetError(tbx_tenphim, "Empty !!");
            }
            else
            {
                err_tenphim.Clear();
            }
        }

        private void tbx_thoiluong_Leave(object sender, EventArgs e)
        {
            if(tbx_thoiluong.Text.Trim() == "")
            {
                err_thoiluong.SetError(tbx_thoiluong, "Empty !!");
            }
            else
            {
                err_thoiluong.Clear();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tbx_thoiluong.Text.Trim() == "" || tbx_tenphim.Text.Trim() == "" || tbx_maphim.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin !");
            }
            else
            {
                ///check ton tai ma phim//roi add
                ph.AddPhim(tbx_maphim.Text, tbx_tenphim.Text, Convert.ToInt32(tbx_thoiluong.Text));
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            ph.DelPhim(tbx_maphim.Text);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (tbx_thoiluong.Text.Trim() == "" || tbx_tenphim.Text.Trim() == "" || tbx_maphim.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin !");
            }
            else
            {
                ph.UpdatePhim(tbx_maphim.Text, tbx_tenphim.Text, Convert.ToInt32(tbx_thoiluong.Text));
            }
        }
    }
}
