using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SaleSysEL
{
    public class CompanyType
    {
        public CompanyType()
        { }

        public CompanyType(SqlDataReader sqlrd)
        {
            FormLoadreader(sqlrd);
        }

        public void FormLoadreader(SqlDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                _ctid = reader.GetGuid(0).ToString();
                if (!reader.IsDBNull(1)) _ctname = reader.GetString(1);

            }
        }

        #region Public Properties
        private string _ctid;
        private string _ctname;

        public string Ctid
        {
            get { return _ctid; }
            set { _ctid = value; }
        }

        public string Ctname
        {
            get { return _ctname; }
            set { _ctname = value; }
        }



        #endregion
    }
}
