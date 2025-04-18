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
            addOrderForm.OrderChanged += (s, args) => OrderList();
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
            if (dgvOrderList.CurrentRow != null)
            {
                int orderId = Convert.ToInt32(dgvOrderList.CurrentRow.Cells["Id"].Value);
                AddOrderForm addOrderForm = new AddOrderForm(orderId);
                addOrderForm.OrderChanged += (s, args) => OrderList();
                addOrderForm.Show();
            }
        }

        private void dgvOrderList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvOrderList.CurrentRow != null)
            {
                int selectedRowIndex = dgvOrderList.CurrentRow.Index;
                if (selectedRowIndex >= 0)
                {
                    var result = MessageBox.Show("Bu siparişi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int orderId = Convert.ToInt32(dgvOrderList.Rows[selectedRowIndex].Cells["Id"].Value);

                        using (var context = new AppDbContext())
                        {
                            var order = context.Orders
                                .Include(o => o.OrderDetails)
                                .FirstOrDefault(o => o.Id == orderId);

                            if (order != null)
                            {
                                context.OrderDetails.RemoveRange(order.OrderDetails); 
                                context.Orders.Remove(order); 
                                context.SaveChanges();

                                MessageBox.Show("Sipariş başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                OrderList(); 
                            }
                        }
                    }
                }
            }
        }
    }
}
