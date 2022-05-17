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
    public partial class AddDoAn : Form
    {
        DOAN da = new DOAN();
        int state;
        string madoan, tenmon;
        int gia;
        public AddDoAn(int state, string madoan, string tenmon, int gia)
        {
            InitializeComponent();
            this.state = state;
            this.madoan = madoan;
            this.tenmon = tenmon;
            this.gia = gia;
        }

        private void AddDoAn_Load(object sender, EventArgs e)
        {
            switch (state)
            {
                case 1: //ADD
                    {
                        btn_del.Enabled = false;
                        btn_del.Visible = false;
                        btn_update.Enabled = false;
                        btn_update.Visible = false;
                        break;
                    }
                case 2: //Del, update
                    {
                        tbx_madoan.Text = madoan;
                        tbx__tenmon.Text = tenmon;
                        tbx_giatien.Text = gia.ToString().Trim();
                        tbx_madoan.Enabled = false;
                        btn_add.Enabled = false;
                        btn_add.Visible = false;
                        err_madoan.Dispose();
                        break;
                    }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (tbx_madoan.Text.Trim() == "" || tbx__tenmon.Text.Trim() == "" || tbx_giatien.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền đủ thông tin !");
            }
            else
            {
                da.UpdateDoAn(tbx_madoan.Text, tbx__tenmon.Text, Convert.ToInt32(tbx_giatien.Text));
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tbx_madoan.Text.Trim() == "" || tbx__tenmon.Text.Trim() == "" || tbx_giatien.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền đủ thông tin !");
            }
            else
            {
                da.AddDoAn(tbx_madoan.Text, tbx__tenmon.Text, Convert.ToInt32(tbx_giatien.Text));
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            da.DelDoAn(tbx_madoan.Text);
        }

        private void tbx_madoan_Leave(object sender, EventArgs e)
        {
            if(tbx_madoan.Text.Trim() == "")
            {
                err_madoan.SetError(tbx_madoan, "Empty !");
            }
            else
            {
                err_madoan.Clear();
            }
        }

        private void tbx__tenmon_Leave(object sender, EventArgs e)
        {
            if (tbx__tenmon.Text.Trim() == "")
            {
                err_tenmon.SetError(tbx__tenmon, "Empty !");
            }
            else
            {
                err_tenmon.Clear();
            }
        }

        private void tbx_giatien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbx_giatien_Leave(object sender, EventArgs e)
        {
            if (tbx_giatien.Text.Trim() == "")
            {
                err_giatien.SetError(tbx_giatien, "Empty !");
            }
            else
            {
                err_giatien.Clear();
            }
        }
    }
}
