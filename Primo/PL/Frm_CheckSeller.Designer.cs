#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Primo.PL
{
    partial class Frm_CheckSeller
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
            this.txtbxPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnOK = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtbxInvalidPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.BeforeTouchSize = new System.Drawing.Size(165, 20);
            this.txtbxPassword.Location = new System.Drawing.Point(12, 31);
            this.txtbxPassword.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.PasswordChar = '*';
            this.txtbxPassword.Size = new System.Drawing.Size(165, 20);
            this.txtbxPassword.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtbxPassword.TabIndex = 0;
            this.txtbxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbxPassword_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(12, 9);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnOK.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnOK.IsBackStageButton = false;
            this.btnOK.Location = new System.Drawing.Point(12, 81);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnCancel.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.IsBackStageButton = false;
            this.btnCancel.Location = new System.Drawing.Point(102, 81);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(12, -4);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(35, 13);
            this.lblUserID.TabIndex = 4;
            this.lblUserID.Text = "label1";
            // 
            // txtbxInvalidPassword
            // 
            this.txtbxInvalidPassword.BackColor = System.Drawing.Color.Red;
            this.txtbxInvalidPassword.Enabled = false;
            this.txtbxInvalidPassword.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtbxInvalidPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtbxInvalidPassword.Location = new System.Drawing.Point(38, 57);
            this.txtbxInvalidPassword.Name = "txtbxInvalidPassword";
            this.txtbxInvalidPassword.ReadOnly = true;
            this.txtbxInvalidPassword.Size = new System.Drawing.Size(105, 20);
            this.txtbxInvalidPassword.TabIndex = 5;
            this.txtbxInvalidPassword.Text = "Invalid Password";
            this.txtbxInvalidPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbxInvalidPassword.Visible = false;
            // 
            // Frm_CheckSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CaptionBarColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(186, 116);
            this.Controls.Add(this.txtbxInvalidPassword);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtbxPassword);
            this.Name = "Frm_CheckSeller";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.Frm_CheckSeller_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_CheckSeller_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtbxPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtbxPassword;
        private System.Windows.Forms.Label lblPassword;
        private Syncfusion.Windows.Forms.ButtonAdv btnOK;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        public System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtbxInvalidPassword;
    }
}