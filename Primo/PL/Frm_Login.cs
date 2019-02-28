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
    
    public partial class Frm_Login : Syncfusion.Windows.Forms.MetroForm
    {
        Cls_UserLogin LogInst = new Cls_UserLogin();

        public Frm_Login()
        {
            InitializeComponent();
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = LogInst.UserLogin(txtBxUserID.Text, txtBxPassword.Text);
            if(dt.Rows.Count>0)
            {
                Program.username = dt.Rows[0][2].ToString();
                Program.userID = dt.Rows[0][0].ToString();
                Frm_Main frm = new Frm_Main();
                this.Hide();
                frm.ShowDialog();
                this.Close();
                
                
            }
            else
            {
                lblInvalidData.Visible = true;
                txtBxUserID.Focus();
            }
                

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }
    }
}
