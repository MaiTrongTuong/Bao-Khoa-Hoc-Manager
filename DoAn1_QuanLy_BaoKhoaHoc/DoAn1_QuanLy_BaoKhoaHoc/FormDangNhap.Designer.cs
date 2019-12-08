namespace DoAn1_QuanLy_BaoKhoaHoc
{
    partial class FormDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_dn = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.cb_show = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_quit = new System.Windows.Forms.Button();
            this.rbt_quanly = new System.Windows.Forms.RadioButton();
            this.rbt_tacgia = new System.Windows.Forms.RadioButton();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // lbl_dn
            // 
            this.lbl_dn.AutoSize = true;
            this.lbl_dn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_dn.Location = new System.Drawing.Point(45, 87);
            this.lbl_dn.Name = "lbl_dn";
            this.lbl_dn.Size = new System.Drawing.Size(97, 20);
            this.lbl_dn.TabIndex = 0;
            this.lbl_dn.Text = "User Name :";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_pass.Location = new System.Drawing.Point(45, 112);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(86, 20);
            this.lbl_pass.TabIndex = 1;
            this.lbl_pass.Text = "Password :";
            // 
            // cb_show
            // 
            this.cb_show.AutoSize = true;
            this.cb_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_show.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cb_show.Location = new System.Drawing.Point(159, 148);
            this.cb_show.Name = "cb_show";
            this.cb_show.Size = new System.Drawing.Size(123, 20);
            this.cb_show.TabIndex = 2;
            this.cb_show.Text = "Show Password";
            this.cb_show.UseVisualStyleBackColor = true;
            this.cb_show.CheckStateChanged += new System.EventHandler(this.cb_show_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOGIN";
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.Gray;
            this.bt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.Location = new System.Drawing.Point(49, 194);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(101, 30);
            this.bt_login.TabIndex = 6;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BackgroundImage = global::DoAn1_QuanLy_BaoKhoaHoc.Properties.Resources.imagellogin;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(324, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 168);
            this.panel1.TabIndex = 7;
            // 
            // bt_quit
            // 
            this.bt_quit.BackColor = System.Drawing.Color.Gray;
            this.bt_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quit.Location = new System.Drawing.Point(179, 194);
            this.bt_quit.Name = "bt_quit";
            this.bt_quit.Size = new System.Drawing.Size(102, 30);
            this.bt_quit.TabIndex = 8;
            this.bt_quit.Text = "Quit";
            this.bt_quit.UseVisualStyleBackColor = false;
            // 
            // rbt_quanly
            // 
            this.rbt_quanly.AutoSize = true;
            this.rbt_quanly.Checked = true;
            this.rbt_quanly.Location = new System.Drawing.Point(98, 56);
            this.rbt_quanly.Name = "rbt_quanly";
            this.rbt_quanly.Size = new System.Drawing.Size(65, 17);
            this.rbt_quanly.TabIndex = 9;
            this.rbt_quanly.TabStop = true;
            this.rbt_quanly.Text = "Quản Lý";
            this.rbt_quanly.UseVisualStyleBackColor = true;
            // 
            // rbt_tacgia
            // 
            this.rbt_tacgia.AutoSize = true;
            this.rbt_tacgia.Location = new System.Drawing.Point(220, 56);
            this.rbt_tacgia.Name = "rbt_tacgia";
            this.rbt_tacgia.Size = new System.Drawing.Size(63, 17);
            this.rbt_tacgia.TabIndex = 10;
            this.rbt_tacgia.TabStop = true;
            this.rbt_tacgia.Text = "Tác Giả";
            this.rbt_tacgia.UseVisualStyleBackColor = true;
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(159, 87);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(108, 20);
            this.tb_user.TabIndex = 11;
            this.tb_user.TextChanged += new System.EventHandler(this.tb_user_TextChanged);
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(159, 112);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(108, 20);
            this.tb_pass.TabIndex = 12;
            this.tb_pass.UseSystemPasswordChar = true;
            this.tb_pass.TextChanged += new System.EventHandler(this.tb_pass_TextChanged);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 261);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.rbt_tacgia);
            this.Controls.Add(this.rbt_quanly);
            this.Controls.Add(this.bt_quit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_show);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_dn);
            this.Name = "FormDangNhap";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dn;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.CheckBox cb_show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_quit;
        private System.Windows.Forms.RadioButton rbt_quanly;
        private System.Windows.Forms.RadioButton rbt_tacgia;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}