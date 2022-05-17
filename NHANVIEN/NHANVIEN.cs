using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnRapChieuPhim
{
    class NHANVIEN
    {
        DB db = new DB();
        public void AddNhanVien(string manv, string tennv, string mapb, bool gioitinh, DateTime namsinh, string diachi, string sdt)
        {
            SqlCommand command = new SqlCommand("exec nhanvien_insert @MaNV ,@TenNV ,@MaPB , @GioiTinh, @NamSinh, @DiaChi, @SDT", db.getConnection);
            command.Parameters.Add("@Manv", SqlDbType.Char).Value = manv;
            command.Parameters.Add("@Tennv", SqlDbType.Char).Value = tennv;
            command.Parameters.Add("@MaPB", SqlDbType.Char).Value = mapb;
            command.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = gioitinh;
            command.Parameters.Add("@NamSinh", SqlDbType.DateTime).Value = namsinh;
            command.Parameters.Add("@DiaChi", SqlDbType.Char).Value = diachi;
            command.Parameters.Add("@SDT", SqlDbType.Char).Value = sdt;
            db.openConnection();
            command.ExecuteNonQuery();
        }

        public void UpdateNhanVien(string manv, string tennv, string mapb, bool gioitinh, DateTime namsinh, string diachi, string sdt)
        {
            SqlCommand command = new SqlCommand("exec nhanvien_updates @MaNV ,@TenNV ,@MaPB , @GioiTinh, @NamSinh, @DiaChi, @SDT", db.getConnection);
            command.Parameters.Add("@Manv", SqlDbType.Char).Value = manv;
            command.Parameters.Add("@Tennv", SqlDbType.Char).Value = tennv;
            command.Parameters.Add("@MaPB", SqlDbType.Char).Value = mapb;
            command.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = gioitinh;
            command.Parameters.Add("@NamSinh", SqlDbType.DateTime).Value = namsinh;
            command.Parameters.Add("@DiaChi", SqlDbType.Char).Value = diachi;
            command.Parameters.Add("@SDT", SqlDbType.Char).Value = sdt;
            db.openConnection();
            command.ExecuteNonQuery();
        }

        public void DelNhanVien(string manv)
        {
            SqlCommand command = new SqlCommand("exec nhanvien_delete @MaNV ", db.getConnection);
            command.Parameters.Add("@Manv", SqlDbType.Char).Value = manv;
            db.openConnection();
            command.ExecuteNonQuery();
        }
    }
}
