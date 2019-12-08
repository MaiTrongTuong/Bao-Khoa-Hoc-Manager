using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn1_QuanLy_BaoKhoaHoc.BS;
using DoAn1_QuanLy_BaoKhoaHoc.Resources;

namespace DoAn1_QuanLy_BaoKhoaHoc
{
    public partial class FormDangNhap : Form
    {
        string error = "";
        public static string TenBang = "";
        DataTable dt = new DataTable();

        public static DataRow DR;

        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void bt_login_Click(object sender, EventArgs e)
        {
            if(tb_user.Text=="" || tb_pass.Text=="")
            {
                MessageBox.Show("Không được để trống");
                tb_user.BackColor = Color.Red;
                tb_pass.BackColor = Color.Red;
                return;
            }
            if (tb_user.Text == "")
            {
                MessageBox.Show("Nội dung Tên đăng nhập không được bỏ trống!");
                tb_user.BackColor = Color.Red;
                return;
            }
            if (tb_pass.Text == "")
            {
                MessageBox.Show("Nội dung Mật khẩu không được để trống!");
                tb_pass.BackColor = Color.Red;
            }

            if (rbt_quanly.Checked == true)
            {
                TenBang = "QuanLy";            
            }
            else if (rbt_tacgia.Checked == true)
            {
                TenBang = "TacGia";
            }
            DangNhap();
        }
        private void DangNhap()
        {
            DangNhap dn = new DangNhap();
            dt = dn.KtraTaiKhoan(TenBang, tb_user.Text, tb_pass.Text, ref error);

            if (dt.Rows.Count > 0)
            {
                DR = dt.Rows[0];

                GiaoDienChinh.isLogin = true;

                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mặt khẩu không đúng!");
                tb_pass.Clear();
            }
        }

        private void cb_show_CheckStateChanged(object sender, EventArgs e)
        {
            if(cb_show.Checked==true)
            {
                tb_pass.UseSystemPasswordChar = false;
            }
            else
            {
                tb_pass.UseSystemPasswordChar = true;
            }
        }
        private void tb_user_TextChanged(object sender, EventArgs e)
        {
            tb_user.BackColor = Color.White;
        }

        private void tb_pass_TextChanged(object sender, EventArgs e)
        {
            tb_pass.BackColor = Color.White;
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
