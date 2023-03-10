using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySqlConexao
{
    public partial class Form1 : Form
    {
        MysqlCon mysql = new MysqlCon();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DataSet ds = mysql.Select("select * from tb_login;");
            DataTable dt = ds.Tables[0];

            foreach (DataRow dr in dt.Rows)
            {
                string l = dr["user_id"].ToString();
                string s = dr["password"].ToString();
            }

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
        }
    }
}
