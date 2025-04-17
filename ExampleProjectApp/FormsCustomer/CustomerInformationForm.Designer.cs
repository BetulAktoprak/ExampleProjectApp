namespace ExampleProjectApp
{
    partial class CustomerInformationForm
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
            dataGridView1 = new DataGridView();
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
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 272);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(960, 684);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(598, 98);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(196, 27);
            txtPhone.TabIndex = 3;
            // 
            // txtVergiDairesi
            // 
            txtVergiDairesi.Location = new Point(598, 148);
            txtVergiDairesi.Margin = new Padding(3, 4, 3, 4);
            txtVergiDairesi.Name = "txtVergiDairesi";
            txtVergiDairesi.Size = new Size(196, 27);
            txtVergiDairesi.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(199, 98);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 25;
            label7.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(266, 98);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(196, 27);
            txtEmail.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(484, 152);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 26;
            label6.Text = "Vergi Dairesi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(519, 98);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 24;
            label2.Text = "Telefon";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(598, 50);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(196, 27);
            txtFullName.TabIndex = 1;
            // 
            // txtVergiNo
            // 
            txtVergiNo.Location = new Point(266, 144);
            txtVergiNo.Margin = new Padding(3, 4, 3, 4);
            txtVergiNo.Name = "txtVergiNo";
            txtVergiNo.Size = new Size(196, 27);
            txtVergiNo.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(505, 50);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 23;
            label3.Text = "FullName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(178, 148);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 22;
            label5.Text = "Vergi No";
            // 
            // txtTC
            // 
            txtTC.Location = new Point(266, 50);
            txtTC.Margin = new Padding(3, 4, 3, 4);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(196, 27);
            txtTC.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 50);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 21;
            label1.Text = "TC";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUpdate.Location = new Point(418, 214);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(159, 39);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // CustomerInformationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(1015, 968);
            Controls.Add(btnUpdate);
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
            Controls.Add(dataGridView1);
            Name = "CustomerInformationForm";
            Text = "CustomerInformationForm";
            Load += CustomerInformationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
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
        private Button btnUpdate;
    }
}