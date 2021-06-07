using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
//第三层
namespace DataBase_Demo
{
    public class doctor_admin_query
    {
        database_util dbutil = new database_util();
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
        public OracleDataAdapter get_patient_info_query(string id)
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

        public OracleDataAdapter get_oper_info_query(string id)//,string current_time)
        {
            String sql = string.Empty;

            sql = "Select * From operation where doctor_id=:id ";// AND operation_date>to_timestamp('2012-07-28','yyyy-mm-dd')";
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

    }
}
