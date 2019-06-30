namespace Primo.PL.MessageBoxes
{
    partial class MB_NoItemFound
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
            this.primoLabel1 = new Primo.PrimoControls.PrimoLabel();
            this.btnOK = new Primo.PrimoControls.PrimoButton();
            this.SuspendLayout();
            // 
            // primoLabel1
            // 
            this.primoLabel1.AutoSize = true;
            this.primoLabel1.Font = new System.Drawing.Font("Verdana", 16F);
            this.primoLabel1.ForeColor = System.Drawing.Color.Blue;
            this.primoLabel1.Location = new System.Drawing.Point(13, 13);
            this.primoLabel1.Name = "primoLabel1";
            this.primoLabel1.Size = new System.Drawing.Size(178, 26);
            this.primoLabel1.TabIndex = 0;
            this.primoLabel1.Text = "No Item Found";
            // 
            // btnOK
            // 
            this.btnOK.Depth = 0;
            this.btnOK.Location = new System.Drawing.Point(94, 65);
            this.btnOK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOK.Name = "btnOK";
            this.btnOK.Primary = true;
            this.btnOK.Size = new System.Drawing.Size(97, 44);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // MB_NoItemFound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 157);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.primoLabel1);
            this.Name = "MB_NoItemFound";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PrimoControls.PrimoLabel primoLabel1;
        private PrimoControls.PrimoButton btnOK;
    }
}