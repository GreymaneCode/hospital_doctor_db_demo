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
    public partial class doctor_menu : MetroForm
    {
        String inputID = string.Empty;
        doctor_admin dcad = new doctor_admin();
        public doctor_menu(string id)
        {
            InitializeComponent();
            inputID = id;
        }       

        private void skindoctorInfoButton_Click(object sender, EventArgs e)
        {
            //查看个人信息
            doctor_info doctor_info_form = new doctor_info(inputID);
            doctor_info_form.Show();
        }

        private void skinpatientInfoButton_Click(object sender, EventArgs e)
        {
            //查看病人信息
            patient_list patient_list_form = new patient_list(inputID);
            patient_list_form.Show();
        }

        private void skinoperationScheduleButton_Click(object sender, EventArgs e)
        {
            //查看手术安排          
            operationSchedule_info operation_info_form = new operationSchedule_info(inputID);
            operation_info_form.Show();
        }

        private void skinoperationReportButton_Click(object sender, EventArgs e)
        {
            //上传手术报告
            operation_info oper_info_form = new operation_info(inputID);
            oper_info_form.Show();
        }

        private void skinexitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}
