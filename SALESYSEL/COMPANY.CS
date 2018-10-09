using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SaleSysEL
{
    public class Company
    {
        public Company()
        {}
        public Company(Guid cid, string cname, string cshortname, string ctype, string caddress, string cpostcode, string ctel, string cfax, string clinkman1, string clinkman2, string email, string bank, string bankAccounts, DateTime caddtime)
        {
            _cid = cid;
            _cname = cname;
            _cshortname = cshortname;
            _ctype = ctype;
            _caddress = caddress;
            _cpostcode = cpostcode;
            _ctel = ctel;
            _cfax = cfax;
            _clinkman1 = clinkman1;
            _clinkman2 = clinkman2;
            _email = email;
            _bank = bank;
            _bankAccounts = bankAccounts;
            _caddtime = caddtime;
        }


        public Company(SqlDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(SqlDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
                  _cid = reader.GetGuid(0);
                  if (!reader.IsDBNull(1)) _cname = reader.GetString(1);
                  if (!reader.IsDBNull(2)) _cshortname = reader.GetString(2);
                  if (!reader.IsDBNull(3)) _ctype = reader.GetString(3);
                  if (!reader.IsDBNull(4)) _caddress = reader.GetString(4);
                  if (!reader.IsDBNull(5)) _cpostcode = reader.GetString(5);
                  if (!reader.IsDBNull(6)) _ctel = reader.GetString(6);
                  if (!reader.IsDBNull(7)) _cfax = reader.GetString(7);
                  if (!reader.IsDBNull(8)) _clinkman1 = reader.GetString(8);
                  if (!reader.IsDBNull(9)) _clinkman2 = reader.GetString(9);
                  if (!reader.IsDBNull(10)) _email = reader.GetString(10);
                  if (!reader.IsDBNull(11)) _bank = reader.GetString(11);
                  if (!reader.IsDBNull(12)) _bankAccounts = reader.GetString(12);
                  if (!reader.IsDBNull(13)) _caddtime = reader.GetDateTime(13);
            }
        }


        #region Public Properties
        private Guid _cid;
        private string _cname;
        private string _cshortname;
        private string _ctype;
        private string _caddress;
        private string _cpostcode;
        private string _ctel;
        private string _cfax;
        private string _clinkman1;
        private string _clinkman2;
        private string _email;
        private string _bank;
        private string _bankAccounts;
        private DateTime _caddtime;

        public Guid Cid
        {
            get { return _cid; }
            set { _cid = value; }
        }
        

        public string Cname
        {
            get { return _cname; }
            set { _cname = value; }
        }
        

        public string Cshortname
        {
            get { return _cshortname; }
            set { _cshortname = value; }
        }


        public string Ctype
        {
            get { return _ctype; }
            set { _ctype = value; }
        }
        

        public string Caddress
        {
            get { return _caddress; }
            set { _caddress = value; }
        }
        

        public string Cpostcode
        {
            get { return _cpostcode; }
            set { _cpostcode = value; }
        }
        

        public string Ctel
        {
            get { return _ctel; }
            set { _ctel = value; }
        }
        

        public string Cfax
        {
            get { return _cfax; }
            set { _cfax = value; }
        }
        

        public string Clinkman1
        {
            get { return _clinkman1; }
            set { _clinkman1 = value; }
        }

        public string Clinkman2
        {
            get { return _clinkman2; }
            set { _clinkman2 = value; }
        }
        

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        

        public string Bank
        {
            get { return _bank; }
            set { _bank = value; }
        }
        
        public string BankAccounts
        {
            get { return _bankAccounts; }
            set { _bankAccounts = value; }
        }
        
        public DateTime Caddtime
        {
            get { return _caddtime; }
            set { _caddtime = value; }
        }
        #endregion
    }
}
