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
    public partial class editPassword : MetroForm
    {
        doctor_admin_query edit_passwd_daq = new doctor_admin_query();
        string current_doctor = string.Empty;
        public editPassword(string doc_id)
        {
            InitializeComponent();
            current_doctor = doc_id;
        }

        private void confirm_sBtn_Click(object sender, EventArgs e)
        {
            if(passwd_identical()&&passwd_valid())
            {
                edit_passwd_daq.edit_passwd(current_doctor, passwd_textBox.Text);
                MessageBox.Show("修改成功");
            }
        }

        private void show_password_sCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            char c = new char();
            if (show_password_sCheckBox.Checked)
            {
                passwd_textBox.IsPasswordChat = c;
                confirm_passwd_textBox.IsPasswordChat = c;
            }
            else
            {
                passwd_textBox.IsPasswordChat = '*';
                confirm_passwd_textBox.IsPasswordChat = '*';
            }
        }

        public bool passwd_identical()
        {
            if( string.Equals(passwd_textBox.Text , confirm_passwd_textBox.Text) )
            {
                return true;
            }
            else
            {
                MessageBox.Show("密码不一致，请在检查后重新输入");
                return false;
            }
        }

        public bool passwd_valid()
        {
            if (string.IsNullOrEmpty(passwd_textBox.Text) || string.IsNullOrWhiteSpace(passwd_textBox.Text))
            {
                MessageBox.Show("密码不能为空或空格");
                return false;
            }
            else if (not_ascii(passwd_textBox.Text))
            {
                MessageBox.Show("密码非法，请输入字母或符号");
                return false;
            }
            else if (too_long(passwd_textBox.Text))
            {
                MessageBox.Show("密码长度过长，请确保在20个字符以内");
                return false;
            }
            else return true;

        }

        public bool not_ascii(string _to_judge)
        {
            foreach(char i in _to_judge)
            {
                if(i>127)
                {
                    return true;
                }
            }
            return false;
        }

        public bool too_long(string _to_judge)
        {
            if(_to_judge.Length>20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void return_sBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
