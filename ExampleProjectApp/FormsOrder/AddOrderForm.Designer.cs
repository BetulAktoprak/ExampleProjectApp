namespace ExampleProjectApp
{
    partial class AddOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrderForm));
            dtpSevkTarihi = new DateTimePicker();
            lblPrice = new Label();
            label8 = new Label();
            lblBarcode = new Label();
            label3 = new Label();
            lblKdv = new Label();
            label5 = new Label();
            label1 = new Label();
            cmbProducts = new ComboBox();
            nmrAdet = new NumericUpDown();
            btnAdd = new Button();
            label2 = new Label();
            cmbCustomer = new ComboBox();
            dgvPRoductList = new DataGridView();
            btnPlus = new Button();
            ((System.ComponentModel.ISupportInitialize)nmrAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPRoductList).BeginInit();
            SuspendLayout();
            // 
            // dtpSevkTarihi
            // 
            dtpSevkTarihi.Location = new Point(160, 192);
            dtpSevkTarihi.MinDate = new DateTime(2025, 4, 16, 0, 0, 0, 0);
            dtpSevkTarihi.Name = "dtpSevkTarihi";
            dtpSevkTarihi.Size = new Size(250, 27);
            dtpSevkTarihi.TabIndex = 51;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(94, 325);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 20);
            lblPrice.TabIndex = 55;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(78, 53);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 47;
            label8.Text = "Ürünler";
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(160, 151);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(0, 20);
            lblBarcode.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 199);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 46;
            label3.Text = "Sevk Tarihi :";
            // 
            // lblKdv
            // 
            lblKdv.AutoSize = true;
            lblKdv.Location = new Point(160, 292);
            lblKdv.Name = "lblKdv";
            lblKdv.Size = new Size(0, 20);
            lblKdv.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 251);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 45;
            label5.Text = "Miktar :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 292);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 52;
            label1.Text = "KDV:";
            // 
            // cmbProducts
            // 
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(160, 50);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(359, 28);
            cmbProducts.TabIndex = 48;
            cmbProducts.SelectedIndexChanged += cmbProducts_SelectedIndexChanged;
            // 
            // nmrAdet
            // 
            nmrAdet.Location = new Point(160, 244);
            nmrAdet.Name = "nmrAdet";
            nmrAdet.Size = new Size(150, 27);
            nmrAdet.TabIndex = 49;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.Location = new Point(389, 318);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 38);
            btnAdd.TabIndex = 50;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 112);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 56;
            label2.Text = "Müşteriler";
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(160, 104);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(359, 28);
            cmbCustomer.TabIndex = 57;
            // 
            // dgvPRoductList
            // 
            dgvPRoductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPRoductList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPRoductList.BackgroundColor = SystemColors.ButtonFace;
            dgvPRoductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPRoductList.Location = new Point(609, 50);
            dgvPRoductList.Name = "dgvPRoductList";
            dgvPRoductList.RowHeadersWidth = 51;
            dgvPRoductList.Size = new Size(858, 306);
            dgvPRoductList.TabIndex = 58;
            dgvPRoductList.KeyDown += dgvPRoductList_KeyDown;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.ButtonFace;
            btnPlus.Image = (Image)resources.GetObject("btnPlus.Image");
            btnPlus.Location = new Point(525, 47);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(57, 32);
            btnPlus.TabIndex = 59;
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // AddOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            ClientSize = new Size(1498, 387);
            Controls.Add(btnPlus);
            Controls.Add(dgvPRoductList);
            Controls.Add(label2);
            Controls.Add(cmbCustomer);
            Controls.Add(dtpSevkTarihi);
            Controls.Add(lblPrice);
            Controls.Add(label8);
            Controls.Add(lblBarcode);
            Controls.Add(label3);
            Controls.Add(lblKdv);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(cmbProducts);
            Controls.Add(nmrAdet);
            Controls.Add(btnAdd);
            Name = "AddOrderForm";
            Text = "AddOrderForm";
            Load += AddOrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)nmrAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPRoductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpSevkTarihi;
        private Label lblPrice;
        private Label label8;
        private Label lblBarcode;
        private Label label3;
        private Label lblKdv;
        private Label label5;
        private Label label1;
        private ComboBox cmbProducts;
        private NumericUpDown nmrAdet;
        private Button btnAdd;
        private Label label2;
        private ComboBox cmbCustomer;
        private DataGridView dgvPRoductList;
        private Button btnPlus;
    }
}