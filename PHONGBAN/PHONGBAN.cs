using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnRapChieuPhim
{
    class PHONGBAN
    {
        DB db = new DB();
        public void AddPB(string mapb, string tenpb)
        {
            SqlCommand command = new SqlCommand("exec phongban_insert @mapb, @tenpb", db.getConnection);
            command.Parameters.Add("@mapb", SqlDbType.Char).Value = mapb;
            command.Parameters.Add("@tenpb", SqlDbType.Char).Value = tenpb;
            db.openConnection();
            command.ExecuteNonQuery();
        }

        public void UpdatePB(string mapb, string tenpb)
        {
            SqlCommand command = new SqlCommand("exec phongban_updates @mapb, @tenpb", db.getConnection);
            command.Parameters.Add("@mapb", SqlDbType.Char).Value = mapb;
            command.Parameters.Add("@tenpb", SqlDbType.Char).Value = tenpb;
            db.openConnection();
            command.ExecuteNonQuery();
        }

        public void DelPB(string mapb)
        {
            SqlCommand command = new SqlCommand("exec phongban_delete @mapb", db.getConnection);
            command.Parameters.Add("@mapb", SqlDbType.Char).Value = mapb;
            db.openConnection();
            command.ExecuteNonQuery();
        }

        
    }
}
