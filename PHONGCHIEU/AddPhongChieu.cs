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
    public partial class AddPhongChieu : Form
    {
        PHONGCHIEU pc = new PHONGCHIEU();
        int state;
        string mapc;
        int succhua;
        bool trangthai;
        public AddPhongChieu(int state, string mapc, int succhua, bool trangthai)
        {
            InitializeComponent();
            this.state = state;
            this.mapc = mapc;
            this.succhua = succhua;
            this.trangthai = trangthai;
        }
        private void AddPhongChieu_Load(object sender, EventArgs e)
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
                case 2: //DEL, EDIT
                    {
                        tbx_maphongchieu.Text = mapc;
                        tbx_succhua.Text = succhua.ToString();
                        cbx_trangthai.Checked = (trangthai) ? true : false; //True laf hoat dong, false laf bao tri
                        tbx_maphongchieu.Enabled = false;
                        btn_add.Enabled = false;
                        btn_add.Visible = false;
                        break;
                    }
            }
        }

        private void tbx_succhua_Leave(object sender, EventArgs e)
        {
            if(tbx_succhua.Text.Trim() == "")
            {
                err_succhua.SetError(tbx_succhua, "Empty !");
            }
            else
            {
                err_succhua.Clear();
            }
        }

        private void tbx_maphongchieu_Leave(object sender, EventArgs e)
        {
            if (tbx_maphongchieu.Text.Trim() == "")
            {
                err_mapc.SetError(tbx_maphongchieu, "Empty !");
            }
            else
            {
                err_mapc.Clear();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tbx_maphongchieu.Text.Trim() == "" || tbx_succhua.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền đàu đủ thông tin !");
            }
            else
            {
                //check ma pc roi add//
                pc.AddPhongChieu(tbx_maphongchieu.Text, Convert.ToInt32(tbx_succhua.Text), (cbx_trangthai.Checked) ? true : false);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (tbx_maphongchieu.Text.Trim() == "" || tbx_succhua.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền đàu đủ thông tin !");
            }
            else
            {
                pc.UpdatePhongChieu(tbx_maphongchieu.Text, Convert.ToInt32(tbx_succhua.Text), (cbx_trangthai.Checked) ? true : false);
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            //del//
            pc.DelPhongChieu(tbx_maphongchieu.Text);
        }
    }
}
