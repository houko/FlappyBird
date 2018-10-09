using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using SaleSysEL;
using SaleSysDIL;

namespace SaleSysBIL
{
    public class Powers
    {
        public Powers() { }

        public IList<Power> SelectAll()
        {
            string strSql = "select * from dbo.UserPower";
            IList<Power> powers = new List<Power>();
            SqlDataReader reader = null;

            try
            {
                reader = SqlHelper.ExecuteReader(strSql,null);
                while(reader.Read())
                {
                    powers.Add(new Power(reader));
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return powers;
        }
    }
}
