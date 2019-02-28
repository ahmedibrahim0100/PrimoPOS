#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Primo.PL
{
    partial class Frm_Login
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
            this.txtBxUserID = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            this.txtBxPassword = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            this.btnOK = new Syncfusion.Windows.Forms.ButtonAdv();
            this.lblUserID = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblPassword = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnExit = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInvalidData = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxUserID
            // 
            this.txtBxUserID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxUserID.AutoSuggestFormula = false;
            this.txtBxUserID.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.txtBxUserID.EnabledBackColor = System.Drawing.SystemColors.Window;
            this.txtBxUserID.Location = new System.Drawing.Point(312, 47);
            this.txtBxUserID.Name = "txtBxUserID";
            this.txtBxUserID.Size = new System.Drawing.Size(223, 20);
            this.txtBxUserID.TabIndex = 0;
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxPassword.AutoSuggestFormula = false;
            this.txtBxPassword.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.txtBxPassword.EnabledBackColor = System.Drawing.SystemColors.Window;
            this.txtBxPassword.Location = new System.Drawing.Point(312, 102);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.PasswordChar = '*';
            this.txtBxPassword.Size = new System.Drawing.Size(223, 20);
            this.txtBxPassword.TabIndex = 1;
            this.txtBxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxPassword_KeyDown);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.BeforeTouchSize = new System.Drawing.Size(92, 35);
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Neo Tech Alt Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Indigo;
            this.btnOK.IsBackStageButton = false;
            this.btnOK.Location = new System.Drawing.Point(312, 150);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 35);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.Font = new System.Drawing.Font("Neo Tech Alt Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.White;
            this.lblUserID.Location = new System.Drawing.Point(237, 47);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(62, 16);
            this.lblUserID.TabIndex = 3;
            this.lblUserID.Text = "User  ID";
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Neo Tech Alt Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(237, 106);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 16);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BeforeTouchSize = new System.Drawing.Size(92, 35);
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Neo Tech Alt Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Indigo;
            this.btnExit.IsBackStageButton = false;
            this.btnExit.Location = new System.Drawing.Point(443, 150);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 35);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(44, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 138);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblInvalidData
            // 
            this.lblInvalidData.AutoSize = false;
            this.lblInvalidData.BackColor = System.Drawing.Color.Red;
            this.lblInvalidData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInvalidData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblInvalidData.Font = new System.Drawing.Font("Neo Tech Alt Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidData.ForeColor = System.Drawing.Color.White;
            this.lblInvalidData.Location = new System.Drawing.Point(373, 203);
            this.lblInvalidData.Name = "lblInvalidData";
            this.lblInvalidData.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.lblInvalidData.Size = new System.Drawing.Size(105, 19);
            this.lblInvalidData.TabIndex = 8;
            this.lblInvalidData.Text = "Invalid data";
            this.lblInvalidData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInvalidData.Visible = false;
            // 
            // Frm_Login
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionButtonColor = System.Drawing.Color.Red;
            this.CaptionButtonHoverColor = System.Drawing.Color.Blue;
            this.CaptionFont = new System.Drawing.Font("Neo Tech Alt Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(547, 268);
            this.Controls.Add(this.lblInvalidData);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxUserID);
            this.DropShadow = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Frm_Login";
            this.ShowIcon = false;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtBxUserID;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtBxPassword;
        private Syncfusion.Windows.Forms.ButtonAdv btnOK;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblUserID;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblPassword;
        private Syncfusion.Windows.Forms.ButtonAdv btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblInvalidData;
    }
}