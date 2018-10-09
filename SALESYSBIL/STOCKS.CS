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
    public class Stocks
    {
        public Stocks()
        { }

        public IList<Stock> SelectAll()
        {
            string strSql = "SELECT  Stock.StockId,  Commodity.CommName,  Stock.Number, " +
                            "Stock.Price,  Stock.SettlementType,  Stock.Payment,Stock.FactPayment,  Stock.NotPayment,  Stock.ManageMan, "+
                            "Stock.AddStockDate,  Stock.Type FROM  Stock INNER JOIN Commodity ON  Stock.CommodityId =  Commodity.CommId";
            IList<Stock> stocks = new List<Stock>();
            SqlDataReader comReader = null;

            try
            {
                comReader = SqlHelper.ExecuteReader(strSql,null);
                while (comReader.Read())
                {
                    stocks.Add(new Stock(comReader));
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return stocks;
        }

        public IList<Stock> Select(string commodity,string manageman,string begindate,string enddate,string type,string settlement)
        {
            IList<Stock> stocks = new List<Stock>();
            SqlDataReader comReader = null;
            string strSql = "SELECT  Stock.StockId, Commodity.CommName,  Stock.Number,Stock.Price,  Stock.SettlementType,  Stock.Payment, "+
                            "Stock.FactPayment,  Stock.NotPayment,  Stock.ManageMan,Stock.AddStockDate,  Stock.Type FROM  Stock INNER JOIN  "+
                            "Commodity ON Stock.CommodityId =  Commodity.CommId ";
            List<SqlParameter> spms = new List<SqlParameter>();
            
            if ((begindate != null) && (enddate != null))
            {
                strSql += "AND AddStockDate BETWEEN @bdate AND @edate ";
                spms.Add(new SqlParameter("@bdate", begindate));
                spms.Add(new SqlParameter("@edate", enddate));
            }
            if (commodity != null)
            {
                strSql += "AND CommName like '%'+@commodity+'%' ";
                spms.Add(new SqlParameter("@commodity",commodity));
            }
            if (manageman != null)
            {
                strSql += "AND ManageMan like '%'+@mman+'%' ";
                spms.Add(new SqlParameter("@mman",manageman));
            }
            if (type != null)
            {
                strSql += "AND Type =@type ";
                spms.Add(new SqlParameter("@type",type));
            }
            if (settlement != null)
            {
                strSql += "AND SettlementType = @stype ";
                spms.Add(new SqlParameter("@stype",settlement));
            }
            try
            {
                comReader = SqlHelper.ExecuteReader(strSql, spms == null ? null : spms.ToArray());
                while (comReader.Read())
                {
                    stocks.Add(new Stock(comReader));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return stocks;
        }

        public int InsertStock(Guid commodityId, string number, decimal price, string settlementType, decimal payment, decimal factpayment, decimal notpayment, string manageman, DateTime stockdate, string type)
        {
            string inserSql = "INSERT INTO Stock "+
            "VALUES(newid(),@commid,@number,@price,@setttype,@payment,@factpayment,@notpayment,@manageman,@stockdate,@type)";
            SqlParameter[] sqlPams = new SqlParameter[10];
            sqlPams[0] = new SqlParameter("@commid",commodityId);
            sqlPams[1] = new SqlParameter("@number",number);
            sqlPams[2] = new SqlParameter("@price",price);
            sqlPams[3] = new SqlParameter("@setttype", settlementType);
            sqlPams[4] = new SqlParameter("@payment",payment);
            sqlPams[5] = new SqlParameter("@factpayment",factpayment);
            sqlPams[6] = new SqlParameter("@notpayment",notpayment);
            sqlPams[7] = new SqlParameter("@manageman",manageman);
            sqlPams[8] = new SqlParameter("@stockdate",stockdate);
            sqlPams[9] = new SqlParameter("@type",type);


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


    }
}
