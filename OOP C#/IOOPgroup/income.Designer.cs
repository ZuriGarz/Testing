namespace IOOPgroup
{
    partial class Frm_Income
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
            this.Btn_Main = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_viewincome = new System.Windows.Forms.Button();
            this.label_display_income = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Main
            // 
            this.Btn_Main.Location = new System.Drawing.Point(147, 299);
            this.Btn_Main.Name = "Btn_Main";
            this.Btn_Main.Size = new System.Drawing.Size(135, 64);
            this.Btn_Main.TabIndex = 1;
            this.Btn_Main.Text = "Main Menu";
            this.Btn_Main.UseVisualStyleBackColor = true;
            this.Btn_Main.Click += new System.EventHandler(this.Btn_Main_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select month:\r\n(1 - 12)";
            // 
            // btn_viewincome
            // 
            this.btn_viewincome.Location = new System.Drawing.Point(147, 212);
            this.btn_viewincome.Name = "btn_viewincome";
            this.btn_viewincome.Size = new System.Drawing.Size(135, 42);
            this.btn_viewincome.TabIndex = 4;
            this.btn_viewincome.Text = "View Income";
            this.btn_viewincome.UseVisualStyleBackColor = true;
            this.btn_viewincome.Click += new System.EventHandler(this.btn_viewincome_Click);
            // 
            // label_display_income
            // 
            this.label_display_income.AutoSize = true;
            this.label_display_income.Location = new System.Drawing.Point(456, 184);
            this.label_display_income.Name = "label_display_income";
            this.label_display_income.Size = new System.Drawing.Size(0, 25);
            this.label_display_income.TabIndex = 5;
            // 
            // Frm_Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 447);
            this.Controls.Add(this.label_display_income);
            this.Controls.Add(this.btn_viewincome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_Main);
            this.Name = "Frm_Income";
            this.Text = "Income";
            this.Load += new System.EventHandler(this.Frm_Income_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Btn_Main;
        private TextBox textBox1;
        private Label label1;
        private Button btn_viewincome;
        private Label label_display_income;
    }
}