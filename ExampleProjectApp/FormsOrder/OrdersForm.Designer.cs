namespace ExampleProjectApp
{
    partial class OrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            btnRefresh = new Button();
            btnCreateOrder = new Button();
            label1 = new Label();
            dgvOrderList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(1204, 31);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(80, 41);
            btnRefresh.TabIndex = 7;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCreateOrder.Location = new Point(1029, 30);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(169, 41);
            btnCreateOrder.TabIndex = 6;
            btnCreateOrder.Text = "Sipariş Ekle";
            btnCreateOrder.UseVisualStyleBackColor = true;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(513, 35);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 5;
            label1.Text = "Sipariş Listesi";
            // 
            // dgvOrderList
            // 
            dgvOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOrderList.BackgroundColor = SystemColors.ControlLight;
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new Point(36, 82);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.Size = new Size(1248, 723);
            dgvOrderList.TabIndex = 4;
            dgvOrderList.DoubleClick += dgvOrderList_DoubleClick;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            ClientSize = new Size(1316, 817);
            Controls.Add(btnRefresh);
            Controls.Add(btnCreateOrder);
            Controls.Add(label1);
            Controls.Add(dgvOrderList);
            Name = "OrdersForm";
            Text = "OrdersForm";
            Load += OrdersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefresh;
        private Button btnCreateOrder;
        private Label label1;
        private DataGridView dgvOrderList;
    }
}