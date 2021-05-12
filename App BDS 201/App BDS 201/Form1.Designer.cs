
namespace App_BDS_201
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
            this.displayTable = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayTable
            // 
            this.displayTable.Location = new System.Drawing.Point(131, 151);
            this.displayTable.Name = "displayTable";
            this.displayTable.Size = new System.Drawing.Size(182, 98);
            this.displayTable.TabIndex = 0;
            this.displayTable.Text = "Thông tin nhân viên";
            this.displayTable.UseVisualStyleBackColor = true;
            this.displayTable.Click += new System.EventHandler(this.displayTable_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 94);
            this.button1.TabIndex = 1;
            this.button1.Text = "Bảng nhân viên và thông tin cá nhân";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản Lý Nhân Viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.displayTable);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Điều khiển";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

