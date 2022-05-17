using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnRapChieuPhim
{
    class DOAN
    {
        DB db = new DB();
        public void AddDoAn(string mada, string tenmon, int gia)
        {
            SqlCommand command = new SqlCommand("exec doan_insert @mada, @tenmon, @gia", db.getConnection);
            command.Parameters.Add("@mada", SqlDbType.Char).Value = mada;
            command.Parameters.Add("@tenmon", SqlDbType.Char).Value = tenmon;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = gia;
            db.openConnection();
            command.ExecuteNonQuery();
        }

        public void UpdateDoAn(string mada, string tenmon, int gia)
        {
            SqlCommand command = new SqlCommand("exec doan_update @mada, @tenmon, @gia", db.getConnection);
            command.Parameters.Add("@mada", SqlDbType.Char).Value = mada;
            command.Parameters.Add("@tenmon", SqlDbType.Char).Value = tenmon;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = gia;
            db.openConnection();
            command.ExecuteNonQuery();
        }
        public void DelDoAn(string mada)
        {
            SqlCommand command = new SqlCommand("exec doan_del @mada", db.getConnection);
            command.Parameters.Add("@mada", SqlDbType.Char).Value = mada;
            db.openConnection();
            command.ExecuteNonQuery();
        }
    }
}
