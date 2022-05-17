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
    public partial class AddPhongBan : Form
    {
        PHONGBAN pb = new PHONGBAN();
        int state;
        string mapb;
        string tenpb;
        public AddPhongBan(int state, string mapb, string tenpb)
        {
            InitializeComponent();
            this.state = state;
            this.mapb = mapb;
            this.tenpb = tenpb;
        }

        private void tbx_mapb_Leave(object sender, EventArgs e)
        {
            if(tbx_mapb.Text.Trim() == "")
            {
                err_mapb.SetError(tbx_mapb, "Empty !");
            }
            else
            {
                err_mapb.Clear();
            }
        }

        private void tbx_tenpb_Leave(object sender, EventArgs e)
        {
            if (tbx_tenpb.Text.Trim() == "")
            {
                err_tenpb.SetError(tbx_tenpb, "Empty !");
            }
            else
            {
                err_tenpb.Clear();
            }
        }

        private void AddPhongBan_Load(object sender, EventArgs e)
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
                case 2: //DEL UPDATE
                    {
                        tbx_mapb.ReadOnly = true;
                        btn_add.Enabled = false;
                        btn_add.Visible = false;
                        tbx_mapb.Text = mapb;
                        tbx_tenpb.Text = tenpb;
                        break;
                    }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tbx_tenpb.Text.Trim() == "" || tbx_mapb.Text.Trim() == "")
            {
                MessageBox.Show("Hẫy điền đủ thông tin !");
            }
            else
            {
                pb.AddPB(tbx_mapb.Text, tbx_tenpb.Text);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (tbx_tenpb.Text.Trim() == "" || tbx_mapb.Text.Trim() == "")
            {
                MessageBox.Show("Hẫy điền đủ thông tin !");
            }
            else
            {
                pb.UpdatePB(mapb, tbx_tenpb.Text);
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            pb.DelPB(tbx_mapb.Text);
        }
    }
}
