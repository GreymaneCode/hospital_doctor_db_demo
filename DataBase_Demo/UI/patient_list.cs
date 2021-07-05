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
    public partial class patient_list : MetroForm
    {
        doctor_admin dcad = new doctor_admin();
        string doctor_id = string.Empty;
        string patient_id = string.Empty;
        /* bool state_sel = false;
         bool pre_sel = false;*/
        public patient_list(string did)
        {
            InitializeComponent();
            doctor_id = did;
            display(doctor_id);
            Bool_To_Text(skinDataGridView_patient_info, "need_operation_col", "否", "0", "是", "1");
        }

        private void display(string id)
        {
            try
            {
                DataSet ds = new DataSet();
                OracleDataAdapter adapt_x = new OracleDataAdapter();
                adapt_x = dcad.get_patient_list(id);
                adapt_x.Fill(ds, "t");
                skinDataGridView_patient_list.DataSource = ds.Tables["t"];
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

            ((DataGridViewComboBoxColumn)skinDataGridView_patient_info.Columns[col_name]).DisplayMember = "text";
            ((DataGridViewComboBoxColumn)skinDataGridView_patient_info.Columns[col_name]).ValueMember = "value";
            DataTable dtM = new DataTable();
            dtM.Columns.Add("text");
            dtM.Columns.Add("value", typeof(String));
            dtM.Rows.Add(new object[] { F_test, F_value });
            dtM.Rows.Add(new object[] { T_test, T_value });
            ((DataGridViewComboBoxColumn)skinDataGridView_patient_info.Columns[col_name]).DataSource = dtM;

        }

      
        private void skinButton_patient_state_modify_Click(object sender, EventArgs e)
        {
            int count_row = skinDataGridView_patient_list.RowCount;
            int select_count = 0;
            int i;
            int j = -1;
            for (i = 0; i < count_row; i++)
            {
                DataGridViewCheckBoxCell checkCell = new DataGridViewCheckBoxCell();
                checkCell = (DataGridViewCheckBoxCell)skinDataGridView_patient_list.Rows[i].Cells["sel_col"];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                {
                    select_count++;
                    j = i;
                }
            }
            if (select_count != 1)
            {
                MessageBox.Show("请选择一位病人");
                return;
            }
            string patient_id = skinDataGridView_patient_list.Rows[j].Cells["pat_id_col"].Value.ToString();
            patient_state_modify psm = new patient_state_modify(doctor_id, patient_id);
            psm.Show();
            this.Hide();
        }

        private void skinButton_state_Click(object sender, EventArgs e)
        {
            int count_row = skinDataGridView_patient_list.RowCount;
            int select_count = 0;
            for (int i = 0; i < count_row; i++)
            {
                DataGridViewCheckBoxCell checkCell = new DataGridViewCheckBoxCell();
                checkCell = (DataGridViewCheckBoxCell)skinDataGridView_patient_list.Rows[i].Cells["sel_col"];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                    select_count++;

            }
            if (select_count != 1)
            {
                MessageBox.Show("请选择一位病人");
                return;
            }
            for (int i = 0; i < count_row; i++)
            {
                DataGridViewCheckBoxCell checkCell = new DataGridViewCheckBoxCell();
                checkCell = (DataGridViewCheckBoxCell)skinDataGridView_patient_list.Rows[i].Cells["sel_col"];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                {

                    patient_id = skinDataGridView_patient_list.Rows[i].Cells["pat_id_col"].Value.ToString();
                    try
                    {
                        DataSet ds = new DataSet();
                        OracleDataAdapter adapt_x = new OracleDataAdapter();
                        adapt_x = dcad.get_patient_info(doctor_id, patient_id);
                        adapt_x.Fill(ds, "t");
                        skinDataGridView_patient_info.DataSource = ds.Tables["t"];
                        //state_sel = true;
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show(ex.Message);
                        throw new Exception(ex.Message);
                    }
                }
            }
        }

        private void skinButton_display_pre_Click(object sender, EventArgs e)
        {
            int count_row = skinDataGridView_patient_list.RowCount;
            int select_count = 0;
            for (int i = 0; i < count_row; i++)
            {
                DataGridViewCheckBoxCell checkCell = new DataGridViewCheckBoxCell();
                checkCell = (DataGridViewCheckBoxCell)skinDataGridView_patient_list.Rows[i].Cells["sel_col"];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                    select_count++;
            }
            if (select_count != 1)
            {
                MessageBox.Show("请选择一位病人");
                return;
            }
            for (int i = 0; i < count_row; i++)
            {
                DataGridViewCheckBoxCell checkCell = new DataGridViewCheckBoxCell();
                checkCell = (DataGridViewCheckBoxCell)skinDataGridView_patient_list.Rows[i].Cells["sel_col"];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                {

                    patient_id = skinDataGridView_patient_list.Rows[i].Cells["pat_id_col"].Value.ToString();
                    try
                    {
                        DataSet ds = new DataSet();
                        OracleDataAdapter tempadp = new OracleDataAdapter();
                        tempadp = dcad.get_prescribe(doctor_id, patient_id);
                        tempadp.Fill(ds, "t");
                        skinDataGridView_prescribe.DataSource = ds.Tables["t"];
                        //pre_sel = true;
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show(ex.Message);
                        throw new Exception(ex.Message);
                    }
                }
            }
        }

        private void skinButton_prescribe_add_Click(object sender, EventArgs e)
        {
            int count_row = skinDataGridView_patient_list.RowCount;
            int select_count = 0;
            int i;
            int j = -1;
            for (i = 0; i < count_row; i++)
            {
                DataGridViewCheckBoxCell checkCell = new DataGridViewCheckBoxCell();
                checkCell = (DataGridViewCheckBoxCell)skinDataGridView_patient_list.Rows[i].Cells["sel_col"];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                {
                    select_count++;
                    j = i;
                }
            }
            if (select_count != 1)
            {
                MessageBox.Show("请选择一位病人");
                return;
            }
            string patient_id = skinDataGridView_patient_list.Rows[j].Cells["pat_id_col"].Value.ToString();
            prescribe_add pad = new prescribe_add(patient_id, doctor_id);
            pad.Show();
            this.Hide();
        }

        private void skinButton_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
