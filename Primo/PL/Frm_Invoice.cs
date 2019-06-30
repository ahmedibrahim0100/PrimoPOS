#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Primo.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Primo.PL
{
    public partial class Frm_Invoice : Syncfusion.Windows.Forms.MetroForm
    {
        DataTable maindt = new DataTable();
        DataTable dt = new DataTable();
        Cls_Items Cls = new Cls_Items();
        DateTime lastItemAddedTime;
        

        //The next 2 lines are related to the process of picking the barcode from the scanner
        //          and will be used in Frm_Invoice.Keypress eventhandler 
        //              The process's other sections are found in the constructor and the eventhandler
        DateTime _lastKeystroke = new DateTime(0);
        List<char> _barcode = new List<char>();


        #region Get Control on this form from other forms
        //The following lines are to get a control of Frm_Invoice from other forms
        //without creating an instance
        private static Frm_Invoice _Frm_Invoice;
        static void _Frm_Invoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Frm_Invoice = null;
        }
        //Getter
        public static Frm_Invoice GetFrm_Invoice
        {
            get
            {
                if (_Frm_Invoice == null)
                {
                    _Frm_Invoice = new Frm_Invoice();
                    _Frm_Invoice.FormClosed += new FormClosedEventHandler(_Frm_Invoice_FormClosed);
                }
                return _Frm_Invoice;
            }
        }
        #endregion

        #region Constructor
        public Frm_Invoice()
        {
            InitializeComponent();
            //The following (if) related to the region (Get Control on this form from other forms)
            if (_Frm_Invoice == null)
            {
                _Frm_Invoice = this;
            }

            //related to the process of picking the barcode from the scanner
            //and will be used in Frm_Invoice.Keypress eventhandler
            //The process other sections are found in the member variables declaration and the eventhandler
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Invoice_KeyPress);

            BuildMainDataTable();
            this.Text = string.Format("INVOICE  - {0}",Program.username);
            lblSellerName.Text = Program.username;
            lblSellerName.Visible = true;
            lblUserID.Text = Program.userID;
            lblCustomerCode.Text = "1";
            dgvTransaction.CellEndEdit += dataGridView1_CellEndEdit;
            this.KeyPreview = true;
        }

       
        #endregion
        

        #region Functions
        public void BuildMainDataTable()
        {
            maindt.Columns.Add("Item Code");
            maindt.Columns.Add("Item Name");
            maindt.Columns.Add("Expiry");
            maindt.Columns.Add("Quantity");
            maindt.Columns.Add("Price");
            maindt.Columns.Add("Stock");
            maindt.Columns.Add("Discount %");
            maindt.Columns.Add("Discount");
            maindt.Columns.Add("Taxes");
            maindt.Columns.Add("Total");
            dgvTransaction.DataSource = maindt;
            dgvTransaction.Columns[0].ReadOnly = true;
            dgvTransaction.Columns[1].ReadOnly = true;
            dgvTransaction.Columns[2].ReadOnly = true;
            dgvTransaction.Columns[5].ReadOnly = true;
            dgvTransaction.Columns[9].ReadOnly = true;
        }

        private void CalculateSum()
        {
            
                decimal sum = 0;
                for (int i = 0; i < dgvTransaction.Rows.Count; i++)
                {
                    //decimal sum = 0;
                    decimal total = Convert.ToDecimal(dgvTransaction.Rows[i].Cells[9].Value);
                    sum = sum + total;
                    txtbxSum.Text = sum.ToString();
                }
            
        }

        private DataRow TakeDataToMaindt()
        {
            DataRow r = maindt.NewRow();
            r[0] = dt.Rows[0][0];//Item Code
            r[1] = dt.Rows[0][1];//Item Name
            r[2] = (Convert.ToDateTime(dt.Rows[0][2])).ToShortDateString();//Expiry
            r[3] = 1;//Quantity
            r[4] = dt.Rows[0][4];//Price
            r[5] = dt.Rows[0][3];
            r[6] = 0;//Discount%
            r[7] = 0;//Discount
            r[8] = 0;//Taxes
            r[9] = (Convert.ToDecimal(r[3]) * Convert.ToDecimal(r[4])) - Convert.ToDecimal(r[7]) + Convert.ToDecimal(r[8]);//Total
            return r;
        }

        private void CheckExpireDate (DataRow r)
        {
            if ((Convert.ToDateTime(r[2])).Year < DateTime.Today.Year)
            {
                MessageBox.Show("This item is expired");
                
                dgvTransaction.Rows[dgvTransaction.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
            }
            else if ((Convert.ToDateTime(r[2])).Year == DateTime.Today.Year && (Convert.ToDateTime(r[2])).Month == DateTime.Today.Month)
            {
                MessageBox.Show("This item is expired");
                dgvTransaction.Rows[dgvTransaction.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;

            }
            else if ((Convert.ToDateTime(r[2])).Year == DateTime.Today.Year && (Convert.ToDateTime(r[2])).Month < DateTime.Today.Month)
            {
                MessageBox.Show("This item is expired");
                dgvTransaction.Rows[dgvTransaction.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;

            }
        }

        private void ShowCreditData()
        {
            lblContractorIdentifier.Visible = true;
            txtbxContractorIdentifier.Visible = true;
            lblViewContractorProfile.Visible = true;
            lblPatientName.Visible = true;
            txtbxPatientName.Visible = true;
            lblPatientMembershipNo.Visible = true;
            txtbxPatientMembershipNo.Visible = true;
        }

        private void HideCreditData()
        {
            lblContractorIdentifier.Visible = false;
            txtbxContractorIdentifier.Visible = false;
            lblViewContractorProfile.Visible = false;
            lblContractorName.Visible = false;
            lblPatientName.Visible = false;
            txtbxPatientName.Visible = false;
            lblPatientMembershipNo.Visible = false;
            txtbxPatientMembershipNo.Visible = false;
        }
        

        //private void DataGridViewDecimalNamings()
        //{
        //    decimal item_quantity = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value);
        //    decimal item_price = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value);
        //    decimal item_discount_percentage = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[6].Value);
        //    decimal item_discount = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[7].Value);
        //    decimal taxes = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[8].Value);
        //    decimal total = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[9].Value);
        //}

        private void CalculatetxtbxDiscValue()
        {
            txtbxDisc.Text = ((Convert.ToDecimal(txtbxDiscPerc.Text) * Convert.ToDecimal(txtbxSum.Text)) / 100).ToString();
        }

        private void CalculatetxtbxFinalTotal()
        {
            txtbxFinalTotal.Text = (Convert.ToDecimal(txtbxSum.Text) - Convert.ToDecimal(txtbxDisc.Text)).ToString();
        }

        /// <summary>
        /// Function to update item quantity when invoice is confirmed even if the quantity is bigger than the available stock
        /// </summary>
        public void UpdateItemsQuantities()
        {
            for (int i = 0; i < dgvTransaction.Rows.Count; i++)
            {
                decimal qty_entered = Convert.ToDecimal(dgvTransaction.Rows[i].Cells[3].Value);
                decimal stk = Convert.ToDecimal(dgvTransaction.Rows[i].Cells[5].Value);
                decimal subtract = stk - qty_entered;
                if (subtract < 0)
                {
                    Cls.DeleteFromtb_QtyEx(Convert.ToInt32(dgvTransaction.Rows[i].Cells[0].Value));
                    Cls.InsertTotb_QtyEx(Convert.ToInt32(dgvTransaction.Rows[i].Cells[0].Value), subtract);
                }
                else if (subtract == 0)
                {
                    Cls.DeleteFromtb_QtyEx(Convert.ToInt32(dgvTransaction.Rows[i].Cells[0].Value));
                    Cls.InsertTotb_QtyEx(Convert.ToInt32(dgvTransaction.Rows[i].Cells[0].Value), subtract);

                }
                else if (subtract > 0)
                {
                    DataTable dt_QtyEx = new DataTable();
                    dt_QtyEx = Cls.SelectFromtb_QtyEx(Convert.ToInt32(dgvTransaction.Rows[i].Cells[0].Value));
                    decimal subtract_QtyFromStock_Ex = 0;
                    //decimal qty = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

                    for (int x = 0; x < dt_QtyEx.Rows.Count; x++)
                    {
                        if (x == 0)
                        {
                            subtract_QtyFromStock_Ex = Convert.ToDecimal(dt_QtyEx.Rows[x][2]) - qty_entered;

                        }
                        else
                        {
                            subtract_QtyFromStock_Ex = Convert.ToDecimal(dt_QtyEx.Rows[x][2]) - (0 - subtract_QtyFromStock_Ex);

                        }
                        if (subtract_QtyFromStock_Ex > 0)
                        {
                            Cls.Updatetb_QtyEx(Convert.ToInt32(dt_QtyEx.Rows[x][0]), Convert.ToDateTime(dt_QtyEx.Rows[x][1]), subtract_QtyFromStock_Ex);

                            break;
                        }
                        else if (subtract_QtyFromStock_Ex == 0)
                        {
                            Cls.DeleteFromtb_QtyEx_Expire(Convert.ToInt32(dt_QtyEx.Rows[x][0]), Convert.ToDateTime(dt_QtyEx.Rows[x][1]));

                            break;
                        }
                        else if (subtract_QtyFromStock_Ex < 0)
                        {
                            Cls.DeleteFromtb_QtyEx_Expire(Convert.ToInt32(dt_QtyEx.Rows[x][0]), Convert.ToDateTime(dt_QtyEx.Rows[x][1]));

                        }

                    }
                }
            }
            
        }

        private string GetTransactionType()
        {
            if (radioOnTime.Checked == true)
            {
                return "Pay now";
            }
            else if (radioDelivery.Checked == true)
            {
                return "Delivery";
            }
            else if (radioCredit.Checked == true)
            {
                return "Credit";
            }
            else return "Pay now";
        }


        private int CountOfItems()
        {
            List<string> CheckRepetition = new List<string>();
            for (int i = 0; i < dgvTransaction.Rows.Count; i++)
            {
                string status = "Unique";
                CheckRepetition.Add(status);
            }
            for (int j = 0; j < dgvTransaction.Rows.Count; j++)
            {
                if (CheckRepetition[j] == "Unique")
                {
                    for (int x = j + 1; x < dgvTransaction.Rows.Count; x++)
                    {
                        if (Convert.ToInt32(dgvTransaction.Rows[x].Cells[0].Value) == Convert.ToInt32(dgvTransaction.Rows[j].Cells[0].Value))
                        {
                            CheckRepetition[x] = "Repeated";
                        }         
                    }
                }
            }
            int count = 0;
            foreach (string s in CheckRepetition)
            {
                if (s=="Repeated") count++;
            }
            int countOfItems = 0;
            return countOfItems = dgvTransaction.Rows.Count - count;
        }


        private decimal GetNoOfPcs()
        {
            decimal count = 0;
            for (int i = 0; i < dgvTransaction.Rows.Count; i++)
            {
                decimal itemQty = Convert.ToDecimal(dgvTransaction.Rows[i].Cells[3].Value);
                count = count + itemQty;
            }
            return count;
        }

        public void SaveInvoiceData()
        {
            //Updating quantities

            UpdateItemsQuantities();


            //Filling tb_transactions_Master

            Cls_Transactions _Cls_Transactions = new Cls_Transactions();
            

            _Cls_Transactions.InsertTransaction_Master(GetTransactionType(), DateTime.Now, lblUserID.Text, Convert.ToInt32(lblCustomerCode.Text),
                Convert.ToDecimal(txtbxFinalTotal.Text), CountOfItems(), GetNoOfPcs());


            //Filling tb_Transactions_Items

            int transactionNo = _Cls_Transactions.GetTransactionNo();
           

            for (int i = 0; i < dgvTransaction.Rows.Count; i++)
            {
                _Cls_Transactions.InsertTransactionItems(transactionNo, Convert.ToInt32(dgvTransaction.Rows[i].Cells[0].Value), 
                    Convert.ToDateTime(dgvTransaction.Rows[i].Cells[2].Value),
                    Convert.ToDecimal(dgvTransaction.Rows[i].Cells[3].Value),
                    Convert.ToDecimal(dgvTransaction.Rows[i].Cells[4].Value),
                    Convert.ToDecimal(dgvTransaction.Rows[i].Cells[6].Value),
                    Convert.ToDecimal(dgvTransaction.Rows[i].Cells[7].Value),
                    Convert.ToDecimal(dgvTransaction.Rows[i].Cells[8].Value),
                    Convert.ToDecimal(dgvTransaction.Rows[i].Cells[9].Value));
            }

        }

        private void AddtoDgvTransactions()
        {
            dt = Cls.SelectItem(txtbxItemIdentification.Text);

            if (dt.Rows.Count == 1)
            {
                DataRow r = maindt.NewRow();
                r = TakeDataToMaindt();
                maindt.Rows.Add(r);
                dgvTransaction.DataSource = maindt;
                CalculateSum();
                txtbxItemIdentification.Clear();
                CheckExpireDate(r);
                txtbxItemIdentification.Focus();

            }
            else if (dt.Rows.Count > 1)
            {
                popupPickItem.Visible = true;
                dgvPickItem.DataSource = dt;
                dgvPickItem.Focus();
            }
            else if (dt.Rows.Count < 1)
            {
                MessageBox.Show("not found");
            }

            lastItemAddedTime = DateTime.Now;

            //CalculateSum();
        }

        #endregion


        #region Frm_Invoice eventhandlers
        private void Frm_Invoice_Load(object sender, EventArgs e)
        {
            //txtbxItemIdentification.Focus();
        }

        private void Frm_Invoice_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Frm_Invoice_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            
            if(addItemInterval.TotalMilliseconds > 100)
            {
                // process barcode
                if (e.KeyChar == 13 && _barcode.Count > 1)
                {
                    _barcode.RemoveAt(_barcode.Count - 1);
                    string msg = new String(_barcode.ToArray());
                    txtbxItemIdentification.Text = msg;
                    AddtoDgvTransactions();
                    //MessageBox.Show(msg);
                    _barcode.Clear();
                }
            }
            

        }
        #endregion

        #region dgvTransaction eventhandlers

        //Calculations when quantity, discount or discount percentage get any changes
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            decimal item_quantity = Convert.ToDecimal(dgvTransaction.CurrentRow.Cells[3].Value);
            decimal item_price = Convert.ToDecimal(dgvTransaction.CurrentRow.Cells[4].Value);
            decimal item_discount_percentage = Convert.ToDecimal(dgvTransaction.CurrentRow.Cells[6].Value);
            decimal item_discount = Convert.ToDecimal(dgvTransaction.CurrentRow.Cells[7].Value);
            decimal taxes = Convert.ToDecimal(dgvTransaction.CurrentRow.Cells[8].Value);

            //if Discount value changed: calculate discount% ,then total, then sum of transaction
            if (e.ColumnIndex == 7)
            {
                dgvTransaction.CurrentRow.Cells[6].Value = (item_discount / (item_quantity * item_price)) * 100;
                dgvTransaction.CurrentRow.Cells[9].Value = (item_quantity * item_price) - item_discount + taxes;
                CalculateSum();
            }

            //if Discount% changed: calculate Discount value ,then total, then sum of transaction
            if (e.ColumnIndex == 6)
            {
                dgvTransaction.CurrentRow.Cells[7].Value = ((item_discount_percentage) * (item_quantity * item_price)) / 100;
                dgvTransaction.CurrentRow.Cells[9].Value = (item_quantity * item_price) - item_discount + taxes;
                CalculateSum();
            }

            //after any of the previous cases or in any other case: calculate total, then sum of transaction
            dgvTransaction.CurrentRow.Cells[9].Value = (item_quantity * item_price) - item_discount + taxes;
            CalculateSum();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvTransaction.Rows.Remove(dgvTransaction.CurrentRow);
            CalculateSum();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.Control && e.KeyCode == Keys.Delete)
            {
                deleteToolStripMenuItem_Click(sender, e);
            }
        }


        #endregion

        #region dgvPickItem eventhandlers

        /// <summary>
        /// Picking item from datagridview2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                DataRow r = maindt.NewRow();
                r[0] = dgvPickItem.CurrentRow.Cells[0].Value;//Item Code
                r[1] = dgvPickItem.CurrentRow.Cells[1].Value;//Item Name
                r[2] = Convert.ToDateTime(dgvPickItem.CurrentRow.Cells[2].Value).ToShortDateString();//Expiry
                r[3] = 1;//quantity
                r[4] = dgvPickItem.CurrentRow.Cells[4].Value;//Price
                r[5] = dgvPickItem.CurrentRow.Cells[3].Value;//Stock
                r[6] = 0;//Discount%
                r[7] = 0;//Discount
                r[8] = 0;//Taxes
                r[9] = (Convert.ToDecimal(r[3]) * Convert.ToDecimal(r[4])) - Convert.ToDecimal(r[7]) + Convert.ToDecimal(r[8]);//Total
                maindt.Rows.Add(r);
                dgvTransaction.DataSource = maindt;
                txtbxItemIdentification.Clear();
                CalculateSum();
                CheckExpireDate(r);
            }

        }

        private void popupControlContainer1_KeyPress(object sender, KeyEventArgs e)
        {

        }

        private void buttonAdv6_Click(object sender, EventArgs e)
        {
            popupPickItem.Visible = false;
        }
        #endregion

        #region txtbxItemIdentification eventhandlers

        /// <summary>
        /// The txtbxItemIdentification allows the user to insert the item auto code or barcode, use it as searchbox by inserting part of item name.
        /// If more than one item found, a popupcontainer shows up with a datagridview to choose from
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtbxItemIdentification_KeyDown(object sender, KeyEventArgs e)
        {

            //dt = Cls.SelectItem(txtbxItemIdentification.Text);
            if (e.KeyCode == Keys.Enter)
            {
                AddtoDgvTransactions();
            }
        }


        #endregion

        #region panelTotals eventhandlers

        private void txtbxDiscPerc_Validated(object sender, EventArgs e)
        {
            CalculatetxtbxDiscValue();
            CalculatetxtbxFinalTotal();
            btnTender.Focus();
        }

        private void txtbxDiscPerc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)
            {
                txtbxDiscPerc_Validated(sender, e);
            }
        }

        private void txtbxDisc_Validated(object sender, EventArgs e)
        {
            txtbxDiscPerc.Text = ((Convert.ToDecimal(txtbxDisc.Text) / Convert.ToDecimal(txtbxSum.Text)) * 100).ToString();
            CalculatetxtbxFinalTotal();
            btnTender.Focus();
        }

        private void txtbxDisc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)
            {
                txtbxDisc_Validated(sender, e);
            }
        }

        private void txtbxSum_TextChanged(object sender, EventArgs e)
        {
            CalculatetxtbxDiscValue();
            CalculatetxtbxFinalTotal();
            
        }

        //for lblSum -- empty
        private void label11_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region panelActions eventhandlers
        private void btnTender_Click(object sender, EventArgs e)
        {
            if (dgvTransaction.Rows.Count > 0 && radioCredit.Checked==false)
            {
                Frm_Tender _Frm_Tender = new Frm_Tender();
                _Frm_Tender.txtbxTotal.Text = txtbxFinalTotal.Text;
                _Frm_Tender.txtbxPaid.Text = txtbxFinalTotal.Text;
                _Frm_Tender.txtbxCash.Text = txtbxFinalTotal.Text;
                _Frm_Tender.btnConfirm.Focus();
                _Frm_Tender.ShowDialog(this);
            }
            else if(dgvTransaction.Rows.Count > 0 && radioCredit.Checked == true)
            {
                Frm_TenderCredit _Frm_TenderCredit = new Frm_TenderCredit();
                _Frm_TenderCredit.txtbxTotal.Text = txtbxFinalTotal.Text;
                //_Frm_TenderCredit.txtbxCustomerPaysValue.Text = "0";
                //_Frm_TenderCredit.txtbxCustomerPaysPerc.Text = "0";
                _Frm_TenderCredit.txtbxContractorPaysValue.Text = txtbxFinalTotal.Text;
                _Frm_TenderCredit.txtbxContractorPaysPerc.Text = "100";
                _Frm_TenderCredit.btnConfirm.Focus();
                _Frm_TenderCredit.ShowDialog(this);
            }
            else
            {
                Frm_TenderError _Frm_TenderError = new Frm_TenderError();
                _Frm_TenderError.ShowDialog(this);
            }
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    decimal qty_entered = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
            //    decimal stk = Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
            //    decimal subtract = stk - qty_entered;
            //    if (subtract < 0)
            //    {
            //        Cls.DeleteFromtb_QtyEx(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value));
            //        Cls.InsertTotb_QtyEx(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), subtract);
            //    }else if(subtract==0)
            //    {
            //        Cls.DeleteFromtb_QtyEx(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value));
            //        Cls.InsertTotb_QtyEx(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), subtract);

            //    }else if (subtract > 0)
            //    {
            //        DataTable dt_QtyEx = new DataTable();
            //        dt_QtyEx = Cls.SelectFromtb_QtyEx(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value));
            //        decimal subtract_QtyFromStock_Ex = 0;
            //        //decimal qty = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

            //        for (int x = 0; x < dt_QtyEx.Rows.Count; x++)
            //        {
            //            if (x == 0)
            //            {
            //                subtract_QtyFromStock_Ex = Convert.ToDecimal(dt_QtyEx.Rows[x][2]) - qty_entered;

            //            }
            //            else
            //            {
            //                subtract_QtyFromStock_Ex = Convert.ToDecimal(dt_QtyEx.Rows[x][2]) - (0 - subtract_QtyFromStock_Ex);

            //            }
            //            if (subtract_QtyFromStock_Ex > 0)
            //            {
            //                Cls.Updatetb_QtyEx(Convert.ToInt32(dt_QtyEx.Rows[x][0]), Convert.ToDateTime(dt_QtyEx.Rows[x][1]), subtract_QtyFromStock_Ex);

            //                break;
            //            }
            //            else if (subtract_QtyFromStock_Ex == 0)
            //            {
            //                Cls.DeleteFromtb_QtyEx_Expire(Convert.ToInt32(dt_QtyEx.Rows[x][0]), Convert.ToDateTime(dt_QtyEx.Rows[x][1]));

            //                break;
            //            }
            //            else if (subtract_QtyFromStock_Ex < 0)
            //            {
            //                Cls.DeleteFromtb_QtyEx_Expire(Convert.ToInt32(dt_QtyEx.Rows[x][0]), Convert.ToDateTime(dt_QtyEx.Rows[x][1]));

            //            }

            //        }
            //    }
            //}

        }

        private void btnQuickTender_Click(object sender, EventArgs e)
        {
            if (dgvTransaction.Rows.Count > 0 && (radioOnTime.Checked == true | radioDelivery.Checked == true))
            {
                SaveInvoiceData();
                Cls_Transactions _Cls_Transactions = new Cls_Transactions();
                _Cls_Transactions.InsertTotb_Transactions_Payment(_Cls_Transactions.GetTransactionNo(), Convert.ToDecimal(txtbxFinalTotal.Text),
                    "cash", null, null, null);
                this.Enabled = false;
                this.Hide();
                Frm_Invoice _Frm_Invoice = new Frm_Invoice();
                _Frm_Invoice.MdiParent = Frm_Main.GetFrm_Main;
                _Frm_Invoice.Dock = DockStyle.Fill;
                _Frm_Invoice.Show();
                this.Close();
            }
            else
            {
                Frm_TenderError _Frm_TenderError = new Frm_TenderError();
                _Frm_TenderError.ShowDialog(this);
            }
        }

        #endregion

            #region grbbxSeller eventhandlers

        private void txtbxSellerID_Validated(object sender, EventArgs e)
        {
            Cls_UserLogin _Cls_UserLogin = new Cls_UserLogin();
            DataTable dt_userIdCheck = new DataTable();
            dt_userIdCheck = _Cls_UserLogin.SelectUserBy_ID(txtbxSellerID.Text);
            if (dt_userIdCheck.Rows.Count > 0)
            {
                if (picboxInvalidData.Visible == true)
                {
                    picboxInvalidData.Hide();
                }
                Frm_CheckSeller frm = new Frm_CheckSeller();
                frm.lblUserID.Text = dt_userIdCheck.Rows[0][0].ToString();
                frm.lblUserID.Visible = false;
                frm.ShowDialog(this);

            }
            else
            {
                picboxInvalidData.Visible = true;
            }

        }

        private void txtbxSellerID_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtbxSellerID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbxSellerID_Validated(sender, e);
            }
        }
        #endregion

        #region grbbxCustomer eventhandlers

        private void txtbxCustomerIdentification_KeyDown(object sender, KeyEventArgs e)
        {
            Cls_Customers _Cls_Customers = new Cls_Customers();
            DataTable dt_customers = new DataTable();
            if (e.KeyCode == Keys.Enter)
            {
                dt_customers = _Cls_Customers.SelectCustomer(txtbxCustomerIdentification.Text);

                if (dt_customers.Rows.Count == 1)
                {
                    picboxInvalidCustomer.Visible = false;
                    lblCustomerName.Text = dt_customers.Rows[0][1].ToString();
                    lblCustomerCode.Text = dt_customers.Rows[0][0].ToString();
                    txtbxMedicalHistory.Text = dt_customers.Rows[0][7].ToString();
                    txtbxCustomerNotes.Text = dt_customers.Rows[0][8].ToString();
                }
                else if (dt_customers.Rows.Count > 1)
                {
                    picboxInvalidCustomer.Visible = false;
                    dgvCustomers.DataSource = dt_customers;
                    popupCustomers.Visible = true;
                    dgvCustomers.Focus();
                }
                else if (dt_customers.Rows.Count < 1)
                {
                    picboxInvalidCustomer.Visible = true;
                }


            }

        }

        private void dgvCustomers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblCustomerName.Text = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
                lblCustomerCode.Text = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
                txtbxMedicalHistory.Text = dgvCustomers.CurrentRow.Cells[7].Value.ToString();
                txtbxCustomerNotes.Text = dgvCustomers.CurrentRow.Cells[8].Value.ToString();
                popupCustomers.Visible = false;
            }
        }

        private void btnClosePopupCustomers_Click(object sender, EventArgs e)
        {
            popupCustomers.Visible = false;
        }

        private void btnPickPopupCustomers_Click(object sender, EventArgs e)
        {
            lblCustomerName.Text = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
            lblCustomerCode.Text = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
            txtbxMedicalHistory.Text = dgvCustomers.CurrentRow.Cells[7].Value.ToString();
            txtbxCustomerNotes.Text = dgvCustomers.CurrentRow.Cells[8].Value.ToString();
            popupCustomers.Visible = false;
        }

        private void dgvCustomers_DoubleClick(object sender, EventArgs e)
        {
            btnPickPopupCustomers_Click(sender, e);
        }

        private void grpbxCustomer_Enter(object sender, EventArgs e)
        {

        }

        #endregion

        #region RadioButtons eventhandlers

        private void radioDelivery_CheckChanged(object sender, EventArgs e)
        {
            HideCreditData();
        }

        private void radioOnTime_CheckChanged(object sender, EventArgs e)
        {
            if (radioOnTime.Checked == true)
            {
                HideCreditData();
            }
        }

        private void radioCredit_CheckChanged(object sender, EventArgs e)
        {
            ShowCreditData();
        }

        #endregion

        #region contractors eventhandlers
        private void txtbxContractorIdentifier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cls_contractors _Cls_Contractors = new Cls_contractors();
                DataTable dt_contractors = new DataTable();

                dt_contractors = _Cls_Contractors.SelectContractor((txtbxContractorIdentifier.Text));

                if (dt_contractors.Rows.Count == 1)
                {
                    picboxInvalidContractor.Visible = false;
                    lblContractorName.Text = dt_contractors.Rows[0][1].ToString();
                    lblContractorName.Visible = true;
                    lblContractorCode.Text = dt_contractors.Rows[0][0].ToString();
                }
                else if (dt_contractors.Rows.Count > 1)
                {
                    picboxInvalidContractor.Visible = false;
                    dgvContractors.DataSource = dt_contractors;
                    popupContractors.Visible = true;
                    dgvContractors.Focus();
                }
                else if (dt_contractors.Rows.Count < 1)
                {
                    picboxInvalidContractor.Visible = true;
                }
            }

        }

        private void dgvContractors_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                picboxInvalidContractor.Visible = false;
                lblContractorName.Text = dgvContractors.CurrentRow.Cells[1].Value.ToString();
                lblContractorName.Visible = true;
                lblContractorCode.Text = dgvContractors.CurrentRow.Cells[0].Value.ToString();
                popupContractors.Visible = false;
            }
        }

        private void dgvContractors_DoubleClick(object sender, EventArgs e)
        {
            picboxInvalidContractor.Visible = false;
            lblContractorName.Text = dgvContractors.CurrentRow.Cells[1].Value.ToString();
            lblContractorName.Visible = true;
            lblContractorCode.Text = dgvContractors.CurrentRow.Cells[0].Value.ToString();
            popupContractors.Visible = false;
        }

        private void btnPickPopupcontractors_Click(object sender, EventArgs e)
        {
            picboxInvalidContractor.Visible = false;
            lblContractorName.Text = dgvContractors.CurrentRow.Cells[1].Value.ToString();
            lblContractorName.Visible = true;
            lblContractorCode.Text = dgvContractors.CurrentRow.Cells[0].Value.ToString();
            popupContractors.Visible = false;
        }

        private void btnClosePopupContractors_Click(object sender, EventArgs e)
        {
            popupContractors.Visible = false;
        }
        #endregion

        
    }

}
