using ExampleProjectApp.Context;
using ExampleProjectApp.Entities;

namespace ExampleProjectApp.FormsProduct
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }
        private string CreateBarcode()
        {
            return "Logo" + Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string barcode = CreateBarcode();
            lblBarcode.Text = barcode;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var product = new Product
                    {
                        ProductName = txtAd.Text,
                        Description = txtDescription.Text,
                        UnitPrice = nmrUnitPrice.Value,
                        Stock = (int)nmrStock.Value,
                        Metre = (double)nmrMetre.Value,
                        Kilo = (double)nmrKilo.Value,
                        Barcode = lblBarcode.Text
                    };

                    if (string.IsNullOrWhiteSpace(txtAd.Text) || nmrUnitPrice.Value <= 0 || nmrStock.Value < 0)
                    {
                        MessageBox.Show("Lütfen geçerli ürün bilgilerini giriniz.");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(lblBarcode.Text))
                    {
                        MessageBox.Show("Lütfen barkod oluşturun.");
                        return;
                    }

                    context.Products.Add(product);
                    context.SaveChanges();

                    MessageBox.Show("Ürün Eklendi");

                    ClearForm();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu. " + ex.Message);
            }
        }
        private void ClearForm()
        {
            txtAd.Clear();
            nmrUnitPrice.Value = 0;
            nmrStock.Value = 0;
            nmrMetre.Value = 0;
            nmrKilo.Value = 0;
            txtDescription.Clear();
            lblBarcode.Text = string.Empty;
        }

        
    }
}
