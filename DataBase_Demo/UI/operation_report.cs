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
    public partial class operation_report : MetroForm
    {
        doctor_admin dcad = new doctor_admin();
        string oper_id = string.Empty;
        string doctor_id = string.Empty;
        int showchoice;
        public operation_report(string operid, string did, int choice)
        {
            InitializeComponent();
            oper_id = operid;
            doctor_id = did;
            showchoice = choice;
            skinskinreportTextBox_show();            
        }
      
        void skinskinreportTextBox_show()
        {
            try
            {               
                DataSet ds = new DataSet();
                OracleDataAdapter adapt_x = new OracleDataAdapter();
                adapt_x = dcad.get_report(oper_id);
                adapt_x.Fill(ds, "REPORT_INFO");
                skinreportdataGridView.DataSource = ds.Tables["REPORT_INFO"];
                int rowcount1 = skinreportdataGridView.Rows.Count;
                string str = string.Empty;
                
                for (int k = 0; k < rowcount1; k++)
                {
                    str = skinreportdataGridView.Rows[k].Cells["conclusion_col"].Value.ToString();
                    skinreportTextBox.Text = str;
                    skinreportdataGridView.Rows[k].Cells["conclusion_col"].Value = "已提交过报告";
                }
                if (showchoice == 1)
                    skinreportTextBox.ReadOnly = true;
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                throw new Exception(ex.Message);
            }
        }     
  
        private void skinsubmitButton_Click(object sender, EventArgs e)
        {
            if(showchoice==0)
            {
                //插之前应该先查一下是不是已经有数据了，有要删掉、、、
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

        private void skinbackbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
