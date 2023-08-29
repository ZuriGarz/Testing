namespace IOOPgroup
{
    partial class Frm_serviceReport
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
            this.lstBox_service = new System.Windows.Forms.ListBox();
            this.btn_main = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_viewservice = new System.Windows.Forms.Button();
            this.lstboxservice = new System.Windows.Forms.ListBox();
            this.lstboxurgen = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstboxcomplete = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBox_service
            // 
            this.lstBox_service.FormattingEnabled = true;
            this.lstBox_service.ItemHeight = 25;
            this.lstBox_service.Location = new System.Drawing.Point(27, 49);
            this.lstBox_service.Name = "lstBox_service";
            this.lstBox_service.Size = new System.Drawing.Size(119, 379);
            this.lstBox_service.TabIndex = 0;
            // 
            // btn_main
            // 
            this.btn_main.Location = new System.Drawing.Point(838, 326);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(137, 47);
            this.btn_main.TabIndex = 1;
            this.btn_main.Text = "Main Menu";
            this.btn_main.UseVisualStyleBackColor = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(764, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select month:\r\n(1 - 12)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(890, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btn_viewservice
            // 
            this.btn_viewservice.Location = new System.Drawing.Point(815, 206);
            this.btn_viewservice.Name = "btn_viewservice";
            this.btn_viewservice.Size = new System.Drawing.Size(199, 46);
            this.btn_viewservice.TabIndex = 6;
            this.btn_viewservice.Text = "View Service in Month";
            this.btn_viewservice.UseVisualStyleBackColor = true;
            this.btn_viewservice.Click += new System.EventHandler(this.btn_viewservice_Click);
            // 
            // lstboxservice
            // 
            this.lstboxservice.FormattingEnabled = true;
            this.lstboxservice.ItemHeight = 25;
            this.lstboxservice.Location = new System.Drawing.Point(172, 49);
            this.lstboxservice.Name = "lstboxservice";
            this.lstboxservice.Size = new System.Drawing.Size(247, 379);
            this.lstboxservice.TabIndex = 0;
            // 
            // lstboxurgen
            // 
            this.lstboxurgen.FormattingEnabled = true;
            this.lstboxurgen.ItemHeight = 25;
            this.lstboxurgen.Location = new System.Drawing.Point(447, 49);
            this.lstboxurgen.Name = "lstboxurgen";
            this.lstboxurgen.Size = new System.Drawing.Size(119, 379);
            this.lstboxurgen.TabIndex = 0;
            this.lstboxurgen.SelectedIndexChanged += new System.EventHandler(this.lstboxurgen_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Urgency";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lstboxcomplete
            // 
            this.lstboxcomplete.FormattingEnabled = true;
            this.lstboxcomplete.ItemHeight = 25;
            this.lstboxcomplete.Location = new System.Drawing.Point(591, 49);
            this.lstboxcomplete.Name = "lstboxcomplete";
            this.lstboxcomplete.Size = new System.Drawing.Size(119, 379);
            this.lstboxcomplete.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(591, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Completion";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // Frm_serviceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 461);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_viewservice);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_main);
            this.Controls.Add(this.lstboxcomplete);
            this.Controls.Add(this.lstboxurgen);
            this.Controls.Add(this.lstboxservice);
            this.Controls.Add(this.lstBox_service);
            this.Name = "Frm_serviceReport";
            this.Text = "Service Report";
            this.Load += new System.EventHandler(this.Frm_serviceReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstBox_service;
        private Button btn_main;
        private Label label1;
        private TextBox textBox1;
        private Button btn_viewservice;
        private ListBox lstboxservice;
        private ListBox lstboxurgen;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox lstboxcomplete;
        private Label label5;
    }
}