using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using System.Threading.Tasks;
//第二层
namespace DataBase_Demo
{
   public class doctor_admin
    {
        doctor_admin_query dcquery = new doctor_admin_query();
        public OracleDataAdapter get_doc_passwd(string id)
        {
            return dcquery.get_doc_passwd_query(id);
        }
        public OracleDataAdapter get_doc_info(string id)
        {
            return dcquery.get_doc_info_query(id);
        }
        public OracleDataAdapter get_oper_info(string id)//, string current_time)
        {
            return dcquery.get_oper_info_query(id);//,current_time);
        }
        
    }
}
