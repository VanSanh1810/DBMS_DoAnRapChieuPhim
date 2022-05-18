using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnRapChieuPhim
{
    class LICHCHIEU
    {
        DB db = new DB();
        public void AddLichChieu(string malc, string mapc, string maphim, DateTime ngaychieu, int sotien)
        {
            SqlCommand command = new SqlCommand("exec lichchieu_insert @MaLC ,@MaPC ,@MaPhim ,@NgayChieu ,@SoTien ", db.getConnection);
            command.Parameters.Add("@MaLC", SqlDbType.Char).Value = malc;
            command.Parameters.Add("@MaPC", SqlDbType.Char).Value = mapc;
            command.Parameters.Add("@MaPhim", SqlDbType.Char).Value = maphim;
            command.Parameters.Add("@NgayChieu", SqlDbType.DateTime).Value = ngaychieu;
            command.Parameters.Add("@SoTien", SqlDbType.Int).Value = sotien;
            db.openConnection();
            command.ExecuteNonQuery();
        }

        public void UpdateLichChieu(string malc, string mapc, string maphim, DateTime ngaychieu, int sotien)
        {
            SqlCommand command = new SqlCommand("exec lichchieu_update @MaLC ,@MaPC ,@MaPhim ,@NgayChieu ,@SoTien ", db.getConnection);
            command.Parameters.Add("@MaLC", SqlDbType.Char).Value = malc;
            command.Parameters.Add("@MaPC", SqlDbType.Char).Value = mapc;
            command.Parameters.Add("@MaPhim", SqlDbType.Char).Value = maphim;
            command.Parameters.Add("@NgayChieu", SqlDbType.DateTime).Value = ngaychieu;
            command.Parameters.Add("@SoTien", SqlDbType.Int).Value = sotien;
            db.openConnection();
            command.ExecuteNonQuery();
        }

        public void DelLichChieu(string malc)
        {
            SqlCommand command = new SqlCommand("exec lichchieu_del @MaLC", db.getConnection);
            command.Parameters.Add("@MaLC", SqlDbType.Char).Value = malc;
            db.openConnection();
            command.ExecuteNonQuery();
        }

        public DataTable FindWithMaPhim(string maphim)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM findWithMaPhim_LICHCHIEU(@MaPhim)", db.getConnection);
            command.Parameters.Add("@MaPhim", SqlDbType.Char).Value = maphim;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable FindWithMaLC(string malc)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM findWithMaLC_LICHCHIEU(@MaLC)", db.getConnection);
            command.Parameters.Add("@MaLC", SqlDbType.Char).Value = malc;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
