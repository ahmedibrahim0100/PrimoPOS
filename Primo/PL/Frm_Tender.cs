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
            if (Convert.ToDecimal(txtbxChange) == 0 | Convert.ToDecimal(txtbxChange.Text) > 0)
            {
                if (txtbxCredit.Text != "0" && lblContractorName.Text == "Contractor Name")
                {
                    MessageBox.Show("Choose Contractor");
                }
                else {
                    Hide();

                    Frm_Invoice.GetFrm_Invoice.UpdateItemsQuantities();
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
                lblContractorName.Visible = true;
                popupContractors.Visible = false;
            }
        }

        private void dgvContractors_DoubleClick(object sender, EventArgs e)
        {
            picboxInvalidContractor.Visible = false;
            lblContractorName.Text = dgvContractors.CurrentRow.Cells[1].Value.ToString();
            lblContractorName.Visible = true;
            popupContractors.Visible = false;
        }

        private void btnPickPopupcontractors_Click(object sender, EventArgs e)
        {
            picboxInvalidContractor.Visible = false;
            lblContractorName.Text = dgvContractors.CurrentRow.Cells[1].Value.ToString();
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
