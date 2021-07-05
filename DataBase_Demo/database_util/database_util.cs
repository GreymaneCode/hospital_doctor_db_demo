using Oracle.ManagedDataAccess.Client;
using System;
//数据库查询工具类
namespace DataBase_Demo
{
    class database_util
    {
        public OracleDataAdapter uniformed_query(OracleCommand cmd)
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            OracleConnection conn = new OracleConnection(connString);
            cmd.Connection = conn;
            try
            {
                conn.Open();
                OracleDataAdapter adapt = new OracleDataAdapter();
                adapt.SelectCommand = cmd;
                conn.Close();
                return adapt;
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void uniformed_insert(OracleCommand cmd)
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            OracleConnection conn = new OracleConnection(connString);
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }
            conn.Close();

        }

        public void uniformed_delete(OracleCommand cmd)
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            OracleConnection conn = new OracleConnection(connString);
            cmd.Connection = conn;
                               
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }
           
        }
        public void uniformed_update(OracleCommand cmd)
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            OracleConnection conn = new OracleConnection(connString);
            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
