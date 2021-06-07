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
    public partial class patient_info : Form
    {
        doctor_admin dcad = new doctor_admin();
        public patient_info(string id)
        {
            InitializeComponent();
            try
            {
                DataSet ds = new DataSet();
                OracleDataAdapter adapt_x = new OracleDataAdapter();
                adapt_x = dcad.get_patient_info(id);
                adapt_x.Fill(ds, "t");
                dataGridView_patient_info.DataSource = ds.Tables["t"];
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

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (dataGridView_patient_info.SelectedRows.Count != 1)
            {
                MessageBox.Show("请选择一条病人以修改");
                return;
            }
            int inx = dataGridView_patient_info.CurrentRow.Index;
            string id = dataGridView_patient_info.Rows[inx].Cells["patient_id"].Value.ToString();
            patient_state_modify paient_state_modify_form = new patient_state_modify(inx,id);
            paient_state_modify_form.Show();
        }

        private void prescribeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView_patient_info.SelectedRows.Count != 1)
            {
                MessageBox.Show("请选择一条病人以修改");
                return;
            }
            int inx = dataGridView_patient_info.CurrentRow.Index;
            string id = dataGridView_patient_info.Rows[inx].Cells["patient_id"].Value.ToString();
            prescribe_add prescribe_add_form = new prescribe_add(inx,id);
            prescribe_add_form.Show();
        }
    }
}
