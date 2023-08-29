namespace IOOPgroup
{
    partial class Frm_AddRecept
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
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtBox_email = new System.Windows.Forms.TextBox();
            this.txtBox_pass = new System.Windows.Forms.TextBox();
            this.btn_createRecept = new System.Windows.Forms.Button();
            this.btn_main = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(65, 139);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(91, 25);
            this.lbl_pass.TabIndex = 0;
            this.lbl_pass.Text = "Password:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(65, 62);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(103, 25);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "User Name:";
            // 
            // txtBox_email
            // 
            this.txtBox_email.Location = new System.Drawing.Point(271, 56);
            this.txtBox_email.Name = "txtBox_email";
            this.txtBox_email.Size = new System.Drawing.Size(150, 31);
            this.txtBox_email.TabIndex = 1;
            // 
            // txtBox_pass
            // 
            this.txtBox_pass.Location = new System.Drawing.Point(271, 133);
            this.txtBox_pass.Name = "txtBox_pass";
            this.txtBox_pass.Size = new System.Drawing.Size(150, 31);
            this.txtBox_pass.TabIndex = 1;
            this.txtBox_pass.TextChanged += new System.EventHandler(this.txtBox_pass_TextChanged);
            // 
            // btn_createRecept
            // 
            this.btn_createRecept.Location = new System.Drawing.Point(252, 231);
            this.btn_createRecept.Name = "btn_createRecept";
            this.btn_createRecept.Size = new System.Drawing.Size(169, 34);
            this.btn_createRecept.TabIndex = 2;
            this.btn_createRecept.Text = "Create Account";
            this.btn_createRecept.UseVisualStyleBackColor = true;
            this.btn_createRecept.Click += new System.EventHandler(this.btn_createRecept_Click);
            // 
            // btn_main
            // 
            this.btn_main.Location = new System.Drawing.Point(64, 232);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(112, 33);
            this.btn_main.TabIndex = 3;
            this.btn_main.Text = "Main Menu";
            this.btn_main.UseVisualStyleBackColor = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // Frm_AddRecept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 348);
            this.Controls.Add(this.btn_main);
            this.Controls.Add(this.btn_createRecept);
            this.Controls.Add(this.txtBox_pass);
            this.Controls.Add(this.txtBox_email);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_pass);
            this.Name = "Frm_AddRecept";
            this.Text = "Add Receptionist";
            this.Load += new System.EventHandler(this.Frm_AddRecept_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_pass;
        private Label lbl_name;
        private TextBox txtBox_email;
        private TextBox txtBox_pass;
        private Button btn_createRecept;
        private Button btn_main;
    }
}