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

using System.Text;
using System.Windows.Forms;

namespace Primo.PL
{
    public partial class Frm_TenderCredit : Syncfusion.Windows.Forms.MetroForm
    {
        public Frm_TenderCredit()
        {
            InitializeComponent();
            //The following (if) related to the region (Get Control on this form from other forms)
            if (_Frm_TenderCredit == null)
            {
                _Frm_TenderCredit = this;
            }
        }

        #region Get Control on this form from other forms
        //The following lines are to get a control of Frm_TenderCredit from other forms
        //without creating an instance
        private static Frm_TenderCredit _Frm_TenderCredit;
        static void _Frm_TenderCredit_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Frm_TenderCredit = null;
        }
        //Getter
        public static Frm_TenderCredit GetFrm_TenderCredit
        {
            get
            {
                if (_Frm_TenderCredit == null)
                {
                    _Frm_TenderCredit = new Frm_TenderCredit();
                    _Frm_TenderCredit.FormClosed += new FormClosedEventHandler(_Frm_TenderCredit_FormClosed);
                }
                return _Frm_TenderCredit;
            }
        }
        #endregion




        #region txtbxCustomerPaysValue eventhandlers
        private void txtbxCustomerPaysValue_Validated(object sender, EventArgs e)
        {
            if (txtbxCustomerPaysValue.Text != null && txtbxCustomerPaysValue.Text != "")
            {
                txtbxCustomerPaysPerc.Text = ((Convert.ToDecimal(txtbxCustomerPaysValue.Text) / Convert.ToDecimal(txtbxTotal.Text)) * 100).ToString();
                txtbxContractorPaysValue.Text = (Convert.ToDecimal(txtbxTotal.Text) - Convert.ToDecimal(txtbxCustomerPaysValue.Text)).ToString();
            }
            else
            {
                txtbxCustomerPaysValue.Text = "0";
            }
            btnConfirm.Focus();
        }

