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

namespace DoAn1_QuanLy_BaoKhoaHoc
{
    public partial class QLTacGia : Form
    {
        DataTable dt_tg = null;
        string error;
        bool isThem = true;

        TacGia dbTacGia = new TacGia();
        public QLTacGia()
        {
            InitializeComponent();
        }
        private void dgv_tg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                int r = dgv_tg.CurrentCell.RowIndex;
                tb_mtg.Text = dgv_tg.Rows[r].Cells[0].Value.ToString();
                tb_ht.Text = dgv_tg.Rows[r].Cells[1].Value.ToString();
                tb_qg.Text = dgv_tg.Rows[r].Cells[3].Value.ToString();
                tb_sdt.Text = dgv_tg.Rows[r].Cells[2].Value.ToString();
            }
        }
        private void QLTacGia_Load(object sender, EventArgs e)
        {
            try
            {
                dt_tg = new DataTable();
                dt_tg.Clear();

                DataSet ql = dbTacGia.LayTacGia();
                dt_tg = ql.Tables[0];

                dgv_tg.DataSource = dt_tg;
                dgv_tg.AutoResizeColumns();
                dgv_tg_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show(error.ToString());
                MessageBox.Show("Có lỗi xảy ra,không lấy được dữ liệu table TieuDe!");
            }
        }
        public bool loaddgv_bykey()
        {
            try
            {
                dt_tg = new DataTable();

                dt_tg = dbTacGia.timKiemTacGia(tb_timkiem.Text).Tables[0];

                dgv_tg.DataSource = dt_tg;
                if (dt_tg.Rows.Count <= 0)
                {
                    return false;
                }
                dgv_tg.AutoResizeColumns();
                dgv_tg_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show(error.ToString());
                MessageBox.Show("Có lỗi xảy ra,không lấy được dữ liệu table TieuDe!");
            }
            return true;
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            loaddgv_bykey();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            try
            {
                TacGia tg = new TacGia();
                tg.SuaTacGia(this.tb_mtg.Text,this.tb_ht.Text,this.tb_qg.Text,this.tb_sdt.Text, ref error);
                Loaddata();
                MessageBox.Show("Đã Sửa!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi trong khi xóa!");
            }
        }
        void Loaddata()
        {
            try
            {
                dt_tg = new DataTable();
                dt_tg.Clear();

                DataSet ql = dbTacGia.LayTacGia();
                dt_tg = ql.Tables[0];

                dgv_tg.DataSource = dt_tg;
                dgv_tg.AutoResizeColumns();
                dgv_tg_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show(error.ToString());
                MessageBox.Show("Có lỗi xảy ra,không lấy được dữ liệu table TacGia!");
            }
        }
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                TacGia mn = new TacGia();
                mn.XoaTacGia(this.tb_mtg.Text, ref error);
                Loaddata();
                MessageBox.Show("Đã xóa xong!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi trong khi xóa!");
            }
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (isThem == false)
            {
                try
                {
                    TacGia tg = new TacGia();
                    tg.CapNhatTacGia(this.tb_mtg.Text, this.tb_ht.Text, this.tb_qg.Text,this.tb_sdt.Text,ref error);
                    Loaddata();
                    MessageBox.Show("Đã sửa xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi khi sửa");
                }
            }
        }

        private void bt_them_Click(object sender, EventArgs e)//them bai
        {
            Form QL = new QLTieuDe();
            this.Hide();
            QL.ShowDialog();
            this.Close();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Form dd = new GiaoDienChinh();
            this.Hide();
            dd.ShowDialog();
            this.Close();
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                TacGia tg = new TacGia();
                tg.CapNhatTacGia(this.tb_mtg.Text, this.tb_ht.Text, this.tb_qg.Text, this.tb_sdt.Text, ref error);
                Loaddata();
                MessageBox.Show("Đã nhập nhật!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi trong khi cập nhập!");
            }
        }

        private void dgv_tg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_tg.CurrentCell.RowIndex;
            tb_mtg.Text = dgv_tg.Rows[r].Cells[0].Value.ToString();
            tb_ht.Text = dgv_tg.Rows[r].Cells[1].Value.ToString();
            tb_qg.Text = dgv_tg.Rows[r].Cells[3].Value.ToString();
            tb_sdt.Text = dgv_tg.Rows[r].Cells[2].Value.ToString();
        }
    }
}
