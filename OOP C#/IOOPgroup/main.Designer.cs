namespace IOOPgroup
{
    partial class Frm_Main_admin
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
            this.btn_tech = new System.Windows.Forms.Button();
            this.btn_recept = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_income = new System.Windows.Forms.Button();
            this.lbl_display_user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_tech
            // 
            this.btn_tech.Location = new System.Drawing.Point(106, 83);
            this.btn_tech.Name = "btn_tech";
            this.btn_tech.Size = new System.Drawing.Size(168, 82);
            this.btn_tech.TabIndex = 0;
            this.btn_tech.Text = "Add Technician";
            this.btn_tech.UseVisualStyleBackColor = true;
            this.btn_tech.Click += new System.EventHandler(this.btn_tech_Click);
            // 
            // btn_recept
            // 
            this.btn_recept.Location = new System.Drawing.Point(106, 224);
            this.btn_recept.Name = "btn_recept";
            this.btn_recept.Size = new System.Drawing.Size(168, 82);
            this.btn_recept.TabIndex = 0;
            this.btn_recept.Text = "Add Receptionist";
            this.btn_recept.UseVisualStyleBackColor = true;
            this.btn_recept.Click += new System.EventHandler(this.btn_recept_Click);
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(514, 83);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(168, 82);
            this.btn_report.TabIndex = 0;
            this.btn_report.Text = "Service Report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_income
            // 
            this.btn_income.Location = new System.Drawing.Point(514, 224);
            this.btn_income.Name = "btn_income";
            this.btn_income.Size = new System.Drawing.Size(168, 82);
            this.btn_income.TabIndex = 0;
            this.btn_income.Text = "Total Income";
            this.btn_income.UseVisualStyleBackColor = true;
            this.btn_income.Click += new System.EventHandler(this.btn_income_Click);
            // 
            // lbl_display_user
            // 
            this.lbl_display_user.AutoSize = true;
            this.lbl_display_user.Location = new System.Drawing.Point(364, 20);
            this.lbl_display_user.Name = "lbl_display_user";
            this.lbl_display_user.Size = new System.Drawing.Size(0, 25);
            this.lbl_display_user.TabIndex = 1;
            // 
            // Frm_Main_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_display_user);
            this.Controls.Add(this.btn_income);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_recept);
            this.Controls.Add(this.btn_tech);
            this.Name = "Frm_Main_admin";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_tech;
        private Button btn_recept;
        private Button btn_report;
        private Button btn_income;
        private Label lbl_display_user;
    }
}