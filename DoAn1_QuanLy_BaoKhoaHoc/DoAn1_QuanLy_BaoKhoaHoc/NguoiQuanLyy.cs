using DoAn1_QuanLy_BaoKhoaHoc.BS;
using DoAn1_QuanLy_BaoKhoaHoc.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_QuanLy_BaoKhoaHoc
{
    public partial class NguoiQuanLyy : Form
    {
        DataTable dt_ql = null;
        string error;
        QuanLy dbQuanLy = new QuanLy();
        public NguoiQuanLyy()
        {
            InitializeComponent();
        }
        private void dgv_nql_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                int r = dgv_nql.CurrentCell.RowIndex;
                tb_ql.Text = dgv_nql.Rows[r].Cells[0].Value.ToString();
                tb_mw.Text = dgv_nql.Rows[r].Cells[1].Value.ToString();
                tb_ht.Text = dgv_nql.Rows[r].Cells[2].Value.ToString();
                tb_sl.Text = dgv_nql.Rows[r].Cells[3].Value.ToString();
                tb_qg.Text = dgv_nql.Rows[r].Cells[4].Value.ToString();
                tb_sdt.Text = dgv_nql.Rows[r].Cells[5].Value.ToString();
            }
        }

        private void Loaddata()
        {
            try
            {
                dt_ql = new DataTable();
                dt_ql.Clear();

                DataSet ql = dbQuanLy.LayQuanLy();
                dt_ql = ql.Tables[0];
                dgv_nql.DataSource = dt_ql;
                dgv_nql.AutoResizeColumns();
                dgv_nql_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show(error.ToString());
                MessageBox.Show("Có lỗi xảy ra,không lấy được dữ liệu table TieuDe!");
            }
        }

        private void bt_web_Click(object sender, EventArgs e)
        {
            Form dd = new QLWeb();
            this.Hide();
            dd.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//qltg
        {
            Form dd = new QLNhomTacGia();
            this.Hide();
            dd.ShowDialog();
            this.Close();
        }

        private void bt_luu_Click(object sender, EventArgs e)//ql tieu de
        {
            Form dd = new QLTieuDe();
            this.Hide();
            dd.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//ql the loai
        {
            Form dd = new QLTheLoai();
            this.Hide();
            dd.ShowDialog();
            this.Close();
        }

        private void bt_thoat_Click(object sender, EventArgs e)//quay lai
        {
            Form dd = new GiaoDienChinh();
            this.Hide();
            dd.ShowDialog();
            this.Close();
        }

        private void NguoiQuanLyy_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void dgv_nql_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_nql.CurrentCell.RowIndex;
            tb_ql.Text = dgv_nql.Rows[r].Cells[0].Value.ToString();
            tb_mw.Text = dgv_nql.Rows[r].Cells[1].Value.ToString();
            tb_ht.Text = dgv_nql.Rows[r].Cells[2].Value.ToString();
            tb_sl.Text = dgv_nql.Rows[r].Cells[3].Value.ToString();
            tb_qg.Text = dgv_nql.Rows[r].Cells[4].Value.ToString();
            tb_sdt.Text = dgv_nql.Rows[r].Cells[5].Value.ToString();
        }

        private void bt_mk_Click(object sender, EventArgs e)
        {

        }
    }
}
