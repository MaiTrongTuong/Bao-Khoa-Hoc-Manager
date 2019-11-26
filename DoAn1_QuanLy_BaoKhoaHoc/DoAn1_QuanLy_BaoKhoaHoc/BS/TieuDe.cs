using DoAn1_QuanLy_BaoKhoaHoc.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_QuanLy_BaoKhoaHoc.BS
{
    class TieuDe
    {

        DBMain db = null;
        public TieuDe()
        {

            db = new DBMain();
        }
        public DataSet LayTieuDe()
        {
            return db.ExecuteQueryDataSet("select * from NoiDungChinh", CommandType.Text);
        }

        public bool ThemTieuDe(string MaTieuDe, string TenTieuDe, string NhomTacGia, string TheLoaiNghienCuu,string QuanLy ,ref string error)
        {
            string sqlString = "Insert Into NoiDungChinh Values('" + MaTieuDe + "','" + TenTieuDe + "','" + NhomTacGia + "',N'" + TheLoaiNghienCuu + "',N'"+QuanLy+"')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        public bool CapNhatTieuDe(string MaTieuDe, string TenTieuDe, string NhomTacGia, string TheLoaiNghienCuu,string QuanLy, ref string error)
        {
            string sqlString =
               "Update NoiDungChinh Set MaTieuDe=N'" + MaTieuDe + "', TenTieuDe='" + TenTieuDe + "',NhomTacGia=N'" + NhomTacGia + "' ,TheLoaiNghienCuu=N'" + TheLoaiNghienCuu + "',QuanLy=N'" + QuanLy + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        public bool XoaTieuDe(string MaTieuDe, ref string error)
        {
            string sqlString = "Delete From NoiDungChinh Where MaTieuDe='" + MaTieuDe + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        public bool KiemTraTonTai(string MaTieuDe, ref string error)
        {
            string sqlString = "Select Count(*) From NoiDungChinh Where MaTieuDe=N'" + MaTieuDe.Trim() + "'";
            return db.Check(sqlString, CommandType.Text, ref error);
        }

        public bool LoadCombobox(ComboBox cbb, string TenTable, string display, string value)
        {
            string sql = "select * from " + TenTable;
            return db.LoadCombobox(cbb, display, value, sql);
        }
    }
}


