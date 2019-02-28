#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace Primo.PL
{
    public partial class Frm_PrintQuestion : Syncfusion.Windows.Forms.MetroForm
    {
        public Frm_PrintQuestion()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_Invoice.GetFrm_Invoice.Close();
            Frm_Invoice _Frm = new Frm_Invoice();
            _Frm.MdiParent = Frm_Main.GetFrm_Main;
            _Frm.Dock = DockStyle.Fill;
            _Frm.Show();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_Invoice.GetFrm_Invoice.Close();
            Frm_Invoice _Frm = new Frm_Invoice();
            _Frm.MdiParent = Frm_Main.GetFrm_Main;
            _Frm.Dock = DockStyle.Fill;
            _Frm.Show();
            Close();
        }
    }
}
