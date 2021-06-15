using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace DataBase_Demo
{
    public partial class prescribe_add : MetroForm
    {
        string patient_id = string.Empty;
        string doctor_id = string.Empty;
        
        public prescribe_add(string pid,string did)
        {
            InitializeComponent();
            patient_id = pid;
            doctor_id = did;
        }

        private void skinButton_confirm_Click(object sender, EventArgs e)
        {
            string medicineName = skinComboBox_medicine_name.Text;
            string medicineUnit = skinTextBox_unit.Text;
            string medicineDose = skinComboBox_dose.Text;
            if (medicineName == String.Empty || medicineUnit == String.Empty || medicineDose == string.Empty)
            {
                MessageBox.Show("必要的信息不能为空");
                return;
            }
            doctor_admin dcad = new doctor_admin();

            if (dcad.prescribe_add(doctor_id, patient_id, dcad.get_medicine_id(medicineName), medicineDose, medicineUnit))
            {
                MessageBox.Show("开药成功，结果已保存");
                this.Close();
                patient_list temp = new patient_list(doctor_id);
                temp.Show();
            }
            else { MessageBox.Show("请输入1-1000的整数");
                this.Close();
                patient_list temp = new patient_list(doctor_id);
                temp.Show();
            }
        }

        private void skinButton_back_Click(object sender, EventArgs e)
        {
            this.Close();
            patient_list temp = new patient_list(doctor_id);
            temp.Show();
        }

       
    }
}
