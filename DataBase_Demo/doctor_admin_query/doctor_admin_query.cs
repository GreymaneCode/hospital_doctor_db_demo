using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
//数据访问
namespace DataBase_Demo
{
    public class doctor_admin_query
    {
        database_util dbutil = new database_util();
        public OracleDataAdapter get_meidcine_id_query(string medicineName)
        {
            String sql = string.Empty;

            sql = "Select medicine_id From medicine where medicine_name=:name ";
            OracleCommand cmd = new OracleCommand(sql);
            cmd.Parameters.Add(new OracleParameter("name", medicineName));


            try
            {
                OracleDataAdapter adapt_medicine_id = new OracleDataAdapter();
                adapt_medicine_id = dbutil.uniformed_query(cmd);
                return adapt_medicine_id;
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public OracleDataAdapter get_doc_passwd_query(string id)
        {
            String sql = string.Empty;
          
            sql = "Select doctor_password From doctor where doctor_id=:id ";
            OracleCommand cmd = new OracleCommand(sql);
            cmd.Parameters.Add(new OracleParameter("id", id));


            try
            {
                OracleDataAdapter adapt_doc_passwd = new OracleDataAdapter();
                adapt_doc_passwd = dbutil.uniformed_query(cmd);
                return adapt_doc_passwd;
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public OracleDataAdapter get_doc_info_query(string id)
        {
            String sql = string.Empty;
            
            sql = "Select * From doctor where doctor_id=:id ";
            OracleCommand cmd = new OracleCommand(sql);
            cmd.Parameters.Add(new OracleParameter("id", id));


            try
            {
                OracleDataAdapter adapt_doc_info = new OracleDataAdapter();
                adapt_doc_info = dbutil.uniformed_query(cmd);
                return adapt_doc_info;
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public OracleDataAdapter get_patient_info_query(string did,string pid)
        {
            String sql = string.Empty;
            sql = "Select patient_id,state_time,illness_condition,need_operation,advice From patient_state where doctor_id=:did and patient_id=: pid";
            OracleCommand cmd = new OracleCommand(sql);
            cmd.Parameters.Add(new OracleParameter("did", did));
            cmd.Parameters.Add(new OracleParameter("pid", pid));

            try
            {
                OracleDataAdapter adapt_doc_info = new OracleDataAdapter();
                adapt_doc_info = dbutil.uniformed_query(cmd);
                return adapt_doc_info;
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public OracleDataAdapter get_patient_list_query(string id)
        {
            String sql = string.Empty;
            sql = "Select patient_id,patient_name From (patient natural join patient_state) where doctor_id=:id ";
            OracleCommand cmd = new OracleCommand(sql);
            cmd.Parameters.Add(new OracleParameter("id", id));


            try
            {
                OracleDataAdapter adapt_doc_info = new OracleDataAdapter();
                adapt_doc_info = dbutil.uniformed_query(cmd);
                return adapt_doc_info;
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public OracleDataAdapter modify_patient_state_query(string id)
        {
            String sql = string.Empty;
            sql = "Select * From patient_state where doctor_id=:id ";
            OracleCommand cmd = new OracleCommand(sql);
            cmd.Parameters.Add(new OracleParameter("id", id));


            try
            {
                OracleDataAdapter adapt_doc_info = new OracleDataAdapter();
                adapt_doc_info = dbutil.uniformed_query(cmd);
                return adapt_doc_info;
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OracleDataAdapter get_oper_info_query(string id,int choice)
        {            
            String current_time = string.Empty;
            current_time = DateTime.Now.ToString("yyyy-MM-dd");
            String sql = string.Empty;
            if (choice == 1)
                sql = "select operation_id,operation_name,sec_id,patient_id,operation_date,patient_name From (operation natural join patient） where (doctor_id=:id AND operation_date>=to_timestamp('" + current_time + "','yyyy-mm-dd')) order by operation_date asc ";
            else if(choice==2)
                sql = "select operation_id,operation_name,sec_id,patient_id,operation_date,patient_name From (operation natural join patient） where (doctor_id=:id AND operation_date<to_timestamp('" + current_time + "','yyyy-mm-dd')) order by operation_date desc ";
            OracleCommand cmd = new OracleCommand(sql);
            cmd.Parameters.Add(new OracleParameter("id", id));
            // cmd.Parameters.Add(new OracleParameter("current_time", current_time));


            try
            {
                OracleDataAdapter adapt_doc_info = new OracleDataAdapter();
                adapt_doc_info = dbutil.uniformed_query(cmd);
                return adapt_doc_info;
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }
        }

       /* public void patient_state_delete(string patient_id)
        {
            String sql = string.Empty;
            sql = "delete from patient_state where patient_id = :id ";

            OracleCommand cmd = new OracleCommand(sql);
            cmd.Parameters.Add(new OracleParameter("id", patient_id));
            try
            {
                OracleDataAdapter adapt = new OracleDataAdapter();
                dbutil.uniformed_insert(cmd);

            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }
        }*/
       //讲道理不应该删除，而是通过时间来覆盖
        public void patient_state_add(string doctor_id,string patient_id, string Illness, string NeedOp, string Advice)
        {
            string nowTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            String sql = string.Empty;
            sql = "insert into patient_state values (:patient_id ," +
                                              "to_timestamp('" + nowTime + "', 'yyyy-mm-dd hh24:mi:ss') ," +
                                              ":doctor_id,:illness_condition,:need_operation,:advice)";


            OracleCommand cmd = new OracleCommand(sql);
            cmd.Parameters.Add(new OracleParameter("patient_id", patient_id));
            cmd.Parameters.Add(new OracleParameter("doctor_id",doctor_id));
            cmd.Parameters.Add(new OracleParameter("illness_condition", Illness));
            if(NeedOp=="是")
                cmd.Parameters.Add(new OracleParameter("need_operation","1"));
            else if(NeedOp=="否")
                cmd.Parameters.Add(new OracleParameter("need_operation","0"));
            cmd.Parameters.Add(new OracleParameter("advice", Advice));
            try
            {
                OracleDataAdapter adapt = new OracleDataAdapter();
                dbutil.uniformed_insert(cmd);

            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void prescribe_add(string doctor_id,string  patient_id,string  medicineId,string medicineDose, string medicineUnit)
        {
            string cur = cur_max_pre_id();
            string newid = get_new_id(cur);
            string nowTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            String sql = string.Empty;
            sql = "insert into prescribe values (:prescribe_id,:medicine_id,:doctor_id,:patient_id ,:dose,:unit,to_timestamp('" + nowTime + "', 'yyyy-mm-dd hh24:mi:ss'))";
            OracleCommand cmd = new OracleCommand(sql);
            cmd.Parameters.Add(new OracleParameter("prescribe_id",newid));
            cmd.Parameters.Add(new OracleParameter("medicine_id", medicineId));
            cmd.Parameters.Add(new OracleParameter("doctor_id", doctor_id));
            cmd.Parameters.Add(new OracleParameter("patient_id", patient_id));
            cmd.Parameters.Add(new OracleParameter("dose", medicineDose));
            cmd.Parameters.Add(new OracleParameter("unit", medicineUnit));
            
            try
            {
                OracleDataAdapter adapt = new OracleDataAdapter();
                dbutil.uniformed_insert(cmd);

            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string cur_max_pre_id()
        {

            String sql = string.Empty;
            sql = "select prescribe_id from prescribe order by prescribe_time DESC";
           
            OracleCommand cmd = new OracleCommand(sql);
            try
            {
                OracleDataAdapter adapt = new OracleDataAdapter();
                adapt = dbutil.uniformed_query(cmd);
                DataSet ds = new DataSet();
                
                adapt.Fill(ds, "cur_max_pre_id");

                DataTable temp = ds.Tables["cur_max_pre_id"];
                DataRow row = temp.Rows[0];
                return row["prescribe_id"].ToString();
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        string get_new_id(string current_latest_string)
        {
            string to_ret = "Pr";
            string num_string = current_latest_string.Substring(2);
            if (num_string == "999999")
            {
                return "Pr" + "000000";
            }
            int new_num = Convert.ToInt32(num_string) + 1;
            int cur_num = new_num;
            int num_digit = 0;
            while (cur_num != 0)
            {
                num_digit++;
                cur_num = cur_num / 10;
            }

            int num_zero = 6 - num_digit;
            for (int i = 0; i < num_zero; i++)
            {
                to_ret += '0';
            }

            to_ret += new_num.ToString();
            return to_ret;
        }

        public void operreport_add(string doctor_id, string oper_id, string reporttext)
        {
            string nowTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            String sql = string.Empty;
            sql = "insert into operation_report values (:doctor_id,:operation_id,:conclusion ,to_timestamp('" + nowTime + "', 'yyyy-mm-dd hh24:mi:ss'))";
            OracleCommand cmd = new OracleCommand(sql);
            
            cmd.Parameters.Add(new OracleParameter("doctor_id", doctor_id));
            cmd.Parameters.Add(new OracleParameter("operation_id", oper_id));
            cmd.Parameters.Add(new OracleParameter("conclusion", reporttext));
            
            try
            {
                OracleDataAdapter adapt = new OracleDataAdapter();
                dbutil.uniformed_insert(cmd);

            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OracleDataAdapter get_report_query(string oper_id)
        {
            String sql = string.Empty;
            sql = "select operation_id,conclusion,report_time from operation_report where operation_id =: oper_id";

            OracleCommand cmd = new OracleCommand(sql);
            cmd.Parameters.Add(new OracleParameter("oper_id", oper_id));
            try
            {
                OracleDataAdapter adapt = new OracleDataAdapter();
                adapt = dbutil.uniformed_query(cmd);                
                return adapt;
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void delete_report(string oper_id)
        {
            String sql = string.Empty;
            sql = "delete from operation_report where operation_id =: oper_id";

            OracleCommand cmd = new OracleCommand(sql);
            cmd.Parameters.Add(new OracleParameter("oper_id", oper_id));
            try
            {
                OracleDataAdapter adapt = new OracleDataAdapter();
                dbutil.uniformed_delete(cmd);
                
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int get_report_num(string oper_id)
        {
            String sql = string.Empty;
            sql = "select COUNT(operation_id) FROM operation_report where operation_id =: oper_id";

            OracleCommand cmd = new OracleCommand(sql);
            cmd.Parameters.Add(new OracleParameter("oper_id", oper_id));
            try
            {
                OracleDataAdapter adapt = new OracleDataAdapter();
                adapt = dbutil.uniformed_query(cmd);               

                DataSet ds = new DataSet();

                adapt.Fill(ds, "report_num");

                DataTable temp = ds.Tables["report_num"];
                int rownum = temp.Rows.Count;
                
                return rownum;
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
