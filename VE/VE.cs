using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnRapChieuPhim
{
    class VE
    {
        DB db = new DB();
        public void AddVE(string mave, string manv, string makh, string malc, string madoan, string maghe, DateTime ngaydatve, int giave)
        {
            SqlCommand command = new SqlCommand("exec ve_insert @mave, @manv, @makh, @malc, @madoan, @maghe, @ngaydat, @gia ", db.getConnection);
            command.Parameters.Add("@malc", SqlDbType.Char).Value = malc;
            command.Parameters.Add("@mave", SqlDbType.Char).Value = mave;
            command.Parameters.Add("@makh", SqlDbType.Char).Value = makh;
            command.Parameters.Add("@manv", SqlDbType.Char).Value = manv;
            command.Parameters.Add("@madoan", SqlDbType.Char).Value = madoan;
            command.Parameters.Add("@maghe", SqlDbType.Char).Value = maghe;
            command.Parameters.Add("@ngaydat", SqlDbType.DateTime).Value = ngaydatve;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = giave;
            db.openConnection();
            command.ExecuteNonQuery();
        }

        public void UpdateVE(string mave, string manv, string makh, string malc, string madoan, string maghe, DateTime ngaydatve, int giave)
        {
            SqlCommand command = new SqlCommand("exec ve_update @mave, @manv, @makh, @malc, @madoan, @maghe, @ngaydat, @gia ", db.getConnection);
            command.Parameters.Add("@malc", SqlDbType.Char).Value = malc;
            command.Parameters.Add("@mave", SqlDbType.Char).Value = mave;
            command.Parameters.Add("@makh", SqlDbType.Char).Value = makh;
            command.Parameters.Add("@manv", SqlDbType.Char).Value = manv;
            command.Parameters.Add("@madoan", SqlDbType.Char).Value = madoan;
            command.Parameters.Add("@maghe", SqlDbType.Char).Value = maghe;
            command.Parameters.Add("@ngaydat", SqlDbType.DateTime).Value = ngaydatve;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = giave;
            db.openConnection();
            command.ExecuteNonQuery();
        }

        public void DelVE(string mave)
        {
            SqlCommand command = new SqlCommand("exec ve_del @mave, @manv, @makh, @malc, @madoan, @maghe, @ngaydat, @gia ", db.getConnection);
            command.Parameters.Add("@mave", SqlDbType.Char).Value = mave;
            db.openConnection();
            command.ExecuteNonQuery();
        }

        public DataTable FindWithMaVe(string mave)
        {
            SqlCommand command = new SqlCommand("findWithMaVe(@MaVe)", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
