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
using DoAn1_QuanLy_BaoKhoaHoc.BS;
using DoAn1_QuanLy_BaoKhoaHoc.DB;

namespace DoAn1_QuanLy_BaoKhoaHoc
{
    public partial class QLNhomTacGia : Form
    {   
        DataTable dt_ntg = null;
        string error;
        bool isThem = true;
        NhomTacGia db_ntg = new NhomTacGia();
        public QLNhomTacGia()
        {
            InitializeComponent();
        }
        private void NhomTacGia_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        void Loaddata()
        {
            try
            {
                 dt_ntg = new DataTable();
                  dt_ntg.Clear();

                DataSet ql = db_ntg.LayNhom();
                dt_ntg = ql.Tables[0];

                dgv_ntg.DataSource = dt_ntg;
                dgv_ntg.AutoResizeColumns();
                dgv_ntg_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show(error.ToString());
                MessageBox.Show("Có lỗi xảy ra,không lấy được dữ liệu table NhomTacGia!");
            }
        }
        private void button2_Click(object sender, EventArgs e)//sua
        {
            isThem = false;
        }

        private void dgv_ntg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                int r = dgv_ntg.CurrentCell.RowIndex;
                tb_mn.Text = dgv_ntg.Rows[r].Cells[0].Value.ToString();
                tb_tn.Text = dgv_ntg.Rows[r].Cells[1].Value.ToString();
            }
        }

        private void bt_them_Click(object sender, EventArgs e)//them
        {
            isThem = true;
        }

        private void bt_luu_Click(object sender, EventArgs e)//luu
        {
            if(isThem == true)
            {
                try
                {
                    NhomTacGia ntg = new NhomTacGia();
                    ntg.ThemNhom(this.tb_mn.Text, this.tb_tn.Text, ref error);
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
                    NhomTacGia ntg = new NhomTacGia();
                    ntg.CapNhatNhom(this.tb_mn.Text, this.tb_tn.Text, ref error);
                    Loaddata();
                    MessageBox.Show("Đã sửa xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi khi sửa");
                }
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)//xoa
        {
            try
            {
                NhomTacGia mn = new NhomTacGia();
                mn.XoaNhom(this.tb_mn.Text, ref error);
                Loaddata();
                MessageBox.Show("Đã xóa xong!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi trong khi xóa!");
            }
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            loaddgv_bykey();
        }
        public bool loaddgv_bykey()
        {
            try
            {
                dt_ntg = new DataTable();

                dt_ntg = db_ntg.timKiemNhom(tbtk.Text).Tables[0];

                dgv_ntg.DataSource = dt_ntg;
                if (dt_ntg.Rows.Count <= 0)
                {
                    return false;
                }
              
                dgv_ntg.AutoResizeColumns();
                dgv_ntg_CellClick(null, null);
         
            }
            catch
            {
                MessageBox.Show(error.ToString());
                MessageBox.Show("Có lỗi xảy ra,không lấy được dữ liệu table TieuDe!");
            }
            return true;
        }

        private void bt_capnhat_Click(object sender, EventArgs e)//cap nhat
        {
            try
            {
                NhomTacGia mn = new NhomTacGia();
                mn.CapNhatNhom(this.tb_mn.Text,this.tb_tn.Text, ref error);
                Loaddata();
                MessageBox.Show("Đã nhập nhật!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi trong khi cập nhập!");
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)//thoat
        {
            Form main = new GiaoDienChinh();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void bt_xem_Click(object sender, EventArgs e)//xem
        {
            Form tg = new QLTacGia();
            this.Hide();
            tg.ShowDialog();
            this.Close();
        }
    }
}
