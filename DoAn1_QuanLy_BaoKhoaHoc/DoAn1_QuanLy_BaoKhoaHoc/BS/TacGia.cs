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
            public DataSet timKiemTacGia(string search)
            {
            return db.ExecuteQueryDataSet("select MaTacGia,HoVaTen,QuocGia,SDT " +
                    "from TacGia" + " where (MaTacGia like  '%" + search + "%'" + " OR HoVaTen like  '%" + search + "%' OR QuocGia like  '%" + search + "%')", CommandType.Text);
            }
             public DataSet LayTacGia()
            {
                return db.ExecuteQueryDataSet("select * from TacGia", CommandType.Text);
            }

            public bool CapNhatTacGia(string MaTacGia, string HoTen, string QuocGia, string SDT, ref string error)
            {
                string sqlString =
                   "Update TacGia Set MaTacGia=N'" + MaTacGia + "', HoTen='" + HoTen + "' ,QuocGia=N'" + QuocGia + "'," +
                   "SDT'" + SDT + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
            }
             public bool SuaTacGia(string MaTacGia, string HoTen, string QuocGia, string SDT, ref string error)
            {
            string sqlString = "UPDATE TacGia SET HoTen='"+HoTen+"',QuocGia='"+QuocGia+"',SDT='"+SDT+"' where MaTacGia='" + MaTacGia + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
            }
           public bool XoaTacGia(string MaTacGia, ref string error)
            {
                string sqlString = "Delete From TacGia Where MaTacGia='" + MaTacGia + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
            }
        
    }
}
