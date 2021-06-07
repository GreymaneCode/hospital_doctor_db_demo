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
        public doctor_info(string id)
        {
            InitializeComponent();
            try
            {
                DataSet ds = new DataSet();
                OracleDataAdapter adapt_x = new OracleDataAdapter();
                adapt_x = dcad.get_doc_info(id);
                adapt_x.Fill(ds, "t");
                dataGridView_doctor_info.DataSource = ds.Tables["t"];
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
