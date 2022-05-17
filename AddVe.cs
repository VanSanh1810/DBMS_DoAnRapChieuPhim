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
        DateTime ngaydat;
        int giave;

        private void tbx_findTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbx_phim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_lichchieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public AddVe(int state, string mave,string manv, string makh, string malc, string madoan, string maghe, DateTime ngaydat, int giave)
        {
            InitializeComponent();
            this.state = state;
            this.mave = mave;
            this.manv = manv;
            this.makh = makh;
            this.malc = malc;
            this.madoan = madoan;
            this.maghe = maghe;
            this.ngaydat = ngaydat;
            this.giave = giave;
        }
        private void AddVe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet4.LICHCHIEU' table. You can move, or remove it, as needed.
            this.lICHCHIEUTableAdapter.Fill(this.doAnRapChieuPhim03DataSet4.LICHCHIEU);
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet3.DOAN' table. You can move, or remove it, as needed.
            this.dOANTableAdapter.Fill(this.doAnRapChieuPhim03DataSet3.DOAN);
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet2.GHE' table. You can move, or remove it, as needed.
            this.gHETableAdapter.Fill(this.doAnRapChieuPhim03DataSet2.GHE);
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet1.PHIM' table. You can move, or remove it, as needed.
            this.pHIMTableAdapter.Fill(this.doAnRapChieuPhim03DataSet1.PHIM);
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.doAnRapChieuPhim03DataSet.KHACHHANG);
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
                        ngaydat = DateTime.Now.Date;
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
        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_del_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
    }
}
