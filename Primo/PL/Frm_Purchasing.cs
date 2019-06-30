#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Primo.BL;
using Primo.Operations;
using Primo.PrimoControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace Primo.PL
{
    public partial class Frm_Purchasing : Syncfusion.Windows.Forms.MetroForm
    {
        DataTable mainDt = new DataTable();
        DataTable dt = new DataTable();
        Cls_Items _Cls_Items = new Cls_Items();
        DgvOperation _DgvOperation = new DgvOperation();
        ScannerOperation _ScannerOperation = new ScannerOperation();
        bool isBarcodePicked = false;
        DateTime lastItemAddedTime;

        //The next 2 lines are related to the process of picking the barcode from the scanner
        //          and will be used in Frm_Purchasing.Keypress eventhandler 
        //              The process's other sections are found in the constructor and the eventhandler
        DateTime _lastKeystroke = new DateTime(0);
        List<char> _barcode = new List<char>();

        public Frm_Purchasing()
        {
            InitializeComponent();
            BuildMainDataTable();

            //related to the process of picking the barcode from the scanner
            //and will be used in Frm_Purchasing.Keypress eventhandler
            //The process other sections are found in the member variables declaration and the eventhandler
            //
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Purchasing_KeyPress);
            //
            this.Text = string.Format("Purchasing Invoice  -  {0}", Program.username);
            this.KeyPreview = true;
        }

        #region Functions

        private void BuildMainDataTable()
        {
            mainDt.Columns.Add("Item Code"); //0
            mainDt.Columns.Add("Item Name"); //1
            mainDt.Columns.Add("Quantity"); //2
            mainDt.Columns.Add("Expiry"); //3
            mainDt.Columns.Add("Bonus"); //4
            mainDt.Columns.Add("Stock"); //5
            mainDt.Columns.Add("Price"); //6
            mainDt.Columns.Add("Trade Discount %"); //7
            mainDt.Columns.Add("Discount Value"); //8
            mainDt.Columns.Add("Taxes %"); //9
            mainDt.Columns.Add("Taxes"); //10
            mainDt.Columns.Add("Total"); //11
            dgvPurchasing.DataSource = mainDt;
            dgvPurchasing.Columns[0].ReadOnly = true;
            dgvPurchasing.Columns[1].ReadOnly = true;
            dgvPurchasing.Columns[5].ReadOnly = true;
            dgvPurchasing.Columns[11].ReadOnly = true;
        }

        private DataRow TakeDataToMainDt()
        {
            DataRow r = mainDt.NewRow();
            r[0] = dt.Rows[0][0]; // Item Code 
            r[1] = dt.Rows[0][1]; // Item Name
            r[2] = 1; // Quantity
            r[3] = (Convert.ToDateTime("1/2000")).ToShortDateString(); // Expiry
            r[4] = 0; // Bonus
            r[5] = dt.Rows[0][2]; // Stock
            r[6] = dt.Rows[0][3]; // price
            r[7] = dt.Rows[0][4]; // Discount%

            decimal totalCustomerPrice = Convert.ToDecimal(r[6]) * Convert.ToDecimal(r[2]);
            r[8] = ((totalCustomerPrice) * (Convert.ToDecimal(r[7]))) / 100;  // Discount Value

            decimal primitiveTotalTradePrice = totalCustomerPrice - Convert.ToDecimal(r[8]);             
            r[9] = dt.Rows[0][5]; // Taxes%

            //Calculating Taxes Value: 
            r[10] = (primitiveTotalTradePrice * Convert.ToDecimal(r[9])) / 100; // Taxes Value

            //Calculate Total Trade Price
            r[11] = primitiveTotalTradePrice + Convert.ToDecimal(r[10]);
            return r;
        }

        private void AddtoDgvPurchasing()
        {
            dt = _Cls_Items.SelectItemForPurchasing(txtbxItemIdentification.Text);

            if (dt.Rows.Count == 1)
            {
                DataRow r = mainDt.NewRow();
                r = TakeDataToMainDt();
                mainDt.Rows.Add(r);
                dgvPurchasing.DataSource = mainDt;
                _DgvOperation.CalculateSum(dgvPurchasing, 11, txtbxSumTradePrice);
                txtbxItemIdentification.Clear();
                txtbxItemIdentification.Focus();

            }
            else if (dt.Rows.Count > 1)
            {
                popupPanel.Visible = true;
                popupDgv.DataSource = dt;
                popupDgv.Focus();

            }
            else if (dt.Rows.Count < 1)
            {
                MessageBoxes.MB_NoItemFound _MB_NoItemFound = new MessageBoxes.MB_NoItemFound();
                _MB_NoItemFound.ShowDialog();
            }

            lastItemAddedTime = DateTime.Now;

            //CalculateSum();
        }
        #endregion

        private void combobxVendor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbxVendorInvoiceNo_TextChanged(object sender, EventArgs e)
        {

        }

        #region txtbxItemIdentification eventhandlers
        private void txtbxItemIdentification_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddtoDgvPurchasing();
            }
        }

        #endregion

        #region popupPanel eventhandlers
        private void btnCancelPopupPanel_Click(object sender, EventArgs e)
        {
            popupPanel.Visible = false;
        }
        #endregion



        #region Frm_Purchasing eventhandlers
        private void Frm_Purchasing_KeyPress(object sender, KeyPressEventArgs e)
        
        {
            //_ScannerOperation.PickScannerCode(lastItemAddedTime, e, txtbxItemIdentification, _lastKeystroke, _barcode, isBarcodePicked);
            //if (isBarcodePicked)
            //{
            //    AddtoDgvPurchasing();
            //}
            // check timing (keystrokes within 100 ms)
            TimeSpan elapsed = (DateTime.Now - _lastKeystroke);
            if (elapsed.TotalMilliseconds > 100)
            {
                _barcode.Clear();
            }

            // record keystroke & timestamp
            _barcode.Add(e.KeyChar);
            _lastKeystroke = DateTime.Now;

            TimeSpan addItemInterval = DateTime.Now - lastItemAddedTime;

            if (addItemInterval.TotalMilliseconds > 100)
            {
                // process barcode
                if (e.KeyChar == 13 && _barcode.Count > 1)
                {
                    _barcode.RemoveAt(_barcode.Count - 1);
                    string msg = new String(_barcode.ToArray());
                    txtbxItemIdentification.Text = msg;
                    AddtoDgvPurchasing();
                    //MessageBox.Show(msg);
                    _barcode.Clear();
                }
            }
        }

        #endregion

        private void dgvPurchasing_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            /*("Item Code"); //0
            ("Item Name"); //1
            ("Quantity"); //2
            ("Expiry"); //3
            ("Bonus"); //4
            ("Stock"); //5
            ("Price"); //6
            ("Trade Discount %"); //7
            ("Discount Value"); //8
            ("Taxes %"); //9
            ("Taxes"); //10
            ("Total"); //11
            */
            decimal quantity = Convert.ToDecimal(dgvPurchasing.CurrentRow.Cells[2].Value);
            decimal price = Convert.ToDecimal(dgvPurchasing.CurrentRow.Cells[6].Value);
            decimal tradeDiscountPercentage = Convert.ToDecimal(dgvPurchasing.CurrentRow.Cells[7].Value);
            decimal discountValue = Convert.ToDecimal(dgvPurchasing.CurrentRow.Cells[8].Value);
            decimal taxesPercentage = Convert.ToDecimal(dgvPurchasing.CurrentRow.Cells[9].Value);
            decimal taxes = Convert.ToDecimal(dgvPurchasing.CurrentRow.Cells[10].Value);

            //if trade discount% changed: calculate discount value, assign discount value to the variable discountValue,
            //calculate total, calculate sum of transaction
            if (e.ColumnIndex == 7)
            {
                dgvPurchasing.CurrentRow.Cells[8].Value = ((quantity * price) * tradeDiscountPercentage) / 100;
                discountValue = Convert.ToDecimal(dgvPurchasing.CurrentRow.Cells[8].Value);
                //dgvPurchasing.CurrentRow.Cells[11].Value = (quantity * price) - discountValue + taxes;
                //_DgvOperation.CalculateSum(dgvPurchasing, 11, txtbxSumTradePrice);
            }


            //if discount value changed: calculate trade discount %
            if(e.ColumnIndex == 8)
            {
                dgvPurchasing.CurrentRow.Cells[7].Value = (discountValue / (quantity * price)) * 100;
                tradeDiscountPercentage = Convert.ToDecimal(dgvPurchasing.CurrentRow.Cells[7].Value);
            }

            //if taxes % changed: calculate taxes value
            if (e.ColumnIndex == 9)
            {
                dgvPurchasing.CurrentRow.Cells[10].Value = (((quantity * price) - discountValue) * taxesPercentage) / 100;
                taxes = Convert.ToDecimal(dgvPurchasing.CurrentRow.Cells[10].Value);
            }

            //if taxes value changed: calculate taxes %
            if(e.ColumnIndex == 10)
            {
                dgvPurchasing.CurrentRow.Cells[9].Value = (taxes / ((quantity * price) - discountValue) * 100);
                taxesPercentage = Convert.ToDecimal(dgvPurchasing.CurrentRow.Cells[9].Value);
            }

            //after any of the previous cases or in any other case: calculate total, then sum of transaction
            dgvPurchasing.CurrentRow.Cells[11].Value = (quantity * price) - discountValue + taxes;
            _DgvOperation.CalculateSum(dgvPurchasing, 11, txtbxSumTradePrice);

        }
    }
}
