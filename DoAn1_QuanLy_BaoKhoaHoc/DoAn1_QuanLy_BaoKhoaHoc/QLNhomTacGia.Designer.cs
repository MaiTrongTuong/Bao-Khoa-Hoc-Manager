namespace DoAn1_QuanLy_BaoKhoaHoc
{
    partial class QLNhomTacGia
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
            this.label6 = new System.Windows.Forms.Label();
            this.bt_capnhat = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.tb_tn = new System.Windows.Forms.RichTextBox();
            this.tb_mn = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_ntg = new System.Windows.Forms.DataGridView();
            this.tbtk = new System.Windows.Forms.TextBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_xem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ntg)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_tim
            // 
            this.bt_tim.Location = new System.Drawing.Point(299, 99);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(75, 23);
            this.bt_tim.TabIndex = 77;
            this.bt_tim.Text = "Tìm Kiếm";
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-4, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 75;
            this.label6.Text = "Từ Khóa Tìm Kiếm ";
            // 
            // bt_capnhat
            // 
            this.bt_capnhat.Location = new System.Drawing.Point(123, 139);
            this.bt_capnhat.Name = "bt_capnhat";
            this.bt_capnhat.Size = new System.Drawing.Size(75, 23);
            this.bt_capnhat.TabIndex = 73;
            this.bt_capnhat.Text = "Cập Nhật";
            this.bt_capnhat.UseVisualStyleBackColor = true;
            this.bt_capnhat.Click += new System.EventHandler(this.bt_capnhat_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(0, 139);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 23);
            this.bt_sua.TabIndex = 71;
            this.bt_sua.Text = "Sửa Bài";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_tn
            // 
            this.tb_tn.Location = new System.Drawing.Point(123, 36);
            this.tb_tn.Name = "tb_tn";
            this.tb_tn.Size = new System.Drawing.Size(179, 24);
            this.tb_tn.TabIndex = 67;
            this.tb_tn.Text = "";
            // 
            // tb_mn
            // 
            this.tb_mn.Location = new System.Drawing.Point(123, 6);
            this.tb_mn.Name = "tb_mn";
            this.tb_mn.Size = new System.Drawing.Size(104, 24);
            this.tb_mn.TabIndex = 66;
            this.tb_mn.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Tên Nhóm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Mã Nhóm";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DoAn1_QuanLy_BaoKhoaHoc.Properties.Resources.imagellogin;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(420, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 133);
            this.panel2.TabIndex = 74;
            // 
            // dgv_ntg
            // 
            this.dgv_ntg.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dgv_ntg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ntg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ntg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_ntg.Location = new System.Drawing.Point(0, 231);
            this.dgv_ntg.Name = "dgv_ntg";
            this.dgv_ntg.Size = new System.Drawing.Size(579, 219);
            this.dgv_ntg.TabIndex = 61;
            this.dgv_ntg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ntg_CellClick);
            this.dgv_ntg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ntg_CellClick);
            // 
            // tbtk
            // 
            this.tbtk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbtk.Location = new System.Drawing.Point(167, 102);
            this.tbtk.Name = "tbtk";
            this.tbtk.Size = new System.Drawing.Size(100, 20);
            this.tbtk.TabIndex = 78;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(0, 182);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 22);
            this.bt_them.TabIndex = 79;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(123, 181);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 23);
            this.bt_luu.TabIndex = 80;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(227, 182);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 23);
            this.bt_thoat.TabIndex = 81;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_xem
            // 
            this.bt_xem.Location = new System.Drawing.Point(227, 140);
            this.bt_xem.Name = "bt_xem";
            this.bt_xem.Size = new System.Drawing.Size(111, 22);
            this.bt_xem.TabIndex = 82;
            this.bt_xem.Text = "Xem Thành Viên";
            this.bt_xem.UseVisualStyleBackColor = true;
            this.bt_xem.Click += new System.EventHandler(this.bt_xem_Click);
            // 
            // QLNhomTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.bt_xem);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.tbtk);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_ntg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bt_capnhat);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.tb_tn);
            this.Controls.Add(this.tb_mn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "QLNhomTacGia";
            this.Text = "NhomTacGia";
            this.Load += new System.EventHandler(this.NhomTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ntg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_capnhat;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.RichTextBox tb_tn;
        private System.Windows.Forms.RichTextBox tb_mn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ntg;
        private System.Windows.Forms.TextBox tbtk;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_xem;
    }
}