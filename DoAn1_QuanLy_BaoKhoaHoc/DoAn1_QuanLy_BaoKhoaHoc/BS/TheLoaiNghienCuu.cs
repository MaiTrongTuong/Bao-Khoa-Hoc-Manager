using DoAn1_QuanLy_BaoKhoaHoc.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1_QuanLy_BaoKhoaHoc.BS
{
    class TheLoaiNghienCuu
    {

        DBMain db = null;
        public TheLoaiNghienCuu()
        {

            db = new DBMain();
        }
        public DataSet timKiemTheLoai(string search)
        {
            return db.ExecuteQueryDataSet("select *from" +
                    " TheLoaiNghienCuu" + " where (MaTheLoai like  '%" + search + "%'" + " OR TenTheLoai like  '%" + search + "%')", CommandType.Text);
        }
        public DataSet LayTheLoai()
        {
            return db.ExecuteQueryDataSet("select * from TheLoaiNghienCuu", CommandType.Text);
        }

        public bool ThemTheLoai(string MaTheLoai, string TenTheLoai, ref string error)
        {
            string sqlString ="Insert Into TheLoaiNghienCuu Values('" + MaTheLoai + "',N'" + TenTheLoai + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
        public bool CapNhatTheLoai(string MaTheLoai,string TenTheLoai,ref string error)
        {
            string sqlString =
            "UPDATE TheLoaiNghienCuu SET TenTheLoai='" + TenTheLoai +"' where MaTheLoai='"+MaTheLoai+"'"+
            "  UPDATE NoiDungChinh SET TheLoaiNghienCuu='" +MaTheLoai+ "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
        public bool XoaTheLoai(string MaTheLoai, ref string error)
        {
            string sqlString = "Delete From TheLoaiNghienCuu Where MaTheLoai='" + MaTheLoai + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
    }
}

