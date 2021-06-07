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
    public partial class patient_state_modify : Form
    {
        doctor_admin dcad = new doctor_admin();
        public patient_state_modify(int inx,string id)
        {
            InitializeComponent();
            string inputIllness = illnessTextBox.Text;
            string inputNeedOp = needOperationTextBox.Text;
            string inputAdvice = adviceTextBox.Text;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
