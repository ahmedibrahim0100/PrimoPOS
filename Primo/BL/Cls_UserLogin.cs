using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Primo.DAL;

namespace Primo.BL
{

    class Cls_UserLogin
    {   
        public DataTable UserLogin(string user_idd, string user_password)
        {
            Cls_DataAccessLayer Dal = new Cls_DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@user_idd", SqlDbType.VarChar, 50);
            param[0].Value = user_idd;
            param[1] = new SqlParameter("@user_password", SqlDbType.VarChar, 50);
            param[1].Value = user_password;
            Dal.OpenCon();
            DataTable dt = new DataTable();
            dt = Dal.SelectData("UserLogin", param);
            Dal.CloseCon();
            return dt;
        }

        public DataTable SelectUserBy_ID(string user_idd)
        {
            Cls_DataAccessLayer Dal = new Cls_DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@user_idd", SqlDbType.VarChar, 50);
            param[0].Value = user_idd;
            Dal.OpenCon();
            DataTable dt = new DataTable();
            dt = Dal.SelectData("SelectUserBy_ID", param);
            Dal.CloseCon();
            return dt;
        }

        public DataTable SelectUserBy_UserName(string user_namee)
        {
            Cls_DataAccessLayer Dal = new Cls_DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@user_namee", SqlDbType.VarChar, 80);
            param[0].Value = user_namee;
            Dal.OpenCon();
            DataTable dt = new DataTable();
            dt = Dal.SelectData("SelectUserBy_UserName", param);
            Dal.CloseCon();
            return dt;
        }

    }
}
