
namespace App_BDS_201
{
    partial class Form2
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nsinh = new System.Windows.Forms.Label();
            this.luong1 = new System.Windows.Forms.Label();
            this.stk1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmnd1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.mnv = new System.Windows.Forms.TextBox();
            this.ns = new System.Windows.Forms.TextBox();
            this.cmnd = new System.Windows.Forms.TextBox();
            this.luong = new System.Windows.Forms.TextBox();
            this.stk = new System.Windows.Forms.TextBox();
            this.mcn = new System.Windows.Forms.TextBox();
            this.day = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(776, 211);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // nsinh
            // 
            this.nsinh.AutoSize = true;
            this.nsinh.Location = new System.Drawing.Point(32, 323);
            this.nsinh.Name = "nsinh";
            this.nsinh.Size = new System.Drawing.Size(71, 17);
            this.nsinh.TabIndex = 1;
            this.nsinh.Text = "Ngày sinh";
            // 
            // luong1
            // 
            this.luong1.AutoSize = true;
            this.luong1.Location = new System.Drawing.Point(32, 408);
            this.luong1.Name = "luong1";
            this.luong1.Size = new System.Drawing.Size(48, 17);
            this.luong1.TabIndex = 1;
            this.luong1.Text = "Lương";
            // 
            // stk1
            // 
            this.stk1.AutoSize = true;
            this.stk1.Location = new System.Drawing.Point(266, 278);
            this.stk1.Name = "stk1";
            this.stk1.Size = new System.Drawing.Size(87, 17);
            this.stk1.TabIndex = 1;
            this.stk1.Text = "Số tài khoản";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mã chi nhánh";
            // 
            // cmnd1
            // 
            this.cmnd1.AutoSize = true;
            this.cmnd1.Location = new System.Drawing.Point(32, 365);
            this.cmnd1.Name = "cmnd1";
            this.cmnd1.Size = new System.Drawing.Size(48, 17);
            this.cmnd1.TabIndex = 1;
            this.cmnd1.Text = "CMND";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(637, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tìm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(522, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(637, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Thêm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // mnv
            // 
            this.mnv.Location = new System.Drawing.Point(132, 278);
            this.mnv.Name = "mnv";
            this.mnv.Size = new System.Drawing.Size(100, 22);
            this.mnv.TabIndex = 6;
            // 
            // ns
            // 
            this.ns.Location = new System.Drawing.Point(132, 323);
            this.ns.Name = "ns";
            this.ns.Size = new System.Drawing.Size(100, 22);
            this.ns.TabIndex = 7;
            // 
            // cmnd
            // 
            this.cmnd.Location = new System.Drawing.Point(132, 365);
            this.cmnd.Name = "cmnd";
            this.cmnd.Size = new System.Drawing.Size(100, 22);
            this.cmnd.TabIndex = 8;
            // 
            // luong
            // 
            this.luong.Location = new System.Drawing.Point(132, 408);
            this.luong.Name = "luong";
            this.luong.Size = new System.Drawing.Size(100, 22);
            this.luong.TabIndex = 9;
            // 
            // stk
            // 
            this.stk.Location = new System.Drawing.Point(369, 278);
            this.stk.Name = "stk";
            this.stk.Size = new System.Drawing.Size(100, 22);
            this.stk.TabIndex = 10;
            // 
            // mcn
            // 
            this.mcn.Location = new System.Drawing.Point(369, 334);
            this.mcn.Name = "mcn";
            this.mcn.Size = new System.Drawing.Size(100, 22);
            this.mcn.TabIndex = 11;
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(369, 382);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(100, 22);
            this.day.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(284, 415);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Nhập lại";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.day);
            this.Controls.Add(this.mcn);
            this.Controls.Add(this.stk);
            this.Controls.Add(this.luong);
            this.Controls.Add(this.cmnd);
            this.Controls.Add(this.ns);
            this.Controls.Add(this.mnv);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmnd1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.stk1);
            this.Controls.Add(this.luong1);
            this.Controls.Add(this.nsinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nsinh;
        private System.Windows.Forms.Label luong1;
        private System.Windows.Forms.Label stk1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label cmnd1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox mnv;
        private System.Windows.Forms.TextBox ns;
        private System.Windows.Forms.TextBox cmnd;
        private System.Windows.Forms.TextBox luong;
        private System.Windows.Forms.TextBox stk;
        private System.Windows.Forms.TextBox mcn;
        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.Button button5;
    }
}