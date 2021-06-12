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
    public partial class operation_info : Form
    {
        doctor_admin dcad = new doctor_admin();
        string doctor_id = string.Empty;
        public operation_info(string inputId)
        {
            InitializeComponent();
            doctor_id = inputId;
            displayOperInfo(doctor_id);
        }

        private void displayOperInfo(string id)
        {
            try
            {
                DataSet ds = new DataSet();
                OracleDataAdapter adapt_x = new OracleDataAdapter();
                adapt_x = dcad.get_oper_info(id, 2);
                adapt_x.Fill(ds, "OPER_INFO");
                dataGridView_oper_info.DataSource = ds.Tables["OPER_INFO"];
                int rowcount = dataGridView_oper_info.Rows.Count;
                
                for (int k = 0; k < rowcount; k++)
                {
                    string str = string.Empty;
                    str = dataGridView_oper_info.Rows[k].Cells["op_sec_id_col"].Value.ToString();
                    if (str == "1")
                        dataGridView_oper_info.Rows[k].Cells["op_sec_id_col"].Value = "8:00-10:00";
                    if (str == "2")
                        dataGridView_oper_info.Rows[k].Cells["op_sec_id_col"].Value = "10:00-12:00";
                    if (str == "3")
                        dataGridView_oper_info.Rows[k].Cells["op_sec_id_col"].Value = "13:00-15:00";
                    if (str == "4")
                        dataGridView_oper_info.Rows[k].Cells["op_sec_id_col"].Value = "15:00-17:00";
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                throw new Exception(ex.Message);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addreportbutton_Click(object sender, EventArgs e)
        {
            int count_row = dataGridView_oper_info.RowCount;
            int select_count = 0;
            for (int i = 0; i < count_row; i++)
            {
                DataGridViewCheckBoxCell checkCell = new DataGridViewCheckBoxCell();
                checkCell = (DataGridViewCheckBoxCell)dataGridView_oper_info.Rows[i].Cells["reportcheckbox"];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                    select_count++;

            }
            if (select_count != 1)
            {
                MessageBox.Show("请选择一条数据的手术，写报告");
                return;
            }
            for (int i = 0; i < count_row; i++)
            {
                DataGridViewCheckBoxCell checkCell = new DataGridViewCheckBoxCell();
                checkCell = (DataGridViewCheckBoxCell)dataGridView_oper_info.Rows[i].Cells["reportcheckbox"];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                {
                    string operation_id;
                    operation_id = dataGridView_oper_info.Rows[i].Cells["operation_id_col"].Value.ToString();
                    operation_report opereport = new operation_report(operation_id, doctor_id);
                    opereport.Show();
                }
            }
        }
    }
}
