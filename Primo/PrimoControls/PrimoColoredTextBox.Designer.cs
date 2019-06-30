namespace Primo.PrimoControls
{
    partial class PrimoColoredTextBox
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
            this.txtbxItem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbxItem
            // 
            this.txtbxItem.BackColor = System.Drawing.Color.Blue;
            this.txtbxItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxItem.Enabled = false;
            this.txtbxItem.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtbxItem.ForeColor = System.Drawing.Color.White;
            this.txtbxItem.Location = new System.Drawing.Point(0, 0);
            this.txtbxItem.Name = "txtbxItem";
            this.txtbxItem.ReadOnly = true;
            this.txtbxItem.Size = new System.Drawing.Size(63, 20);
            this.txtbxItem.TabIndex = 19;
            this.txtbxItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PrimoColoredTextBox
            // 
            this.Controls.Add(this.txtbxItem);
            this.Size = new System.Drawing.Size(63, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxItem;
    }
}
