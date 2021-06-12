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

namespace DataBase_Demo
{
    public partial class operation_report : Form
    {
        doctor_admin dcad = new doctor_admin();
        string oper_id = string.Empty;
        string doctor_id = string.Empty;

        public operation_report(string operid, string did)
        {
            InitializeComponent();
            oper_id = operid;
            doctor_id = did;
            reporttextbox_show();
        }

       

        void reporttextbox_show()
        {
            try
            {
                DataSet ds = new DataSet();
                OracleDataAdapter adapt_x = new OracleDataAdapter();
                adapt_x = dcad.get_report(oper_id);
                adapt_x.Fill(ds, "REPORT_INFO");
                reportdataGridView.DataSource = ds.Tables["REPORT_INFO"];
                int rowcount = reportdataGridView.Rows.Count;
                string str = string.Empty;
                for (int k = 0; k < rowcount; k++)
                {
                    str = reportdataGridView.Rows[k].Cells["conclusion_col"].Value.ToString();
                    if (str != "")
                    {
                        reporttextBox.Text = str;
                        reportdataGridView.Rows[k].Cells["conclusion_col"].Value = "已提交过报告";
                    }
                    else
                    {
                        reportdataGridView.Rows[k].Cells["conclusion_col"].Value = "未提交过报告";
                    }
                }
                

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                throw new Exception(ex.Message);
            }
        }


        

        private void operation_report_Load(object sender, EventArgs e)
        {

        }

        private void submitbutton_Click_1(object sender, EventArgs e)
        {
            //插之前应该先查一下是不是已经有数据了，有要删掉、、、
            string reporttext = reporttextBox.Text;
            if (reporttext == String.Empty)
            {
                MessageBox.Show("必要的信息不能为空");
                return;
            }           
            //在这里调查询报告的函数，然后判断它的数量，如果不为0，调删除函数                              
            int rowcount = dcad.get_report_num(oper_id);
            if (rowcount!=0)
            {
                //删除原记录
                dcad.delete_report(oper_id);
            }
            dcad.oper_report_add(doctor_id, oper_id, reporttext);
            MessageBox.Show("报告提交成功，结果已保存");

            this.Close();
        }

        private void backbutton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reporttextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void reportdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
