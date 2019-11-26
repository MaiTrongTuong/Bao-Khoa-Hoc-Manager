using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DoAn1_QuanLy_BaoKhoaHoc.DB;

namespace DoAn1_QuanLy_BaoKhoaHoc.BS
{
    class DangNhap
    {
        DBMain db = null;
        public DangNhap()
        {
            db = new DBMain();
        }
        public bool KtraTaiKhoan(string TenBang ,string TenDangNhap, string MatKhau, ref string err)
        {
            string id = "";
            if(TenBang=="QuanLy")
            {
                id = "idQuanLy";
            }
            else if(TenBang=="TacGia")
            {
                id = "MaTacGia";
            }
            string sqlkt = "select * from "+TenBang+" where "+id +"=" +"N'" + TenDangNhap + "' and MatKhau=N'" + MatKhau + "'";
            return db.CheckLogin(sqlkt, System.Data.CommandType.Text, ref err);
        }
    }
}
