using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DataBase_Demo
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			String sql = string.Empty;
			sql = "Select * From people where name=:name and id_num=:id_num";
			string connString = System.Configuration.ConfigurationManager.ConnectionStrings["connString"]
				.ConnectionString;
			OracleConnection conn = new OracleConnection(connString);
			try
			{
				OracleCommand cmd = new OracleCommand(sql, conn);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.Add(new OracleParameter("name", textBox1.Text));
				cmd.Parameters.Add(new OracleParameter("id_num", textBox2.Text));
				conn.Open();
				OracleDataReader dr0 = cmd.ExecuteReader();
				if(dr0.HasRows)
                {
					Form1 form1 = new Form1();
					form1.Show();
					this.Hide();
				}
				else//如果登录失败，询问是否注册新用户
				{
					DialogResult dr = MessageBox.Show("是返回登陆前界面？", "登录失败", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (dr == DialogResult.Yes)//打开注册界面
					{
						Form4 form4 = new Form4();
						form4.Show();
						this.Hide();
					}
					else
					{
						this.Show();
					}
				}
			
				/*OracleDataAdapter adapt = new OracleDataAdapter();
				adapt.SelectCommand = cmd;
				DataSet ds = new DataSet();
				adapt.Fill(ds, "t");    //第二个参数:表名，随便取
				dataGridView1.DataSource = ds.Tables["t"];*/
			//ds.Clear();

		}
			catch (OracleException ex)
			{
				MessageBox.Show(ex.Message);
				throw new Exception(ex.Message);
			}
			conn.Close();
		}
	}
    
}
