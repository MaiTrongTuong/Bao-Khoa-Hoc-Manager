namespace TheLoaiNghienCuu
{
    partial class Form1
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
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.tbtk = new System.Windows.Forms.TextBox();
            this.bt_tim = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_tlnc = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_capnhat = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.tb_ttl = new System.Windows.Forms.RichTextBox();
            this.tb_mtl = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tlnc)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(360, 180);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 23);
            this.bt_luu.TabIndex = 94;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(0, 181);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 22);
            this.bt_them.TabIndex = 93;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            // 
            // tbtk
            // 
            this.tbtk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbtk.Location = new System.Drawing.Point(160, 138);
            this.tbtk.Name = "tbtk";
            this.tbtk.Size = new System.Drawing.Size(100, 20);
            this.tbtk.TabIndex = 92;
            // 
            // bt_tim
            // 
            this.bt_tim.Location = new System.Drawing.Point(279, 138);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(75, 23);
            this.bt_tim.TabIndex = 91;
            this.bt_tim.Text = "Tìm Kiếm";
            this.bt_tim.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 90;
            this.label6.Text = "Từ Khóa Tìm Kiếm ";
            // 
            // dgv_tlnc
            // 
            this.dgv_tlnc.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dgv_tlnc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tlnc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_tlnc.Location = new System.Drawing.Point(0, 231);
            this.dgv_tlnc.Name = "dgv_tlnc";
            this.dgv_tlnc.Size = new System.Drawing.Size(603, 219);
            this.dgv_tlnc.TabIndex = 81;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TheLoaiNghienCuu.Properties.Resources.theloai;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(451, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 133);
            this.panel2.TabIndex = 89;
            // 
            // bt_capnhat
            // 
            this.bt_capnhat.Location = new System.Drawing.Point(279, 180);
            this.bt_capnhat.Name = "bt_capnhat";
            this.bt_capnhat.Size = new System.Drawing.Size(75, 23);
            this.bt_capnhat.TabIndex = 88;
            this.bt_capnhat.Text = "Cập Nhật";
            this.bt_capnhat.UseVisualStyleBackColor = true;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(187, 181);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 23);
            this.bt_xoa.TabIndex = 87;
            this.bt_xoa.Text = "Xóa Nhóm";
            this.bt_xoa.UseVisualStyleBackColor = true;
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(93, 181);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 23);
            this.bt_sua.TabIndex = 86;
            this.bt_sua.Text = "Sửa Bài";
            this.bt_sua.UseVisualStyleBackColor = true;
            // 
            // tb_ttl
            // 
            this.tb_ttl.Location = new System.Drawing.Point(215, 31);
            this.tb_ttl.Name = "tb_ttl";
            this.tb_ttl.Size = new System.Drawing.Size(206, 24);
            this.tb_ttl.TabIndex = 85;
            this.tb_ttl.Text = "";
            // 
            // tb_mtl
            // 
            this.tb_mtl.Location = new System.Drawing.Point(215, 4);
            this.tb_mtl.Name = "tb_mtl";
            this.tb_mtl.Size = new System.Drawing.Size(126, 24);
            this.tb_mtl.TabIndex = 84;
            this.tb_mtl.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 83;
            this.label2.Text = "Thể Loại Nghiên Cứu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Mã Thể Loại";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.tbtk);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_tlnc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bt_capnhat);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.tb_ttl);
            this.Controls.Add(this.tb_mtl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tlnc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox tbtk;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_tlnc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_capnhat;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.RichTextBox tb_ttl;
        private System.Windows.Forms.RichTextBox tb_mtl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

