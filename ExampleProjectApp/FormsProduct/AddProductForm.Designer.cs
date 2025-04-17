namespace ExampleProjectApp.FormsProduct
{
    partial class AddProductForm
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
            lblBarcode = new Label();
            button1 = new Button();
            nmrUnitPrice = new NumericUpDown();
            nmrStock = new NumericUpDown();
            label7 = new Label();
            label5 = new Label();
            label2 = new Label();
            txtAd = new TextBox();
            btnSave = new Button();
            nmrMetre = new NumericUpDown();
            nmrKilo = new NumericUpDown();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDescription = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nmrUnitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrMetre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrKilo).BeginInit();
            SuspendLayout();
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(232, 378);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(0, 20);
            lblBarcode.TabIndex = 36;
            // 
            // button1
            // 
            button1.Location = new Point(38, 369);
            button1.Name = "button1";
            button1.Size = new Size(113, 29);
            button1.TabIndex = 7;
            button1.Text = "Barkod Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // nmrUnitPrice
            // 
            nmrUnitPrice.Location = new Point(200, 185);
            nmrUnitPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nmrUnitPrice.Name = "nmrUnitPrice";
            nmrUnitPrice.Size = new Size(150, 27);
            nmrUnitPrice.TabIndex = 2;
            // 
            // nmrStock
            // 
            nmrStock.Location = new Point(200, 226);
            nmrStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nmrStock.Name = "nmrStock";
            nmrStock.Size = new Size(150, 27);
            nmrStock.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 185);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 30;
            label7.Text = "Ürün fiyatı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 233);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 31;
            label5.Text = "Stok miktarı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 47);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 32;
            label2.Text = "Ürün adı:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(200, 40);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(217, 27);
            txtAd.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSkyBlue;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.Location = new Point(298, 416);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 35);
            btnSave.TabIndex = 8;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // nmrMetre
            // 
            nmrMetre.Location = new Point(200, 268);
            nmrMetre.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nmrMetre.Name = "nmrMetre";
            nmrMetre.Size = new Size(150, 27);
            nmrMetre.TabIndex = 4;
            // 
            // nmrKilo
            // 
            nmrKilo.Location = new Point(200, 309);
            nmrKilo.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nmrKilo.Name = "nmrKilo";
            nmrKilo.Size = new Size(150, 27);
            nmrKilo.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 268);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 38;
            label1.Text = "Metre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 316);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 39;
            label3.Text = "Kilo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 91);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 43;
            label4.Text = "Açıklama:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(200, 88);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(217, 78);
            txtDescription.TabIndex = 1;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(469, 485);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(nmrMetre);
            Controls.Add(nmrKilo);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(btnSave);
            Controls.Add(lblBarcode);
            Controls.Add(button1);
            Controls.Add(nmrUnitPrice);
            Controls.Add(nmrStock);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(txtAd);
            Name = "AddProductForm";
            Text = "AddProductForm";
            Load += AddProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)nmrUnitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrMetre).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrKilo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBarcode;
        private Button button1;
        private NumericUpDown nmrUnitPrice;
        private NumericUpDown nmrStock;
        private Label label7;
        private Label label5;
        private Label label2;
        private TextBox txtAd;
        private Button btnSave;
        private NumericUpDown nmrMetre;
        private NumericUpDown nmrKilo;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtDescription;
    }
}