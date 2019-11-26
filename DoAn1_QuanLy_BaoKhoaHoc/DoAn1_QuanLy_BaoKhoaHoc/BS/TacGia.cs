using DoAn1_QuanLy_BaoKhoaHoc.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1_QuanLy_BaoKhoaHoc.BS
{
    class TacGia
    {
      
            DBMain db = null;
            public TacGia()
            {

                db = new DBMain();
            }
            public DataSet LayTacGia()
            {
                return db.ExecuteQueryDataSet("select * from TacGia", CommandType.Text);
            }

            public bool ThemTacGia(string MaTacGia, string HoTen, string MatKhau, string QuocGia,int SDT,ref string error)
            {
                string sqlString = "Insert Into TacGia Values('" + MaTacGia + "',N'" + HoTen + "','" + MatKhau + "',N'" + SDT +"')";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
            }

            public bool CapNhatTacGia(string MaTacGia, string HoTen, string MatKhau, string QuocGia, int SDT, ref string error)
            {
                string sqlString =
                   "Update TacGia Set MaTacGia=N'" + MaTacGia + "', HoTen='" + HoTen + "',MatKhau=N'" + MatKhau + "' ,QuocGia=N'" + QuocGia + "'," +
                   "SDT'" + SDT + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
            }

            public bool XoaTacGia(string MaTacGia, ref string error)
            {
                string sqlString = "Delete From TacGia Where MaTacGia='" + MaTacGia + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
            }

            public bool KiemTraTonTai(string MaTacGia, ref string error)
            {
                string sqlString = "Select Count(*) From TacGia Where MaNV=N'" + MaTacGia.Trim() + "'";
                return db.Check(sqlString, CommandType.Text, ref error);
            }
        
    }
}
