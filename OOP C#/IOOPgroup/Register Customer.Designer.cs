
namespace IOOPgroup
{
    partial class registerCus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerCus));
            this.custName_lbl = new System.Windows.Forms.Label();
            this.laptopBr_lbl = new System.Windows.Forms.Label();
            this.labelSr_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.entName_txb = new System.Windows.Forms.TextBox();
            this.entLbrand_txb = new System.Windows.Forms.TextBox();
            this.entLserial_txb = new System.Windows.Forms.TextBox();
            this.serviceCmb = new System.Windows.Forms.ComboBox();
            this.confrmCus = new System.Windows.Forms.Button();
            this.resetCus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.urgencyCmb = new System.Windows.Forms.ComboBox();
            this.passTxb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // custName_lbl
            // 
            this.custName_lbl.AutoSize = true;
            this.custName_lbl.Font = new System.Drawing.Font("Conneqt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custName_lbl.Location = new System.Drawing.Point(82, 99);
            this.custName_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.custName_lbl.Name = "custName_lbl";
            this.custName_lbl.Size = new System.Drawing.Size(233, 20);
            this.custName_lbl.TabIndex = 0;
            this.custName_lbl.Text = "Enter customer name:";
            // 
            // laptopBr_lbl
            // 
            this.laptopBr_lbl.AutoSize = true;
            this.laptopBr_lbl.Font = new System.Drawing.Font("Conneqt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laptopBr_lbl.Location = new System.Drawing.Point(165, 195);
            this.laptopBr_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laptopBr_lbl.Name = "laptopBr_lbl";
            this.laptopBr_lbl.Size = new System.Drawing.Size(150, 20);
            this.laptopBr_lbl.TabIndex = 1;
            this.laptopBr_lbl.Text = "Laptop brand:";
            // 
            // labelSr_lbl
            // 
            this.labelSr_lbl.AutoSize = true;
            this.labelSr_lbl.Font = new System.Drawing.Font("Conneqt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSr_lbl.Location = new System.Drawing.Point(82, 246);
            this.labelSr_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSr_lbl.Name = "labelSr_lbl";
            this.labelSr_lbl.Size = new System.Drawing.Size(232, 20);
            this.labelSr_lbl.TabIndex = 2;
            this.labelSr_lbl.Text = "Laptop serial number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Conneqt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(107, 348);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Choose the service:";
            // 
            // entName_txb
            // 
            this.entName_txb.Location = new System.Drawing.Point(321, 99);
            this.entName_txb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.entName_txb.Name = "entName_txb";
            this.entName_txb.Size = new System.Drawing.Size(233, 23);
            this.entName_txb.TabIndex = 4;
            // 
            // entLbrand_txb
            // 
            this.entLbrand_txb.Location = new System.Drawing.Point(321, 195);
            this.entLbrand_txb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.entLbrand_txb.Name = "entLbrand_txb";
            this.entLbrand_txb.Size = new System.Drawing.Size(233, 23);
            this.entLbrand_txb.TabIndex = 5;
            // 
            // entLserial_txb
            // 
            this.entLserial_txb.Location = new System.Drawing.Point(321, 246);
            this.entLserial_txb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.entLserial_txb.Name = "entLserial_txb";
            this.entLserial_txb.Size = new System.Drawing.Size(233, 23);
            this.entLserial_txb.TabIndex = 6;
            // 
            // serviceCmb
            // 
            this.serviceCmb.FormattingEnabled = true;
            this.serviceCmb.Items.AddRange(new object[] {
            "Remove virus",
            "Troubleshot and fix computer running ",
            "Laptop screen replacement",
            "Laptop keyboard replacement",
            "Laptop battery replacement",
            "Operating System Format and Installation",
            "Data backup and recovery ",
            "Internet connectivity issues"});
            this.serviceCmb.Location = new System.Drawing.Point(321, 348);
            this.serviceCmb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.serviceCmb.Name = "serviceCmb";
            this.serviceCmb.Size = new System.Drawing.Size(233, 23);
            this.serviceCmb.TabIndex = 7;
            this.serviceCmb.SelectedIndexChanged += new System.EventHandler(this.serviceCmb_SelectedIndexChanged);
            // 
            // confrmCus
            // 
            this.confrmCus.Location = new System.Drawing.Point(135, 404);
            this.confrmCus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.confrmCus.Name = "confrmCus";
            this.confrmCus.Size = new System.Drawing.Size(125, 33);
            this.confrmCus.TabIndex = 8;
            this.confrmCus.Text = "Confirm";
            this.confrmCus.UseVisualStyleBackColor = true;
            this.confrmCus.Click += new System.EventHandler(this.confrmCus_Click);
            // 
            // resetCus
            // 
            this.resetCus.Location = new System.Drawing.Point(268, 404);
            this.resetCus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.resetCus.Name = "resetCus";
            this.resetCus.Size = new System.Drawing.Size(125, 33);
            this.resetCus.TabIndex = 9;
            this.resetCus.Text = "Reset";
            this.resetCus.UseVisualStyleBackColor = true;
            this.resetCus.Click += new System.EventHandler(this.resetCus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Conneqt", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Register New Customer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Conneqt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(215, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Urgency:";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(401, 404);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(125, 33);
            this.backBtn.TabIndex = 13;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // urgencyCmb
            // 
            this.urgencyCmb.FormattingEnabled = true;
            this.urgencyCmb.Items.AddRange(new object[] {
            "Normal",
            "Urgent"});
            this.urgencyCmb.Location = new System.Drawing.Point(321, 298);
            this.urgencyCmb.Name = "urgencyCmb";
            this.urgencyCmb.Size = new System.Drawing.Size(233, 23);
            this.urgencyCmb.TabIndex = 14;
            this.urgencyCmb.SelectedIndexChanged += new System.EventHandler(this.urgencyCmb_SelectedIndexChanged);
            // 
            // passTxb
            // 
            this.passTxb.Location = new System.Drawing.Point(321, 146);
            this.passTxb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passTxb.Name = "passTxb";
            this.passTxb.Size = new System.Drawing.Size(233, 23);
            this.passTxb.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Conneqt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(199, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password:";
            // 
            // registerCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.passTxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.urgencyCmb);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetCus);
            this.Controls.Add(this.confrmCus);
            this.Controls.Add(this.serviceCmb);
            this.Controls.Add(this.entLserial_txb);
            this.Controls.Add(this.entLbrand_txb);
            this.Controls.Add(this.entName_txb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSr_lbl);
            this.Controls.Add(this.laptopBr_lbl);
            this.Controls.Add(this.custName_lbl);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "registerCus";
            this.Text = "Register New Customer";
            this.Load += new System.EventHandler(this.registerCus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label custName_lbl;
        private System.Windows.Forms.Label laptopBr_lbl;
        private System.Windows.Forms.Label labelSr_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox entName_txb;
        private System.Windows.Forms.TextBox entLbrand_txb;
        private System.Windows.Forms.TextBox entLserial_txb;
        private System.Windows.Forms.ComboBox serviceCmb;
        private System.Windows.Forms.Button confrmCus;
        private System.Windows.Forms.Button resetCus;
        private System.Windows.Forms.Label label1;
        private Label label2;
        private Button backBtn;
        private ComboBox urgencyCmb;
        private TextBox passTxb;
        private Label label4;
    }
}