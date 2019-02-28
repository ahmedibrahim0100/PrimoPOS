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
    public partial class Frm_Main : Syncfusion.Windows.Forms.Tools.RibbonForm
    {
        
        public Frm_Main()
        {
            InitializeComponent();
            if (_Frm_Main == null)
            {
                _Frm_Main = this;
            }
        }

        //The following lines are to get a control of Frm_Main from other forms
        //without creating an instance..I took these codes from Khaled Alsaadany course
        private static Frm_Main _Frm_Main;
        static void _Frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Frm_Main = null;
        }
        //Getter
        public static Frm_Main GetFrm_Main
        {
            get
            {
                if (_Frm_Main == null)
                {
                    _Frm_Main = new Frm_Main();
                    _Frm_Main.FormClosed += new FormClosedEventHandler(_Frm_Main_FormClosed);
                }
                return _Frm_Main;
            }
        }

        private void toolStripTabItem2_Click(object sender, EventArgs e)
        {
            

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Frm_Invoice frm = new Frm_Invoice();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            
        }
    }
}
