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
            return db.ExecuteQueryDataSet("select * from WebDangTai", CommandType.Text);
        }

        public bool ThemWeb(string Ma_Website, string NoiDangTai, string SoTrang, string TG_DangTai,string website,string idQuanLy, ref string error)
        {
            string sqlString = "Insert Into WebDangTai Values('" + Ma_Website + "',N'" + NoiDangTai + "','" +SoTrang + "',N'" + TG_DangTai + "',N'" + website + "',N'"+idQuanLy+"')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        public bool CapNhatWeb(string Ma_Website, string NoiDangTai, string SoTrang, string TG_DangTai, string website, string idQuanLy, ref string error)
        {
            string sqlString =
               "Update WebDangTai Set Ma_Website=N'" + Ma_Website + "', NoiDangTai=N'" + NoiDangTai + "',SoTrang=N'" + SoTrang + "' ,TG_DangTai=N'" + TG_DangTai + "',website=N'"+website+ "',N'" + idQuanLy + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
        public DataSet timKiemweb(string search)
        {
            return db.ExecuteQueryDataSet("select*from WebDangTai" + " where Ma_Website like  '%" + search + "%'" + " OR TG_DangTai like  '%" + search + "%' OR website like  '%" + search + "%'", CommandType.Text);
        }
    }
}

