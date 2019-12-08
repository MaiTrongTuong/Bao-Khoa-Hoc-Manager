using DoAn1_QuanLy_BaoKhoaHoc.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn1_QuanLy_BaoKhoaHoc;

namespace DoAn1_QuanLy_BaoKhoaHoc.BS
{
    class TieuDe
    {

        DBMain db = null;
        public TieuDe()
        {

            db = new DBMain();
        }
        public DataSet timKiemTieuDe(string search)
        {

                return db.ExecuteQueryDataSet("select MaTieuDe,TieuDe,NhomTacGia,TheLoaiNghienCuu,QuanLy " +
                      "from NoiDungChinh, NhomTacGia, TheLoaiNghienCuu, QuanLy " + "where NhomTacGia.MaNhom=NoiDungChinh.NhomTacGia " +
                      "AND TheLoaiNghienCuu.MaTheLoai=NoiDungChinh.TheLoaiNghienCuu AND QuanLy.idQuanLy=NoiDungChinh.QuanLy AND " +
                  "  (MaTieuDe like '%" + search + "%'" + " OR" +
                  " TieuDe like  '%" + search + "%'" + " OR NhomTacGia like  '%" + search + "%'" + " OR TheLoaiNghienCuu like  '%" + search + "%')", CommandType.Text);
        }
        public DataSet LayTieuDe()
        {
            return db.ExecuteQueryDataSet("Select MaTieuDe,TieuDe,TenNhom,TenTheLoai,idQuanLy " +
                " from NoiDungChinh,NhomTacGia,TheLoaiNghienCuu,QuanLy " + " where NhomTacGia.MaNhom=NoiDungChinh.NhomTacGia AND " +
                "TheLoaiNghienCuu.MaTheLoai=NoiDungChinh.TheLoaiNghienCuu AND QuanLy.idQuanLy=NoiDungChinh.QuanLy", CommandType.Text);
        }
        public bool ThemTieuDe(string MaTieuDe, string TenTieuDe, string NhomTacGia, string TheLoaiNghienCuu, string QuanLy,ref string error)
        {
            int t=917;
            int q = 261;
            string sqlString =
                "  Insert NoiDungChinh Values('" + MaTieuDe + "','" + TenTieuDe + "'," + "NhomTacGia = N'" + NhomTacGia + "'," +
               "TheLoaiNghienCuu='" + TheLoaiNghienCuu + "',QuanLy='" + QuanLy + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);

        }
        public bool CapNhatTieuDe(string MaTieuDe, string TenTieuDe, string NhomTacGia, string TheLoaiNghienCuu,string QuanLy, ref string error)
        {
            string sqlString =
               "   Update NoiDungChinh Set MaTieuDe=N'" + MaTieuDe + "', TenTieuDe='" + TenTieuDe +"',"+ "NhomTacGia = N'" + NhomTacGia + "'," +
               "TheLoaiNghienCuu='"+TheLoaiNghienCuu+"',QuanLy='" + QuanLy +"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        public bool XoaTieuDe(string MaTieuDe, string NhomTacGia, string TheLoaiNghienCuu, ref string error)
        {
            string sqlString =
                "Delete From NoiDungChinh Where MaTieuDe='" + MaTieuDe + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
        public bool LoadCombobox(ComboBox cbb, string TenTable, string display, string value)
        {
            string sql = "select * from " + TenTable;
            return db.LoadCombobox(cbb, display, value, sql);
        }
    }
}


