using DoAn1_QuanLy_BaoKhoaHoc.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1_QuanLy_BaoKhoaHoc.BS
{
    class QuanHeWeb_QL
    {
        DBMain db = null;
        public QuanHeWeb_QL()
        {

            db = new DBMain();
        }
        public DataSet LayQH()
        {
            return db.ExecuteQueryDataSet("select QuanLy,Mawebsite from QuanHeWeb_QL,QuanLy,WebDangTai Where  QuanHeWeb_QL.QuanLy=QuanLy.idQuanLy AND QuanHeWeb_QL.Mawebsite=WebDangTai.Ma_website", CommandType.Text);
        }

        public bool ThemQH(string QuanLy, string Mawebsite, ref string error)
        {
            string sqlString = "Insert Into QHTGNhom Values('" + QuanLy + "',N'" + Mawebsite + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        public bool CapNhatNhom(string QuanLy, string Mawebsite, ref string error)
        {
            string sqlString =
               "Update QHTGNhom Set QuanLy=N'" + QuanLy + "', Mawebsite=N'" + Mawebsite + "' where QuanLy='" + QuanLy + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
        public bool XoaQh(string MaNhom, ref string error)
        {
            string sqlString = "Delete From QuanHeTGNhom Where Nhom='" + MaNhom + "'AND NhomTacGia.MaNhom=QuanHeTGNhom.Nhom AND TacGia.MaTacGia=QuanHeTGNhom.TacGia";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
    }
}
