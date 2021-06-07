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
            doctor_info doctor_info_form = new doctor_info(inputID);
            doctor_info_form.Show();
        }

        private void operationScheduleButton_Click(object sender, EventArgs e)
        {

        }

        private void patientInfoButton_Click(object sender, EventArgs e)
        {
            patient_info patient_info_form = new patient_info(inputID);
            patient_info_form.Show();
        }

        private void operationReportButton_Click(object sender, EventArgs e)
        {

        }

     

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}
