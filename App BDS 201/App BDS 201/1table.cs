using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace App_BDS_201
{

    public partial class Form2 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=SANGPHAM\SQLEXPRESS;Initial Catalog=CONG_TY;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter adpter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM NHAN_VIEN";
            adpter.SelectCommand = command;
            table.Clear();
            adpter.Fill(table);
            dgv.DataSource = table;

        }
        public Form2()
        {
            InitializeComponent();
        }

        private void dgv_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            bool a = false;
            for (i = 0; i < dgv.Rows.Count - 1; i++)
            {

                if (mnv.Text == dgv.Rows[i].Cells[0].Value.ToString())
                {
                    a = true;
                    break;
                }


            }

            if (a)
            {
                try
                {
                    command = connection.CreateCommand();
                    command.CommandText = "DELETE NHAN_VIEN WHERE MA_NHAN_VIEN = " + mnv.Text;
                    command.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Thành công");
                }
                catch
                {
                    MessageBox.Show("Không thể xóa thông tin này", "Lỗi ràng buộc",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Mã nhân viên không tồn tại", "Dữ liệu nhập vào lỗi",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = dgv.CurrentRow.Index;
            mnv.Text = dgv.Rows[i].Cells[0].Value.ToString();
            day.Text = dgv.Rows[i].Cells[1].Value.ToString();
            ns.Text = dgv.Rows[i].Cells[2].Value.ToString();
            luong.Text = dgv.Rows[i].Cells[3].Value.ToString();
            stk.Text = dgv.Rows[i].Cells[4].Value.ToString();
            mcn.Text = dgv.Rows[i].Cells[5].Value.ToString();
            cmnd.Text = dgv.Rows[i].Cells[6].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int len = mnv.TextLength;
            bool a = false;
            bool b = false;
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                if (mnv.Text == dgv.Rows[i].Cells[0].Value.ToString())
                {
                    a = true;
                    break;
                }
            }
            for (int j = 1; j < dgv.Rows.Count - 1; j++)
            {
                if (mcn.Text == dgv.Rows[j].Cells[5].Value.ToString() || mcn.Text == "")
                {
                    b = true;
                    break;
                }
            }
            DateTime myDate = DateTime.ParseExact(day.Text, "dd-mm-yyyy",
                                     System.Globalization.CultureInfo.InvariantCulture);
            TimeSpan Time = DateTime.Now - myDate;


            if (!a && len == 6)
            {
                if (b)
                {
                    if (Time.Days >= 0)
                    {
                        command.Connection.CreateCommand();
                        command.CommandText = "INSERT NHAN_VIEN VALUES ('" + mnv.Text + "','" + day.Text + "','" + ns.Text + "','" + luong.Text + "','" + stk.Text + "','" + mcn.Text + "','" + cmnd.Text + "')";
                        command.ExecuteNonQuery();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Thời gian bắt đầu làm phải trước hiện tại", "Dữ liệu nhập vào lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                }
                else MessageBox.Show("Không tìm thấy mã chi nhánh", "Dữ liệu nhập vào lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else MessageBox.Show("Mã nhân viên đã tồn tại hoặc nhập vào sai (6 ký tự)", "Dữ liệu nhập vào lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mnv.Clear();
            ns.Clear();
            day.Clear();
            stk.Clear();
            cmnd.Clear();
            luong.Clear();
            mcn.Clear();

            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM NHAN_VIEN";
            adpter.SelectCommand = command;
            table.Clear();
            adpter.Fill(table);
            dgv.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool a = false;
            bool b = false;
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {

                if (mnv.Text == dgv.Rows[i].Cells[0].Value.ToString())
                {
                    a = true;
                    break;
                }
            }

            for (int j = 1; j < dgv.Rows.Count - 1; j++)
            {

                if (mcn.Text == dgv.Rows[j].Cells[5].Value.ToString() || mcn.Text == "")
                {
                    b = true;
                    break;
                }
            }

            DateTime myDate = DateTime.ParseExact(day.Text, "dd-mm-yyyy",
                                      System.Globalization.CultureInfo.InvariantCulture);
            TimeSpan Time = DateTime.Now - myDate;
            if (a)
            {
                if (b || mcn.Text == "")
                {
                    if (Time.Days >= 0)
                    {
                        try
                        {
                            command.Connection.CreateCommand();
                            command.CommandText = "UPDATE NHAN_VIEN SET [NGAY_BAT_DAU_LAM_VIEC] = '" + day.Text + "',[NGAY_SINH] ='" + ns.Text + "',[LUONG] = " + luong.Text + ",[SO_TAI_KHOAN] ='" + stk.Text + "',[CN_MA_CHI_NHANH] ='" + mcn.Text + "',[CMND] = '" + cmnd.Text + "' where [MA_NHAN_VIEN] = '" + mnv.Text + "'";
                            command.ExecuteNonQuery();
                            LoadData();
                            MessageBox.Show("Thành công");
                        }
                        catch
                        {
                            MessageBox.Show("Sai định dạng ngày: yyyy/mm/dd ", "Dữ liệu nhập vào lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thời gian bắt đầu làm phải trước hiện tại", "Dữ liệu nhập vào lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("Mã chi nhánh không tồn tại", "Dữ liệu nhập vào lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Mã nhân viên không tồn tại", "Dữ liệu nhập vào lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
        } // sua
        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            bool a = false;
            for (i = 0; i < dgv.Rows.Count - 1; i++)
            {



                if (mnv.Text == dgv.Rows[i].Cells[0].Value.ToString())
                {
                    a = true;
                    break;
                }

            }
            if (a)
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM NHAN_VIEN where [MA_NHAN_VIEN] = '" + mnv.Text + "'";
                adpter.SelectCommand = command;
                table.Clear();
                adpter.Fill(table);
                dgv.DataSource = table;
            }
            else MessageBox.Show("Mã nhân viên không tồn tại", "Dữ liệu nhập vào lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}