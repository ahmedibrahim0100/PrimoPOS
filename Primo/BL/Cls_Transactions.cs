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
    class Cls_Transactions
    {
        
            /// <summary>
            /// Function to insert main transaction data to tb_Transactions_Master
            /// </summary>
            /// <param name="transaction_type"></param>
            /// <param name="transaction_timing"></param>
            /// <param name="user_idd"></param>
            /// <param name="customer_code"></param>
            /// <param name="transaction_sum"></param>
            /// <param name="transaction_no_of_items"></param>
            /// <param name="payment"></param>
            /// <param name="contractor_code"></param>
        public void InsertTransaction_Master(string transaction_type, DateTime transaction_timing, string user_idd, int customer_code,
            decimal transaction_sum, int transaction_no_of_items, decimal transaction_no_of_pcs)
        {
            Cls_DataAccessLayer DAL = new Cls_DataAccessLayer();
            DAL.OpenCon();

            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@transaction_type", SqlDbType.VarChar, 30);
            param[0].Value = transaction_type;
            param[1] = new SqlParameter("@transaction_timing", SqlDbType.DateTime);
            param[1].Value = transaction_timing;
            param[2] = new SqlParameter("@user_idd", SqlDbType.VarChar, 50);
            param[2].Value = user_idd;
            param[3] = new SqlParameter("@customer_code", SqlDbType.Int);
            param[3].Value = customer_code;
            param[4] = new SqlParameter("@transaction_sum", SqlDbType.Decimal);
            param[4].Value = transaction_sum;
            param[5] = new SqlParameter("@transaction_no_of_items", SqlDbType.Int);
            param[5].Value = transaction_no_of_items;
            param[6] = new SqlParameter("@transaction_no_of_pcs", SqlDbType.Decimal);
            param[6].Value = transaction_no_of_pcs;

            DAL.ExecuteCommand("InsertTransaction_Master", param);
            DAL.CloseCon();
        }

//        ALTER proc[dbo].[InsertTransactionItems]
//        @transaction_no int,
//@item_auto_code int,
//@expiry date,
//@transaction_item_quantity decimal(10,3),
//@price decimal(10,3),
//@discount_percentage decimal(10,3),
//@discount decimal(10,3),
//@taxes decimal(10,3),
//@total decimal(10,3)
//As
//INSERT INTO tb_Transactions_Items
//           ([transaction_no]
//           , [item_auto_code]
//           , [expiry]
//           , [transaction_item_quantity]
//           , [price]
//           , [discount_percentage]
//           , [discount]
//           , [taxes]
//           , [total])
//     VALUES
//           (@transaction_no,
//            @item_auto_code,
//            @expiry,
//            @transaction_item_quantity,
//            @price,
//            @discount_percentage,
//            @discount,
//            @taxes,
//            @total)


            /// <summary>
            /// Function to insert item details of a transaction to tb_Transactions_Items
            /// </summary>
            /// <param name="transaction_no"></param>
            /// <param name="item_auto_code"></param>
            /// <param name="transaction_item_quantity"></param>
            /// <param name="value"></param>
        public void InsertTransactionItems(int transaction_no, int item_auto_code, DateTime expiry, decimal transaction_item_quantity, decimal price, 
            decimal discount_percentage, decimal discount, decimal taxes,decimal total)
        {
            Cls_DataAccessLayer DAL = new Cls_DataAccessLayer();
            DAL.OpenCon();

            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@transaction_no", SqlDbType.Int);
            param[0].Value = transaction_no;
            param[1] = new SqlParameter("@item_auto_code", SqlDbType.Int);
            param[1].Value = item_auto_code;
            param[2] = new SqlParameter("@expiry", SqlDbType.Date);
            param[2].Value = expiry;
            param[3] = new SqlParameter("@transaction_item_quantity", SqlDbType.Decimal);
            param[3].Value = transaction_item_quantity;
            param[4].Value = new SqlParameter("@price", SqlDbType.Decimal);
            param[4].Value = price;
            param[5].Value = new SqlParameter("@discount_percentage", SqlDbType.Decimal);
            param[5].Value = discount_percentage;
            param[6].Value = new SqlParameter("@discount", SqlDbType.Decimal);
            param[6].Value = discount;
            param[7].Value = new SqlParameter("@taxes", SqlDbType.Decimal);
            param[7].Value = taxes;
            param[8] = new SqlParameter("@total", SqlDbType.Decimal);
            param[8].Value = total;

            DAL.ExecuteCommand("InsertTransactionItems", param);
            DAL.CloseCon();
        }




        /*create proc GetTransactionNo
As
Select MAX(transaction_no) from tb_Transactions_Master*/

            /// <summary>
            /// Function to get the last transaction number from tb_Transactions_Master
            /// </summary>
            /// <returns></returns>
        public int GetTransactionNo()
        {
            Cls_DataAccessLayer DAL = new Cls_DataAccessLayer();
            DataTable dt = new DataTable();
            int transactionNo;
            DAL.OpenCon();
            dt = DAL.SelectData("GetTransactionNo", null);
            DAL.CloseCon();
            return transactionNo = (int)dt.Rows[0][0];
        }

    }
}
