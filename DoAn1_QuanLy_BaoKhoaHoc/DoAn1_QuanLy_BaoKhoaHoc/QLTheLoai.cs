using DoAn1_QuanLy_BaoKhoaHoc.BS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_QuanLy_BaoKhoaHoc.Resources
{
    public partial class QLTheLoai : Form
    {

        DataTable dt_tl = null;
        string error;
        bool isThem = true;
        TheLoaiNghienCuu db_tl = new TheLoaiNghienCuu();
        public QLTheLoai()
        {
            InitializeComponent();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Form main = new GiaoDienChinh();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }
        void Loaddata()
        {
            try
            {
                dt_tl = new DataTable();
                dt_tl.Clear();

                DataSet ql = db_tl.LayTheLoai();
                dt_tl = ql.Tables[0];

                dgv_tl.DataSource = dt_tl;
                dgv_tl.AutoResizeColumns();
                dgv_tl_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show(error.ToString());
                MessageBox.Show("Có lỗi xảy ra,không lấy được dữ liệu table The Loai Nghien Cuu!");
            }
        }
        private void dgv_tl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                int r = dgv_tl.CurrentCell.RowIndex;
                tb_mtl.Text = dgv_tl.Rows[r].Cells[0].Value.ToString();
                tb_ttl.Text = dgv_tl.Rows[r].Cells[1].Value.ToString();
            }
        }
        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (isThem == true)
            {
                try
                {
                    TheLoaiNghienCuu tl = new TheLoaiNghienCuu();
                    tl.ThemTheLoai(this.tb_mtl.Text, this.tb_ttl.Text, ref error);
                    Loaddata();
                    MessageBox.Show("Đã thêm");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi thêm");
                }
            }
            else
            {
                try
                {
                    TheLoaiNghienCuu tl = new TheLoaiNghienCuu();
                    tl.CapNhatTheLoai(this.tb_mtl.Text, this.tb_ttl.Text, ref error);
                    Loaddata();
                    MessageBox.Show("Đã sửa xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi khi sửa");
                }
            }
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            isThem = true;
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                TheLoaiNghienCuu tl = new TheLoaiNghienCuu();
                tl.CapNhatTheLoai(this.tb_mtl.Text, this.tb_ttl.Text, ref error);
                Loaddata();
                MessageBox.Show("Đã nhập nhật!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi trong khi cập nhập!");
            }
        }

        private void QLTheLoai_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            isThem = false;
        }
        public bool load_key()
        {
            try
            {
                dt_tl = new DataTable();

                dt_tl = db_tl.timKiemTheLoai(tbtk.Text).Tables[0];

                dgv_tl.DataSource = dt_tl;
                if (dt_tl.Rows.Count <= 0)
                {
                    return false;
                }
                dgv_tl.AutoResizeColumns();
                dgv_tl_CellClick(null, null);

            }
            catch
            {
                MessageBox.Show(error.ToString());
                MessageBox.Show("Có lỗi xảy ra,không lấy được dữ liệu table TieuDe!");
            }
            return true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                TheLoaiNghienCuu tl = new TheLoaiNghienCuu();
                tl.XoaTheLoai(this.tb_mtl.Text, ref error);

                Loaddata();
                MessageBox.Show("Đã xóa xong!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi trong khi xóa!");
            }
        }

        private void tbtk_TextChanged(object sender, EventArgs e)
        {
            load_key();
        }
    }
}
