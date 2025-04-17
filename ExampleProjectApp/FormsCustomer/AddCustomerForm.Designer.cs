namespace ExampleProjectApp
{
    partial class AddCustomerForm
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
            btnSave = new Button();
            txtPhone = new TextBox();
            txtVergiDairesi = new TextBox();
            label7 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            label2 = new Label();
            txtFullName = new TextBox();
            txtVergiNo = new TextBox();
            label3 = new Label();
            label5 = new Label();
            txtTC = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Orange;
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(132, 310);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(196, 31);
            btnSave.TabIndex = 6;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(132, 162);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(196, 27);
            txtPhone.TabIndex = 3;
            // 
            // txtVergiDairesi
            // 
            txtVergiDairesi.Location = new Point(132, 256);
            txtVergiDairesi.Margin = new Padding(3, 4, 3, 4);
            txtVergiDairesi.Name = "txtVergiDairesi";
            txtVergiDairesi.Size = new Size(196, 27);
            txtVergiDairesi.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(65, 119);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 13;
            label7.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(132, 119);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(196, 27);
            txtEmail.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 260);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 14;
            label6.Text = "Vergi Dairesi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 162);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 11;
            label2.Text = "Telefon";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(132, 75);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(196, 27);
            txtFullName.TabIndex = 1;
            // 
            // txtVergiNo
            // 
            txtVergiNo.Location = new Point(132, 212);
            txtVergiNo.Margin = new Padding(3, 4, 3, 4);
            txtVergiNo.Name = "txtVergiNo";
            txtVergiNo.Size = new Size(196, 27);
            txtVergiNo.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 75);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 10;
            label3.Text = "FullName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 216);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 9;
            label5.Text = "Vergi No";
            // 
            // txtTC
            // 
            txtTC.Location = new Point(132, 40);
            txtTC.Margin = new Padding(3, 4, 3, 4);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(196, 27);
            txtTC.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 40);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 8;
            label1.Text = "TC";
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(399, 366);
            Controls.Add(btnSave);
            Controls.Add(txtPhone);
            Controls.Add(txtVergiDairesi);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(txtFullName);
            Controls.Add(txtVergiNo);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(txtTC);
            Controls.Add(label1);
            Name = "AddCustomerForm";
            Text = "AddCustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtPhone;
        private TextBox txtVergiDairesi;
        private Label label7;
        private TextBox txtEmail;
        private Label label6;
        private Label label2;
        private TextBox txtFullName;
        private TextBox txtVergiNo;
        private Label label3;
        private Label label5;
        private TextBox txtTC;
        private Label label1;
    }
}