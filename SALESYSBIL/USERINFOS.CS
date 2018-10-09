using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SaleSysEL;
using SaleSysDIL;

namespace SaleSysBIL
{
    public class UserInfos
    {
        public UserInfos()
        { }

        public bool ckLogin(string uname, string pwd)
        {
            string strSql = "SELECT count(*) FROM UserInfo WHERE UName = @uname and UPwd = @pwd";
            SqlParameter[] sqlPams = new SqlParameter[2];
            sqlPams[0] = new SqlParameter("@uname",uname);
            sqlPams[1] = new SqlParameter("@pwd", pwd);

            int i = 0;
            try
            {
                i = (int)SqlHelper.ExecuteScalar(strSql, sqlPams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            if (i == 0)
                return false;
            return true;
        }

        public int InsertUser(string Name,string Pwd,Guid qx)
        {
            string strInsert = "insert into UserInfo Values(newid(),@name,@pwd,@qx)";
            SqlParameter[] sqlPams = new SqlParameter[3];
            sqlPams[0] = new SqlParameter("@name",Name);
            sqlPams[1] = new SqlParameter("@pwd", Pwd);
            sqlPams[2] = new SqlParameter("@qx",qx);

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

        public IList<UserInfo> SelectAll()
        {
            string strSql = "SELECT UserInfo.Uid, UserInfo.UName,UserInfo.UPwd,UserPower.UPName FROM dbo.UserInfo INNER JOIN "+
                            "UserPower ON dbo.UserInfo.Upower = dbo.UserPower.UPID";
            IList<UserInfo> user = new List<UserInfo>();
            SqlDataReader reader = null;

            try
            {
                reader = SqlHelper.ExecuteReader(strSql, null);
                while (reader.Read())
                {
                    user.Add(new UserInfo(reader));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return user;
        }
    }
}
