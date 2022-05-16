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
    public partial class AddVe : Form
    {
        int state;
        string mave, manv, makh, malc, madoan, maghe;

        private void AddVe_Load(object sender, EventArgs e)
        {
            switch (state)
            {
                case 1: ///ADD
                    {
                        btn_del.Enabled = false;
                        btn_del.Visible = false;
                        btn_edit.Enabled = false;
                        btn_edit.Visible = false;
                        tbx_ve.Text = "VE" + DateTime.Now.Month.ToString()
                                          + DateTime.Now.Day.ToString()
                                          + DateTime.Now.Hour.ToString()
                                          + DateTime.Now.Minute.ToString()
                                          + DateTime.Now.Second.ToString();
                        break;

                    }
                case 2: ///DEL update
                    {
                        btn_add.Enabled = false;
                        btn_add.Visible = false;
                        break;
                    }
            }
        }

        DateTime ngaydat;
        int giave;
        public AddVe(int state, string mave, string makh, string malc, string madoan, string maghe, DateTime ngaydat, int giave)
        {
            InitializeComponent();
            this.state = state;
            this.mave = mave;
            this.makh = makh;
            this.malc = malc;
            this.madoan = madoan;
            this.maghe = maghe;
            this.ngaydat = ngaydat;
            this.giave = giave;
        }
    }
}