        private void txtbxCustomerPaysValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbxCustomerPaysValue_Validated(sender, e);
                //txtbxCustomerPaysPerc.Text = ((Convert.ToDecimal(txtbxCustomerPaysValue.Text) / Convert.ToDecimal(txtbxTotal.Text)) * 100).ToString();
                //txtbxContractorPaysValue.Text = (Convert.ToDecimal(txtbxTotal.Text) - Convert.ToDecimal(txtbxCustomerPaysValue.Text)).ToString();
            }
        }

        private void txtbxCustomerPaysValue_TextChanged(object sender, EventArgs e)
        {
            if (txtbxCustomerPaysValue.Focused == false)
            {
                txtbxCustomerPaysValue_Validated(sender, e);
            }

            //if (txtbxCustomerPaysValue.Text != null && txtbxCustomerPaysValue.Text != "0" && txtbxCustomerPaysValue.Text != "")
            //{
            //    txtbxCustomerPaysPerc.Text = ((Convert.ToDecimal(txtbxCustomerPaysValue.Text) / Convert.ToDecimal(txtbxTotal.Text)) * 100).ToString();
            //    txtbxContractorPaysValue.Text = (Convert.ToDecimal(txtbxTotal.Text) - Convert.ToDecimal(txtbxCustomerPaysValue.Text)).ToString();
            //}
            
        }

        #endregion




        #region txtbxCustomerPaysPerc eventhandlers
        private void txtbxCustomerPaysPerc_Validated(object sender, EventArgs e)
        {
            if (txtbxCustomerPaysPerc.Text != null && txtbxCustomerPaysPerc.Text != "")
            {
                txtbxCustomerPaysValue.Text = ((Convert.ToDecimal(txtbxCustomerPaysPerc.Text) * Convert.ToDecimal(txtbxTotal.Text)) / 100).ToString();
                btnConfirm.Focus();
            }
            else
            {
                txtbxCustomerPaysPerc.Text = "0";
            }
            btnConfirm.Focus();
        }

        private void txtbxCustomerPaysPerc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbxCustomerPaysPerc_Validated(sender, e);
                //txtbxCustomerPaysValue.Text = ((Convert.ToDecimal(txtbxCustomerPaysPerc.Text) * Convert.ToDecimal(txtbxTotal.Text)) / 100).ToString();
            }

        }
        #endregion



        #region txtbxContractorPaysValue eventhandlers
        private void txtbxContractorPaysValue_Validated(object sender, EventArgs e)
        {
            if (txtbxContractorPaysValue.Text != null && txtbxContractorPaysValue.Text != "")
            {
                txtbxContractorPaysPerc.Text = ((Convert.ToDecimal(txtbxContractorPaysValue.Text) / Convert.ToDecimal(txtbxTotal.Text)) * 100).ToString();
                txtbxCustomerPaysValue.Text = (Convert.ToDecimal(txtbxTotal.Text) - Convert.ToDecimal(txtbxContractorPaysValue.Text)).ToString();
            }
            else
            {
                txtbxContractorPaysValue.Text = "0";
            }
            btnConfirm.Focus();
        }

        private void txtbxContractorPaysValue_TextChanged(object sender, EventArgs e)
        {
            if (txtbxContractorPaysValue.Focused == false)
            {
                txtbxContractorPaysValue_Validated(sender, e);
            }
            //if (txtbxContractorPaysValue.Text != null && txtbxContractorPaysValue.Text != "0" && txtbxContractorPaysValue.Text != "")
            //{
            //    txtbxContractorPaysPerc.Text = ((Convert.ToDecimal(txtbxContractorPaysValue.Text) / Convert.ToDecimal(txtbxTotal.Text)) * 100).ToString();
            //    txtbxCustomerPaysValue.Text = (Convert.ToDecimal(txtbxTotal.Text) - Convert.ToDecimal(txtbxContractorPaysValue.Text)).ToString();
            //}
        }

        private void txtbxContractorPaysValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbxContractorPaysValue_Validated(sender, e);
                //txtbxContractorPaysPerc.Text = ((Convert.ToDecimal(txtbxContractorPaysValue.Text) / Convert.ToDecimal(txtbxTotal.Text)) * 100).ToString();
                //txtbxCustomerPaysValue.Text = (Convert.ToDecimal(txtbxTotal.Text) - Convert.ToDecimal(txtbxContractorPaysValue.Text)).ToString();

            }
        }
        #endregion



        #region txtbxContractorPaysPerc eventhandlers
        private void txtbxContractorPaysPerc_Validated(object sender, EventArgs e)
        {
            if (txtbxContractorPaysPerc.Text != null && txtbxContractorPaysPerc.Text != "")
            {
                txtbxContractorPaysValue.Text = ((Convert.ToDecimal(txtbxContractorPaysPerc.Text) * Convert.ToDecimal(txtbxTotal.Text)) / 100).ToString();
            }
            else
            {
                txtbxContractorPaysPerc.Text = "0";
            }
            btnConfirm.Focus();
        }

        private void txtbxContractorPaysPerc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbxContractorPaysPerc_Validated(sender, e);
                //txtbxContractorPaysValue.Text = ((Convert.ToDecimal(txtbxContractorPaysPerc.Text) * Convert.ToDecimal(txtbxTotal.Text)) / 100).ToString();
            }
        }


        #endregion

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //The condition is to finish the whole invoice if the customer pays zero
            if (Convert.ToDecimal(txtbxCustomerPaysValue.Text) <= 0)
            {
                Hide();
                Frm_Invoice.GetFrm_Invoice.SaveInvoiceData();
                Cls_Transactions _Cls_Transactions = new Cls_Transactions();
                _Cls_Transactions.InsertTotb_Transactions_Payment(_Cls_Transactions.GetTransactionNo(), Convert.ToDecimal(txtbxContractorPaysValue.Text),
                    "credit", Convert.ToInt32(Frm_Invoice.GetFrm_Invoice.lblContractorCode.Text),null, null);
                Frm_Invoice.GetFrm_Invoice.Enabled = false;
                Frm_PrintQuestion _Frm_PrintQuestion = new Frm_PrintQuestion();
                _Frm_PrintQuestion.ShowDialog(Frm_Invoice.GetFrm_Invoice);
                Close();
            }
            else
            {
                Frm_Tender _Frm_Tender = new Frm_Tender();
                _Frm_Tender.CreditInvoice = true;
                _Frm_Tender.txtbxTotal.Text = txtbxCustomerPaysValue.Text;
                _Frm_Tender.txtbxPaid.Text = txtbxCustomerPaysValue.Text;
                _Frm_Tender.txtbxCash.Text = txtbxCustomerPaysValue.Text;
                _Frm_Tender.btnConfirm.Focus();
                _Frm_Tender.ShowDialog(Frm_Invoice.GetFrm_Invoice);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
