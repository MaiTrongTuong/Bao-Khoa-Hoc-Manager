using DoAn1_QuanLy_BaoKhoaHoc.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1_QuanLy_BaoKhoaHoc.BS
{
    class QuanLy
    {
        DBMain db = null;
        public QuanLy()
        {

            db = new DBMain();
        }
        public DataSet LayQuanLy()
        {
            return db.ExecuteQueryDataSet("select * from QuanLy where idQuanLy = '" + FormDangNhap.DR["idQuanLy"].ToString()+ "'", CommandType.Text);
        }
        public bool DoiMatKhau(string MatKhau,ref string error)
        {
            string sqlString =
               "Update QuanLy Set MatKhau=N'" + MatKhau + "' where idQuanLy='" + FormDangNhap.DR["idQuanLy"].ToString() + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
    
    }
}
