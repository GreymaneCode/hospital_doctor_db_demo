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
        public operationSchedule_info()
        {
            InitializeComponent();
        }

        public operationSchedule_info(OracleDataAdapter adapter)
        {
            InitializeComponent();
            try
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds, "operscheinfo");
                dataGridView_operation_info.DataSource = ds.Tables["operscheinfo"];
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
