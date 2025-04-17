namespace ExampleProjectApp
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStockCards = new Button();
            btnCustomer = new Button();
            btnOrders = new Button();
            SuspendLayout();
            // 
            // btnStockCards
            // 
            btnStockCards.BackColor = Color.DeepSkyBlue;
            btnStockCards.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnStockCards.Location = new Point(397, 120);
            btnStockCards.Name = "btnStockCards";
            btnStockCards.Size = new Size(283, 193);
            btnStockCards.TabIndex = 0;
            btnStockCards.Text = "Stok Kartları";
            btnStockCards.UseVisualStyleBackColor = false;
            btnStockCards.Click += btnStockCards_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.Orange;
            btnCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCustomer.Location = new Point(44, 120);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(282, 193);
            btnCustomer.TabIndex = 1;
            btnCustomer.Text = "Müşteriler";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.LimeGreen;
            btnOrders.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOrders.Location = new Point(744, 120);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(303, 193);
            btnOrders.TabIndex = 2;
            btnOrders.Text = "Siparişler";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += btnOrders_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1094, 471);
            Controls.Add(btnOrders);
            Controls.Add(btnCustomer);
            Controls.Add(btnStockCards);
            Name = "MenuForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStockCards;
        private Button btnCustomer;
        private Button btnOrders;
    }
}
