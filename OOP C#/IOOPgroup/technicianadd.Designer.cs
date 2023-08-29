namespace IOOPgroup
{
    partial class Frm_AddTech
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
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txtBox_email = new System.Windows.Forms.TextBox();
            this.txtBox_pass = new System.Windows.Forms.TextBox();
            this.btn_main = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(75, 68);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(100, 25);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "User name:";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(75, 138);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(91, 25);
            this.lbl_pass.TabIndex = 0;
            this.lbl_pass.Text = "Password:";
            // 
            // txtBox_email
            // 
            this.txtBox_email.Location = new System.Drawing.Point(274, 62);
            this.txtBox_email.Name = "txtBox_email";
            this.txtBox_email.Size = new System.Drawing.Size(150, 31);
            this.txtBox_email.TabIndex = 1;
            // 
            // txtBox_pass
            // 
            this.txtBox_pass.Location = new System.Drawing.Point(274, 132);
            this.txtBox_pass.Name = "txtBox_pass";
            this.txtBox_pass.Size = new System.Drawing.Size(150, 31);
            this.txtBox_pass.TabIndex = 1;
            this.txtBox_pass.TextChanged += new System.EventHandler(this.txtBox_pass_TextChanged);
            // 
            // btn_main
            // 
            this.btn_main.Location = new System.Drawing.Point(75, 244);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(112, 34);
            this.btn_main.TabIndex = 2;
            this.btn_main.Text = "Main Menu";
            this.btn_main.UseVisualStyleBackColor = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(274, 244);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(150, 34);
            this.btn_create.TabIndex = 3;
            this.btn_create.Text = "Create Account";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // Frm_AddTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 385);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_main);
            this.Controls.Add(this.txtBox_pass);
            this.Controls.Add(this.txtBox_email);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_email);
            this.Name = "Frm_AddTech";
            this.Text = "Add Technician";
            this.Load += new System.EventHandler(this.Frm_AddTech_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_email;
        private Label lbl_pass;
        private TextBox txtBox_email;
        private TextBox txtBox_pass;
        private Button btn_main;
        private Button btn_create;
    }
}