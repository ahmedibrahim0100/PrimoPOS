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
    public partial class Frm_Tender : Syncfusion.Windows.Forms.MetroForm
    {
        public bool CreditInvoice { get; set; } = false;

        public Frm_Tender()
        {
            InitializeComponent();
            
            
        }

        //I need a clock image neer the label Credit

        #region Functions

        private void CalculatetxtbxPaid()
        {
            txtbxPaid.Text = (Convert.ToDecimal(txtbxCash.Text)+Convert.ToDecimal(txtbxCard_1.Text)+
                Convert.ToDecimal(txtbxCard_2.Text)+Convert.ToDecimal(txtbxCard_3.Text)).ToString();
        }

        private decimal GetCashPayment()
        {
            return Convert.ToDecimal(txtbxCash.Text) - Convert.ToDecimal(txtbxChange.Text);
        }

        private void InsertPayments()
        {
            Cls_Transactions _Cls_Transactions = new Cls_Transactions();
            int transactionNo = _Cls_Transactions.GetTransactionNo();
            if (CreditInvoice == true)
            {
                _Cls_Transactions.InsertTotb_Transactions_Payment(transactionNo, Convert.ToDecimal(Frm_TenderCredit.GetFrm_TenderCredit.txtbxContractorPaysValue.Text),
"credit", Convert.ToInt32(Frm_Invoice.GetFrm_Invoice.lblContractorCode.Text), null, null);
            }
            if(Convert.ToDecimal(txtbxCash.Text) > 0)
            {
                _Cls_Transactions.InsertTotb_Transactions_Payment(transactionNo, GetCashPayment(),
                    "cash", null, null, null);
            }
            if(Convert.ToDecimal(txtbxCard_1.Text) > 0)
            {
                _Cls_Transactions.InsertTotb_Transactions_Payment(transactionNo, Convert.ToDecimal(txtbxCard_1.Text),
                    "card", null, txtbxCardNo.Text, txtbxBank.Text);
            }
            if (Convert.ToDecimal(txtbxCard_2.Text) > 0)
            {
                _Cls_Transactions.InsertTotb_Transactions_Payment(transactionNo, Convert.ToDecimal(txtbxCard_2.Text),
                    "card", null, txtbxCardNo_2.Text, txtbxBank_2.Text);
            }
            if (Convert.ToDecimal(txtbxCard_3.Text) > 0)
            {
                _Cls_Transactions.InsertTotb_Transactions_Payment(transactionNo, Convert.ToDecimal(txtbxCard_3.Text),
                    "card", null, txtbxCardNo_3.Text, txtbxBank_3.Text);
            }
            if(Convert.ToDecimal(txtbxCredit.Text) > 0)
            {
                _Cls_Transactions.InsertTotb_Transactions_Payment(transactionNo, Convert.ToDecimal(txtbxCredit.Text),
                    "credit", Convert.ToInt32(lblContractorCode.Text), null, null);
            }

        }

        #endregion

        #region txtbxPaid eventhandlers

        private void txtbxPaid_Validated(object sender, EventArgs e)
        {
            
        }

        private void txtbxPaid_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtbxPaid_TextChanged(object sender, EventArgs e)
        {
                txtbxChange.Text = (Convert.ToDecimal(txtbxPaid.Text) - Convert.ToDecimal(txtbxTotal.Text)).ToString();
        }

        #endregion



        #region btnConfirm & btnCancel
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtbxChange.Text) >= 0 )
            {
                if (Convert.ToDecimal(txtbxCredit.Text) != 0 && Convert.ToDecimal(lblContractorCode.Text) == 0)
                {
                    Frm_ContractorError _Frm_ContractorError = new Frm_ContractorError();
                    _Frm_ContractorError.ShowDialog(this);
                }
                else
                {
                    Hide();

                    Frm_Invoice.GetFrm_Invoice.SaveInvoiceData();
                    InsertPayments();
                    Frm_Invoice.GetFrm_Invoice.Enabled = false;
                    Frm_PrintQuestion _Frm_PrintQuestion = new Frm_PrintQuestion();
                    _Frm_PrintQuestion.ShowDialog(Frm_Invoice.GetFrm_Invoice);
                    Frm_TenderCredit.GetFrm_TenderCredit.Close();
                    Close();
                }
            }
            else
            {
                Frm_PaymentError _Frm_PaymentError = new Frm_PaymentError();
                _Frm_PaymentError.ShowDialog(this);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void radioCard_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        #region txtbxCash eventhandlers
        private void txtbxCash_Validated(object sender, EventArgs e)
        {
            CalculatetxtbxPaid();
        }

        private void txtbxCash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbxCash_Validated(sender, e);
            }
        }

        private void txtbxCash_TextChanged(object sender, EventArgs e)
        {
            if (txtbxCash.Focused == false)
            {
                txtbxCash_Validated(sender, e);
            }
        }


        #endregion

        private void lblPlusSign_Click(object sender, EventArgs e)
        {
            
        }

        #region Cards eventhandlers
        //performed already through the Properties window

        #endregion

        #region Credit eventhandlers

        //txtbxCredit eventhandlers performed already through Properties window
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
                    lblContractorCode.Text = dt_contractors.Rows[0][0].ToString();
                    lblContractorName.Visible = true;
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
                lblContractorCode.Text = dgvContractors.CurrentRow.Cells[0].Value.ToString();
                lblContractorName.Visible = true;
                popupContractors.Visible = false;
            }
        }

        private void dgvContractors_DoubleClick(object sender, EventArgs e)
        {
            picboxInvalidContractor.Visible = false;
            lblContractorName.Text = dgvContractors.CurrentRow.Cells[1].Value.ToString();
            lblContractorCode.Text = dgvContractors.CurrentRow.Cells[0].Value.ToString();
            lblContractorName.Visible = true;
            popupContractors.Visible = false;
        }

        private void btnPickPopupcontractors_Click(object sender, EventArgs e)
        {
            picboxInvalidContractor.Visible = false;
            lblContractorName.Text = dgvContractors.CurrentRow.Cells[1].Value.ToString();
            lblContractorCode.Text = dgvContractors.CurrentRow.Cells[0].Value.ToString();
            lblContractorName.Visible = true;
            popupContractors.Visible = false;
        }

        private void btnClosePopupContractors_Click(object sender, EventArgs e)
        {
            popupContractors.Visible = false;
        }
        #endregion


    }

        
    }
