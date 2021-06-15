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
using MetroFramework.Forms;

namespace DataBase_Demo
{
    public partial class doctor_info : MetroForm
    {
        
        doctor_admin dcad = new doctor_admin();
        doctor_admin edit_info_dcad = new doctor_admin();
        string current_doctor;
        public doctor_info(string id)
        {
            InitializeComponent();
            make_query(id);
            current_doctor = id;
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
            doctor_name_skinTextBox.Text = row["doctor_name"].ToString();
            doc_id_skinTextBox.Text = row["doctor_id"].ToString();
            dept_name_skinTextBox.Text = row["dept_name"].ToString();
            title_skinTextBox.Text = row["title"].ToString();
            phone_num_skinTextBox.Text = row["phone_number"].ToString();
            passwd_query_textBox.Text = row["doctor_password"].ToString();

            passwd_query_textBox.Text = row["doctor_password"].ToString();
            
            passwd_query_textBox.UseSystemPasswordChar = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void submit_edit_sBtn_Click(object sender, EventArgs e)
        {
            int result = edit_info_dcad.edit_doc_info(doc_id_skinTextBox.Text, doctor_name_skinTextBox.Text, phone_num_skinTextBox.Text);
            if (result == 1)
            {
                MessageBox.Show("修改成功");
            }
            else if(result==-1)
            {
                MessageBox.Show("修改失败，请确保电话号码为11位数字。");
            }
            else
            {
                MessageBox.Show("修改失败，姓名仅能为1-3个中文字符。");
            }
        }


        private void return_sBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void show_passwd_skinCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (show_passwd_skinCheckBox.Checked)
            {
                passwd_query_textBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwd_query_textBox.UseSystemPasswordChar = true; ;

            }
        }

        private void edit_passwd_sBtn_Click(object sender, EventArgs e)
        {
            editPassword ePasswd = new editPassword(current_doctor);
            ePasswd.Show();
        }
    }
}
