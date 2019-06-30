namespace Primo.PL
{
    partial class VendorGroupBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupbxVendor = new System.Windows.Forms.GroupBox();
            this.lblVendorCode = new System.Windows.Forms.Label();
            this.txtbxVendorCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.combobxSelectVendor = new System.Windows.Forms.ComboBox();
            this.txtbxVendorBalance = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblVendorBalance = new System.Windows.Forms.Label();
            this.groupbxVendor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbxVendor
            // 
            this.groupbxVendor.BackColor = System.Drawing.Color.White;
            this.groupbxVendor.Controls.Add(this.txtbxVendorBalance);
            this.groupbxVendor.Controls.Add(this.lblVendorBalance);
            this.groupbxVendor.Controls.Add(this.combobxSelectVendor);
            this.groupbxVendor.Controls.Add(this.txtbxVendorCode);
            this.groupbxVendor.Controls.Add(this.lblVendorCode);
            this.groupbxVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupbxVendor.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbxVendor.ForeColor = System.Drawing.Color.Blue;
            this.groupbxVendor.Location = new System.Drawing.Point(3, 3);
            this.groupbxVendor.Name = "groupbxVendor";
            this.groupbxVendor.Size = new System.Drawing.Size(508, 79);
            this.groupbxVendor.TabIndex = 0;
            this.groupbxVendor.TabStop = false;
            this.groupbxVendor.Text = "Vendor";
            // 
            // lblVendorCode
            // 
            this.lblVendorCode.AutoSize = true;
            this.lblVendorCode.Location = new System.Drawing.Point(7, 37);
            this.lblVendorCode.Name = "lblVendorCode";
            this.lblVendorCode.Size = new System.Drawing.Size(47, 18);
            this.lblVendorCode.TabIndex = 0;
            this.lblVendorCode.Text = "Code";
            // 
            // txtbxVendorCode
            // 
            this.txtbxVendorCode.Depth = 0;
            this.txtbxVendorCode.Hint = "";
            this.txtbxVendorCode.Location = new System.Drawing.Point(60, 32);
            this.txtbxVendorCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtbxVendorCode.Name = "txtbxVendorCode";
            this.txtbxVendorCode.PasswordChar = '\0';
            this.txtbxVendorCode.SelectedText = "";
            this.txtbxVendorCode.SelectionLength = 0;
            this.txtbxVendorCode.SelectionStart = 0;
            this.txtbxVendorCode.Size = new System.Drawing.Size(71, 23);
            this.txtbxVendorCode.TabIndex = 1;
            this.txtbxVendorCode.UseSystemPasswordChar = false;
            this.txtbxVendorCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbxVendorCode_KeyDown);
            this.txtbxVendorCode.Validated += new System.EventHandler(this.txtbxVendorCode_Validated);
            // 
            // combobxSelectVendor
            // 
            this.combobxSelectVendor.FormattingEnabled = true;
            this.combobxSelectVendor.Location = new System.Drawing.Point(148, 29);
            this.combobxSelectVendor.Name = "combobxSelectVendor";
            this.combobxSelectVendor.Size = new System.Drawing.Size(147, 26);
            this.combobxSelectVendor.TabIndex = 2;
            this.combobxSelectVendor.SelectedIndexChanged += new System.EventHandler(this.combobxSelectVendor_SelectedIndexChanged);
            // 
            // txtbxVendorBalance
            // 
            this.txtbxVendorBalance.Depth = 0;
            this.txtbxVendorBalance.Hint = "";
            this.txtbxVendorBalance.Location = new System.Drawing.Point(388, 32);
            this.txtbxVendorBalance.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtbxVendorBalance.Name = "txtbxVendorBalance";
            this.txtbxVendorBalance.PasswordChar = '\0';
            this.txtbxVendorBalance.SelectedText = "";
            this.txtbxVendorBalance.SelectionLength = 0;
            this.txtbxVendorBalance.SelectionStart = 0;
            this.txtbxVendorBalance.Size = new System.Drawing.Size(84, 23);
            this.txtbxVendorBalance.TabIndex = 4;
            this.txtbxVendorBalance.UseSystemPasswordChar = false;
            // 
            // lblVendorBalance
            // 
            this.lblVendorBalance.AutoSize = true;
            this.lblVendorBalance.Location = new System.Drawing.Point(317, 37);
            this.lblVendorBalance.Name = "lblVendorBalance";
            this.lblVendorBalance.Size = new System.Drawing.Size(65, 18);
            this.lblVendorBalance.TabIndex = 3;
            this.lblVendorBalance.Text = "Balance";
            // 
            // VendorGroupBox
            // 
            this.Controls.Add(this.groupbxVendor);
            this.Name = "VendorGroupBox";
            this.Size = new System.Drawing.Size(519, 89);
            this.groupbxVendor.ResumeLayout(false);
            this.groupbxVendor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbxVendor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtbxVendorBalance;
        private System.Windows.Forms.Label lblVendorBalance;
        private System.Windows.Forms.ComboBox combobxSelectVendor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtbxVendorCode;
        private System.Windows.Forms.Label lblVendorCode;
    }
}
