using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SaleSysEL;
using SaleSysDIL;

namespace SaleSysBIL
{
    public class Commoditys
    {
        public Commoditys()
        { }

        /// <summary>
        /// 返回全部商品信息
        /// </summary>
        /// <returns>IList</returns>
        public IList<Commodity> SelectAll()
        {
            string strSql = "SELECT Commodity.CommId,  Commodity.CommName,Commodity.CommShortName,  Commodity.CommProducePlace, "+
                     "Commodity.Unit,  Commodity.Specs,  Commodity.PassNumber,Commodity.PassList,  Company.ComName,  Commodity.Remark, "+
                     "Commodity.ComAddTime FROM  Commodity INNER JOIN Company ON  Commodity.ComId =  Company.ComId ";

            IList<Commodity> commoditys = new List<Commodity>();
            SqlDataReader reader = null;

            try
            {
                reader = SqlHelper.ExecuteReader(strSql, null);
                while (reader.Read())
                {
                    commoditys.Add(new Commodity(reader));
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return commoditys;
        }

        /// <summary>
        /// 根据Id返回数据表中数据
        /// </summary>
        /// <param name="ID">商品Id</param>
        /// <returns>List</returns>
        public IList<Commodity> SelectInfoByID(Guid ID)
        {
            string strSql = "SELECT Commodity.CommId,  Commodity.CommName,Commodity.CommShortName,  Commodity.CommProducePlace, " +
                     "Commodity.Unit,  Commodity.Specs,  Commodity.PassNumber,Commodity.PassList,  Company.ComName,  Commodity.Remark, " +
                     "Commodity.ComAddTime FROM  Commodity INNER JOIN Company ON  Commodity.ComId =  Company.ComId  AND Commodity.CommId = @comid";
            SqlParameter[] sqlPames = new SqlParameter[1];
            sqlPames[0] = new SqlParameter("@comid",ID);

            IList<Commodity> commoditys = new List<Commodity>();
            SqlDataReader reader = null;

            try
            {
                reader = SqlHelper.ExecuteReader(strSql, sqlPames);
                while (reader.Read())
                {
                    commoditys.Add(new Commodity(reader));
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return commoditys;
        }

        /// <summary>
        /// 向数据库中商品表插入一条数据
        /// </summary>
        /// <param name="commname">商品名称</param>
        /// <param name="commsn">商品简称</param>
        /// <param name="commpp">商品产地</param>
        /// <param name="unit">商品单位</param>
        /// <param name="specs">商品规格</param>
        /// <param name="passnu">商品批号</param>
        /// <param name="compl">批准文号</param>
        /// <param name="commid">供应商ID</param>
        /// <param name="remark">备注</param>
        /// <returns>整型</returns>
        public int InsertCommodity(string commname, string commsn, string commpp, string unit, string specs, string passnu, string compl, string commid, string remark)
        {
            DateTime DT = DateTime.Now;
            string strInsert = "INSERT INTO Commodity Values(newid(),@commname,@commsn,@compp,@communit,@commspecs,@commpn,@compl,@comid, "+
                               "@comremark,@datetime)";
            SqlParameter[] sqlPams = new SqlParameter[10];
            sqlPams[0] = new SqlParameter("@commname", commname);
            sqlPams[1] = new SqlParameter("@commsn", commsn);
            sqlPams[2] = new SqlParameter("@compp", commpp);
            sqlPams[3] = new SqlParameter("@communit", unit);
            sqlPams[4] = new SqlParameter("@commspecs", specs);
            sqlPams[5] = new SqlParameter("@commpn", passnu);
            sqlPams[6] = new SqlParameter("@compl", compl);
            sqlPams[7] = new SqlParameter("@comid", commid);
            sqlPams[8] = new SqlParameter("@comremark", remark);
            sqlPams[9] = new SqlParameter("@datetime", DT);

            int i = 0;
            try
            {
                i = SqlHelper.ExecuteNonQuery(strInsert, sqlPams);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return i;
        }

        /// <summary>
        /// 更新数据库中商品表的数据
        /// </summary>
        /// <param name="commid">商品ID</param>
        ///<param name="commname">商品名称</param>
        /// <param name="commsn">商品简称</param>
        /// <param name="commpp">商品产地</param>
        /// <param name="unit">商品单位</param>
        /// <param name="specs">商品规格</param>
        /// <param name="passnu">商品批号</param>
        /// <param name="compl">批准文号</param>
        /// <param name="commid">供应商ID</param>
        /// <param name="remark">备注</param>
        /// <returns>整型</returns>
        public int UpdateCommodity(Guid commid, string commname, string commsn, string commpp, string unit, string specs, string passnu, string compl,Guid comid, string remark)
        {
            string strInsert = "Update Commodity SET CommName = @commname,CommShortName = @commsn,CommProducePlace = @commpp,Unit= @communit, " +
            " Specs = @commspecs,PassNumber = @commpn,PassList = @commpl,ComId = @comid, Remark = @commrem WHERE CommId = @cid";
            SqlParameter[] sqlPams = new SqlParameter[10];
            sqlPams[0] = new SqlParameter("@commname", commname);
            sqlPams[1] = new SqlParameter("@commsn", commsn);
            sqlPams[2] = new SqlParameter("@commpp", commpp);
            sqlPams[3] = new SqlParameter("@communit", unit);
            sqlPams[4] = new SqlParameter("@commspecs", specs);
            sqlPams[5] = new SqlParameter("@commpn", passnu);
            sqlPams[6] = new SqlParameter("@commpl", compl);
            sqlPams[7] = new SqlParameter("@comid", comid);
            sqlPams[8] = new SqlParameter("@commrem", remark);
            sqlPams[9] = new SqlParameter("@cid", commid);

            int i = 0;
            try
            {
                i = SqlHelper.ExecuteNonQuery(strInsert, sqlPams);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return i;
        }

        /// <summary>
        /// 根据ID删除数据库中商品表的数据
        /// </summary>
        /// <param name="commid">商品ID</param>
        /// <returns>整型</returns>
        public int delCommodity(Guid commid)
        {
            string strDel = "DELETE FROM Commodity WHERE CommId = @commid";
            SqlParameter[] sqlPams = new SqlParameter[1];
            sqlPams[0] = new SqlParameter("@commid", commid);

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
