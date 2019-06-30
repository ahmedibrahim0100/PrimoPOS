using Primo.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primo.BL
{
    class Cls_Vendors
    {
        public DataTable SelectVendorByCode(int vendor_code)
        {
            Cls_DataAccessLayer DAL = new Cls_DataAccessLayer();
            DataTable dt = new DataTable();
            DAL.OpenCon();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@vendor_code", SqlDbType.VarChar, 100);
            param[0].Value = vendor_code;
            dt = DAL.SelectData("SelectVendorByCode", param);
            DAL.CloseCon();
            return dt;
        }

        public DataTable GetAllVendors()
        {
            Cls_DataAccessLayer DAL = new Cls_DataAccessLayer();
            DataTable dt = new DataTable();
            DAL.OpenCon();
            dt = DAL.SelectData("GetAllVendors", null);
            DAL.CloseCon();
            return dt;
        }
    }
}
