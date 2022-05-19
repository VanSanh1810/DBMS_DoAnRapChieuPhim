using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnRapChieuPhim
{
    class KHACHHANG
    {
        DB db = new DB();
        public void AddKhachHang(string makh, string tenkh, bool gioitinh, DateTime namsinh, bool VIP, int diem)
        {
            SqlCommand command = new SqlCommand("exec khachhang_insert @makh ,@tenkh ,@gioitinh, @NamSinh, @VIP, @diem", db.getConnection);
            command.Parameters.Add("@makh", SqlDbType.Char).Value = makh;
            command.Parameters.Add("@tenkh", SqlDbType.Char).Value = tenkh;
            command.Parameters.Add("@gioitinh", SqlDbType.Bit).Value = gioitinh;
            command.Parameters.Add("@NamSinh", SqlDbType.DateTime).Value = namsinh;
            command.Parameters.Add("@VIP", SqlDbType.Bit).Value = VIP;
            command.Parameters.Add("@diem", SqlDbType.Int).Value = diem;
            db.openConnection();
            command.ExecuteNonQuery();
        }

        public void UpdateKhachHang(string makh, string tenkh, bool gioitinh, DateTime namsinh, bool VIP, int diem)
        {
            SqlCommand command = new SqlCommand("exec khachhang_update @makh ,@tenkh ,@gioitinh, @NamSinh, @VIP, @diem", db.getConnection);
            command.Parameters.Add("@makh", SqlDbType.Char).Value = makh;
            command.Parameters.Add("@tenkh", SqlDbType.Char).Value = tenkh;
            command.Parameters.Add("@gioitinh", SqlDbType.Bit).Value = gioitinh;
            command.Parameters.Add("@NamSinh", SqlDbType.DateTime).Value = namsinh;
            command.Parameters.Add("@VIP", SqlDbType.Bit).Value = VIP;
            command.Parameters.Add("@diem", SqlDbType.Int).Value = diem;
            db.openConnection();
            command.ExecuteNonQuery();
        }
        public void DelKhachHang(string makh)
        {
            SqlCommand command = new SqlCommand("exec khachhang_del @makh", db.getConnection);
            command.Parameters.Add("@makh", SqlDbType.Char).Value = makh;
            db.openConnection();
            command.ExecuteNonQuery();
        }

        public DataTable GetKHWithMa(string makh)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM findMKH(@MaKH)", db.getConnection);
            command.Parameters.Add("@MaKH", SqlDbType.Char).Value = makh;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable GetKHWithName(string tenkh)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM findTKH(@MaKH)", db.getConnection);
            command.Parameters.Add("@MaKH", SqlDbType.Char).Value = tenkh;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable findWithDiem(int max, int min)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM findWithDiem(@max, @min)", db.getConnection);
            command.Parameters.Add("@max", SqlDbType.Char).Value = max;
            command.Parameters.Add("@min", SqlDbType.Char).Value = min;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
