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
    public partial class GiaoDienChinh : Form
    {
        public static bool isLogin = false;

        FormDangNhap dangnhap;

        public GiaoDienChinh()
        {
            InitializeComponent();
        }

        private void bt_QLBaoCao_Click(object sender, EventArgs e)
        {
            Form tl = new QLTheLoai();
            this.Hide();
            tl.ShowDialog();
            this.Close();
        }
        private void GiaoDienChinh_Load(object sender, EventArgs e)
        {
            if (isLogin == true)
            {
                
                if(FormDangNhap.TenBang=="QuanLy")
                {
                    lblTenQuanLy.Text = FormDangNhap.DR["HoVaTen"].ToString();
                    SetupEnable("QuanLy", true);
                    SetupEn("QuanLy", true);
                }
                else
                {
                    lblTenQuanLy.Text = FormDangNhap.DR["HoVaTen"].ToString();
                    SetupEnable("TacGia", true);
                    SetupEn("QuanLy", true);
                }
            }
            else
            {
                SetupEnable("QuanLy", false);
                SetupEn("QuanLy", false);
                SetupEnable("TacGia", false);
                SetupEn("TacGia", false);
            }
        }
        private void SetupEnable(string TenBang, bool istrue)
        {
            if (TenBang == "QuanLy")
            {
                bt_ntg.Enabled = istrue;
                bt_TTQL.Enabled = istrue;
                bt_QLTG.Enabled = istrue;
                bt_QLTieuDe.Enabled = istrue;
                bt_QLwebsite.Enabled = istrue;
                bt_QLTL.Enabled = istrue;
            }
            else if(TenBang=="TacGia")
            {
                bt_ntg.Enabled = istrue;
                bt_QLTG.Enabled = istrue;
                bt_QLTieuDe.Enabled = istrue;
                bt_QLwebsite.Enabled = istrue;
            }
        }
        private void SetupEn(string TenBang, bool istrue)
        {
            if (TenBang == "QuanLy")
            {
                ql_NhomTacGia.Enabled = istrue;
                ql_Tieude.Enabled = istrue;
                ql_tacgia.Enabled = istrue;
                ql_web.Enabled = istrue;
                ql_theloai.Enabled = istrue;
                ql_thongtin.Enabled = istrue;
            }
            else if (TenBang == "TacGia")
            {
                ql_NhomTacGia.Enabled = istrue;
                ql_Tieude.Enabled = istrue;
                ql_tacgia.Enabled = istrue;
                ql_web.Enabled = istrue;
            }

        }

        private void bt_QLTieuDe_Click(object sender, EventArgs e)
        {
            GiaoDienChinh_Load(sender, e);

            Form td = new QLTieuDe();
            this.Hide();
            td.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//nhom tac gia
        {
            GiaoDienChinh_Load(sender, e);
            Form ntg = new QLNhomTacGia();
            this.Hide();
            ntg.ShowDialog();
            this.Close();
        }

        private void bt_QLTG_Click(object sender, EventArgs e)
        {
            GiaoDienChinh_Load(sender,e);
            Form tg = new QLTacGia();
            this.Hide();
            tg.ShowDialog();
            this.Close();
        }

        private void bt_QLTheLoai_Click(object sender, EventArgs e)
        {
            GiaoDienChinh_Load(sender, e);
            Form ql = new NguoiQuanLyy();
            this.Hide();
            ql.ShowDialog();
            this.Close();
        }

        private void bt_QLwebsite_Click(object sender, EventArgs e)
        {
            GiaoDienChinh_Load(sender, e);
            Form web = new QLWeb();
            this.Hide();
            web.ShowDialog();
            this.Close();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dangnhap ==null)
            {
                dangnhap = new FormDangNhap();
            } 
            dangnhap.ShowDialog();

            GiaoDienChinh_Load(sender, e);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(isLogin==false)
            {
                MessageBox.Show("Vui Lòng Đăng Nhập Để Sử Dụng Các Chức Năng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isLogin = false;
            SetupEnable("QuanLy", false);
            SetupEn("QuanLy", false);
        }

        private void ql_Tieude_Click(object sender, EventArgs e)
        {
            GiaoDienChinh_Load(sender, e);
            Form td = new QLTieuDe();
            this.Hide();
            td.ShowDialog();
            this.Close();
        }

        private void ql_web_Click(object sender, EventArgs e)
        {
            GiaoDienChinh_Load(sender, e);
            Form web = new QLWeb();
            this.Hide();
            web.ShowDialog();
            this.Close();
        }

        private void ql_theloai_Click(object sender, EventArgs e)
        {
            GiaoDienChinh_Load(sender, e);
            Form ql = new QLTheLoai();
            this.Hide();
            ql.ShowDialog();
            this.Close();
        }

        private void ql_tacgia_Click(object sender, EventArgs e)
        {
            GiaoDienChinh_Load(sender, e);
            Form tg = new QLTacGia();
            this.Hide();
            tg.ShowDialog();
            this.Close();
        }

        private void ql_NhomTacGia_Click(object sender, EventArgs e)
        {
            GiaoDienChinh_Load(sender, e);
            Form ntg = new QLNhomTacGia();
            this.Hide();
            ntg.ShowDialog();
            this.Close();
        }

        private void ql_thongtin_Click(object sender, EventArgs e)
        {
            GiaoDienChinh_Load(sender, e);
            Form ql = new NguoiQuanLyy();
            this.Hide();
            ql.ShowDialog();
            this.Close();

        }

 
    }
}
