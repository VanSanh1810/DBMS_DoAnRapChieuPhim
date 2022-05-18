using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnRapChieuPhim
{
    class PHONGCHIEU
    {
        DB db = new DB();
        public void AddPhongChieu(string mapc, int succhua, bool trangthai)
        {
            SqlCommand command = new SqlCommand("exec phongchieu_insert @mapc, @succhua, @trangthai", db.getConnection);
            command.Parameters.Add("@mapc", SqlDbType.Char).Value = mapc;
            command.Parameters.Add("@succhua", SqlDbType.Int).Value = succhua;
            command.Parameters.Add("@trangthai", SqlDbType.Bit).Value = trangthai;
            db.openConnection();
            command.ExecuteNonQuery();
        }
        public void UpdatePhongChieu(string mapc, int succhua, bool trangthai)
        {
            SqlCommand command = new SqlCommand("exec phongchieu_update @mapc, @succhua, @trangthai", db.getConnection);
            command.Parameters.Add("@mapc", SqlDbType.Char).Value = mapc;
            command.Parameters.Add("@succhua", SqlDbType.Int).Value = succhua;
            command.Parameters.Add("@trangthai", SqlDbType.Bit).Value = trangthai;
            db.openConnection();
            command.ExecuteNonQuery();
        }
        public void DelPhongChieu(string mapc)
        {
            SqlCommand command = new SqlCommand("exec phongchieu_delete @mapc", db.getConnection);
            command.Parameters.Add("@mapc", SqlDbType.Char).Value = mapc;
            db.openConnection();
            command.ExecuteNonQuery();
        }

        public DataTable GetGheTrong(string mapc)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM GetGheTrong(@MaPC)", db.getConnection);
            command.Parameters.Add("@MaPC", SqlDbType.Char).Value = mapc;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
