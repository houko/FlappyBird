using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SaleSysDIL
{
    public static class SqlHelper
    {
        /// <summary>
        /// 数据库连接字符串
        /// server: 数据库地址
        /// uid: 数据库用户名
        /// pwd: 数据库用户名登录密码
        /// dataBase: 数据库名字
        /// </summary>
        private static string SaleSysConn = @"server=92996974633A47E\SQLEXPRESS;Integrated Security=true;dataBase= SaleSys";

        /// <summary>
        /// 返回DataSet数据集方法
        /// </summary>
        /// <param name="strSql">sql语句</param>
        /// <param name="sqlPms">sql语句中的参数</param>
        /// <param name="tableName">sql语句中的数据表</param>
        /// <returns>DataSet数据集</returns>
        public static DataSet ExcuteDataSet(string strSql,SqlParameter[] sqlPms,string tableName)
        {
            SqlConnection sqlCon = new SqlConnection(SaleSysConn);
            SqlDataAdapter sqlDa = new SqlDataAdapter(strSql,sqlCon);
            if (sqlPms != null)
            {
                foreach (SqlParameter pmsTemp in sqlPms)
                    sqlDa.SelectCommand.Parameters.Add(pmsTemp);
            }
            DataSet exDs = new DataSet();
            sqlDa.Fill(exDs, tableName);
            return exDs;
        }

        /// <summary>
        /// 返回SqlDataReader数据集方法
        /// </summary>
        /// <param name="cmdText">sql语句</param>
        /// <param name="cmdParms">sql语句中的参数</param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string cmdText,SqlParameter[] cmdParms)
        {
            
            SqlConnection sqlCon = new SqlConnection(SaleSysConn);
            SqlCommand sqlCmd = new SqlCommand();

            if (sqlCon.State != ConnectionState.Open)
                sqlCon.Open();

            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandText = cmdText;

            

            if (cmdParms != null)
            {
                foreach (SqlParameter parm in cmdParms)
                    sqlCmd.Parameters.Add(parm);
            }
            try
            {              
                SqlDataReader rdr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
                sqlCmd.Parameters.Clear();
                return rdr;
            }
            catch
            {
                sqlCon.Close();
                throw;
            }
        }

        /// <summary>
        /// 返回影响行数的方法
        /// </summary>
        /// <param name="strSql">sql语句</param>
        /// <param name="cmdParms">sql语句中的参数</param>
        /// <returns>整型</returns>
        public static int ExecuteNonQuery(string strSql, SqlParameter[] cmdParms)
        {
            SqlConnection sqlCon = new SqlConnection(SaleSysConn);
            SqlCommand sqlCmd = new SqlCommand();
            if (sqlCon.State != ConnectionState.Open)
                sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandText = strSql;

            if (cmdParms != null)
            {
                foreach (SqlParameter parm in cmdParms)
                    sqlCmd.Parameters.Add(parm);
            }

            int i = 0;

            try
            {
                i = sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State != ConnectionState.Closed)
                    sqlCon.Close();
            }
            return i;
        }


        public static object ExecuteScalar(string strSql, SqlParameter[] cmdParms)
        {
            SqlConnection sqlCon = new SqlConnection(SaleSysConn);
            SqlCommand sqlCmd = new SqlCommand();
            if (sqlCon.State != ConnectionState.Open)
                sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandText = strSql;
            if (cmdParms != null)
            {
                foreach (SqlParameter sqlPm in cmdParms)
                {
                    sqlCmd.Parameters.Add(sqlPm);
                }
            }


            object o = null;
            try
            {
                o = sqlCmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State != ConnectionState.Closed)
                {
                    sqlCon.Close();
                }
            }

            return o;
        }
    }
}
