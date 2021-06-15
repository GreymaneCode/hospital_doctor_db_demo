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
    public partial class patient_info : Form
    {
        doctor_admin dcad = new doctor_admin();
        string detailed_content = string.Empty;
        DetailedInfo curDetailedInfo = new DetailedInfo(string.Empty);
        string doctor_id = string.Empty;
        string patient_id = string.Empty;
        public patient_info(string did,string pid)
        {
            InitializeComponent();
            doctor_id = did;
            patient_id = pid;
            Bool_To_Text(dataGridView_patient_info, "need_operation_col", "否", "0", "是", "1");
            display(doctor_id,patient_id);
        }
        private void display(string did,string pid)
        {
            try
            {
                DataSet ds = new DataSet();
                OracleDataAdapter adapt_x = new OracleDataAdapter();
                adapt_x = dcad.get_patient_info(did,pid);
                adapt_x.Fill(ds, "t");
                dataGridView_patient_info.DataSource = ds.Tables["t"];
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                throw new Exception(ex.Message);
            }
        }
        private void Bool_To_Text(DataGridView gdv, String col_name, String F_test, String F_value, String T_test, String T_value)
        {
            //将gdv中col_name列中的布尔值与文本绑定

            ((DataGridViewComboBoxColumn)dataGridView_patient_info.Columns[col_name]).DisplayMember = "text";
            ((DataGridViewComboBoxColumn)dataGridView_patient_info.Columns[col_name]).ValueMember = "value";
            DataTable dtM = new DataTable();
            dtM.Columns.Add("text");
            dtM.Columns.Add("value", typeof(String));
            dtM.Rows.Add(new object[] { F_test, F_value });
            dtM.Rows.Add(new object[] { T_test, T_value });
            ((DataGridViewComboBoxColumn)dataGridView_patient_info.Columns[col_name]).DataSource = dtM;

        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            int count_row = dataGridView_patient_info.RowCount;
            int select_count = 0;
            for (int i = 0; i < count_row; i++)
            {
                DataGridViewCheckBoxCell checkCell = new DataGridViewCheckBoxCell();
                checkCell = (DataGridViewCheckBoxCell)dataGridView_patient_info.Rows[i].Cells["patient_id_check_box"];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                    select_count++;
                
            }
            if(select_count!=1)
            { MessageBox.Show("请选择一条数据进行修改");
                return; 
            }
            for (int i = 0; i < count_row; i++)
            {
                DataGridViewCheckBoxCell checkCell = new DataGridViewCheckBoxCell();
                checkCell = (DataGridViewCheckBoxCell)dataGridView_patient_info.Rows[i].Cells["patient_id_check_box"];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                {
                    string patient_id, illness, operation, advice;
                    patient_id = dataGridView_patient_info.Rows[i].Cells["patient_id_col"].Value.ToString();
                    illness = dataGridView_patient_info.Rows[i].Cells["ill_con_col"].Value.ToString();
                    operation = dataGridView_patient_info.Rows[i].Cells["need_operation_col"].Value.ToString();
                    advice = dataGridView_patient_info.Rows[i].Cells["advice_col"].Value.ToString();
                    
                    patient_state_modify psm =new patient_state_modify(doctor_id,patient_id,illness,operation,advice);
                    
                    psm.Show();
                    this.Hide();
                }
            }

           
        }

        private void prescribeButton_Click(object sender, EventArgs e)
        {

            int count_row = dataGridView_patient_info.RowCount;
            int select_count = 0;
            for (int i = 0; i < count_row; i++)
            {
                DataGridViewCheckBoxCell checkCell = new DataGridViewCheckBoxCell();
                checkCell = (DataGridViewCheckBoxCell)dataGridView_patient_info.Rows[i].Cells["patient_id_check_box"];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                    select_count++;

            }
            if (select_count != 1)
            {
                MessageBox.Show("请选择一条数据的病人，为他开药");
                return;
            }
            for (int i = 0; i < count_row; i++)
            {
                DataGridViewCheckBoxCell checkCell = new DataGridViewCheckBoxCell();
                checkCell = (DataGridViewCheckBoxCell)dataGridView_patient_info.Rows[i].Cells["patient_id_check_box"];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                {
                    string patient_id;
                    patient_id = dataGridView_patient_info.Rows[i].Cells["patient_id_col"].Value.ToString();
                    prescribe_add pad = new prescribe_add(patient_id,doctor_id);
                    
                    pad.Show();
                    this.Hide();
                }
            }
        }
        private void dataGridView_patient_info_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            detailed_content = dataGridView_patient_info[e.ColumnIndex, e.RowIndex].Value.ToString();
            curDetailedInfo = new DetailedInfo(detailed_content);
            curDetailedInfo.Show();
        }  



  

   
    }
}
