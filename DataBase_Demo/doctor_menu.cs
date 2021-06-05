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
    public partial class doctor_menu : Form
    {
        String inputID = string.Empty;
        doctor_admin dcad = new doctor_admin();
        public doctor_menu(string id)
        {
            InitializeComponent();
            inputID = id;
        }

        private void doctorInfoButton_Click(object sender, EventArgs e)
        {
            doctor_info doctor_info_form = new doctor_info(displayDoctorInfo(inputID));
            doctor_info_form.Show();
        }

        private void operationScheduleButton_Click(object sender, EventArgs e)
        {

        }

        private void patientInfoButton_Click(object sender, EventArgs e)
        {
            patient_info patient_info_form = new patient_info(displayPatientInfo(inputID));
            patient_info_form.Show();
        }

        private void operationReportButton_Click(object sender, EventArgs e)
        {

        }

        private OracleDataAdapter displayDoctorInfo(string id)
        {
            try
            {
                DataSet ds = new DataSet();
                OracleDataAdapter adapt_x = new OracleDataAdapter();
                adapt_x = dcad.get_doc_info(id);
                return adapt_x;
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                throw new Exception(ex.Message);
            }       
        }
        private OracleDataAdapter displayPatientInfo(string id)
        {
            try
            {
                DataSet ds = new DataSet();
                OracleDataAdapter adapt_x = new OracleDataAdapter();
                adapt_x = dcad.get_patient_info(id);
                return adapt_x;
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                throw new Exception(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}
