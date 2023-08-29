namespace IOOPgroup
{
    partial class ChangeRequestService
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChangeLaptop = new System.Windows.Forms.TextBox();
            this.txtChangeService = new System.Windows.Forms.TextBox();
            this.txtChangeDescription = new System.Windows.Forms.RichTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "laptop type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "service type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "description";
            // 
            // txtChangeLaptop
            // 
            this.txtChangeLaptop.Location = new System.Drawing.Point(204, 48);
            this.txtChangeLaptop.Name = "txtChangeLaptop";
            this.txtChangeLaptop.Size = new System.Drawing.Size(125, 27);
            this.txtChangeLaptop.TabIndex = 3;
            this.txtChangeLaptop.TextChanged += new System.EventHandler(this.txtChangeLaptop_TextChanged);
            // 
            // txtChangeService
            // 
            this.txtChangeService.Location = new System.Drawing.Point(204, 86);
            this.txtChangeService.Name = "txtChangeService";
            this.txtChangeService.Size = new System.Drawing.Size(125, 27);
            this.txtChangeService.TabIndex = 4;
            this.txtChangeService.TextChanged += new System.EventHandler(this.txtChangeService_TextChanged);
            // 
            // txtChangeDescription
            // 
            this.txtChangeDescription.Location = new System.Drawing.Point(204, 125);
            this.txtChangeDescription.Name = "txtChangeDescription";
            this.txtChangeDescription.Size = new System.Drawing.Size(125, 120);
            this.txtChangeDescription.TabIndex = 6;
            this.txtChangeDescription.Text = "";
            this.txtChangeDescription.TextChanged += new System.EventHandler(this.txtChangeDescription_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(305, 357);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ChangeRequestService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtChangeDescription);
            this.Controls.Add(this.txtChangeService);
            this.Controls.Add(this.txtChangeLaptop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeRequestService";
            this.Text = "ChangeRequestService";
            this.Load += new System.EventHandler(this.ChangeRequestService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtChangeLaptop;
        private TextBox txtChangeService;
        private RichTextBox txtChangeDescription;
        private Button btnUpdate;
    }
}