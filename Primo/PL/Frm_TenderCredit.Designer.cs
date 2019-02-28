#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Primo.PL
{
    partial class Frm_TenderCredit
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtbxTotal = new System.Windows.Forms.TextBox();
            this.lblCustomerPays = new System.Windows.Forms.Label();
            this.txtbxCustomerPaysValue = new System.Windows.Forms.TextBox();
            this.lblEquals = new System.Windows.Forms.Label();
            this.txtbxCustomerPaysPerc = new System.Windows.Forms.TextBox();
            this.lblContractorPays = new System.Windows.Forms.Label();
            this.txtbxContractorPaysPerc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxContractorPaysValue = new System.Windows.Forms.TextBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblPercentage2 = new System.Windows.Forms.Label();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnConfirm = new Syncfusion.Windows.Forms.ButtonAdv();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblTotal.Location = new System.Drawing.Point(1, 31);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 25);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total";
            // 
            // txtbxTotal
            // 
            this.txtbxTotal.Enabled = false;
            this.txtbxTotal.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTotal.ForeColor = System.Drawing.Color.Blue;
            this.txtbxTotal.Location = new System.Drawing.Point(177, 12);
            this.txtbxTotal.Name = "txtbxTotal";
            this.txtbxTotal.ReadOnly = true;
            this.txtbxTotal.Size = new System.Drawing.Size(110, 50);
            this.txtbxTotal.TabIndex = 4;
            this.txtbxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCustomerPays
            // 
            this.lblCustomerPays.AutoSize = true;
            this.lblCustomerPays.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerPays.ForeColor = System.Drawing.Color.Blue;
            this.lblCustomerPays.Location = new System.Drawing.Point(1, 87);
            this.lblCustomerPays.Name = "lblCustomerPays";
            this.lblCustomerPays.Size = new System.Drawing.Size(157, 25);
            this.lblCustomerPays.TabIndex = 6;
            this.lblCustomerPays.Text = "Customer pays:";
            // 
            // txtbxCustomerPaysValue
            // 
            this.txtbxCustomerPaysValue.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCustomerPaysValue.ForeColor = System.Drawing.Color.Blue;
            this.txtbxCustomerPaysValue.Location = new System.Drawing.Point(177, 70);
            this.txtbxCustomerPaysValue.Name = "txtbxCustomerPaysValue";
            this.txtbxCustomerPaysValue.Size = new System.Drawing.Size(89, 50);
            this.txtbxCustomerPaysValue.TabIndex = 7;
            this.txtbxCustomerPaysValue.Text = "0";
            this.txtbxCustomerPaysValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbxCustomerPaysValue.TextChanged += new System.EventHandler(this.txtbxCustomerPaysValue_TextChanged);
            this.txtbxCustomerPaysValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbxCustomerPaysValue_KeyDown);
            this.txtbxCustomerPaysValue.Validated += new System.EventHandler(this.txtbxCustomerPaysValue_Validated);
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquals.ForeColor = System.Drawing.Color.Blue;
            this.lblEquals.Location = new System.Drawing.Point(272, 87);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(27, 25);
            this.lblEquals.TabIndex = 8;
            this.lblEquals.Text = "=";
            // 
            // txtbxCustomerPaysPerc
            // 
            this.txtbxCustomerPaysPerc.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCustomerPaysPerc.ForeColor = System.Drawing.Color.Blue;
            this.txtbxCustomerPaysPerc.Location = new System.Drawing.Point(305, 70);
            this.txtbxCustomerPaysPerc.Name = "txtbxCustomerPaysPerc";
            this.txtbxCustomerPaysPerc.Size = new System.Drawing.Size(89, 50);
            this.txtbxCustomerPaysPerc.TabIndex = 9;
            this.txtbxCustomerPaysPerc.Text = "0";
            this.txtbxCustomerPaysPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbxCustomerPaysPerc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbxCustomerPaysPerc_KeyDown);
            this.txtbxCustomerPaysPerc.Validated += new System.EventHandler(this.txtbxCustomerPaysPerc_Validated);
            // 
            // lblContractorPays
            // 
            this.lblContractorPays.AutoSize = true;
            this.lblContractorPays.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractorPays.ForeColor = System.Drawing.Color.Blue;
            this.lblContractorPays.Location = new System.Drawing.Point(1, 143);
            this.lblContractorPays.Name = "lblContractorPays";
            this.lblContractorPays.Size = new System.Drawing.Size(166, 25);
            this.lblContractorPays.TabIndex = 10;
            this.lblContractorPays.Text = "Contractor pays:";
            // 
            // txtbxContractorPaysPerc
            // 
            this.txtbxContractorPaysPerc.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxContractorPaysPerc.ForeColor = System.Drawing.Color.Blue;
            this.txtbxContractorPaysPerc.Location = new System.Drawing.Point(305, 126);
            this.txtbxContractorPaysPerc.Name = "txtbxContractorPaysPerc";
            this.txtbxContractorPaysPerc.Size = new System.Drawing.Size(89, 50);
            this.txtbxContractorPaysPerc.TabIndex = 13;
            this.txtbxContractorPaysPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbxContractorPaysPerc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbxContractorPaysPerc_KeyDown);
            this.txtbxContractorPaysPerc.Validated += new System.EventHandler(this.txtbxContractorPaysPerc_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(272, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "=";
            // 
            // txtbxContractorPaysValue
            // 
            this.txtbxContractorPaysValue.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxContractorPaysValue.ForeColor = System.Drawing.Color.Blue;
            this.txtbxContractorPaysValue.Location = new System.Drawing.Point(177, 126);
            this.txtbxContractorPaysValue.Name = "txtbxContractorPaysValue";
            this.txtbxContractorPaysValue.Size = new System.Drawing.Size(89, 50);
            this.txtbxContractorPaysValue.TabIndex = 11;
            this.txtbxContractorPaysValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbxContractorPaysValue.TextChanged += new System.EventHandler(this.txtbxContractorPaysValue_TextChanged);
            this.txtbxContractorPaysValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbxContractorPaysValue_KeyDown);
            this.txtbxContractorPaysValue.Validated += new System.EventHandler(this.txtbxContractorPaysValue_Validated);
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.ForeColor = System.Drawing.Color.Blue;
            this.lblPercentage.Location = new System.Drawing.Point(403, 87);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(33, 25);
            this.lblPercentage.TabIndex = 14;
            this.lblPercentage.Text = "%";
            // 
            // lblPercentage2
            // 
            this.lblPercentage2.AutoSize = true;
            this.lblPercentage2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage2.ForeColor = System.Drawing.Color.Blue;
            this.lblPercentage2.Location = new System.Drawing.Point(403, 143);
            this.lblPercentage2.Name = "lblPercentage2";
            this.lblPercentage2.Size = new System.Drawing.Size(33, 25);
            this.lblPercentage2.TabIndex = 15;
            this.lblPercentage2.Text = "%";
            // 
            // btnCancel
            // 
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(75, 36);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Blue;
            this.btnCancel.IsBackStageButton = false;
            this.btnCancel.Location = new System.Drawing.Point(223, 222);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BeforeTouchSize = new System.Drawing.Size(75, 36);
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.Blue;
            this.btnConfirm.IsBackStageButton = false;
            this.btnConfirm.Location = new System.Drawing.Point(134, 222);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 36);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Frm_TenderCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBarColor = System.Drawing.Color.Blue;
            this.CaptionButtonColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(448, 279);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblPercentage2);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.txtbxContractorPaysPerc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxContractorPaysValue);
            this.Controls.Add(this.lblContractorPays);
            this.Controls.Add(this.txtbxCustomerPaysPerc);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.txtbxCustomerPaysValue);
            this.Controls.Add(this.lblCustomerPays);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtbxTotal);
            this.Name = "Frm_TenderCredit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.TextBox txtbxTotal;
        private System.Windows.Forms.Label lblCustomerPays;
        public System.Windows.Forms.TextBox txtbxCustomerPaysValue;
        private System.Windows.Forms.Label lblEquals;
        public System.Windows.Forms.TextBox txtbxCustomerPaysPerc;
        private System.Windows.Forms.Label lblContractorPays;
        public System.Windows.Forms.TextBox txtbxContractorPaysPerc;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtbxContractorPaysValue;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblPercentage2;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        public Syncfusion.Windows.Forms.ButtonAdv btnConfirm;
    }
}