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
        public OracleDataAdapter get_doc_passwd_query(string id)//病情查询
        {
            String sql = string.Empty;
            //sql = "select doctor_password from doctor where doctor_id = '" + id + "'";
            //OracleCommand cmd = new OracleCommand(sql);

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
    }
}
