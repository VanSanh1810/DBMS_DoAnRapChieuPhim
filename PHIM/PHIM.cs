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
    }
}
