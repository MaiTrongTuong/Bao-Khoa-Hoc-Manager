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
    public partial class QLWeb : Form
    {
        DataTable dtweb = null;
        string error;
        bool isThem = true;
        WebDangTai dbweb = new WebDangTai();

        public QLWeb()
        {
            InitializeComponent();
        }
        private void QLWeb_Load(object sender, EventArgs e)
        {
            Loaddata();
            SetupEnable("TacGia");      
            }
        private void SetupEnable(string TenBang)
        {
            if (FormDangNhap.TenBang == "TacGia")
            {
                bt_them.Hide();
                button2.Hide();
                bt_luu.Hide();
                button4.Hide();
            }
        }
        void Loaddata()
        {
            try
            {
                dtweb = new DataTable();
                dtweb.Clear();

                DataSet ql = dbweb.LayWeb();
                dtweb = ql.Tables[0];

                dgv_web.DataSource = dtweb;
                dgv_web.AutoResizeColumns();
                dgvweb_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show(error.ToString());
                MessageBox.Show("Có lỗi xảy ra,không lấy được dữ liệu table TieuDe!");
            }
        }
        private void button2_Click_1(object sender, EventArgs e)//sua
        {
            isThem = false;
        }

        private void dgvweb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_web.CurrentCell.RowIndex;
            tb_mw.Text = dgv_web.Rows[r].Cells[0].Value.ToString();
            tb_ndt.Text = dgv_web.Rows[r].Cells[1].Value.ToString();
            tb_sotrang.Text = dgv_web.Rows[r].Cells[2].Value.ToString();
            tb_tgDangTai.Text = dgv_web.Rows[r].Cells[3].Value.ToString();
            tb_web.Text = dgv_web.Rows[r].Cells[4].Value.ToString();
            tb_ql.Text = dgv_web.Rows[r].Cells[5].Value.ToString();
        }
        private void bt_luu_Click_1(object sender, EventArgs e)
        {
            if (isThem == true)
            {
                try
                {
                    WebDangTai web = new WebDangTai();
                    web.ThemWeb(this.tb_mw.Text, this.tb_ndt.Text, this.tb_sotrang.Text, this.tb_tgDangTai.Text, this.tb_web.Text,this.tb_ql.Text, ref error);
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
                    WebDangTai web = new WebDangTai();
                    web.CapNhatWeb(this.tb_mw.Text, this.tb_ndt.Text, this.tb_sotrang.Text, this.tb_tgDangTai.Text, this.tb_web.Text,this.tb_ql.Text, ref error);
                    Loaddata();
                    MessageBox.Show("Đã sửa xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi khi sửa");
                }
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
                dtweb = new DataTable();

                dtweb = dbweb.timKiemweb(tb_tk.Text).Tables[0];

                dgv_web.DataSource = dtweb;
                if (dtweb.Rows.Count <= 0)
                {
                    return false;
                }

                dgv_web.AutoResizeColumns();
                dgvweb_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show(error.ToString());
                MessageBox.Show("Có lỗi xảy ra,không lấy được dữ liệu table TieuDe!");
            }
            return true;
        }
    
        private void bt_them_Click(object sender, EventArgs e)
        {
            isThem = true;
        }

        private void bt_thoat_Click(object sender, EventArgs e)//thoat
        {
            Form main = new GiaoDienChinh();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }
       
        private void button4_Click_1(object sender, EventArgs e)//cap nhat
        {
            Loaddata();
        }
         
        private void tb_tk_TextChanged(object sender, EventArgs e)
        {
            loaddgv_bykey();
        }
    }
}
