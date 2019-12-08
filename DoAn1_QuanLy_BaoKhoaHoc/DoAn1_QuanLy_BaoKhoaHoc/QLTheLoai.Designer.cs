namespace DoAn1_QuanLy_BaoKhoaHoc.Resources
{
    partial class QLTheLoai
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
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.tbtk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_tl = new System.Windows.Forms.DataGridView();
            this.bt_sua = new System.Windows.Forms.Button();
            this.tb_ttl = new System.Windows.Forms.RichTextBox();
            this.tb_mtl = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tl)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(113, 178);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 23);
            this.bt_thoat.TabIndex = 96;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(113, 138);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 23);
            this.bt_luu.TabIndex = 95;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(20, 179);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 22);
            this.bt_them.TabIndex = 94;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // tbtk
            // 
            this.tbtk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbtk.Location = new System.Drawing.Point(169, 101);
            this.tbtk.Name = "tbtk";
            this.tbtk.Size = new System.Drawing.Size(100, 20);
            this.tbtk.TabIndex = 93;
            this.tbtk.TextChanged += new System.EventHandler(this.tbtk_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-2, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 91;
            this.label6.Text = "Từ Khóa Tìm Kiếm ";
            // 
            // dgv_tl
            // 
            this.dgv_tl.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dgv_tl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_tl.Location = new System.Drawing.Point(0, 231);
            this.dgv_tl.Name = "dgv_tl";
            this.dgv_tl.Size = new System.Drawing.Size(604, 219);
            this.dgv_tl.TabIndex = 83;
            this.dgv_tl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tl_CellClick);
            this.dgv_tl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tl_CellClick);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(2, 138);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 23);
            this.bt_sua.TabIndex = 88;
            this.bt_sua.Text = "Sửa Thể Loại";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // tb_ttl
            // 
            this.tb_ttl.Location = new System.Drawing.Point(125, 35);
            this.tb_ttl.Name = "tb_ttl";
            this.tb_ttl.Size = new System.Drawing.Size(179, 24);
            this.tb_ttl.TabIndex = 87;
            this.tb_ttl.Text = "";
            // 
            // tb_mtl
            // 
            this.tb_mtl.Location = new System.Drawing.Point(125, 5);
            this.tb_mtl.Name = "tb_mtl";
            this.tb_mtl.Size = new System.Drawing.Size(104, 24);
            this.tb_mtl.TabIndex = 86;
            this.tb_mtl.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 85;
            this.label2.Text = "Tên Thể Loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 84;
            this.label1.Text = "Mã Thể Loại";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DoAn1_QuanLy_BaoKhoaHoc.Properties.Resources.the_loai;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(422, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 119);
            this.panel2.TabIndex = 90;
            // 
            // QLTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.tbtk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_tl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.tb_ttl);
            this.Controls.Add(this.tb_mtl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QLTheLoai";
            this.Text = "QLTheLoai";
            this.Load += new System.EventHandler(this.QLTheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox tbtk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_tl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.RichTextBox tb_ttl;
        private System.Windows.Forms.RichTextBox tb_mtl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}