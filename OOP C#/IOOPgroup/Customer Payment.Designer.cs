
namespace IOOPgroup
{
    partial class cusPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cusPayment));
            this.label1 = new System.Windows.Forms.Label();
            this.receiptRTB = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chooseCustCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.total_txb = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.printBTN = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Conneqt", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(140, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Payment and Receipt";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // receiptRTB
            // 
            this.receiptRTB.Location = new System.Drawing.Point(304, 94);
            this.receiptRTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.receiptRTB.Name = "receiptRTB";
            this.receiptRTB.Size = new System.Drawing.Size(368, 319);
            this.receiptRTB.TabIndex = 1;
            this.receiptRTB.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer ID:";
            // 
            // chooseCustCmb
            // 
            this.chooseCustCmb.FormattingEnabled = true;
            this.chooseCustCmb.Location = new System.Drawing.Point(165, 115);
            this.chooseCustCmb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chooseCustCmb.Name = "chooseCustCmb";
            this.chooseCustCmb.Size = new System.Drawing.Size(131, 23);
            this.chooseCustCmb.TabIndex = 3;
            this.chooseCustCmb.SelectedIndexChanged += new System.EventHandler(this.chooseCustCmb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(102, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total:";
            // 
            // total_txb
            // 
            this.total_txb.Location = new System.Drawing.Point(165, 158);
            this.total_txb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.total_txb.Name = "total_txb";
            this.total_txb.ReadOnly = true;
            this.total_txb.Size = new System.Drawing.Size(130, 23);
            this.total_txb.TabIndex = 5;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(169, 213);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(111, 39);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Reset";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(110, 258);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(111, 39);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // printBTN
            // 
            this.printBTN.Location = new System.Drawing.Point(50, 213);
            this.printBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.printBTN.Name = "printBTN";
            this.printBTN.Size = new System.Drawing.Size(111, 39);
            this.printBTN.TabIndex = 9;
            this.printBTN.Text = "Print Receipt!";
            this.printBTN.UseVisualStyleBackColor = true;
            this.printBTN.Click += new System.EventHandler(this.printBTN_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // cusPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.printBTN);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.total_txb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chooseCustCmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.receiptRTB);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "cusPayment";
            this.Text = "Customer Payment & Receipt";
            this.Load += new System.EventHandler(this.cusPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox receiptRTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox chooseCustCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox total_txb;
        private System.Windows.Forms.Button cancelBtn;
        private Button backBtn;
        private Button printBTN;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}