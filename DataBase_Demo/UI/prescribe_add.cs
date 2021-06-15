using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Demo
{
    public partial class prescribe_add : Form
    {
        string patient_id = string.Empty;
        string doctor_id = string.Empty;
        
        public prescribe_add(string pid,string did)
        {
            InitializeComponent();
            patient_id = pid;
            doctor_id = did;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            patient_info temp = new patient_info(doctor_id,patient_id);
            temp.Show();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
           
            string medicineName = medicineNameComboBox.Text;
            string medicineUnit = unitTextBox.Text;
            string medicineDose = doseComboBox.Text;
            if (medicineName == String.Empty || medicineUnit == String.Empty||medicineDose==string.Empty )
            {
                MessageBox.Show("必要的信息不能为空");
                return;
            }
            doctor_admin dcad = new doctor_admin();
            dcad.prescribe_add(doctor_id, patient_id , dcad.get_medicine_id(medicineName), medicineDose,medicineUnit);
            MessageBox.Show("开药成功，结果已保存");
            this.Close();
            patient_info temp = new patient_info(doctor_id,patient_id);
            temp.Show();
        }

       
    }
}
