using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

//第二层
namespace DataBase_Demo
{
   public class doctor_admin
    {
        doctor_admin_query dcquery = new doctor_admin_query();        
        public OracleDataAdapter get_doc_info(string id)
        {
            return dcquery.get_doc_info_query(id);
        }
        public OracleDataAdapter get_patient_info(string id)
        {
            return dcquery.get_patient_info_query(id);
        }
        public OracleDataAdapter modify_patient_state(string id)
        {
            return dcquery.modify_patient_state_query( id);
        }
        public bool login(string id,string passwd)
        {
            try
            {
                DataSet ds = new DataSet();
                OracleDataAdapter adapt_x = new OracleDataAdapter();
                adapt_x = dcquery.get_doc_passwd_query(id);
                adapt_x.Fill(ds, "DOC_PASSWD");

                int dataCount = ds.Tables["DOC_PASSWD"].Rows.Count;//table中的纪录总数

                if (dataCount == 1)
                {
                    DataTable pswd_table = ds.Tables["DOC_PASSWD"];
                    DataRow row = pswd_table.Rows[0];
                    string doc_passwd = row["doctor_password"].ToString();
                    if (passwd == doc_passwd)
                    {
                        return true;
                    }
                    else
                    {
                        //有账户，但是密码错了
                        return false;
                    }
                }
                else //查无此人
                {
                    return false;
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public OracleDataAdapter get_oper_info(string id)
        {
            return dcquery.get_oper_info_query(id);
        }
    }
}
