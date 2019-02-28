#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Primo.PL
{
    partial class Frm_PaymentError
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtbxPaymentError = new System.Windows.Forms.TextBox();
            this.btnBack = new Syncfusion.Windows.Forms.ButtonAdv();
            this.SuspendLayout();
            // 
            // txtbxPaymentError
            // 
            this.txtbxPaymentError.Enabled = false;
            this.txtbxPaymentError.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPaymentError.ForeColor = System.Drawing.Color.Blue;
            this.txtbxPaymentError.Location = new System.Drawing.Point(24, 12);
            this.txtbxPaymentError.Multiline = true;
            this.txtbxPaymentError.Name = "txtbxPaymentError";
            this.txtbxPaymentError.Size = new System.Drawing.Size(220, 72);
            this.txtbxPaymentError.TabIndex = 0;
            this.txtbxPaymentError.Text = "Paid amount can\'t be less than Total";
            this.txtbxPaymentError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Blue;
            this.btnBack.BeforeTouchSize = new System.Drawing.Size(75, 33);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.IsBackStageButton = false;
            this.btnBack.Location = new System.Drawing.Point(88, 90);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 33);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Frm_PaymentError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 138);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtbxPaymentError);
            this.Name = "Frm_PaymentError";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxPaymentError;
        private Syncfusion.Windows.Forms.ButtonAdv btnBack;
    }
}