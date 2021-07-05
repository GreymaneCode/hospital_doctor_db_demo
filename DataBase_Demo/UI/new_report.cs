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
    public partial class new_report : MetroForm
    {
        doctor_admin dcad = new doctor_admin();
        string oper_id = string.Empty;
        string doctor_id = string.Empty;
        public new_report(string operid, string did)
        {
            InitializeComponent();
            oper_id = operid;
            doctor_id = did;
            skinnewreportshow();
        }

        private void skinnewreportshow()
        {
            skinidTextBox.Text = oper_id;
            skinidTextBox.ReadOnly = true;
        }
                    
        private void skinreturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinsubmitButton_Click_1(object sender, EventArgs e)
        {          
            string reporttext = skinreportTextBox.Text;
            if (reporttext == String.Empty)
            {
                MessageBox.Show("必要的信息不能为空");
                return;
            }
            //在这里调查询报告的函数，然后判断它的数量，如果不为0，调删除函数                              
            int rowcount = dcad.get_report_num(oper_id);
            if (rowcount != 0)
            {
                //删除原记录
                dcad.delete_report(oper_id);
            }
            dcad.oper_report_add(doctor_id, oper_id, reporttext);
            MessageBox.Show("报告提交成功，结果已保存");

            this.Close();
        }

        

    }
}
