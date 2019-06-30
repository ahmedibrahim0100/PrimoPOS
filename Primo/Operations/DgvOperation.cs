using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primo.Operations
{
    class DgvOperation
    {
        /// <summary>
        /// Function to calculate total value for items in DataGridView and show it in a specified textbox
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="DataGridViewColumnNo"></param>
        /// <param name="txtbxSum"></param>
        public void CalculateSum(DataGridView dgv, int DataGridViewColumnNo, TextBox txtbxSum)
        {
            decimal sum = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                //decimal sum = 0;
                decimal total = Convert.ToDecimal(dgv.Rows[i].Cells[DataGridViewColumnNo].Value);
                sum = sum + total;
                txtbxSum.Text = sum.ToString();
            }
        }


        /// <summary>
        /// Function to return number of items in a DataGridView & excludes repitition
        /// </summary>
        /// <param name="dgv"></param>
        /// <returns></returns>
        public int CountOfItems(DataGridView dgv)
        {
            List<string> CheckRepetition = new List<string>();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                string status = "Unique";
                CheckRepetition.Add(status);
            }
            for (int j = 0; j < dgv.Rows.Count; j++)
            {
                if (CheckRepetition[j] == "Unique")
                {
                    for (int x = j + 1; x < dgv.Rows.Count; x++)
                    {
                        if (Convert.ToInt32(dgv.Rows[x].Cells[0].Value) == Convert.ToInt32(dgv.Rows[j].Cells[0].Value))
                        {
                            CheckRepetition[x] = "Repeated";
                        }
                    }
                }
            }
            int count = 0;
            foreach (string s in CheckRepetition)
            {
                if (s == "Repeated") count++;
            }
            int countOfItems = 0;
            return countOfItems = dgv.Rows.Count - count;
        }

        /// <summary>
        /// Function to return number of pieces in a DataGridView
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="DataGridViewColumnNo"></param>
        /// <returns></returns>
        public decimal GetNoOfPcs(DataGridView dgv, int DataGridViewColumnNo)
        {
            decimal count = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                decimal itemQty = Convert.ToDecimal(dgv.Rows[i].Cells[DataGridViewColumnNo].Value);
                count = count + itemQty;
            }
            return count;
        }
    }
}
