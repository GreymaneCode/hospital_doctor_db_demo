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
    public partial class patient_list : Form
    {
        doctor_admin dcad = new doctor_admin();
        string doctor_id = string.Empty;
        string patient_id = string.Empty;
        public patient_list(string did)
        {
            InitializeComponent();
            doctor_id = did;
            display(doctor_id);
        }



        private void display(string id)
        {
            try
            {
                DataSet ds = new DataSet();
                OracleDataAdapter adapt_x = new OracleDataAdapter();
                adapt_x = dcad.get_patient_list(id);
                adapt_x.Fill(ds, "t");
                dataGridView_patient_list.DataSource = ds.Tables["t"];
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                throw new Exception(ex.Message);
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            int count_row = dataGridView_patient_list.RowCount;
            int select_count = 0;
            for (int i = 0; i < count_row; i++)
            {
                DataGridViewCheckBoxCell checkCell = new DataGridViewCheckBoxCell();
                checkCell = (DataGridViewCheckBoxCell)dataGridView_patient_list.Rows[i].Cells["sel_col"];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                    select_count++;

            }
            if (select_count != 1)
            {
                MessageBox.Show("请选择一位病人");
                return;
            }
            for (int i = 0; i < count_row; i++)
            {
                DataGridViewCheckBoxCell checkCell = new DataGridViewCheckBoxCell();
                checkCell = (DataGridViewCheckBoxCell)dataGridView_patient_list.Rows[i].Cells["sel_col"];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                {

                    patient_id = dataGridView_patient_list.Rows[i].Cells["pat_id_col"].Value.ToString();


                    patient_info psm = new patient_info(doctor_id, patient_id);

                    psm.Show();
                    this.Hide();
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
