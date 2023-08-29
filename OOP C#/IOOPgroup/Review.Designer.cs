namespace IOOPgroup
{
    partial class Review
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblProb = new System.Windows.Forms.Label();
            this.Rdbtn1 = new System.Windows.Forms.RadioButton();
            this.btnDone = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Rdbtn2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lblname1 = new System.Windows.Forms.Label();
            this.lblcomplete1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(34, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(316, 31);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Laptop Completion x\'s laptop";
            // 
            // lblProb
            // 
            this.lblProb.AutoSize = true;
            this.lblProb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProb.Location = new System.Drawing.Point(39, 51);
            this.lblProb.Name = "lblProb";
            this.lblProb.Size = new System.Drawing.Size(126, 28);
            this.lblProb.TabIndex = 1;
            this.lblProb.Text = "Problem_____";
            // 
            // Rdbtn1
            // 
            this.Rdbtn1.AutoSize = true;
            this.Rdbtn1.Checked = true;
            this.Rdbtn1.Location = new System.Drawing.Point(34, 146);
            this.Rdbtn1.Name = "Rdbtn1";
            this.Rdbtn1.Size = new System.Drawing.Size(131, 24);
            this.Rdbtn1.TabIndex = 3;
            this.Rdbtn1.TabStop = true;
            this.Rdbtn1.Text = "Still In Progress";
            this.Rdbtn1.UseVisualStyleBackColor = true;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(379, 358);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(120, 37);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 317);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 27);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Additional Information?";
            // 
            // Rdbtn2
            // 
            this.Rdbtn2.AutoSize = true;
            this.Rdbtn2.Location = new System.Drawing.Point(34, 195);
            this.Rdbtn2.Name = "Rdbtn2";
            this.Rdbtn2.Size = new System.Drawing.Size(95, 24);
            this.Rdbtn2.TabIndex = 8;
            this.Rdbtn2.Text = "Complete";
            this.Rdbtn2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblname1
            // 
            this.lblname1.AutoSize = true;
            this.lblname1.Location = new System.Drawing.Point(433, 51);
            this.lblname1.Name = "lblname1";
            this.lblname1.Size = new System.Drawing.Size(50, 20);
            this.lblname1.TabIndex = 12;
            this.lblname1.Text = "label3";
            // 
            // lblcomplete1
            // 
            this.lblcomplete1.AutoSize = true;
            this.lblcomplete1.Location = new System.Drawing.Point(433, 71);
            this.lblcomplete1.Name = "lblcomplete1";
            this.lblcomplete1.Size = new System.Drawing.Size(50, 20);
            this.lblcomplete1.TabIndex = 13;
            this.lblcomplete1.Text = "label3";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(350, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 444);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblcomplete1);
            this.Controls.Add(this.lblname1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Rdbtn2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.Rdbtn1);
            this.Controls.Add(this.lblProb);
            this.Controls.Add(this.lblName);
            //this.Name = "Review";
            this.Text = "Review Menu";
            this.Load += new System.EventHandler(this.Review_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Label lblProb;
        private RadioButton Rdbtn1;
        private Button btnDone;
        private TextBox textBox1;
        private Label label1;
        private RadioButton Rdbtn2;
        private Button button1;
        private Label lblname1;
        private Label lblcomplete1;
        private DateTimePicker dateTimePicker1;
    }
}