using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace SaleSysEL
{
    public class Sale
    {
        public Sale()
        { }

        public Sale(SqlDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        private void LoadFromReader(SqlDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                _saleid = reader.GetGuid(0);
                if (!reader.IsDBNull(1)) _companyname = reader.GetString(1);
                if (!reader.IsDBNull(2)) _commid = reader.GetString(2);
                if (!reader.IsDBNull(3)) _price = reader.GetDecimal(3);
                if (!reader.IsDBNull(4)) _number = reader.GetInt32(4);
                if (!reader.IsDBNull(5)) _settlementtype = reader.GetString(5);
                if (!reader.IsDBNull(6)) _payment = reader.GetDecimal(6);
                if (!reader.IsDBNull(7)) _factpayment = reader.GetDecimal(7);
                if (!reader.IsDBNull(8)) _notpayment = reader.GetDecimal(8);
                if (!reader.IsDBNull(9)) _manageman = reader.GetString(9);
                if (!reader.IsDBNull(10)) _stockdate = reader.GetDateTime(10);
                if (!reader.IsDBNull(11)) _type = reader.GetString(11);
                
            }
        }

        #region private
        private Guid _saleid;
        private string _commid;
        private string _companyname;
        private decimal _price;
        private int _number;
        private string _settlementtype;
        private decimal _payment;
        private decimal _factpayment;
        private decimal _notpayment;
        private string _manageman;
        private DateTime _stockdate;
        private string _type;

        public Guid Saleid
        {
            get { return _saleid; }
            set { _saleid = value; }
        }


        public string Companyname
        {
            get { return _companyname; }
            set { _companyname = value; }
        }

        public string Commid
        {
            get { return _commid; }
            set { _commid = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }


        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string Settlementtype
        {
            get { return _settlementtype; }
            set { _settlementtype = value; }
        }


        public decimal Payment
        {
            get { return _payment; }
            set { _payment = value; }
        }


        public decimal Factpayment
        {
            get { return _factpayment; }
            set { _factpayment = value; }
        }


        public decimal Notpayment
        {
            get { return _notpayment; }
            set { _notpayment = value; }
        }
        
        public string Manageman
        {
            get { return _manageman; }
            set { _manageman = value; }
        }


        public DateTime Stockdate
        {
            get { return _stockdate; }
            set { _stockdate = value; }
        }
        
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        #endregion
    }
}
