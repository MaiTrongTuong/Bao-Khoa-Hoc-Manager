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
namespace DoAn1_QuanLy_BaoKhoaHoc
{
    public partial class QLTieuDe : Form
    {
        DataTable dtTieuDe = null;
        string error;
        bool isThem = true;
        TieuDe dbtieude = new TieuDe();

        public QLTieuDe()
        {
            InitializeComponent();
        }

        private void DuLieuChinh_Load(object sender, EventArgs e)
        {
            Loaddata();

            dbtieude.LoadCombobox(cbb_ql, "QuanLy", "HoVaTen", "idQuanLy");

        }
   
        void Loaddata()
        {
            try
            {
                dtTieuDe = new DataTable();
                dtTieuDe.Clear();

                DataSet ql = dbtieude.LayTieuDe();
                dtTieuDe = ql.Tables[0];

                dgv_TieuDe.DataSource = dtTieuDe;
                dgv_TieuDe.AutoResizeColumns();

                dgvTieuDe_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra,không lấy được dữ liệu table TieuDe!");
            }
        }
        private void dgvTieuDe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string a = cbb_ql.Text;
            //string sql = "Select QuanLy from NoiDungChinh" + a + "'";
            //{
            //    int r = dgv_TieuDe.CurrentCell.RowIndex;
            //    tb_mtd.Text = dgv_TieuDe.Rows[r].Cells[0].Value.ToString();
            //    tb_ntg.Text = dgv_TieuDe.Rows[r].Cells[1].Value.ToString();
            //    tb_td.Text = dgv_TieuDe.Rows[r].Cells[2].Value.ToString();
            //    tb_tlnc.Text = dgv_TieuDe.Rows[r].Cells[3].Value.ToString();
            //    a=cbb_ql.Text= dgv_TieuDe.Rows[r].Cells[4].Value.ToString();
            //}
        }
        private void bt_tim_Click(object sender, EventArgs e)
        {

        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            isThem = true;
        }

        private void button2_Click(object sender, EventArgs e)//sua
        {
            isThem = false;
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (isThem == true)
            {
                try
                {
                    TieuDe td = new TieuDe();
                    td.ThemTieuDe("Ad net", "ngu qua", "0235", "901", "16145255", ref error) ;
                    MessageBox.Show(error.ToString());
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
                    TieuDe td = new TieuDe();
                    td.CapNhatTieuDe(this.tb_mtd.Text, this.tb_td.Text, this.tb_ntg.Text, this.tb_tlnc.Text,"16145255", ref error);

                    Loaddata();
                    MessageBox.Show("Đã sửa xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi khi sửa");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)//cap nhat
        {
            Loaddata();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Form main = new Form();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }
    }
}
