namespace DoAn1_QuanLy_BaoKhoaHoc
{
    partial class QLWeb
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
            this.bt_tim = new System.Windows.Forms.Button();
            this.rtb_timkiem = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_mtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_mn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_td = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_tn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_web = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TgDangTai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_web = new System.Windows.Forms.RichTextBox();
            this.tb_tgDangTai = new System.Windows.Forms.RichTextBox();
            this.tb_sotrang = new System.Windows.Forms.RichTextBox();
            this.tb_ndt = new System.Windows.Forms.RichTextBox();
            this.tb_mw = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_MTD = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_ql = new System.Windows.Forms.RichTextBox();
            this.bt_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_tim
            // 
            this.bt_tim.Location = new System.Drawing.Point(479, 185);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(75, 23);
            this.bt_tim.TabIndex = 39;
            this.bt_tim.Text = "Tìm Kiếm";
            this.bt_tim.UseVisualStyleBackColor = true;
            // 
            // rtb_timkiem
            // 
            this.rtb_timkiem.Location = new System.Drawing.Point(347, 184);
            this.rtb_timkiem.Name = "rtb_timkiem";
            this.rtb_timkiem.Size = new System.Drawing.Size(126, 24);
            this.rtb_timkiem.TabIndex = 38;
            this.rtb_timkiem.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(364, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Tìm Kiếm ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_mtd,
            this.cl_mn,
            this.cl_td,
            this.cl_tn,
            this.cl_web,
            this.TgDangTai});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(668, 219);
            this.dataGridView1.TabIndex = 21;
            // 
            // col_mtd
            // 
            this.col_mtd.HeaderText = "Mã Tiêu Đề";
            this.col_mtd.Name = "col_mtd";
            this.col_mtd.Width = 80;
            // 
            // cl_mn
            // 
            this.cl_mn.HeaderText = "Mã Nhóm";
            this.cl_mn.Name = "cl_mn";
            this.cl_mn.Width = 80;
            // 
            // cl_td
            // 
            this.cl_td.HeaderText = "Tên Tiêu Đề";
            this.cl_td.Name = "cl_td";
            this.cl_td.Width = 150;
            // 
            // cl_tn
            // 
            this.cl_tn.HeaderText = "Tên Nhóm";
            this.cl_tn.Name = "cl_tn";
            this.cl_tn.Width = 150;
            // 
            // cl_web
            // 
            this.cl_web.HeaderText = "Số Trang";
            this.cl_web.Name = "cl_web";
            this.cl_web.Width = 80;
            // 
            // TgDangTai
            // 
            this.TgDangTai.HeaderText = "Tg Đăng Tải";
            this.TgDangTai.Name = "TgDangTai";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DoAn1_QuanLy_BaoKhoaHoc.Properties.Resources.web;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(507, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 133);
            this.panel2.TabIndex = 36;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(252, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "Cập Nhật";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tb_web
            // 
            this.tb_web.Location = new System.Drawing.Point(121, 128);
            this.tb_web.Name = "tb_web";
            this.tb_web.Size = new System.Drawing.Size(299, 24);
            this.tb_web.TabIndex = 31;
            this.tb_web.Text = "";
            // 
            // tb_tgDangTai
            // 
            this.tb_tgDangTai.Location = new System.Drawing.Point(121, 98);
            this.tb_tgDangTai.Name = "tb_tgDangTai";
            this.tb_tgDangTai.Size = new System.Drawing.Size(206, 24);
            this.tb_tgDangTai.TabIndex = 30;
            this.tb_tgDangTai.Text = "";
            // 
            // tb_sotrang
            // 
            this.tb_sotrang.Location = new System.Drawing.Point(121, 68);
            this.tb_sotrang.Name = "tb_sotrang";
            this.tb_sotrang.Size = new System.Drawing.Size(126, 24);
            this.tb_sotrang.TabIndex = 29;
            this.tb_sotrang.Text = "";
            // 
            // tb_ndt
            // 
            this.tb_ndt.Location = new System.Drawing.Point(121, 39);
            this.tb_ndt.Name = "tb_ndt";
            this.tb_ndt.Size = new System.Drawing.Size(206, 24);
            this.tb_ndt.TabIndex = 28;
            this.tb_ndt.Text = "";
            // 
            // tb_mw
            // 
            this.tb_mw.Location = new System.Drawing.Point(121, 9);
            this.tb_mw.Name = "tb_mw";
            this.tb_mw.Size = new System.Drawing.Size(126, 24);
            this.tb_mw.TabIndex = 27;
            this.tb_mw.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Số Trang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "TG Đăng Tải";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mục Đăng Tải";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã Website";
            // 
            // lbl_MTD
            // 
            this.lbl_MTD.AutoSize = true;
            this.lbl_MTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MTD.Location = new System.Drawing.Point(-34, 24);
            this.lbl_MTD.Name = "lbl_MTD";
            this.lbl_MTD.Size = new System.Drawing.Size(0, 20);
            this.lbl_MTD.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Website";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Quản Lý";
            // 
            // tb_ql
            // 
            this.tb_ql.Location = new System.Drawing.Point(121, 158);
            this.tb_ql.Name = "tb_ql";
            this.tb_ql.Size = new System.Drawing.Size(206, 24);
            this.tb_ql.TabIndex = 42;
            this.tb_ql.Text = "";
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(5, 196);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 23);
            this.bt_them.TabIndex = 43;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            // 
            // QLWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(668, 444);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.tb_ql);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.rtb_timkiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_web);
            this.Controls.Add(this.tb_tgDangTai);
            this.Controls.Add(this.tb_sotrang);
            this.Controls.Add(this.tb_ndt);
            this.Controls.Add(this.tb_mw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_MTD);
            this.Name = "QLWeb";
            this.Text = "QLWeb";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.RichTextBox rtb_timkiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_mn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_td;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_tn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_web;
        private System.Windows.Forms.DataGridViewTextBoxColumn TgDangTai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox tb_web;
        private System.Windows.Forms.RichTextBox tb_tgDangTai;
        private System.Windows.Forms.RichTextBox tb_sotrang;
        private System.Windows.Forms.RichTextBox tb_ndt;
        private System.Windows.Forms.RichTextBox tb_mw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_MTD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox tb_ql;
        private System.Windows.Forms.Button bt_them;
    }
}