using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Primo.BL;

namespace Primo.PL
{
    public partial class VendorGroupBox : UserControl
    {
        Cls_Vendors _Cls_Vendors = new Cls_Vendors();
        DataTable vendor_dt = new DataTable();
        protected DateTime codeEditingTime;
        protected DateTime comboSelectionTime;

        public VendorGroupBox()
        {
            InitializeComponent();
            vendor_dt = _Cls_Vendors.GetAllVendors();
            combobxSelectVendor.ValueMember = "vendor_code";
            combobxSelectVendor.DisplayMember = "vendor_name";
            combobxSelectVendor.DataSource = vendor_dt;
        }

        #region combobxSelectVendor eventhandlers
        private void combobxSelectVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeSpan interval = DateTime.Now - codeEditingTime;
            if (interval.TotalMilliseconds < 200)
            {

            }
            else if (interval.TotalMilliseconds > 200)
            {
                comboSelectionTime = DateTime.Now;
                txtbxVendorCode.Text = ((combobxSelectVendor.SelectedIndex) + 1).ToString();
                txtbxVendorBalance.Text = (vendor_dt.Rows[combobxSelectVendor.SelectedIndex][2]).ToString();
            }
        }
        #endregion

        #region txtbxVendorCode eventhandlers
        private void txtbxVendorCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                codeEditingTime = DateTime.Now;
                DataTable dt = new DataTable();
                dt = _Cls_Vendors.SelectVendorByCode(Convert.ToInt32(txtbxVendorCode.Text));
                if(dt.Rows.Count > 0)
                {
                    combobxSelectVendor.SelectedIndex = (Convert.ToInt32(dt.Rows[0][0]) - 1);
                    txtbxVendorBalance.Text = dt.Rows[0][2].ToString();
                }else
                {

                }
            }
        }

        private void txtbxVendorCode_Validated(object sender, EventArgs e)
        {
            TimeSpan interval = DateTime.Now - comboSelectionTime;
            if (interval.TotalMilliseconds < 200)
            {

            }
            else if (interval.TotalMilliseconds > 200)
            {
                codeEditingTime = DateTime.Now;
                DataTable dt = new DataTable();
                dt = _Cls_Vendors.SelectVendorByCode(Convert.ToInt32(txtbxVendorCode.Text));
                if (dt.Rows.Count > 0)
                {
                    combobxSelectVendor.SelectedIndex = (Convert.ToInt32(dt.Rows[0][0]) - 1);
                    txtbxVendorBalance.Text = dt.Rows[0][2].ToString();
                }
                else
                {

                }
            }
        }
        #endregion

    }
}
