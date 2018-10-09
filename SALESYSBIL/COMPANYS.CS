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
    public class Companys
    {
        /// <summary>
        /// 返回数据库中company表的记录
        /// </summary>
        /// <returns>IList</returns>
        public IList<Company> SelectAll()
        {
            string strSql = "SELECT Company.ComId, Company.ComName, Company.ComShort, "+
                            "ComType.CTName, Company.CompAddr, Company.ComPostalcode, "+ 
                            "Company.ComTelephoe, Company.ComFax, Company.ComLinkman1, "+
                            "Company.ComLinkman2, Company.ComEmail, Company.ComBank, "+ 
                            "Company.ComBankAccounts, Company.ComAddTime "+
                            "FROM Company, ComType WHERE Company.ComType = ComType.CTID";
            IList<Company> companys = new List<Company>();
            SqlDataReader comReader = null;

            try
            {
                comReader = SqlHelper.ExecuteReader(strSql, null);
                while(comReader.Read())
                {
                    companys.Add(new Company(comReader));
                }
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return companys;
        }

        /// <summary>
        /// 返回数据库中company表的记录特定数据
        /// </summary>
        /// <returns></returns>
        public IList<Company> SelectInfoByID(Guid ID)
        {
            string strSql = "SELECT Company.ComId, Company.ComName, Company.ComShort, " +
                            "ComType.CTName, Company.CompAddr, Company.ComPostalcode, " +
                            "Company.ComTelephoe, Company.ComFax, Company.ComLinkman1, " +
                            "Company.ComLinkman2, Company.ComEmail, Company.ComBank, " +
                            "Company.ComBankAccounts, Company.ComAddTime " +
                            "FROM Company, ComType WHERE Company.ComType = ComType.CTID AND Company.ComId = @id";

            SqlParameter[] sqlPams = new SqlParameter[1];
            sqlPams[0] = new SqlParameter("@id",ID); 
            IList<Company> companys = new List<Company>();
            SqlDataReader comReader = null;

            try
            {
                comReader = SqlHelper.ExecuteReader(strSql, sqlPams);
                while (comReader.Read())
                {
                    companys.Add(new Company(comReader));
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return companys;
        }

        /// <summary>
        /// 向数据库中company表中插入一条记录
        /// </summary>
        /// <param name="cname">公司名称</param>
        /// <param name="csname">公司名称缩写</param>
        /// <param name="ctype">公司类型</param>
        /// <param name="caddress">公司地址</param>
        /// <param name="cpostcode">公司邮编</param>
        /// <param name="tel">公司电话</param>
        /// <param name="fax">公司传真</param>
        /// <param name="lname1">公司联系人1</param>
        /// <param name="lname2">公司联系人2</param>
        /// <param name="cemail">公司联系Email</param>
        /// <param name="cbank">公司开户银行</param>
        /// <param name="cbAccount">公司开户银行帐号</param>
        /// <returns>整型</returns>
        public int InsertCompany(string cname,string csname,Guid ctype,string caddress,string cpostcode,string tel,string fax,string lname1,string lname2,string cemail,string cbank,string cbAccount)
        {
            DateTime DT = DateTime.Now;
            string strInsert = "INSERT INTO Company  Values(newid(),@comname,@comsname,@comtype,@comadd,@compcode,@comtele,@comfax,@linkman1,@linkman2, "+
            "@cemail,@bank,@baccount,@datetime)";
            SqlParameter[] sqlPams = new SqlParameter[13];
            sqlPams[0] = new SqlParameter("@comname",cname);
            sqlPams[1] = new SqlParameter("@comsname",csname);
            sqlPams[2] = new SqlParameter("@comtype", ctype);
            sqlPams[3] = new SqlParameter("@compcode", cpostcode);
            sqlPams[4] = new SqlParameter("@comtele", tel);
            sqlPams[5] = new SqlParameter("@comfax", fax);
            sqlPams[6] = new SqlParameter("@linkman1", lname1);
            sqlPams[7] = new SqlParameter("@linkman2", lname2);
            sqlPams[8] = new SqlParameter("@cemail", cemail);
            sqlPams[9] = new SqlParameter("@bank", cbank);
            sqlPams[10] = new SqlParameter("@baccount", cbAccount);
            sqlPams[11] = new SqlParameter("@datetime", DT);
            sqlPams[12] = new SqlParameter("@comadd",caddress);


            int i = 0;
            try
            {
                i = SqlHelper.ExecuteNonQuery(strInsert,sqlPams);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return i;
        }

        /// <summary>
        /// 根据公司ID更新数据库中的数据
        /// </summary>
        /// <param name="cid">公司ID</param>
        ///<param name="cname">公司名称</param>
        /// <param name="csname">公司名称缩写</param>
        /// <param name="ctype">公司类型</param>
        /// <param name="caddress">公司地址</param>
        /// <param name="cpostcode">公司邮编</param>
        /// <param name="tel">公司电话</param>
        /// <param name="fax">公司传真</param>
        /// <param name="lname1">公司联系人1</param>
        /// <param name="lname2">公司联系人2</param>
        /// <param name="cemail">公司联系Email</param>
        /// <param name="cbank">公司开户银行</param>
        /// <param name="cbAccount">公司开户银行帐号</param>
        /// <returns>整型</returns>
        public int UpdateCompany(Guid cid, string cname, string csname, Guid ctype, string caddress, string cpostcode, string tel, string fax, string lname1,string lname2, string cemail, string cbank, string cbAccount)
        {
            string strUpdate = "Update  Company SET ComName = @comname,ComShort = @comsname, ComType = @comtype, CompAddr= @comadd, "+
            " Compostalcode = @compcode,ComTelephoe = @comtele,ComFax = @comfax,ComLinkman1 = @linkman1, ComLinkman2 = @linkman2, " + 
            " ComEmail = @cemail,ComBank = @bank,ComBankAccounts = @baccount WHERE ComId = @cid";
            SqlParameter[] sqlPams = new SqlParameter[13];
            sqlPams[0] = new SqlParameter("@comname", cname);
            sqlPams[1] = new SqlParameter("@comsname", csname);
            sqlPams[2] = new SqlParameter("@comtype", ctype);
            sqlPams[3] = new SqlParameter("@compcode", cpostcode);
            sqlPams[4] = new SqlParameter("@comtele", tel);
            sqlPams[5] = new SqlParameter("@comfax", fax);
            sqlPams[6] = new SqlParameter("@linkman1", lname1);
            sqlPams[7] = new SqlParameter("@linkman2", lname2);
            sqlPams[8] = new SqlParameter("@cemail", cemail);
            sqlPams[9] = new SqlParameter("@bank", cbank);
            sqlPams[10] = new SqlParameter("@baccount", cbAccount);
            sqlPams[11] = new SqlParameter("@cid", cid);
            sqlPams[12] = new SqlParameter("@comadd", caddress);

            int i = 0;
            try
            {
                i = SqlHelper.ExecuteNonQuery(strUpdate, sqlPams);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return i;
        }

        public int delCompany(Guid cid)
        {
            string strDel = "DELETE FROM Company WHERE ComId = @cid";
            SqlParameter[] sqlPams = new SqlParameter[1];
            sqlPams[0] = new SqlParameter("@cid", cid);

            int i = 0;
            try
            {
                i = SqlHelper.ExecuteNonQuery(strDel, sqlPams);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return i;
        }


    }
}
