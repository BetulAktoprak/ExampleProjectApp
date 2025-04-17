namespace ExampleProjectApp
{
    partial class ProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            btnRefresh = new Button();
            btnCreateProduct = new Button();
            label1 = new Label();
            dgvProductList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(1198, 43);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(80, 41);
            btnRefresh.TabIndex = 11;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnCreateProduct
            // 
            btnCreateProduct.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCreateProduct.Location = new Point(1023, 42);
            btnCreateProduct.Name = "btnCreateProduct";
            btnCreateProduct.Size = new Size(169, 41);
            btnCreateProduct.TabIndex = 10;
            btnCreateProduct.Text = "Ürün Ekle";
            btnCreateProduct.UseVisualStyleBackColor = true;
            btnCreateProduct.Click += btnCreateProduct_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(507, 47);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
            label1.TabIndex = 9;
            label1.Text = "Ürün Listesi";
            // 
            // dgvProductList
            // 
            dgvProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductList.BackgroundColor = SystemColors.ControlLight;
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(12, 94);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.Size = new Size(1285, 753);
            dgvProductList.TabIndex = 8;
            dgvProductList.CellDoubleClick += dgvProductList_CellDoubleClick;
            dgvProductList.KeyDown += dgvProductList_KeyDown;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1309, 859);
            Controls.Add(btnRefresh);
            Controls.Add(btnCreateProduct);
            Controls.Add(label1);
            Controls.Add(dgvProductList);
            Name = "ProductsForm";
            Text = "ProductsForm";
            Load += ProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefresh;
        private Button btnCreateProduct;
        private Label label1;
        private DataGridView dgvProductList;
    }
}