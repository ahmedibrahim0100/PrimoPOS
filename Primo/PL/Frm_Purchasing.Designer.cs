#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Primo.PL
{
    partial class Frm_Purchasing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.primoPanel1 = new Primo.PrimoControls.PrimoPanel();
            this.txtbxSumTradePrice = new Primo.PrimoControls.PrimoTotalsTextBox();
            this.popupPanel = new Primo.PrimoControls.PrimoPanel();
            this.popupDgv = new Primo.PrimoControls.PrimoDataGrid();
            this.btnCancelPopupPanel = new Primo.PrimoControls.PrimoButton();
            this.btnOkPopupPanel = new Primo.PrimoControls.PrimoButton();
            this.dgvPurchasing = new Primo.PrimoControls.PrimoDataGrid();
            this.txtbxItemIdentification = new Primo.PrimoControls.PrimoTextBox();
            this.primoColoredTextBox1 = new Primo.PrimoControls.PrimoColoredTextBox();
            this.vendorGroupBox1 = new Primo.PL.VendorGroupBox();
            this.primoButton3 = new Primo.PrimoControls.PrimoButton();
            this.primoButton2 = new Primo.PrimoControls.PrimoButton();
            this.primoButton1 = new Primo.PrimoControls.PrimoButton();
            this.primoPanel1.SuspendLayout();
            this.popupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchasing)).BeginInit();
            this.SuspendLayout();
            // 
            // primoPanel1
            // 
            this.primoPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.primoPanel1.Controls.Add(this.txtbxSumTradePrice);
            this.primoPanel1.HorizontalScrollbarBarColor = true;
            this.primoPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.primoPanel1.HorizontalScrollbarSize = 10;
            this.primoPanel1.Location = new System.Drawing.Point(524, 417);
            this.primoPanel1.Name = "primoPanel1";
            this.primoPanel1.Size = new System.Drawing.Size(389, 100);
            this.primoPanel1.TabIndex = 25;
            this.primoPanel1.VerticalScrollbarBarColor = true;
            this.primoPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.primoPanel1.VerticalScrollbarSize = 10;
            // 
            // txtbxSumTradePrice
            // 
            this.txtbxSumTradePrice.Location = new System.Drawing.Point(20, 51);
            this.txtbxSumTradePrice.Name = "txtbxSumTradePrice";
            this.txtbxSumTradePrice.Size = new System.Drawing.Size(79, 20);
            this.txtbxSumTradePrice.TabIndex = 2;
            // 
            // popupPanel
            // 
            this.popupPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.popupPanel.Controls.Add(this.popupDgv);
            this.popupPanel.Controls.Add(this.btnCancelPopupPanel);
            this.popupPanel.Controls.Add(this.btnOkPopupPanel);
            this.popupPanel.HorizontalScrollbarBarColor = true;
            this.popupPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.popupPanel.HorizontalScrollbarSize = 10;
            this.popupPanel.Location = new System.Drawing.Point(282, 100);
            this.popupPanel.Name = "popupPanel";
            this.popupPanel.Size = new System.Drawing.Size(452, 195);
            this.popupPanel.TabIndex = 24;
            this.popupPanel.VerticalScrollbarBarColor = true;
            this.popupPanel.VerticalScrollbarHighlightOnWheel = false;
            this.popupPanel.VerticalScrollbarSize = 10;
            this.popupPanel.Visible = false;
            // 
            // popupDgv
            // 
            this.popupDgv.AllowUserToResizeRows = false;
            this.popupDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.popupDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.popupDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.popupDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.popupDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.popupDgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.popupDgv.EnableHeadersVisualStyles = false;
            this.popupDgv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.popupDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.popupDgv.Location = new System.Drawing.Point(3, 4);
            this.popupDgv.Name = "popupDgv";
            this.popupDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.popupDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.popupDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.popupDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.popupDgv.Size = new System.Drawing.Size(444, 133);
            this.popupDgv.TabIndex = 4;
            // 
            // btnCancelPopupPanel
            // 
            this.btnCancelPopupPanel.Depth = 0;
            this.btnCancelPopupPanel.Location = new System.Drawing.Point(92, 143);
            this.btnCancelPopupPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelPopupPanel.Name = "btnCancelPopupPanel";
            this.btnCancelPopupPanel.Primary = true;
            this.btnCancelPopupPanel.Size = new System.Drawing.Size(63, 32);
            this.btnCancelPopupPanel.TabIndex = 3;
            this.btnCancelPopupPanel.Text = "Cancel";
            this.btnCancelPopupPanel.UseVisualStyleBackColor = true;
            this.btnCancelPopupPanel.Click += new System.EventHandler(this.btnCancelPopupPanel_Click);
            // 
            // btnOkPopupPanel
            // 
            this.btnOkPopupPanel.Depth = 0;
            this.btnOkPopupPanel.Location = new System.Drawing.Point(15, 143);
            this.btnOkPopupPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOkPopupPanel.Name = "btnOkPopupPanel";
            this.btnOkPopupPanel.Primary = true;
            this.btnOkPopupPanel.Size = new System.Drawing.Size(58, 32);
            this.btnOkPopupPanel.TabIndex = 2;
            this.btnOkPopupPanel.Text = "OK";
            this.btnOkPopupPanel.UseVisualStyleBackColor = true;
            // 
            // dgvPurchasing
            // 
            this.dgvPurchasing.AllowUserToResizeRows = false;
            this.dgvPurchasing.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPurchasing.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPurchasing.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchasing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPurchasing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchasing.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPurchasing.EnableHeadersVisualStyles = false;
            this.dgvPurchasing.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPurchasing.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPurchasing.Location = new System.Drawing.Point(0, 125);
            this.dgvPurchasing.Name = "dgvPurchasing";
            this.dgvPurchasing.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchasing.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPurchasing.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPurchasing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchasing.Size = new System.Drawing.Size(576, 150);
            this.dgvPurchasing.TabIndex = 23;
            this.dgvPurchasing.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchasing_CellEndEdit);
            // 
            // txtbxItemIdentification
            // 
            this.txtbxItemIdentification.Depth = 0;
            this.txtbxItemIdentification.Hint = "";
            this.txtbxItemIdentification.Location = new System.Drawing.Point(81, 96);
            this.txtbxItemIdentification.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtbxItemIdentification.Name = "txtbxItemIdentification";
            this.txtbxItemIdentification.PasswordChar = '\0';
            this.txtbxItemIdentification.SelectedText = "";
            this.txtbxItemIdentification.SelectionLength = 0;
            this.txtbxItemIdentification.SelectionStart = 0;
            this.txtbxItemIdentification.Size = new System.Drawing.Size(144, 23);
            this.txtbxItemIdentification.TabIndex = 20;
            this.txtbxItemIdentification.UseSystemPasswordChar = false;
            this.txtbxItemIdentification.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbxItemIdentification_KeyDown);
            // 
            // primoColoredTextBox1
            // 
            this.primoColoredTextBox1.BackColor = System.Drawing.Color.Blue;
            this.primoColoredTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.primoColoredTextBox1.ForeColor = System.Drawing.Color.White;
            this.primoColoredTextBox1.Location = new System.Drawing.Point(0, 100);
            this.primoColoredTextBox1.Name = "primoColoredTextBox1";
            this.primoColoredTextBox1.Size = new System.Drawing.Size(63, 20);
            this.primoColoredTextBox1.TabIndex = 19;
            // 
            // vendorGroupBox1
            // 
            this.vendorGroupBox1.Location = new System.Drawing.Point(0, 3);
            this.vendorGroupBox1.Name = "vendorGroupBox1";
            this.vendorGroupBox1.Size = new System.Drawing.Size(521, 91);
            this.vendorGroupBox1.TabIndex = 17;
            // 
            // primoButton3
            // 
            this.primoButton3.Depth = 0;
            this.primoButton3.Location = new System.Drawing.Point(270, 22);
            this.primoButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.primoButton3.Name = "primoButton3";
            this.primoButton3.Primary = true;
            this.primoButton3.Size = new System.Drawing.Size(113, 56);
            this.primoButton3.TabIndex = 3;
            this.primoButton3.Text = "CLEAR";
            this.primoButton3.UseVisualStyleBackColor = true;
            // 
            // primoButton2
            // 
            this.primoButton2.Depth = 0;
            this.primoButton2.Location = new System.Drawing.Point(140, 22);
            this.primoButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.primoButton2.Name = "primoButton2";
            this.primoButton2.Primary = true;
            this.primoButton2.Size = new System.Drawing.Size(113, 56);
            this.primoButton2.TabIndex = 2;
            this.primoButton2.Text = "SUSPEND";
            this.primoButton2.UseVisualStyleBackColor = true;
            // 
            // primoButton1
            // 
            this.primoButton1.Depth = 0;
            this.primoButton1.Location = new System.Drawing.Point(12, 22);
            this.primoButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.primoButton1.Name = "primoButton1";
            this.primoButton1.Primary = true;
            this.primoButton1.Size = new System.Drawing.Size(113, 56);
            this.primoButton1.TabIndex = 1;
            this.primoButton1.Text = "Save";
            this.primoButton1.UseVisualStyleBackColor = true;
            // 
            // Frm_Purchasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBarColor = System.Drawing.Color.MidnightBlue;
            this.CaptionButtonColor = System.Drawing.Color.White;
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 519);
            this.Controls.Add(this.primoPanel1);
            this.Controls.Add(this.popupPanel);
            this.Controls.Add(this.dgvPurchasing);
            this.Controls.Add(this.txtbxItemIdentification);
            this.Controls.Add(this.primoColoredTextBox1);
            this.Controls.Add(this.vendorGroupBox1);
            this.Name = "Frm_Purchasing";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Purchasing_KeyPress);
            this.primoPanel1.ResumeLayout(false);
            this.primoPanel1.PerformLayout();
            this.popupPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchasing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private VendorGroupBox vendorGroupBox1;
        private PrimoControls.PrimoButton primoButton3;
        private PrimoControls.PrimoButton primoButton2;
        private PrimoControls.PrimoButton primoButton1;
        private PrimoControls.PrimoColoredTextBox primoColoredTextBox1;
        private PrimoControls.PrimoTextBox txtbxItemIdentification;
        private PrimoControls.PrimoDataGrid dgvPurchasing;
        private PrimoControls.PrimoPanel popupPanel;
        private PrimoControls.PrimoDataGrid popupDgv;
        private PrimoControls.PrimoButton btnCancelPopupPanel;
        private PrimoControls.PrimoButton btnOkPopupPanel;
        private PrimoControls.PrimoPanel primoPanel1;
        private PrimoControls.PrimoTotalsTextBox txtbxSumTradePrice;
    }
}