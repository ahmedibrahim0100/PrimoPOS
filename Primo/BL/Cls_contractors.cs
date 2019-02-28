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
    class Cls_contractors
    {
        public DataTable SelectContractor(string contractor_identifier)
        {
            Cls_DataAccessLayer DAL = new Cls_DataAccessLayer();
            DataTable dt = new DataTable();
            DAL.OpenCon();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@contractor_identifier", SqlDbType.VarChar,100);
            param[0].Value = contractor_identifier;
            dt = DAL.SelectData("SelectContractor", param);
            DAL.CloseCon();
            return dt;
        }
    }
}
