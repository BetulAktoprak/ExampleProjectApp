using System.Data;
using ExampleProjectApp.Context;
using ExampleProjectApp.Entities;
using ExampleProjectApp.FormsProduct;

namespace ExampleProjectApp
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            ProductList();
        }

        private void ProductList()
        {
            using (var context = new AppDbContext())
            {
                var products = context.Products.Select(p => new
                {
                    p.Id,
                    p.ProductName,
                    p.Barcode,
                    p.Description,
                    p.Stock,
                    UnitPrice = p.UnitPrice.ToString("N2"),
                    p.Metre,
                    p.Kilo,
                    p.CreatedDate
                }).ToList();

                dgvProductList.DataSource = products;
            }
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ProductChanged += (s, ev) => ProductList();
            addProductForm.Show();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ProductList();
        }

        private void dgvProductList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvProductList.CurrentRow != null)
            {
                int rowIndex = dgvProductList.CurrentRow.Index;
                if (rowIndex < 0) return;

                int productId = (int)dgvProductList.Rows[rowIndex].Cells["Id"].Value;

                var result = MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz?",
                                             "Ürün Sil",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (var context = new AppDbContext())
                    {
                        var product = context.Products.FirstOrDefault(p => p.Id == productId);

                        if (product != null)
                        {
                            context.Products.Remove(product);
                            context.SaveChanges();
                        }
                    }

                    ProductList();
                }

                e.Handled = true;
            }
        }

        private void dgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int productId = Convert.ToInt32(dgvProductList.Rows[e.RowIndex].Cells["Id"].Value);
                AddProductForm updatetForm = new AddProductForm(productId);
                updatetForm.ProductChanged += (s, ev) => ProductList();
                updatetForm.Show();
            }

            //if(e.RowIndex >= 0)
            //{
            //    int productId = Convert.ToInt32(dgvProductList.Rows[e.RowIndex].Cells["Id"].Value);
            //    ProductInformationForm productInformationForm = new ProductInformationForm(productId);
            //    productInformationForm.Show();
            //}
        }
    }
}
