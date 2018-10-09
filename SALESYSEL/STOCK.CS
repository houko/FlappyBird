using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace SaleSysEL
{
    public class Stock
    {

        public Stock() { }

        public Stock(SqlDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        private void LoadFromReader(SqlDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                _stockId = reader.GetGuid(0);
                if (!reader.IsDBNull(1)) _commodityname = reader.GetString(1);
                if (!reader.IsDBNull(2)) _stocknumber = reader.GetString(2);
                if (!reader.IsDBNull(3)) _stockprice = reader.GetDecimal(3);
                if (!reader.IsDBNull(4)) _settlementtype = reader.GetString(4);
                if (!reader.IsDBNull(5)) _payment = reader.GetDecimal(5);
                if (!reader.IsDBNull(6)) _factpayment = reader.GetDecimal(6);
                if (!reader.IsDBNull(7)) _notpayment = reader.GetDecimal(7);
                if (!reader.IsDBNull(8)) _manageman = reader.GetString(8);
                if (!reader.IsDBNull(9)) _stockdate = reader.GetDateTime(9);
                if (!reader.IsDBNull(10)) _type = reader.GetString(10);
            }
        }

        #region public
        private Guid _stockId;
        private string _commodityname;
        private string _stocknumber;
        private decimal _stockprice;
        private string _settlementtype;
        private decimal _payment;
        private decimal _factpayment;
        private decimal _notpayment;
        private string _manageman;
        private DateTime _stockdate;
        private string _type;

        public Guid StockId
        {
            get { return _stockId; }
            set { _stockId = value; }
        }
        
        public string Commodityname
        {
            get { return _commodityname; }
            set { _commodityname = value; }
        }
        
        public string Stocknumber
        {
            get { return _stocknumber; }
            set { _stocknumber = value; }
        }
        
        public decimal Stockprice
        {
            get { return _stockprice; }
            set { _stockprice = value; }
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
