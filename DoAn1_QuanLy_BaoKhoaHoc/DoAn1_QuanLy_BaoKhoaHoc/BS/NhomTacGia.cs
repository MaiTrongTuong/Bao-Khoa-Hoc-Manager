using DoAn1_QuanLy_BaoKhoaHoc.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1_QuanLy_BaoKhoaHoc.BS
{
    class NhomTacGia
    {

        DBMain db = null;
        public NhomTacGia()
        {

            db = new DBMain();
        }
        public DataSet LayNhom()
        {
            return db.ExecuteQueryDataSet("select * from NhomTacGia", CommandType.Text);
        }

        public bool ThemNhom(string MaNhom, string TenNhom,ref string error)
        {
            string sqlString = "Insert Into NhomTacGia Values('" + MaNhom + "',N'" + TenNhom + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        public bool CapNhatNhom(string MaNhom, string TenNhom,ref string error)
        {
            string sqlString =
               "Update TacGia Set MaNhom=N'" + MaNhom + "', TenNhom=N'" + TenNhom + "',";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        public bool XoaTacGia(string MaNhom, ref string error)
        {
            string sqlString = "Delete From NhomTacGia Where MaNhom='" + MaNhom + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        public bool KiemTraTonTai(string MaNhom, ref string error)
        {
            string sqlString = "Select Count(*) From NhomTacGia Where MaNhom=N'" + MaNhom.Trim() + "'";
            return db.Check(sqlString, CommandType.Text, ref error);
        }
    }
}

