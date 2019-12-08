namespace DoAn1_QuanLy_BaoKhoaHoc
{
    partial class QLTieuDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLTieuDe));
            this.lbl_MTD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_mtd = new System.Windows.Forms.RichTextBox();
            this.tb_td = new System.Windows.Forms.RichTextBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_TieuDe = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_luu = new System.Windows.Forms.Button();
            this.cbb_ql = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.tbtk = new System.Windows.Forms.TextBox();
            this.bt_tn = new System.Windows.Forms.Button();
            this.bt_themtlnc = new System.Windows.Forms.Button();
            this.OuputText = new System.Windows.Forms.Button();
            this.OuputExcel = new System.Windows.Forms.Button();
            this.tb_ntg = new System.Windows.Forms.RichTextBox();
            this.tb_tlnc = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TieuDe)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MTD
            // 
            this.lbl_MTD.AutoSize = true;
            this.lbl_MTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MTD.Location = new System.Drawing.Point(37, 29);
            this.lbl_MTD.Name = "lbl_MTD";
            this.lbl_MTD.Size = new System.Drawing.Size(0, 20);
            this.lbl_MTD.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Tiêu Đề";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiêu Đề";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhóm Tác Giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thể Loại Nghiên Cứu";
            // 
            // tb_mtd
            // 
            this.tb_mtd.Location = new System.Drawing.Point(175, 25);
            this.tb_mtd.Name = "tb_mtd";
            this.tb_mtd.Size = new System.Drawing.Size(126, 24);
            this.tb_mtd.TabIndex = 6;
            this.tb_mtd.Text = "";
            // 
            // tb_td
            // 
            this.tb_td.Location = new System.Drawing.Point(175, 54);
            this.tb_td.Name = "tb_td";
            this.tb_td.Size = new System.Drawing.Size(289, 24);
            this.tb_td.TabIndex = 7;
            this.tb_td.Text = "";
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(0, 190);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 23);
            this.bt_them.TabIndex = 11;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(81, 190);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 23);
            this.bt_sua.TabIndex = 12;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(162, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(506, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 133);
            this.panel2.TabIndex = 16;
            // 
            // dgv_TieuDe
            // 
            this.dgv_TieuDe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TieuDe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TieuDe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_TieuDe.Location = new System.Drawing.Point(0, 231);
            this.dgv_TieuDe.Name = "dgv_TieuDe";
            this.dgv_TieuDe.Size = new System.Drawing.Size(814, 219);
            this.dgv_TieuDe.TabIndex = 0;
            this.dgv_TieuDe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TieuDe_CellContentClick);
            this.dgv_TieuDe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TieuDe_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(348, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Từ Khóa Tìm Kiếm ";
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(243, 190);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 23);
            this.bt_luu.TabIndex = 20;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // cbb_ql
            // 
            this.cbb_ql.FormattingEnabled = true;
            this.cbb_ql.Location = new System.Drawing.Point(175, 155);
            this.cbb_ql.Name = "cbb_ql";
            this.cbb_ql.Size = new System.Drawing.Size(173, 21);
            this.cbb_ql.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Quản Lý";
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(706, 52);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(96, 23);
            this.bt_thoat.TabIndex = 23;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // tbtk
            // 
            this.tbtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtk.Location = new System.Drawing.Point(494, 191);
            this.tbtk.Name = "tbtk";
            this.tbtk.Size = new System.Drawing.Size(161, 22);
            this.tbtk.TabIndex = 24;
            this.tbtk.TextChanged += new System.EventHandler(this.tbtk_TextChanged);
            // 
            // bt_tn
            // 
            this.bt_tn.Location = new System.Drawing.Point(338, 90);
            this.bt_tn.Name = "bt_tn";
            this.bt_tn.Size = new System.Drawing.Size(110, 23);
            this.bt_tn.TabIndex = 28;
            this.bt_tn.Text = "Thêm Nhóm";
            this.bt_tn.UseVisualStyleBackColor = true;
            this.bt_tn.Click += new System.EventHandler(this.bt_tn_Click);
            // 
            // bt_themtlnc
            // 
            this.bt_themtlnc.Location = new System.Drawing.Point(338, 124);
            this.bt_themtlnc.Name = "bt_themtlnc";
            this.bt_themtlnc.Size = new System.Drawing.Size(110, 23);
            this.bt_themtlnc.TabIndex = 29;
            this.bt_themtlnc.Text = "Thêm Thể Loại";
            this.bt_themtlnc.UseVisualStyleBackColor = true;
            // 
            // OuputText
            // 
            this.OuputText.Location = new System.Drawing.Point(706, 93);
            this.OuputText.Name = "OuputText";
            this.OuputText.Size = new System.Drawing.Size(96, 23);
            this.OuputText.TabIndex = 32;
            this.OuputText.Text = "Xuất file Text";
            this.OuputText.UseVisualStyleBackColor = true;
            this.OuputText.Click += new System.EventHandler(this.OuputText_Click);
            // 
            // OuputExcel
            // 
            this.OuputExcel.Location = new System.Drawing.Point(706, 135);
            this.OuputExcel.Name = "OuputExcel";
            this.OuputExcel.Size = new System.Drawing.Size(96, 23);
            this.OuputExcel.TabIndex = 33;
            this.OuputExcel.Text = "Xuất file Excel";
            this.OuputExcel.UseVisualStyleBackColor = true;
            this.OuputExcel.Click += new System.EventHandler(this.OuputExcel_Click);
            // 
            // tb_ntg
            // 
            this.tb_ntg.Location = new System.Drawing.Point(175, 95);
            this.tb_ntg.Name = "tb_ntg";
            this.tb_ntg.Size = new System.Drawing.Size(126, 24);
            this.tb_ntg.TabIndex = 36;
            this.tb_ntg.Text = "";
            // 
            // tb_tlnc
            // 
            this.tb_tlnc.Location = new System.Drawing.Point(175, 126);
            this.tb_tlnc.Name = "tb_tlnc";
            this.tb_tlnc.Size = new System.Drawing.Size(126, 24);
            this.tb_tlnc.TabIndex = 37;
            this.tb_tlnc.Text = "";
            // 
            // QLTieuDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.tb_tlnc);
            this.Controls.Add(this.tb_ntg);
            this.Controls.Add(this.OuputExcel);
            this.Controls.Add(this.OuputText);
            this.Controls.Add(this.bt_themtlnc);
            this.Controls.Add(this.bt_tn);
            this.Controls.Add(this.tbtk);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbb_ql);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_TieuDe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.tb_td);
            this.Controls.Add(this.tb_mtd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_MTD);
            this.Name = "QLTieuDe";
            this.Text = "DuLieuChinh";
            this.Load += new System.EventHandler(this.DuLieuChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TieuDe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MTD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox tb_mtd;
        private System.Windows.Forms.RichTextBox tb_td;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_TieuDe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.ComboBox cbb_ql;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.TextBox tbtk;
        private System.Windows.Forms.Button bt_tn;
        private System.Windows.Forms.Button bt_themtlnc;
        private System.Windows.Forms.Button OuputText;
        private System.Windows.Forms.Button OuputExcel;
        private System.Windows.Forms.RichTextBox tb_ntg;
        private System.Windows.Forms.RichTextBox tb_tlnc;
    }
}

