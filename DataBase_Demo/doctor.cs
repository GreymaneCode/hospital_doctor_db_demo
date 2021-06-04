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
//第一层
namespace DataBase_Demo
{
    public partial class doctor : Form
    {
        String inputId = string.Empty;
        String inputPasswd = string.Empty;
        doctor_admin dcform = new doctor_admin();
        public doctor()
        {
            InitializeComponent();
        }

        private void doctor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(login())
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Failed");
                //1234
            }

        }
        private bool login()
        {
            inputId = idTextBox.Text;
            inputPasswd = passwdTextBox.Text;
            try
            {
                DataSet ds = new DataSet();
                OracleDataAdapter adapt_x = new OracleDataAdapter();
                adapt_x = dcform.get_doc_passwd(idTextBox.Text);
                adapt_x.Fill(ds, "DOC_PASSWD");

                int dataCount = ds.Tables["DOC_PASSWD"].Rows.Count;//table中的纪录总数

                if (dataCount == 1)
                {
                    DataTable pswd_table = ds.Tables["DOC_PASSWD"];
                    DataRow row = pswd_table.Rows[0];
                    string doc_passwd = row["doctor_password"].ToString();
                    if (passwdTextBox.Text == doc_passwd)
                    {
                        return true;
                    }
                    else
                    {
                        //有账户，但是密码错了
                        return false;
                    }
                }
                else //查无此人
                {
                    return false;
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}
