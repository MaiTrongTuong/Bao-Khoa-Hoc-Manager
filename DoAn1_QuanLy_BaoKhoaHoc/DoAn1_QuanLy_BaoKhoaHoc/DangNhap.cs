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

namespace DoAn1_QuanLy_BaoKhoaHoc
{
    public partial class DangNhap : Form
    {
        string error = "";
        public DangNhap()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if(tb_user.Text=="" || tb_pass.Text=="")
            {
                MessageBox.Show("Khong ai ngu bang Tuong");
                return;
            }
            string TenBang = "";
            if (rbt_quanly.Checked == true)
            {
                TenBang = "QuanLy";
            }
            else if (rbt_tacgia.Checked == true)
            {
                TenBang = "TacGia";
            }
            BS.DangNhap dn = new BS.DangNhap();
            bool isLogin = dn.KtraTaiKhoan(TenBang, tb_user.Text, tb_pass.Text, ref error);
            if(isLogin)
            { MessageBox.Show("Login Complete!"); }
            else
            {
                MessageBox.Show("Login failed! please check the input again!");
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
