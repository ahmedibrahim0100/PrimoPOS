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
    public partial class Frm_CheckSeller : Syncfusion.Windows.Forms.MetroForm
    {
        public Frm_CheckSeller()
        {
            InitializeComponent();
        }

        private void Frm_CheckSeller_Shown(object sender, EventArgs e)
        {
            txtbxPassword.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Cls_UserLogin _Cls_UserLogin = new Cls_UserLogin();
            DataTable dt_CheckUser = new DataTable();
            dt_CheckUser=_Cls_UserLogin.UserLogin(lblUserID.Text, txtbxPassword.Text);
            if (dt_CheckUser.Rows.Count > 0)
            {
                Frm_Invoice.GetFrm_Invoice.lblSellerName.Text = dt_CheckUser.Rows[0][2].ToString();
                Frm_Invoice.GetFrm_Invoice.lblUserID.Text = dt_CheckUser.Rows[0][0].ToString();
                Frm_Invoice.GetFrm_Invoice.txtbxSellerID.Clear();
                Frm_Invoice.GetFrm_Invoice.txtbxItemIdentification.Focus();
                this.Close();
            }
            else
            {
                txtbxInvalidPassword.Visible = true;
                txtbxPassword.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_CheckSeller_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }
    }
}
