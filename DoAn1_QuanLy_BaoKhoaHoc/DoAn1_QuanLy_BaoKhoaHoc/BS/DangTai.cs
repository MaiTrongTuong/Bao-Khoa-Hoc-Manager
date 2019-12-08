using DoAn1_QuanLy_BaoKhoaHoc.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1_QuanLy_BaoKhoaHoc.BS
{
    class DangTai
    {
        DBMain db = null;
        public DangTai()
        {

            db = new DBMain();
        }
        public DataSet LayDT()
        {
            return db.ExecuteQueryDataSet("select Nhom,Mawebsite from DangTai,NhomTacGia,WebDangTai Where  DangTai.Nhom=NhomTacGia.MaNhom AND DangTai.Mawebsite=WebDangTai.Ma_website", CommandType.Text);
        }

        public bool ThemQH(string Nhom, string Mawebsite, ref string error)
        {
            string sqlString = "Insert Into DangTai Values('" + Nhom + "',N'" + Mawebsite + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        public bool CapNhatNhom(string Nhom, string Mawebsite, ref string error)
        {
            string sqlString =
               "Update DangTai Set MaNhom=N'" + Nhom + "', Mawebsite=N'" + Mawebsite + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
        public bool XoaQh(string MaNhom, ref string error)
        {
            string sqlString = "Delete From DangTai Where Nhom='" + MaNhom;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
    }
}
