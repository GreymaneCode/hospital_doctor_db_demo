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
    public partial class operationSchedule_info : Form
    {
        doctor_admin dcad = new doctor_admin();
        string doctor_id = string.Empty;

        public operationSchedule_info(string inputId)
        {
            InitializeComponent();
            doctor_id = inputId;
            displayOperScheInfo(doctor_id);
        }

        private void displayOperScheInfo(string id)
        {
            try
            {
                DataSet ds = new DataSet();
                OracleDataAdapter adapt_x = new OracleDataAdapter();
                adapt_x = dcad.get_oper_info(id,1);
                adapt_x.Fill(ds, "OPERSCHE_INFO");
                dataGridView_operation_info.DataSource = ds.Tables["OPERSCHE_INFO"];
                int rowcount = dataGridView_operation_info.Rows.Count;
                for (int k = 0; k < rowcount; k++)
                {
                    string str= string.Empty;
                    str = dataGridView_operation_info.Rows[k].Cells["op_sec_id_col"].Value.ToString();
                    if (str == "1") 
                        dataGridView_operation_info.Rows[k].Cells["op_sec_id_col"].Value = "8:00-10:00";
                    if (str == "2") 
                        dataGridView_operation_info.Rows[k].Cells["op_sec_id_col"].Value = "10:00-12:00";
                    if (str == "3") 
                        dataGridView_operation_info.Rows[k].Cells["op_sec_id_col"].Value = "13:00-15:00";
                    if (str == "4") 
                        dataGridView_operation_info.Rows[k].Cells["op_sec_id_col"].Value = "15:00-17:00";
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

    }
}
