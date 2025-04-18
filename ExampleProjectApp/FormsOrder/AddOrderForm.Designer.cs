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
            dtpSevkTarihi.Location = new Point(140, 144);
            dtpSevkTarihi.Margin = new Padding(3, 2, 3, 2);
            dtpSevkTarihi.MinDate = new DateTime(2025, 4, 16, 0, 0, 0, 0);
            dtpSevkTarihi.Name = "dtpSevkTarihi";
            dtpSevkTarihi.Size = new Size(219, 23);
            dtpSevkTarihi.TabIndex = 2;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(82, 244);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 15);
            lblPrice.TabIndex = 55;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(68, 40);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 47;
            label8.Text = "Ürünler";
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(140, 113);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(0, 15);
            lblBarcode.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 149);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 46;
            label3.Text = "Sevk Tarihi :";
            // 
            // lblKdv
            // 
            lblKdv.AutoSize = true;
            lblKdv.Location = new Point(140, 219);
            lblKdv.Name = "lblKdv";
            lblKdv.Size = new Size(0, 15);
            lblKdv.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 188);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 45;
            label5.Text = "Miktar :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 219);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 52;
            label1.Text = "KDV:";
            // 
            // cmbProducts
            // 
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(140, 38);
            cmbProducts.Margin = new Padding(3, 2, 3, 2);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(315, 23);
            cmbProducts.TabIndex = 0;
            cmbProducts.SelectedIndexChanged += cmbProducts_SelectedIndexChanged;
            // 
            // nmrAdet
            // 
            nmrAdet.Location = new Point(140, 183);
            nmrAdet.Margin = new Padding(3, 2, 3, 2);
            nmrAdet.Name = "nmrAdet";
            nmrAdet.Size = new Size(131, 23);
            nmrAdet.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.Location = new Point(340, 238);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 28);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Kaydet";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 84);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 56;
            label2.Text = "Müşteriler";
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(140, 78);
            cmbCustomer.Margin = new Padding(3, 2, 3, 2);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(315, 23);
            cmbCustomer.TabIndex = 1;
            // 
            // dgvPRoductList
            // 
            dgvPRoductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPRoductList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPRoductList.BackgroundColor = SystemColors.ButtonFace;
            dgvPRoductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPRoductList.Location = new Point(533, 38);
            dgvPRoductList.Margin = new Padding(3, 2, 3, 2);
            dgvPRoductList.Name = "dgvPRoductList";
            dgvPRoductList.RowHeadersWidth = 51;
            dgvPRoductList.Size = new Size(751, 230);
            dgvPRoductList.TabIndex = 58;
            dgvPRoductList.KeyDown += dgvPRoductList_KeyDown;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.ButtonFace;
            btnPlus.Image = (Image)resources.GetObject("btnPlus.Image");
            btnPlus.Location = new Point(459, 35);
            btnPlus.Margin = new Padding(3, 2, 3, 2);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(50, 24);
            btnPlus.TabIndex = 59;
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // AddOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            ClientSize = new Size(1311, 290);
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
            Margin = new Padding(3, 2, 3, 2);
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