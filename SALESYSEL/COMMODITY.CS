using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SaleSysEL
{
    public class Commodity
    {
        public Commodity()
        { }

        public Commodity(SqlDataReader reader)
        {
            this.LoadFromReader(reader); 
        }


        protected void LoadFromReader(SqlDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                _commId = reader.GetGuid(0);
                if (!reader.IsDBNull(1)) _commName = reader.GetString(1);
                if (!reader.IsDBNull(2)) _commShortName = reader.GetString(2);
                if (!reader.IsDBNull(3)) _commProducePlace = reader.GetString(3);
                if (!reader.IsDBNull(4)) _unit = reader.GetString(4);
                if (!reader.IsDBNull(5)) _specs = reader.GetString(5);
                if (!reader.IsDBNull(6)) _passNumber = reader.GetString(6);
                if (!reader.IsDBNull(7)) _passList = reader.GetString(7);
                if (!reader.IsDBNull(8)) _comName = reader.GetString(8);
                if (!reader.IsDBNull(9)) _remark = reader.GetString(9);
                if (!reader.IsDBNull(10)) _comAddTime = reader.GetDateTime(10);
            }
        }


        #region Public Properties
        private Guid _commId;
        private string _commName;
        private string _commShortName;
        private string _commProducePlace;
        private string _unit;
        private string _specs;
        private string _passNumber;
        private string _passList;
        private string _comName;
        private string _remark;
        private DateTime _comAddTime;

        public Guid CommId
        {
            get { return _commId; }
            set { _commId = value; }
        }
        

        public string CommName
        {
            get { return _commName; }
            set { _commName = value; }
        }
        

        public string CommShortName
        {
            get { return _commShortName; }
            set { _commShortName = value; }
        }
        

        public string CommProducePlace
        {
            get { return _commProducePlace; }
            set { _commProducePlace = value; }
        }
        

        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }
        

        public string Specs
        {
            get { return _specs; }
            set { _specs = value; }
        }
        
        public string PassNumber
        {
            get { return _passNumber; }
            set { _passNumber = value; }
        }
        

        public string PassList
        {
            get { return _passList; }
            set { _passList = value; }
        }
        
        public string ComName
        {
            get { return _comName; }
            set { _comName = value; }
        }

        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }
        
        public DateTime ComAddTime
        {
            get { return _comAddTime; }
            set { _comAddTime = value; }
        }
        #endregion

    }
}
