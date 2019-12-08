using DoAn1_QuanLy_BaoKhoaHoc.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1_QuanLy_BaoKhoaHoc.BS
{
    class QuanHeTGNhom
    {
        DBMain db = null;
        public QuanHeTGNhom()
        {

            db = new DBMain();
        }
        public DataSet LayQH()
        {
            return db.ExecuteQueryDataSet("select TacGia,Nhom from QuanHeTGNhom,TacGia,NhomTacGia Where  NhomTacGia.MaNhom=QuanHeTGNhom.Nhom AND TacGia.MaTacGia=QuanHeTGNhom.TacGia", CommandType.Text);
        }
 
        public bool ThemQH(string MaNhom, string MaTacGia, ref string error)
        {
            string sqlString = "Insert Into QHTGNhom Values('" + MaNhom + "',N'" + MaTacGia + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        public bool CapNhatNhom(string MaNhom, string MaTacGia, ref string error)
        {
            string sqlString =
               "Update NhomTacGia Set MaNhom=N'" + MaNhom + "', Nhom=N'" + MaNhom + "' where Nhom='" + MaNhom + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        public bool XoaQh(string MaNhom, ref string error)
        {
            string sqlString = "Delete From QuanHeTGNhom Where Nhom='" + MaNhom + "'AND NhomTacGia.MaNhom=QuanHeTGNhom.Nhom AND TacGia.MaTacGia=QuanHeTGNhom.TacGia";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
    }
}
