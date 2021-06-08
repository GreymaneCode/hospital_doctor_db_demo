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
        doctor_admin dcad = new doctor_admin();
        public prescribe_add(int inx,string id)
        {
            InitializeComponent();
            string medicineId = medicineIdTextBox.Text;
            string medicineName = medicineNameTextBox.Text;
            string medicineUnit = unitTextBox.Text;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
