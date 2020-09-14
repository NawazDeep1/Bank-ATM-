namespace PrjBankAccount
{
    partial class ResultofOOP
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
            this.lblResult1 = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.lblDateResult1 = new System.Windows.Forms.Label();
            this.lblresultDate2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResult1
            // 
            this.lblResult1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult1.Location = new System.Drawing.Point(30, 29);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(148, 23);
            this.lblResult1.TabIndex = 1;
            // 
            // lblResult2
            // 
            this.lblResult2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult2.Location = new System.Drawing.Point(30, 89);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(148, 23);
            this.lblResult2.TabIndex = 1;
            // 
            // lblDateResult1
            // 
            this.lblDateResult1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateResult1.Location = new System.Drawing.Point(232, 29);
            this.lblDateResult1.Name = "lblDateResult1";
            this.lblDateResult1.Size = new System.Drawing.Size(207, 23);
            this.lblDateResult1.TabIndex = 1;
            // 
            // lblresultDate2
            // 
            this.lblresultDate2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblresultDate2.Location = new System.Drawing.Point(232, 89);
            this.lblresultDate2.Name = "lblresultDate2";
            this.lblresultDate2.Size = new System.Drawing.Size(235, 23);
            this.lblresultDate2.TabIndex = 1;
            // 
            // ResultofOOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresultDate2);
            this.Controls.Add(this.lblDateResult1);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.lblResult1);
            this.Name = "ResultofOOP";
            this.Text = "ResultofOOP";
            this.Load += new System.EventHandler(this.ResultofOOP_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.Label lblDateResult1;
        private System.Windows.Forms.Label lblresultDate2;
    }
}