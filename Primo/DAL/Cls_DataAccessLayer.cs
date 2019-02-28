using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Primo.DAL
{
    class Cls_DataAccessLayer
    {
        SqlConnection con;
        
        public Cls_DataAccessLayer()
        {
            con =new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog = db_PharmacyManager; Integrated Security = True");
        }


        #region DataBase Main Functions
        /// <summary>
        /// /Function to open connection
        /// </summary>
        public void OpenCon()
        {
            if(con.State != ConnectionState.Open)
            {
                con.Open();
            }
                          
        }

        /// <summary>
        /// /Function to close connection
        /// </summary>
        public void CloseCon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        /// <summary>
        /// /Function to select data
        /// </summary>
        /// <param name="stored_procedure"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand(stored_procedure, con);
            cmd.CommandType = CommandType.StoredProcedure;
            if(param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        /// <summary>
        /// /Function to insert, update or delete data
        /// </summary>
        /// <param name="stored_procedure"></param>
        /// <param name="param"></param>
        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand(stored_procedure, con);
            
            cmd.CommandType = CommandType.StoredProcedure;
            if(param != null)
            {
                
                cmd.Parameters.AddRange(param);
            }
            cmd.ExecuteNonQuery();
        }
        
        #endregion
    }
}
