using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SaleSysEL
{
    public class Power
    {
        public Power() { }

        public Power(SqlDataReader reader)
        {
            this.LoadFromReader(reader);
        }

         private void LoadFromReader(SqlDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                _id = reader.GetGuid(0);
                if (!reader.IsDBNull(1)) _name = reader.GetString(1);

            }
        }

        #region private
        private Guid _id;
        private string _name;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }
        

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        #endregion
    }
}
