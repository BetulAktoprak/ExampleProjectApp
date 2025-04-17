using ExampleProjectApp.Context;
using Microsoft.EntityFrameworkCore;

namespace ExampleProjectApp
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm(null);
            addOrderForm.Show();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            OrderList();

        }

        private void OrderList()
        {
            using (var context = new AppDbContext())
            {
                var orders = context.Orders
                    .Include(o => o.Customer)
                    .Include(o => o.OrderDetails)
                    .Select(o => new
                    {
                        o.Id,
                        o.FisNo,
                        Müşteri = o.Customer!.FullName,
                        SiparisTarihi = o.CreatedDate,
                        SevkiyatTarihi = o.ShipmentDate,
                        ÜrünSayisi = o.OrderDetails.Count,
                        ToplamTutar = o.OrderDetails.Sum(d => d.Quantity * d.UnitPrice)
                    })
                    .ToList();

                dgvOrderList.DataSource = orders;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            OrderList();
        }

        private void dgvOrderList_DoubleClick(object sender, EventArgs e)
        {
            // TODO: satırda seçilen id
            AddOrderForm addOrderForm = new AddOrderForm(2);
            addOrderForm.Show();
        }
    }
}
