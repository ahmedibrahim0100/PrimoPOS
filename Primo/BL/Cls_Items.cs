using Primo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Primo.BL
{
    class Cls_Items
    {
        /// <summary>
        /// /Function to insert new items into tb_Items_Master
        /// </summary>
        /// <param name="item_name_en"></param>
        /// <param name="item_name_2"></param>
        /// <param name="company_code"></param>
        /// <param name="price"></param>
        /// <param name="percentage"></param>
        /// <param name="item_class"></param>
        public void AddItem(string item_name_en, string item_name_2,
            string company_code, string price, string percentage,
            string item_class)
        {
            Cls_DataAccessLayer DAL = new Cls_DataAccessLayer();
            DAL.OpenCon();

            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@item_name_en", SqlDbType.VarChar, 100);
            param[0].Value = item_name_en;
            param[1] = new SqlParameter("@item_name_2", SqlDbType.VarChar, 100);
            param[1].Value = item_name_2;
            param[2] = new SqlParameter("@company_code", SqlDbType.Int);
            param[2].Value = company_code;
            param[3] = new SqlParameter("@price", SqlDbType.Decimal);
            param[3].Value = price;
            param[4] = new SqlParameter("@percentage", SqlDbType.Decimal);
            param[4].Value = percentage;
            param[5] = new SqlParameter("@class", SqlDbType.VarChar, 100);
            param[5].Value = item_class;

            DAL.ExecuteCommand("AddItem", param);
            DAL.CloseCon();
        }

        /// <summary>
        /// /function to insert item codes into tb_Items_codes
        /// </summary>
        /// <param name="item_auto_code"></param>
        /// <param name="item_code"></param>
        public void AddItemCodes(string item_auto_code, string item_code)
        {
            Cls_DataAccessLayer DAL = new Cls_DataAccessLayer();
            DAL.OpenCon();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@item_auto_code", SqlDbType.Int);
            param[0].Value = item_auto_code;
            param[1] = new SqlParameter("@item_code", SqlDbType.VarChar, 50);
            param[1].Value = item_code;

            DAL.ExecuteCommand("AddItemCode", param);
            DAL.CloseCon();
        }

        /// <summary>
        /// Function to select item using barcode, autocode, or part of name
        /// </summary>
        /// <param name="item_identifier"></param>
        /// <returns></returns>
        public DataTable SelectItem(string item_identifier)
        {
            Cls_DataAccessLayer DAL = new Cls_DataAccessLayer();
            DataTable dt = new DataTable();
            DAL.OpenCon();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@identifier", SqlDbType.VarChar, 200);
            param[0].Value = item_identifier;
            dt = DAL.SelectData("SelectItem", param);
            DAL.CloseCon();
            return dt;
        }

        /// <summary>
        /// function to select item for purchasing using barcode, autocode, or part of name
        /// </summary>
        /// <param name="item_identifier"></param>
        /// <returns></returns>
        public DataTable SelectItemForPurchasing(string item_identifier)
        {
            Cls_DataAccessLayer DAL = new Cls_DataAccessLayer();
            DataTable dt = new DataTable();
            DAL.OpenCon();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@identifier", SqlDbType.VarChar, 200);
            param[0].Value = item_identifier;
            dt = DAL.SelectData("SelectItemForPurchasing", param);
            DAL.CloseCon();
            return dt;
        }


        /// <summary>
        /// Function to delete from tb_Quantity_Expire
        /// </summary>
        /// <param name="autoCodeIdentifier"></param>
        public void DeleteFromtb_QtyEx(int autoCodeIdentifier)
        {
            Cls_DataAccessLayer DAL = new Cls_DataAccessLayer();
            DAL.OpenCon();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@autoCodeIdentifier", SqlDbType.Int);
            param[0].Value = autoCodeIdentifier;
            
            DAL.ExecuteCommand("DeleteFromtb_QtyEx", param);
            DAL.CloseCon();
        }

        /// <summary>
        /// Function to insert negative quantities to an item when the user
        /// inserts quantity greater than the stock and the expire date will then be null
        /// </summary>
        /// <param name="autoCodeIdentifier"></param>
        /// <param name="qtyStockSubstraction"></param>
        public void InsertTotb_QtyEx(int autoCodeIdentifier, decimal qtyStockSubstraction)
        {
            Cls_DataAccessLayer DAL = new Cls_DataAccessLayer();
            DAL.OpenCon();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@autoCodeIdentifier", SqlDbType.Int);
            param[0].Value = autoCodeIdentifier;
            param[1] = new SqlParameter("@QtyStockSubstraction", SqlDbType.Decimal);
            param[1].Value = qtyStockSubstraction;

            DAL.ExecuteCommand("InsertTotb_QtyEx", param);
            DAL.CloseCon();
        }

        /// <summary>
        /// Function to select from tb_Quantity_Expire
        /// </summary>
        /// <param name="item_auto_code"></param>
        /// <returns></returns>
        public DataTable SelectFromtb_QtyEx(int item_auto_code)
        {
            Cls_DataAccessLayer DAL = new Cls_DataAccessLayer();
            DataTable dt = new DataTable();
            DAL.OpenCon();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@item_auto_code", SqlDbType.Int);
            param[0].Value = item_auto_code;
            dt = DAL.SelectData("SelectFromtb_QtyEx", param);
            DAL.CloseCon();
            return dt;
        }

        /// <summary>
        /// Function to update quantity in tb_Quantity_Expire
        /// </summary>
        /// <param name="item_auto_code"></param>
        /// <param name="expiry_date"></param>
        /// <param name="substract"></param>
        public void Updatetb_QtyEx(int item_auto_code, DateTime expiry_date,decimal substract)
        {
            Cls_DataAccessLayer DAL = new Cls_DataAccessLayer();
            DAL.OpenCon();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@item_auto_code", SqlDbType.Int);
            param[0].Value = item_auto_code;
            param[1] = new SqlParameter("@expiry_date", SqlDbType.Date);
            param[1].Value = expiry_date;
            param[2] = new SqlParameter("@substract", SqlDbType.Decimal);
            param[2].Value = substract;

            DAL.ExecuteCommand("Updatetb_QtyEx", param);
            DAL.CloseCon();
        }

        /// <summary>
        /// Function to delete from tb_Quantity_Expire by item_auto_code & expire_date
        /// </summary>
        /// <param name="item_auto_code"></param>
        /// <param name="expiry_date"></param>
        public void DeleteFromtb_QtyEx_Expire(int item_auto_code,DateTime expiry_date)
        {
            Cls_DataAccessLayer DAL = new Cls_DataAccessLayer();
            DAL.OpenCon();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@item_auto_code", SqlDbType.Int);
            param[0].Value = item_auto_code;
            param[1] = new SqlParameter("@expiry_date", SqlDbType.Date);
            param[1].Value = expiry_date;

            DAL.ExecuteCommand("DeleteFromtb_QtyEx_Expire", param);
            DAL.CloseCon();
        }


    }

}
