using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnRapChieuPhim
{
    public partial class AddVe : Form
    {
        VE ve = new VE();
        KHACHHANG kh = new KHACHHANG();
        PHIM ph = new PHIM();
        LICHCHIEU lc = new LICHCHIEU();
        PHONGCHIEU pc = new PHONGCHIEU();
        int state;
        string mave, manv, makh, malc, madoan, maghe;
        DateTime ngaydat;
        int giave;

        private void tbx_findTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            string name = tbx_findTenKH.Text;
            if (tbx_findTenKH.Text.Trim() == "")
            {
                this.kHACHHANGTableAdapter.Fill(this.doAnRapChieuPhim03DataSet.KHACHHANG);
                dataGridView_KH.DataSource = doAnRapChieuPhim03DataSet.KHACHHANG;
            }
            else
            {
                dataGridView_KH.DataSource = kh.GetKHWithName(name.Trim());
            }
        }

        private void cbx_phim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbx_phim.SelectedValue != null)
            {
                dataGridView1.DataSource = ph.FindWithMaPhim(cbx_phim.SelectedValue.ToString().Trim());
            }
        }

        private void cbx_lichchieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbx_lichchieu.SelectedValue != null)
            {
                string malc = cbx_lichchieu.SelectedValue.ToString().Trim();
                //dataGridView_LC.DataSource = //Ham tim lich chieu tu ma//
                lc.FindWithMaLC(malc);
                cbx_maghe.DataSource = pc.GetGheTrong(dataGridView_LC.CurrentRow.Cells[2].Value.ToString().Trim());
            }
        }

        private void cbx_makh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_makh.SelectedValue != null)
            {
                string makh = cbx_makh.SelectedValue.ToString().Trim();
                dataGridView_KH.DataSource = kh.GetKHWithMa(makh);
            }
        }

        private void dataGridView_KH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cbx_makh.SelectedValue = dataGridView_KH.CurrentRow.Cells[0].Value.ToString().Trim();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.kHACHHANGTableAdapter.Fill(this.doAnRapChieuPhim03DataSet.KHACHHANG);
            dataGridView_KH.DataSource = doAnRapChieuPhim03DataSet.KHACHHANG;
        }

        private void dataGridView_LC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cbx_lichchieu.SelectedValue = dataGridView_LC.CurrentRow.Cells[0].Value.ToString().Trim();
        }

        private void tbx_findtennphim_KeyPress(object sender, KeyPressEventArgs e)
        {
            string tenphim = tbx_findtennphim.Text;
            dataGridView1.DataSource = ph.FindWithTenPhim(tenphim);
            if(tenphim.Trim() == "")
            {
                this.pHIMTableAdapter1.Fill(this.doAnRapChieuPhim03DataSet17.PHIM);
                dataGridView1.DataSource = doAnRapChieuPhim03DataSet17.PHIM;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cbx_phim.SelectedValue = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            dataGridView_LC.DataSource = lc.FindWithMaPhim(dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim());
        }

        private void btn_refresh_1_Click(object sender, EventArgs e)
        {
            dataGridView_LC.DataSource = doAnRapChieuPhim03DataSet4.LICHCHIEU;
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
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet19.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.doAnRapChieuPhim03DataSet19.NHANVIEN);
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet17.PHIM' table. You can move, or remove it, as needed.
            this.pHIMTableAdapter1.Fill(this.doAnRapChieuPhim03DataSet17.PHIM);
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
            dataGridView_KH.DataSource = doAnRapChieuPhim03DataSet.KHACHHANG;
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
                        tbx_ve.Text = mave;
                        break;
                    }
            }
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            ve.UpdateVE(tbx_ve.Text.Trim(), comboBox1.SelectedValue.ToString().Trim(), cbx_makh.SelectedValue.ToString().Trim(), cbx_lichchieu.SelectedValue.ToString().Trim(), cbx_madoan.SelectedValue.ToString().Trim(), cbx_maghe.SelectedValue.ToString().Trim(), DateTime.Now.Date, 0);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            ve.DelVE(tbx_ve.Text.Trim());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ve.AddVE(tbx_ve.Text.Trim(), comboBox1.SelectedValue.ToString().Trim(), cbx_makh.SelectedValue.ToString().Trim(), cbx_lichchieu.SelectedValue.ToString().Trim(), cbx_madoan.SelectedValue.ToString().Trim(), cbx_maghe.SelectedValue.ToString().Trim(), DateTime.Now.Date, 0);
        }
    }
}
