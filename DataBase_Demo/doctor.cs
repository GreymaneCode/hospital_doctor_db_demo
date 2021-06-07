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
//第一层
namespace DataBase_Demo
{
    public partial class doctor : Form
    {
        String inputId = string.Empty;
        String inputPasswd = string.Empty;
        doctor_admin dcad = new doctor_admin();
        public doctor()
        {
            InitializeComponent();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if(dcad.login(idTextBox.Text,passwdTextBox.Text))
            {
                this.Hide();
                doctor_menu doctor_menu_form = new doctor_menu(idTextBox.Text);
                doctor_menu_form.Show();
            }
            else
            {
                MessageBox.Show("Login Failed");
                Application.Restart();
            }

        }
    }
}
