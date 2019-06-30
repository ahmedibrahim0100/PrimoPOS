#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Primo.PL
{
    partial class Frm_ContractorError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ContractorError));
            this.lblContractorWarning_1 = new System.Windows.Forms.Label();
            this.lblContractorWarning_2 = new System.Windows.Forms.Label();
            this.picbxContractorWarning = new System.Windows.Forms.PictureBox();
            this.btnClose = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.picbxContractorWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContractorWarning_1
            // 
            this.lblContractorWarning_1.AutoSize = true;
            this.lblContractorWarning_1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblContractorWarning_1.ForeColor = System.Drawing.Color.Blue;
            this.lblContractorWarning_1.Location = new System.Drawing.Point(12, 9);
            this.lblContractorWarning_1.Name = "lblContractorWarning_1";
            this.lblContractorWarning_1.Size = new System.Drawing.Size(253, 33);
            this.lblContractorWarning_1.TabIndex = 0;
            this.lblContractorWarning_1.Text = "Choose a contractor";
            // 
            // lblContractorWarning_2
            // 
            this.lblContractorWarning_2.AutoSize = true;
            this.lblContractorWarning_2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblContractorWarning_2.ForeColor = System.Drawing.Color.Blue;
            this.lblContractorWarning_2.Location = new System.Drawing.Point(12, 59);
            this.lblContractorWarning_2.Name = "lblContractorWarning_2";
            this.lblContractorWarning_2.Size = new System.Drawing.Size(280, 33);
            this.lblContractorWarning_2.TabIndex = 1;
            this.lblContractorWarning_2.Text = "for the credit payment";
            // 
            // picbxContractorWarning
            // 
            this.picbxContractorWarning.Image = ((System.Drawing.Image)(resources.GetObject("picbxContractorWarning.Image")));
            this.picbxContractorWarning.Location = new System.Drawing.Point(298, 18);
            this.picbxContractorWarning.Name = "picbxContractorWarning";
            this.picbxContractorWarning.Size = new System.Drawing.Size(100, 74);
            this.picbxContractorWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxContractorWarning.TabIndex = 2;
            this.picbxContractorWarning.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Blue;
            this.btnClose.BeforeTouchSize = new System.Drawing.Size(109, 37);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IsBackStageButton = false;
            this.btnClose.Location = new System.Drawing.Point(156, 107);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 37);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Frm_ContractorError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 156);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.picbxContractorWarning);
            this.Controls.Add(this.lblContractorWarning_2);
            this.Controls.Add(this.lblContractorWarning_1);
            this.Name = "Frm_ContractorError";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            ((System.ComponentModel.ISupportInitialize)(this.picbxContractorWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContractorWarning_1;
        private System.Windows.Forms.Label lblContractorWarning_2;
        private System.Windows.Forms.PictureBox picbxContractorWarning;
        private Syncfusion.Windows.Forms.ButtonAdv btnClose;
    }
}