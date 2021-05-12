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
    public partial class Form3 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=SANGPHAM\SQLEXPRESS;Initial Catalog=CONG_TY;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter adpter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = " SELECT * FROM THONG_TIN_CA_NHAN INNER JOIN NHAN_VIEN ON NHAN_VIEN.CMND = THONG_TIN_CA_NHAN.CMND";
            adpter.SelectCommand = command;
            table.Clear();
            adpter.Fill(table);
            dgv.DataSource = table;

        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }
    }
}
