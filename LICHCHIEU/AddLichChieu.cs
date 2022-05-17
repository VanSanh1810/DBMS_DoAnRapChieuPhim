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
    public partial class AddLichChieu : Form
    {
        LICHCHIEU lc = new LICHCHIEU();
        int state;
        string malc, maphim, mapc;
        DateTime ngaykc;
        int sotien;

        private void tbx_sotien_Leave(object sender, EventArgs e)
        {
            if(tbx_sotien.Text.Trim() == "")
            {
                err_sotien.SetError(tbx_sotien, "Empty !");
            }
            else
            {
                err_sotien.Clear();
            }
        }

        private void tbx_sotien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tbx_sotien.Text.Trim() == "")
            {
                err_sotien.SetError(tbx_sotien, "Empty !");
            }
            else
            {
                err_sotien.Clear();
                //add//
                lc.AddLichChieu(tbx_malc.Text, 
                                cbx_mapc.SelectedValue.ToString(), 
                                cbx_maphim.SelectedValue.ToString(), 
                                dateTimePicker1.Value, 
                                Convert.ToInt32(tbx_sotien.Text));
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (tbx_sotien.Text.Trim() == "")
            {
                err_sotien.SetError(tbx_sotien, "Empty !");
            }
            else
            {
                err_sotien.Clear();
                //update//
                lc.UpdateLichChieu(tbx_malc.Text,
                                cbx_mapc.SelectedValue.ToString(),
                                cbx_maphim.SelectedValue.ToString(),
                                dateTimePicker1.Value,
                                Convert.ToInt32(tbx_sotien.Text));
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            //del
            lc.DelLichChieu(tbx_malc.Text);
        }

        public AddLichChieu(int state, string malc, string maphim, string mapc, DateTime ngaykc, int sotien)
        {
            InitializeComponent();
            this.state = state;
            this.malc = malc;
            this.maphim = maphim;
            this.mapc = mapc;
            this.ngaykc = ngaykc;
            this.sotien = sotien;
        }

        private void AddLichChieu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet16.PHONGCHIEU' table. You can move, or remove it, as needed.
            this.pHONGCHIEUTableAdapter.Fill(this.doAnRapChieuPhim03DataSet16.PHONGCHIEU);
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet15.PHIM' table. You can move, or remove it, as needed.
            this.pHIMTableAdapter.Fill(this.doAnRapChieuPhim03DataSet15.PHIM);
            switch (state)
            {
                case 1: //ADD
                    {
                        btn_del.Enabled = false;
                        btn_del.Visible = false;
                        btn_update.Enabled = false;
                        btn_update.Visible = false;
                        string ma = "LC" + DateTime.Now.Month.ToString()
                                            + DateTime.Now.Day.ToString()
                                            + DateTime.Now.Hour.ToString()
                                            + DateTime.Now.Minute.ToString()
                                            + DateTime.Now.Second.ToString();
                        tbx_malc.Text = ma;
                        tbx_malc.ReadOnly = true;
                        break;
                    }
                case 2: //DEL UPDATE
                    {
                        btn_add.Enabled = false;
                        btn_add.Visible = false;
                        tbx_malc.Text = malc;
                        tbx_sotien.Text = sotien.ToString();
                        //thieu mapc maphim
                        cbx_mapc.SelectedValue = mapc;
                        cbx_maphim.SelectedValue = maphim;
                        dateTimePicker1.Value = ngaykc;
                        break;
                    }
            }
        }
    }
}
