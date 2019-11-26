using DoAn1_QuanLy_BaoKhoaHoc.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1_QuanLy_BaoKhoaHoc.BS
{
    class WebDangTai
    {

        DBMain db = null;
        public WebDangTai()
        {

            db = new DBMain();
        }
        public DataSet LayWeb()
        {
            return db.ExecuteQueryDataSet("select * from Noi", CommandType.Text);
        }

        public bool ThemWeb(string Ma_Website, string NoiDangTai, string SoTrang, string TG_DangTai,string website,string idQuanLy, ref string error)
        {
            string sqlString = "Insert Into NoiDungChinh Values('" + Ma_Website + "',N'" + NoiDangTai + "','" +SoTrang + "',N'" + TG_DangTai + "',N'" + website + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        public bool CapNhatWeb(string Ma_Website, string NoiDangTai, string SoTrang, string TG_DangTai, string website, string idQuanLy, ref string error)
        {
            string sqlString =
               "Update WebDangTai Set Ma_Website=N'" + Ma_Website + "', NoiDangTai='" + NoiDangTai + "',SoTrang=N'" + SoTrang + "' ,TG_DangTai=N'" + TG_DangTai + "',website=N'"+website+ "',";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
        public bool KiemTraTonTai(string Ma_Website, ref string error)
        {
            string sqlString = "Select Count(*) From NoiDungChinh Where MaTieuDe=N'" + Ma_Website.Trim() + "'";
            return db.Check(sqlString, CommandType.Text, ref error);
        }
    }
}

