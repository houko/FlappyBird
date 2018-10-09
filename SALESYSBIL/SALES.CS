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
    public class Sales
    {
        public Sales()
        { }

        public IList<Sale> SelectAll()
        {
            string strSql = "SELECT  Sale.SaleId,  Commodity.CommName,  Company.ComName,Sale.SalePrice,  Sale.SaleNumber,  Sale.SettlementType, "+
                            "Sale.Payment,  Sale.FactPayment,  Sale.NotPayment, Sale.ManageMan,  Sale.AddStockDate,  Sale.Type "+
                            "FROM  Sale,Commodity,Company WHERE Sale.CommodityId =  Commodity.CommId AND Sale.companyId =  Company.ComId  ";

            IList<Sale> sales = new List<Sale>();
            SqlDataReader comreader = null;

            try
            {
                comreader = SqlHelper.ExecuteReader(strSql, null);
                while (comreader.Read())
                {
                    sales.Add(new Sale(comreader));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return sales;
        }

        public IList<Sale> Select(string company, string commodity, string manageman, string begindate, string enddate, string type, string settlement)
        {
            IList<Sale> sales = new List<Sale>();
            SqlDataReader comReader = null;
            string strSql = "SELECT Sale.SaleId,Company.ComName,Commodity.CommName,Sale.SalePrice,Sale.SaleNumber,  Sale.SettlementType, " +
                            "Sale.Payment,Sale.FactPayment,Sale.NotPayment,Sale.ManageMan,Sale.AddStockDate,Sale.Type FROM Sale,Commodity,Company " +
                            "WHERE Sale.CommodityId =  Commodity.CommId AND Sale.companyId =  Company.ComId ";
            List<SqlParameter> spms = new List<SqlParameter>();

            if (company != null)
            {
                strSql += " AND ComName like '%'+@company+'%'";
                spms.Add(new SqlParameter("@company",company));
            }
            if ((begindate != null) && (enddate != null))
            {
                strSql += "AND AddSaleDate BETWEEN @bdate AND @edate ";
                spms.Add(new SqlParameter("@bdate", begindate));
                spms.Add(new SqlParameter("@edate", enddate));
            }
            if (commodity != null)
            {
                strSql += "AND CommName like '%'+@commodity+'%' ";
                spms.Add(new SqlParameter("@commodity", commodity));
            }
            if (manageman != null)
            {
                strSql += "AND ManageMan like '%'+@mman+'%' ";
                spms.Add(new SqlParameter("@mman", manageman));
            }
            if (type != null)
            {
                strSql += "AND Type =@type ";
                spms.Add(new SqlParameter("@type", type));
            }
            if (settlement != null)
            {
                strSql += "AND SettlementType = @stype ";
                spms.Add(new SqlParameter("@stype", settlement));
            }
            try
            {
                comReader = SqlHelper.ExecuteReader(strSql, spms == null ? null : spms.ToArray());
                while (comReader.Read())
                {
                    sales.Add(new Sale(comReader));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return sales;
        }

        public int InsertSale(Guid companyId,Guid commodityId, int number, decimal price, string settlementType, decimal payment, decimal factpayment, decimal notpayment, string manageman, DateTime stockdate, string type)
        {
            string inserSql = "INSERT INTO sale " +
            "VALUES(newid(),@companyId,@commid,@number,@price,@setttype,@payment,@factpayment,@notpayment,@manageman,@stockdate,@type)";
            SqlParameter[] sqlPams = new SqlParameter[11];
            sqlPams[0] = new SqlParameter("@commid", commodityId);
            sqlPams[1] = new SqlParameter("@number", number);
            sqlPams[2] = new SqlParameter("@price", price);
            sqlPams[3] = new SqlParameter("@setttype", settlementType);
            sqlPams[4] = new SqlParameter("@payment", payment);
            sqlPams[5] = new SqlParameter("@factpayment", factpayment);
            sqlPams[6] = new SqlParameter("@notpayment", notpayment);
            sqlPams[7] = new SqlParameter("@manageman", manageman);
            sqlPams[8] = new SqlParameter("@stockdate", stockdate);
            sqlPams[9] = new SqlParameter("@type", type);
            sqlPams[10] = new SqlParameter("@companyId",companyId);


            int i = 0;

            try
            {
                i = SqlHelper.ExecuteNonQuery(inserSql, sqlPams);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return i;
        }

        public DataSet TopSale()
        {
            string strSql = "SELECT DISTINCT  Commodity.CommName as 商品,(SELECT count(Sale.SaleNumber) FROM  Sale  WHERE Sale.Type = '销售') as 数量 "+
                            "FROM  Sale,Commodity WHERE Sale.CommodityId =  Commodity.CommId  AND Sale.Type = '销售'";
            DataSet topsale = new DataSet();

            try
            {
                topsale = SqlHelper.ExcuteDataSet(strSql, null, "commodity");
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return topsale;
        }
    }
}
