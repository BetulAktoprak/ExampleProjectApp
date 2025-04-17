using System.Globalization;
using ExampleProjectApp.Context;
using ExampleProjectApp.Entities;

namespace ExampleProjectApp
{
    public partial class AddOrderForm : Form
    {
        private int? _id;
        public AddOrderForm(int? id = null)
        {
            _id = id;

            InitializeComponent();
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var customers = context.Customers
                    .Select(c => new { c.Id, c.FullName })
                    .ToList();
                cmbCustomer.DataSource = customers;
                cmbCustomer.DisplayMember = "FullName";
                cmbCustomer.ValueMember = "Id";

                var products = context.Products
                    .Select(p => new { p.Id, Display = p.ProductName })
                    .ToList();
                cmbProducts.DataSource = products;
                cmbProducts.DisplayMember = "Display";
                cmbProducts.ValueMember = "Id";

                if (products.Count > 0)
                    cmbProducts.SelectedIndex = 0;
            }

            lblKdv.Text = "%18";
            dtpSevkTarihi.MinDate = DateTime.Today;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedValue == null || orderDetails.Count == 0)
            {
                MessageBox.Show("Müşteri seçiniz ve en az bir ürün ekleyiniz.");
                return;
            }

            using (var context = new AppDbContext())
            {
                var order = new Order
                {
                    CustomerId = (int)cmbCustomer.SelectedValue!,
                    ShipmentDate = dtpSevkTarihi.Value,
                    FisNo = new Random().Next(1000, 9999),
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    OrderDetails = orderDetails
                };

                context.Orders.Add(order);
                context.SaveChanges();

                MessageBox.Show("Sipariş başarıyla kaydedildi.");
                orderDetails.Clear();
                RefreshGrid();
            }
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedValue is int productId)
            {
                using (var context = new AppDbContext())
                {
                    var product = context.Products.FirstOrDefault(p => p.Id == productId);
                    if (product != null)
                    {
                        lblPrice.Text = product.UnitPrice.ToString("N2");
                    }
                }
            }
        }

        private List<OrderDetail> orderDetails = new();
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedValue == null || !int.TryParse(cmbProducts.SelectedValue.ToString(), out int productId))
            {
                MessageBox.Show("Lütfen bir ürün seçin.");
                return;
            }

            if (string.IsNullOrWhiteSpace(lblPrice.Text) ||
                !decimal.TryParse(lblPrice.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal unitPrice))
            {
                MessageBox.Show("Fiyat geçersiz.");
                return;
            }

            if (!int.TryParse(lblKdv.Text.Replace("%", ""), out int kdv))
            {
                MessageBox.Show("KDV formatı geçersiz.");
                return;
            }

            var detail = new OrderDetail
            {
                ProductId = productId,
                Quantity = (int)nmrAdet.Value,
                UnitPrice = unitPrice,
                KDV = kdv,
                TotalAmount = (decimal)(nmrAdet.Value * unitPrice)
            };

            orderDetails.Add(detail);
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgvPRoductList.Columns.Clear();
            dgvPRoductList.DataSource = orderDetails.Select(od => new
            {
                Ürün = GetProductNameById(od.ProductId),
                Miktar = od.Quantity,
                Fiyat = od.UnitPrice,
                KDV = od.KDV,
                Tutar = od.TotalAmount
            }).ToList();

        }
        private string GetProductNameById(int productId)
        {
            using (var context = new AppDbContext())
            {
                return context.Products.FirstOrDefault(p => p.Id == productId)?.ProductName ?? "Bilinmiyor";
            }
        }

        private void dgvPRoductList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvPRoductList.CurrentRow != null)
            {
                int selectedIndex = dgvPRoductList.CurrentRow.Index;
                if (selectedIndex >= 0 && selectedIndex < orderDetails.Count)
                {
                    orderDetails.RemoveAt(selectedIndex);
                    RefreshGrid();
                }
            }
        }
    }
}
