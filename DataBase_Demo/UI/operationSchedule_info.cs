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
    public partial class operationSchedule_info : MetroForm
    {
        doctor_admin dcad = new doctor_admin();
        string doctor_id = string.Empty;

        public operationSchedule_info(string inputId)
        {
            InitializeComponent();
            doctor_id = inputId;
            skinComboBox1.SelectedIndex = 0;
            displayOperScheInfo(doctor_id, 1);
        }

        private void displayOperScheInfo(string id,int timestage)
        {
            try
            {
                DataSet ds = new DataSet();
                OracleDataAdapter adapt_x = new OracleDataAdapter();
                adapt_x = dcad.get_oper_info(id, timestage);
                adapt_x.Fill(ds, "OPERSCHE_INFO");
                skinDataGridView_operation_info.DataSource = ds.Tables["OPERSCHE_INFO"];
                int rowcount = skinDataGridView_operation_info.Rows.Count;
                for (int k = 0; k < rowcount; k++)
                {
                    string str= string.Empty;
                    str = skinDataGridView_operation_info.Rows[k].Cells["op_sec_id_col"].Value.ToString();
                    if (str == "1")
                        skinDataGridView_operation_info.Rows[k].Cells["op_sec_id_col"].Value = "8:00-10:00";
                    if (str == "2")
                        skinDataGridView_operation_info.Rows[k].Cells["op_sec_id_col"].Value = "10:00-12:00";
                    if (str == "3")
                        skinDataGridView_operation_info.Rows[k].Cells["op_sec_id_col"].Value = "13:00-15:00";
                    if (str == "4")
                        skinDataGridView_operation_info.Rows[k].Cells["op_sec_id_col"].Value = "15:00-17:00";
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                throw new Exception(ex.Message);
            }
        }
           
        private void skin_backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int timestage = skinComboBox1.SelectedIndex;
            if (skinComboBox1.SelectedIndex == 0)
                timestage = 1;
            else
                timestage = 2;
            displayOperScheInfo(doctor_id,timestage);
        }
    }
}
