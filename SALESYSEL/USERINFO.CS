using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SaleSysEL
{
    public class UserInfo
    {
        public UserInfo()
        { }

        public UserInfo(SqlDataReader sqlrd)
        {
            FormLoadreader(sqlrd);
        }

        public void FormLoadreader(SqlDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                _uid = reader.GetGuid(0);
                if (!reader.IsDBNull(1)) _uname = reader.GetString(1);
                if (!reader.IsDBNull(2)) _upwd = reader.GetString(2);
                if (!reader.IsDBNull(3)) _upower = reader.GetString(3);
            }
        }

        #region Public Properties
        private Guid _uid;
        private string _uname;
        private string _upwd;
        private string _upower;

        public Guid Uid
        {
            get { return _uid; }
            set { _uid = value; }
        }
        

        public string Uname
        {
            get { return _uname; }
            set { _uname = value; }
        }

        public string Upwd
        {
            get { return _upwd; }
            set { _upwd = value; }
        }


        public string Upower
        {
            get { return _upower; }
            set { _upower = value; }
        }
        #endregion
    }
}
