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
    class Cls_Customers
    {
        public DataTable SelectCustomer(string customer_identifier)
        {
            Cls_DataAccessLayer DAL = new Cls_DataAccessLayer();
            DataTable dt = new DataTable();
            DAL.OpenCon();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@customer_identifier", SqlDbType.VarChar, 100);
            param[0].Value = customer_identifier;
            dt = DAL.SelectData("SelectCustomer", param);
            DAL.CloseCon();
            return dt;
        }
    }
}
