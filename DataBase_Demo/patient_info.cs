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
        public patient_info(OracleDataAdapter adapter)
        {
            InitializeComponent();
            try
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds, "t");
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
                MessageBox.Show("请选择一条病人的信息以修改");
                return;
            }
            int inx = dataGridView_patient_info.CurrentRow.Index;
            string id = dataGridView_patient_info.Rows[inx].Cells["patient_id"].Value.ToString();
            
        }
    }
}
