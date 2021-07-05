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
    public partial class operation_info : MetroForm
    {
        doctor_admin dcad = new doctor_admin();      
        string doctor_id = string.Empty;
        public operation_info(string inputId)
        {
            InitializeComponent();
            doctor_id = inputId;
            displayOperInfo(doctor_id);
        }

        private void displayOperInfo(string id)
        {
            try
            {
                DataSet ds = new DataSet();
                OracleDataAdapter adapt_x = new OracleDataAdapter();
                adapt_x = dcad.get_oper_info(id, 2);
                adapt_x.Fill(ds, "OPER_INFO");
                skindataGridView_oper_info.DataSource = ds.Tables["OPER_INFO"];
                int rowcount = skindataGridView_oper_info.Rows.Count;
                
                for (int k = 0; k < rowcount; k++)
                {
                    string str = string.Empty;
                    str = skindataGridView_oper_info.Rows[k].Cells["op_sec_id_col"].Value.ToString();
                    if (str == "1")
                        skindataGridView_oper_info.Rows[k].Cells["op_sec_id_col"].Value = "8:00-10:00";
                    if (str == "2")
                        skindataGridView_oper_info.Rows[k].Cells["op_sec_id_col"].Value = "10:00-12:00";
                    if (str == "3")
                        skindataGridView_oper_info.Rows[k].Cells["op_sec_id_col"].Value = "13:00-15:00";
                    if (str == "4")
                        skindataGridView_oper_info.Rows[k].Cells["op_sec_id_col"].Value = "15:00-17:00";
                }
                
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                throw new Exception(ex.Message);
            }
        }

        private void skinbackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinaddreportbutton_Click(object sender, EventArgs e)
        {
            int count_row = skindataGridView_oper_info.RowCount;
            int select_count = 0;
            for (int i = 0; i < count_row; i++)
            {
                DataGridViewCheckBoxCell checkCell = new DataGridViewCheckBoxCell();
                checkCell = (DataGridViewCheckBoxCell)skindataGridView_oper_info.Rows[i].Cells["reportcheckbox"];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                    select_count++;

            }
            if (select_count != 1)
            {
                MessageBox.Show("请选择一条数据的手术，编辑报告");
                return;
            }
            for (int i = 0; i < count_row; i++)
            {
                DataGridViewCheckBoxCell checkCell = new DataGridViewCheckBoxCell();
                checkCell = (DataGridViewCheckBoxCell)skindataGridView_oper_info.Rows[i].Cells["reportcheckbox"];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                {
                    string operation_id;
                    operation_id = skindataGridView_oper_info.Rows[i].Cells["operation_id_col"].Value.ToString();

                    int rowcount = dcad.get_report_num(operation_id);

                    if (rowcount == 1)
                    {                      
                        operation_report opereport = new operation_report(operation_id, doctor_id, 0);
                        opereport.Show();
                    }
                    else
                    {
                        new_report tempnew = new new_report(operation_id, doctor_id);
                        tempnew.Show();
                    }                                     
                }
            }
        }

        private void skinviewreportButton_Click(object sender, EventArgs e)
        {
            int count_row = skindataGridView_oper_info.RowCount;
            int select_count = 0;
            for (int i = 0; i < count_row; i++)
            {
                DataGridViewCheckBoxCell checkCell = new DataGridViewCheckBoxCell();
                checkCell = (DataGridViewCheckBoxCell)skindataGridView_oper_info.Rows[i].Cells["reportcheckbox"];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                    select_count++;

            }
            if (select_count != 1)
            {
                MessageBox.Show("请选择一条数据的手术，查看报告");
                return;
            }
            for (int i = 0; i < count_row; i++)
            {
                DataGridViewCheckBoxCell checkCell = new DataGridViewCheckBoxCell();
                checkCell = (DataGridViewCheckBoxCell)skindataGridView_oper_info.Rows[i].Cells["reportcheckbox"];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                {
                    string operation_id;
                    operation_id = skindataGridView_oper_info.Rows[i].Cells["operation_id_col"].Value.ToString();
                    int rowcount = dcad.get_report_num(operation_id);
                    if (rowcount == 1)
                    {                       
                        operation_report opereport = new operation_report(operation_id, doctor_id, 1);
                        opereport.Show();
                    }
                    else
                    {
                        MessageBox.Show("尚未给该手术添加过手术报告，无法查看！");
                        return;
                    }                   
                }
            }
        }
    }
}
