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
    public partial class patient_state_modify :MetroForm
    {
       
        string inputIllness = string.Empty;
        string inputNeedOp = string.Empty;
        string inputAdvice = string.Empty;
        string patient_id = string.Empty;
        string doctor_id = string.Empty;
       /* public patient_state_modify(string did,string pid,string illness,string operation,string advice)
        {
            InitializeComponent();

            illnessTextBox.Text = illness;
            needOperationComboBox.Text = operation;
            adviceTextBox.Text = advice;

            inputAdvice = advice;
            inputIllness = illness;
            inputNeedOp = operation;
            patient_id = pid;
            doctor_id = did;
        }*/
        public patient_state_modify(string did,string pid)
        { InitializeComponent();
            doctor_id = did;
            patient_id = pid;
        }

        

        

        private void skinButton_modify_Click(object sender, EventArgs e)
        {

            inputAdvice = skinTextBox_advice.Text;
            inputIllness = skinTextBox_illness.Text;
            inputNeedOp = skinComboBox_need_operation.Text;
            if (inputAdvice == String.Empty || inputIllness == String.Empty || inputNeedOp == String.Empty)
            {
                MessageBox.Show("必要的信息不能为空");
                return;
            }
            doctor_admin dcad = new doctor_admin();
            dcad.patient_state_modify(doctor_id, patient_id, inputIllness, inputNeedOp, inputAdvice);
            MessageBox.Show("修改成功，结果已保存");
            this.Close();
            patient_list temp = new patient_list(doctor_id);
            temp.Show();
        }

        private void skinButton_back_Click(object sender, EventArgs e)
        {
            this.Close();
            patient_list temp = new patient_list(doctor_id);
            temp.Show();
        }
    }
}
