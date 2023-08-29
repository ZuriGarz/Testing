namespace IOOPgroup
{
    partial class TechnicianMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnReview = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UrgentBtn = new System.Windows.Forms.RadioButton();
            this.NormalBtn = new System.Windows.Forms.RadioButton();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.List1 = new System.Windows.Forms.ListBox();
            this.List2 = new System.Windows.Forms.ListBox();
            this.Rbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello Sir Technician";
            // 
            // btnReview
            // 
            this.btnReview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReview.Location = new System.Drawing.Point(797, 455);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(133, 46);
            this.btnReview.TabIndex = 2;
            this.btnReview.Text = "Review";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // LogOut
            // 
            this.LogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogOut.Location = new System.Drawing.Point(73, 458);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(133, 46);
            this.LogOut.TabIndex = 3;
            this.LogOut.Text = "LogOut";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(73, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Urgent Requests";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(674, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Normal Requests";
            // 
            // UrgentBtn
            // 
            this.UrgentBtn.AutoSize = true;
            this.UrgentBtn.Location = new System.Drawing.Point(73, 389);
            this.UrgentBtn.Name = "UrgentBtn";
            this.UrgentBtn.Size = new System.Drawing.Size(175, 24);
            this.UrgentBtn.TabIndex = 7;
            this.UrgentBtn.TabStop = true;
            this.UrgentBtn.Text = "Urgent Request Check";
            this.UrgentBtn.UseVisualStyleBackColor = true;
            // 
            // NormalBtn
            // 
            this.NormalBtn.AutoSize = true;
            this.NormalBtn.Location = new System.Drawing.Point(674, 402);
            this.NormalBtn.Name = "NormalBtn";
            this.NormalBtn.Size = new System.Drawing.Size(180, 24);
            this.NormalBtn.TabIndex = 8;
            this.NormalBtn.TabStop = true;
            this.NormalBtn.Text = "Normal Request Check";
            this.NormalBtn.UseVisualStyleBackColor = true;
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(240, 458);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(115, 46);
            this.Updatebtn.TabIndex = 9;
            this.Updatebtn.Text = "Update Profile";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // List1
            // 
            this.List1.FormattingEnabled = true;
            this.List1.ItemHeight = 20;
            this.List1.Location = new System.Drawing.Point(53, 121);
            this.List1.Name = "List1";
            this.List1.Size = new System.Drawing.Size(492, 224);
            this.List1.TabIndex = 10;
            this.List1.SelectedIndexChanged += new System.EventHandler(this.List1_SelectedIndexChanged_1);
            // 
            // List2
            // 
            this.List2.FormattingEnabled = true;
            this.List2.ItemHeight = 20;
            this.List2.Location = new System.Drawing.Point(612, 121);
            this.List2.Name = "List2";
            this.List2.Size = new System.Drawing.Size(492, 224);
            this.List2.TabIndex = 11;
            this.List2.SelectedIndexChanged += new System.EventHandler(this.List2_SelectedIndexChanged);
            // 
            // Rbtn
            // 
            this.Rbtn.Location = new System.Drawing.Point(979, 351);
            this.Rbtn.Name = "Rbtn";
            this.Rbtn.Size = new System.Drawing.Size(94, 29);
            this.Rbtn.TabIndex = 12;
            this.Rbtn.Text = "Refresh";
            this.Rbtn.UseVisualStyleBackColor = true;
            this.Rbtn.Click += new System.EventHandler(this.Rbtn_Click);
            // 
            // TechnicianMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1142, 628);
            this.Controls.Add(this.Rbtn);
            this.Controls.Add(this.List2);
            this.Controls.Add(this.List1);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.NormalBtn);
            this.Controls.Add(this.UrgentBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.label1);
            this.Name = "TechnicianMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.TechnicianMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnReview;
        private Button LogOut;
        private Label label2;
        private Label label3;
        private RadioButton UrgentBtn;
        private RadioButton NormalBtn;
        private Button Updatebtn;
        private ListBox List1;
        private ListBox List2;
        private Button Rbtn;
    }
}