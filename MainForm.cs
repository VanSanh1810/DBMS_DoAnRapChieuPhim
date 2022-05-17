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
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
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
                                  Convert.ToInt32(dataGridView_ve.CurrentRow.Cells[0].Value));
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
    }
}
