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
    public partial class MainForm : Form
    {
        PHIM ph = new PHIM();
        KHACHHANG kh = new KHACHHANG();
        NHANVIEN nv = new NHANVIEN();
        string role;
        string name;
        public MainForm(string role, string name)
        {
            InitializeComponent();
            this.role = role.Trim(); ;
            this.name = name;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet18.GHE' table. You can move, or remove it, as needed.
            this.gHETableAdapter.Fill(this.doAnRapChieuPhim03DataSet18.GHE);
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet13.PHONGBAN' table. You can move, or remove it, as needed.
            this.pHONGBANTableAdapter.Fill(this.doAnRapChieuPhim03DataSet13.PHONGBAN);
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet12.LICHCHIEU' table. You can move, or remove it, as needed.
            this.lICHCHIEUTableAdapter1.Fill(this.doAnRapChieuPhim03DataSet12.LICHCHIEU);
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet11.LICHCHIEU' table. You can move, or remove it, as needed.
            this.lICHCHIEUTableAdapter.Fill(this.doAnRapChieuPhim03DataSet11.LICHCHIEU);
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet10.VE' table. You can move, or remove it, as needed.
            this.vETableAdapter.Fill(this.doAnRapChieuPhim03DataSet10.VE);
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet9.DOAN' table. You can move, or remove it, as needed.
            this.dOANTableAdapter.Fill(this.doAnRapChieuPhim03DataSet9.DOAN);
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet8.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.doAnRapChieuPhim03DataSet8.NHANVIEN);
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet7.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.doAnRapChieuPhim03DataSet7.KHACHHANG);
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet6.PHONGCHIEU' table. You can move, or remove it, as needed.
            this.pHONGCHIEUTableAdapter.Fill(this.doAnRapChieuPhim03DataSet6.PHONGCHIEU);
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet5.PHIM' table. You can move, or remove it, as needed.
            this.pHIMTableAdapter.Fill(this.doAnRapChieuPhim03DataSet5.PHIM);
            lb_username.Text = name;
            //tabControl1.TabPages[0].Controls.Clear();
            switch (role)
            {
                case "PB01": //QLPhongChieu
                    {
                        tabControl1.TabPages[0].Controls.Clear();
                        //tabControl1.TabPages[1].Controls.Clear();
                        tabControl1.TabPages[2].Controls.Clear();
                        tabControl1.TabPages[3].Controls.Clear();
                        tabControl1.TabPages[4].Controls.Clear();
                        tabControl1.TabPages[5].Controls.Clear();
                        tabControl1.TabPages[6].Controls.Clear();
                        tabControl1.TabPages[7].Controls.Clear();
                        //tabControl1.TabPages[8].Controls.Clear();
                        break;
                    }
                case "PB02": //QLPhim
                    {
                        //tabControl1.TabPages[0].Controls.Clear();
                        tabControl1.TabPages[1].Controls.Clear();
                        tabControl1.TabPages[2].Controls.Clear();
                        tabControl1.TabPages[3].Controls.Clear();
                        tabControl1.TabPages[4].Controls.Clear();
                        tabControl1.TabPages[5].Controls.Clear();
                        tabControl1.TabPages[6].Controls.Clear();
                        tabControl1.TabPages[7].Controls.Clear();
                        tabControl1.TabPages[8].Controls.Clear();
                        break;
                    }
                case "PB03": //QLLichChieu
                    {
                        //tabControl1.TabPages[0].Controls.Clear();
                        //tabControl1.TabPages[1].Controls.Clear();
                        tabControl1.TabPages[2].Controls.Clear();
                        tabControl1.TabPages[3].Controls.Clear();
                        tabControl1.TabPages[4].Controls.Clear();
                        tabControl1.TabPages[5].Controls.Clear();
                        //tabControl1.TabPages[6].Controls.Clear();
                        tabControl1.TabPages[7].Controls.Clear();
                        tabControl1.TabPages[8].Controls.Clear();
                        break;
                    }
                case "PB04": //QLKhachHang
                    {
                        tabControl1.TabPages[0].Controls.Clear();
                        tabControl1.TabPages[1].Controls.Clear();
                        //tabControl1.TabPages[2].Controls.Clear();
                        tabControl1.TabPages[3].Controls.Clear();
                        tabControl1.TabPages[4].Controls.Clear();
                        tabControl1.TabPages[5].Controls.Clear();
                        tabControl1.TabPages[6].Controls.Clear();
                        tabControl1.TabPages[7].Controls.Clear();
                        tabControl1.TabPages[8].Controls.Clear();
                        break;
                    }
                case "PB05": //QLVe
                    {
                        tabControl1.TabPages[0].Controls.Clear();
                        tabControl1.TabPages[1].Controls.Clear();
                        tabControl1.TabPages[2].Controls.Clear();
                        tabControl1.TabPages[3].Controls.Clear();
                        tabControl1.TabPages[4].Controls.Clear();
                        //tabControl1.TabPages[5].Controls.Clear();
                        tabControl1.TabPages[6].Controls.Clear();
                        tabControl1.TabPages[7].Controls.Clear();
                        tabControl1.TabPages[8].Controls.Clear();
                        break;
                    }
                case "ad":
                    {
                        break;
                    }
            }
        }

        private void dataGridView_phim_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_phim.Rows.Count != 0)
            {
                AddPhim a = new AddPhim(2, dataGridView_phim.CurrentRow.Cells[0].Value.ToString(),
                                        dataGridView_phim.CurrentRow.Cells[1].Value.ToString(),
                                        Convert.ToInt32(dataGridView_phim.CurrentRow.Cells[2].Value.ToString().Trim()));
                a.Show(this);
            }
        }
        private void dataGridView_phongchieu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddPhongChieu a = new AddPhongChieu(2, dataGridView_phongchieu.CurrentRow.Cells[0].Value.ToString(),
                                                    Convert.ToInt32(dataGridView_phongchieu.CurrentRow.Cells[1].Value.ToString().Trim()),
                                                    (bool)dataGridView_phongchieu.CurrentRow.Cells[2].Value);
            a.Show(this);
        }
        private void dataGridView_lichchieu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddLichChieu a = new AddLichChieu(2, dataGridView_lichchieu.CurrentRow.Cells[0].Value.ToString(),
                                                    dataGridView_lichchieu.CurrentRow.Cells[1].Value.ToString(),
                                                    dataGridView_lichchieu.CurrentRow.Cells[2].Value.ToString(),
                                                    (DateTime)dataGridView_lichchieu.CurrentRow.Cells[3].Value,
                                                    (int)dataGridView_lichchieu.CurrentRow.Cells[4].Value);
            a.Show(this);
        }
        private void dataGridView_khachhang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddKhachHang a = new AddKhachHang(2, dataGridView_khachhang.CurrentRow.Cells[0].Value.ToString(),
                                                dataGridView_khachhang.CurrentRow.Cells[1].Value.ToString(),
                                                (bool)dataGridView_khachhang.CurrentRow.Cells[2].Value,
                                                (DateTime)dataGridView_khachhang.CurrentRow.Cells[3].Value,
                                                (bool)dataGridView_khachhang.CurrentRow.Cells[4].Value,
                                                Convert.ToInt32(dataGridView_khachhang.CurrentRow.Cells[5].Value.ToString()));
            a.Show(this);
        }
        private void dataGridView_nhanvien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddNhanVien a = new AddNhanVien(2, dataGridView_nhanvien.CurrentRow.Cells[0].Value.ToString(),
                                               dataGridView_nhanvien.CurrentRow.Cells[1].Value.ToString(),
                                               dataGridView_nhanvien.CurrentRow.Cells[2].Value.ToString(),
                                               (bool)dataGridView_nhanvien.CurrentRow.Cells[3].Value,
                                               (DateTime)dataGridView_nhanvien.CurrentRow.Cells[4].Value,
                                               dataGridView_nhanvien.CurrentRow.Cells[5].Value.ToString(),
                                               dataGridView_nhanvien.CurrentRow.Cells[6].Value.ToString());
            a.Show(this);
        }
        private void dataGridView_doan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddDoAn a = new AddDoAn(2, dataGridView_doan.CurrentRow.Cells[0].Value.ToString(),
                                       dataGridView_doan.CurrentRow.Cells[1].Value.ToString(),
                                       Convert.ToInt32(dataGridView_doan.CurrentRow.Cells[2].Value));
            a.Show(this);
        }
        private void dataGridView_phongban_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddPhongBan a = new AddPhongBan(2, dataGridView_phongban.CurrentRow.Cells[0].Value.ToString(),
                                              dataGridView_phongban.CurrentRow.Cells[1].Value.ToString());
            a.Show(this);
        }
        private void dataGridView_ve_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddVe a = new AddVe(2, dataGridView_ve.CurrentRow.Cells[0].Value.ToString(),
                                  dataGridView_ve.CurrentRow.Cells[1].Value.ToString(),
                                  dataGridView_ve.CurrentRow.Cells[2].Value.ToString(),
                                  dataGridView_ve.CurrentRow.Cells[3].Value.ToString(),
                                  dataGridView_ve.CurrentRow.Cells[4].Value.ToString(),
                                  dataGridView_ve.CurrentRow.Cells[5].Value.ToString(),
                                  (DateTime)dataGridView_ve.CurrentRow.Cells[6].Value,
                                  Convert.ToInt32(dataGridView_ve.CurrentRow.Cells[7
                                  ].Value));
            a.Show(this);
        }



        private void button_add_phim_Click(object sender, EventArgs e)
        {
            AddPhim a = new AddPhim(1, "", "", 0);
            a.Show(this);
        }

        private void button_add_phongchieu_Click(object sender, EventArgs e)
        {
            AddPhongChieu a = new AddPhongChieu(1, "", 0, true);
            a.Show(this);
        }

        private void button_add_khachhang_Click(object sender, EventArgs e)
        {
            AddKhachHang a = new AddKhachHang(1, "", "", true, DateTime.Now, true, 0);
            a.Show(this);
        }

        private void button_add_nhanvien_Click(object sender, EventArgs e)
        {
            AddNhanVien a = new AddNhanVien(1, "", "", "", true, DateTime.Now, "", "");
            a.Show(this);
        }

        private void button_add_doan_Click(object sender, EventArgs e)
        {
            AddDoAn a = new AddDoAn(1, "", "", 0);
            a.Show(this);
        }

        private void button_add_ve_Click(object sender, EventArgs e)
        {
            AddVe a = new AddVe(1, "", "", "", "", "", "", DateTime.Now, 0);
            a.Show(this);
        }

        private void btn_add_lichchieu_Click(object sender, EventArgs e)
        {
            AddLichChieu a = new AddLichChieu(1, "", "", "", DateTime.Now, 0);
            a.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPhongBan a = new AddPhongBan(1, "", "");
            a.Show(this);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort; 
        }

        private void btn_refresh_phongban_Click(object sender, EventArgs e)
        {
            this.pHONGBANTableAdapter.Fill(this.doAnRapChieuPhim03DataSet13.PHONGBAN);
        }

        private void button_refresh_doan_Click(object sender, EventArgs e)
        {
            this.dOANTableAdapter.Fill(this.doAnRapChieuPhim03DataSet9.DOAN);
        }

        private void button_refresh_phim_Click(object sender, EventArgs e)
        {
            this.pHIMTableAdapter.Fill(this.doAnRapChieuPhim03DataSet5.PHIM);
        }

        private void button_refresh_phongchieu_Click(object sender, EventArgs e)
        {
            this.pHONGCHIEUTableAdapter.Fill(this.doAnRapChieuPhim03DataSet6.PHONGCHIEU);
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet13.PHONGBAN' table. You can move, or remove it, as needed.
            this.pHONGBANTableAdapter.Fill(this.doAnRapChieuPhim03DataSet13.PHONGBAN);
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet12.LICHCHIEU' table. You can move, or remove it, as needed.
            this.lICHCHIEUTableAdapter1.Fill(this.doAnRapChieuPhim03DataSet12.LICHCHIEU);
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet11.LICHCHIEU' table. You can move, or remove it, as needed.
            this.lICHCHIEUTableAdapter.Fill(this.doAnRapChieuPhim03DataSet11.LICHCHIEU);
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet10.VE' table. You can move, or remove it, as needed.
            this.vETableAdapter.Fill(this.doAnRapChieuPhim03DataSet10.VE);
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet9.DOAN' table. You can move, or remove it, as needed.
            this.dOANTableAdapter.Fill(this.doAnRapChieuPhim03DataSet9.DOAN);
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet8.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.doAnRapChieuPhim03DataSet8.NHANVIEN);
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet7.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.doAnRapChieuPhim03DataSet7.KHACHHANG);
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet6.PHONGCHIEU' table. You can move, or remove it, as needed.
            this.pHONGCHIEUTableAdapter.Fill(this.doAnRapChieuPhim03DataSet6.PHONGCHIEU);
            // TODO: This line of code loads data into the 'doAnRapChieuPhim03DataSet5.PHIM' table. You can move, or remove it, as needed.
            this.pHIMTableAdapter.Fill(this.doAnRapChieuPhim03DataSet5.PHIM);
        }

        private void button_refresh_nhanvien_Click(object sender, EventArgs e)
        {
            this.nHANVIENTableAdapter.Fill(this.doAnRapChieuPhim03DataSet8.NHANVIEN);
        }

        private void button_refresh_khachhang_Click(object sender, EventArgs e)
        {
            this.kHACHHANGTableAdapter.Fill(this.doAnRapChieuPhim03DataSet7.KHACHHANG);
        }

        private void btn_refresh_lichchieu_Click(object sender, EventArgs e)
        {
            this.lICHCHIEUTableAdapter.Fill(this.doAnRapChieuPhim03DataSet11.LICHCHIEU);
        }

        private void trackBar_thoiluongmin_ValueChanged(object sender, EventArgs e)
        {
            lb_min.Text = trackBar_thoiluongmin.Value.ToString();
            if(trackBar_thoiluongmin.Value > trackBar_thoiluongmax.Value)
            {
                trackBar_thoiluongmax.Value = trackBar_thoiluongmin.Value;
            }
            dataGridView_phim.DataSource =  ph.FindWithThoiLuong(trackBar_thoiluongmax.Value, trackBar_thoiluongmin.Value);
        }

        private void trackBar_thoiluongmax_ValueChanged(object sender, EventArgs e)
        {
            lb_max.Text = trackBar_thoiluongmax.Value.ToString();
            if(trackBar_thoiluongmax.Value < trackBar_thoiluongmin.Value)
            {
                trackBar_thoiluongmin.Value = trackBar_thoiluongmax.Value;
            }
            dataGridView_phim.DataSource = ph.FindWithThoiLuong(trackBar_thoiluongmax.Value, trackBar_thoiluongmin.Value);
        }

        private void cbx_thoiluong_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_thoiluong.Checked)
            {
                trackBar_thoiluongmax.Enabled = true;
                trackBar_thoiluongmin.Enabled = true;
                dataGridView_phim.DataSource = ph.FindWithThoiLuong(trackBar_thoiluongmax.Value, trackBar_thoiluongmin.Value);
            }
            else
            {
                trackBar_thoiluongmax.Enabled = false;
                trackBar_thoiluongmin.Enabled = false;
                dataGridView_phim.DataSource = doAnRapChieuPhim03DataSet5.PHIM;
            }
        }

        private void tbx_find_tenphim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbx_find_tenphim.Text.Trim() != "")
            {
                dataGridView_phim.DataSource = ph.FindWithTenPhim(tbx_find_tenphim.Text);
            }
            else
            {
                dataGridView_phim.DataSource = doAnRapChieuPhim03DataSet5.PHIM;
            }
        }

        private void trackBar_diemmax_ValueChanged(object sender, EventArgs e)
        {
            if(trackBar_diemmax.Value < trackBar_diemmin.Value)
            {
                trackBar_diemmin.Value = trackBar_diemmax.Value;
            }
            lb_diem_max.Text = trackBar_diemmax.Value.ToString();
            dataGridView_khachhang.DataSource = kh.findWithDiem(trackBar_diemmax.Value, trackBar_diemmin.Value);
        }

        private void trackBar_diemmin_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar_diemmin.Value > trackBar_diemmax.Value)
            {
                trackBar_diemmax.Value = trackBar_diemmin.Value;
            }
            lb_diem_min.Text = trackBar_diemmin.Value.ToString();
            dataGridView_khachhang.DataSource = kh.findWithDiem(trackBar_diemmax.Value, trackBar_diemmin.Value);
        }

        private void chbx_diem_kh_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView_khachhang.DataSource = doAnRapChieuPhim03DataSet7.KHACHHANG;
            if (chbx_diem_kh.Checked)
            {
                trackBar_diemmax.Enabled = true;
                trackBar_diemmin.Enabled = true;
            }
            else
            {
                trackBar_diemmax.Enabled = false;
                trackBar_diemmin.Enabled = false;
            }
        }

        private void tbx_findwithname_khachhang_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if(tbx_findwithname_khachhang.Text.Trim() != "")
            {
                dataGridView_khachhang.DataSource =  kh.GetKHWithName(tbx_findwithname_khachhang.Text);
            }
            else
            {
                dataGridView_khachhang.DataSource = doAnRapChieuPhim03DataSet7.KHACHHANG;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            this.gHETableAdapter.Fill(this.doAnRapChieuPhim03DataSet18.GHE);
            dataGridView1.DataSource = doAnRapChieuPhim03DataSet18.GHE;
        }

        private void button_refresh_ve_Click(object sender, EventArgs e)
        {
            this.vETableAdapter.Fill(this.doAnRapChieuPhim03DataSet10.VE);
            dataGridView_ve.DataSource = doAnRapChieuPhim03DataSet10.VE;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue != null)
            {
                nv.timkiemnhanvien_TenPhongBang(comboBox1.SelectedValue.ToString().Trim());
            }
        }

        private void tbx_findwithname_nhanvien_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
