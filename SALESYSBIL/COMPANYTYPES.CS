using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SaleSysEL;
using SaleSysDIL;

namespace SaleSysBIL
{
    public class CompanyTypes
    {
        public IList<CompanyType> SelectAll()
        {
            string strSql = "SELECT * FROM ComType";
            IList<CompanyType> companyTypes = new List<CompanyType>();
            SqlDataReader comReader = null;

            try
            {
                comReader = SqlHelper.ExecuteReader(strSql, null);
                while (comReader.Read())
                {
                    companyTypes.Add(new CompanyType(comReader));
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return companyTypes;
        }
    }
}
