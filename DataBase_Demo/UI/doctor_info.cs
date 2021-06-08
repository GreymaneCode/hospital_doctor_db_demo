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
    public partial class doctor_info : Form
    {
        
        doctor_admin dcad = new doctor_admin();
        Boolean flag_show_password = false;

        //String doctor_name = string.Empty;
        //String doctor_password = string.Empty;
        //String doctor_id_query = string.Empty;
        //String doctor_dept = string.Empty;
        //String doctor_title = string.Empty;
        //String doctor_phone_number = string.Empty;
        
        public doctor_info(string id)
        {
            InitializeComponent();
            make_query(id);
            
        }

        public void make_query(string id)
        {
            try
            {
                DataSet ds = new DataSet();
                OracleDataAdapter adapt_x = new OracleDataAdapter();
                adapt_x = dcad.get_doc_info(id);
                adapt_x.Fill(ds, "t");
                int dataCount = ds.Tables["t"].Rows.Count;//table中的纪录总数
                //dataGridView_doctor_info.DataSource = ds.Tables["t"];
                DataTable doc_table = ds.Tables["t"];
                DataRow row = doc_table.Rows[0];
                show_info(row);
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                throw new Exception(ex.Message);
            }

        }

        public void show_info(DataRow row)
        {
            doctor_name_query_label.Text = row["doctor_name"].ToString();
            doctor_id_query_label.Text = row["doctor_id"].ToString();
            doctor_dept_query_label.Text = row["dept_name"].ToString();
            doctor_title_query_label.Text = row["title"].ToString();
            phone_num_query_label.Text = row["phone_number"].ToString();
            
            passwd_query_textBox.Text = row["doctor_password"].ToString();
            passwd_query_textBox.UseSystemPasswordChar = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flag_passwd_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(flag_passwd_checkBox.Checked)
            {
                passwd_query_textBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwd_query_textBox.UseSystemPasswordChar = true; ;

            }
        }
    }
}
