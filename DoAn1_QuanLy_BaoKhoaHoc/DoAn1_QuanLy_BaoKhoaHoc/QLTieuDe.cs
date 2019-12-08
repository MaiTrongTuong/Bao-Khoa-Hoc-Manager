using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        QLNhomTacGia ntg = new QLNhomTacGia();
        public QLTieuDe()
        {
            InitializeComponent();
        }

        private void DuLieuChinh_Load(object sender, EventArgs e)
        {
            Loaddata();
            dbtieude.LoadCombobox(cbb_ql, "QuanLy", "HoVaTen", "idQuanLy");
            SetupEnable("QuanLy");
        }
        private void SetupEnable(string TenBang)
        {
             if(FormDangNhap.TenBang == "QuanLy")
             {
                button3.Hide();
                bt_them.Hide();
                bt_sua.Hide();
                bt_luu.Hide();
            }
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
            int r = dgv_TieuDe.CurrentCell.RowIndex;
            tb_mtd.Text = dgv_TieuDe.Rows[r].Cells[0].Value.ToString();
            tb_td.Text = dgv_TieuDe.Rows[r].Cells[1].Value.ToString();
            tb_tlnc.Text = dgv_TieuDe.Rows[r].Cells[3].Value.ToString();
            tb_ntg.Text = dgv_TieuDe.Rows[r].Cells[2].Value.ToString();
        }
        public bool loaddgv_bykey()
        {
            try
            {
                dtTieuDe = new DataTable();

                dtTieuDe = dbtieude.timKiemTieuDe(tbtk.Text).Tables[0];

                dgv_TieuDe.DataSource = dtTieuDe;
                if (dtTieuDe.Rows.Count <= 0)
                {
                    return false;
                }
                dgv_TieuDe.AutoResizeColumns();
                dgvTieuDe_CellClick(null, null);
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

        private void button2_Click(object sender, EventArgs e)//sua
        {
            isThem = false;
        }

        private void bt_luu_Click(object sender, EventArgs e)//luu
        {
            if (isThem == true)
            {
                try
                {
                    TieuDe td = new TieuDe();
                    //td.ThemTieuDe("Ad net", "ngu qua", "0235", "901", "16145255", ref error) ;
                    td.ThemTieuDe(this.tb_mtd.Text, this.tb_td.Text, this.tb_ntg.Text, this.tb_tlnc.Text, this.cbb_ql.Text, ref error);
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
                    td.CapNhatTieuDe(this.tb_mtd.Text, this.tb_td.Text, this.tb_ntg.Text, this.tb_tlnc.Text,this.cbb_ql.Text, ref error);
                    Loaddata();
                    MessageBox.Show("Đã Cập Nhật!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi khi sửa");
                }
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)//thoat nhom
        {
            Form main = new GiaoDienChinh();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }
        private void bt_tn_Click(object sender, EventArgs e)//them
        {
            Form tn= new QLNhomTacGia();
            this.Hide();
            tn.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)//xoa nhom
        {
            try
            {
                TieuDe td = new TieuDe();
                td.XoaTieuDe(this.tb_mtd.Text,tb_ntg.Text,tb_tlnc.Text, ref error);

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
            loaddgv_bykey();
        }

        private void OuputText_Click(object sender, EventArgs e)
        {
            string filePath = "";
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "TextDocument | *.txt ";

            dialog.ShowDialog();

            filePath = dialog.FileName;

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }

            FileStream fw = null;
            string msg;

            byte[] msgByte = null;
            fw = new FileStream(filePath, FileMode.CreateNew);

            msg = ConvertToText();
            msgByte = Encoding.Default.GetBytes(msg);

            fw.Write(msgByte, 0, msgByte.Length);
            if (fw != null) fw.Close();
            msg = "";
        }
        public string ConvertToText()
        {
            string text = "";
            for(int i=0;i<dgv_TieuDe.Rows.Count-1;i++)
            {
                for(int j=0;j<dgv_TieuDe.Columns.Count;j++)
                {
                    text += dgv_TieuDe.Rows[i].Cells[j].Value.ToString() + ",";
                }
                text += "\r\n";
            }
            return text;
        }

        private void OuputExcel_Click(object sender, EventArgs e)
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            dialog.ShowDialog();

            filePath = dialog.FileName;

            try
            {
                ExportToExcel excel = new ExportToExcel();

                DataTable dt = (DataTable)dgv_TieuDe.DataSource;
                excel.Export(dt, "Danh sach Tieu De", "Tiêu Đề Báo Cáo Khoa Học");

            }
            catch
            {
                MessageBox.Show("Không xuất được file exCel!");

            }
        }

        private void dgv_TieuDe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_TieuDe.CurrentCell.RowIndex;
            tb_mtd.Text = dgv_TieuDe.Rows[r].Cells[0].Value.ToString();
            tb_td.Text = dgv_TieuDe.Rows[r].Cells[1].Value.ToString();
            tb_tlnc.Text = dgv_TieuDe.Rows[r].Cells[3].Value.ToString();
            tb_ntg.Text = dgv_TieuDe.Rows[r].Cells[2].Value.ToString();
        }
    }
}
