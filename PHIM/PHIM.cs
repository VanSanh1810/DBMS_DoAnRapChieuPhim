using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnRapChieuPhim
{
    class PHIM
    {
        DB db = new DB();
        public void AddPhim(string maphim, string tenphim, int thoiluong)
        {
            SqlCommand command = new SqlCommand("exec phim_insert @maphim, @tenphim, @thoiluong", db.getConnection);
            command.Parameters.Add("@maphim", SqlDbType.Char).Value = maphim;
            command.Parameters.Add("@tenphim", SqlDbType.Char).Value = tenphim;
            command.Parameters.Add("@thoiluong", SqlDbType.Int).Value = thoiluong;
            db.openConnection();
            command.ExecuteNonQuery();
        }

        public void DelPhim(string maphim)
        {
            SqlCommand command = new SqlCommand("exec phim_delete @maphim", db.getConnection);
            command.Parameters.Add("@maphim", SqlDbType.Char).Value = maphim;
            db.openConnection();
            command.ExecuteNonQuery();
        }

        public void UpdatePhim(string maphim, string tenphim, int thoiluong)
        {
            SqlCommand command = new SqlCommand("exec phim_update @maphim, @tenphim, @thoiluong", db.getConnection);
            command.Parameters.Add("@maphim", SqlDbType.Char).Value = maphim;
            command.Parameters.Add("@tenphim", SqlDbType.Char).Value = tenphim;
            command.Parameters.Add("@thoiluong", SqlDbType.Int).Value = thoiluong;
            db.openConnection();
            command.ExecuteNonQuery();
        }

        public DataTable FindWithMaPhim(string maphim)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM FindWithMaPhim(@MaPhim)", db.getConnection);
            command.Parameters.Add("@MaPhim", SqlDbType.Char).Value = maphim;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable FindWithTenPhim(string maten)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM FindWithTenPhim(@TenPhim)", db.getConnection);
            command.Parameters.Add("@TenPhim", SqlDbType.Char).Value = maten;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable FindWithThoiLuong(int max, int min)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM FindWithThoiLuong(@max, @min)", db.getConnection);
            command.Parameters.Add("@max", SqlDbType.Int).Value = max;
            command.Parameters.Add("@min", SqlDbType.Int).Value = min;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
