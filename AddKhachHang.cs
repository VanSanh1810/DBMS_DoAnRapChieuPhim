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
    public partial class AddKhachHang : Form
    {
        int state;
        string makh, tenkh;
        bool giotinh;
        DateTime namsinh;
        bool loaikh;
        int diem;
        public AddKhachHang(int state, string makh, string tenkh, bool giotinh, DateTime namsinh, bool loai, int diem)
        {
            InitializeComponent();
            this.state = state;
            this.makh = makh;
            this.tenkh = tenkh;
            this.giotinh = giotinh;
            this.namsinh = namsinh;
            this.loaikh = loai;
            this.diem = diem;
        }

        private void AddKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
