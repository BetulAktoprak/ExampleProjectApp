using System.Data;
using ExampleProjectApp.Context;
using ExampleProjectApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExampleProjectApp
{
    public partial class CustomerInformationForm : Form
    {
        private readonly int _customerId;
        public CustomerInformationForm(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;
            this.Load += CustomerInformationForm_Load!;
        }


        private void CustomerInformationForm_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var customer = context.Customers.FirstOrDefault(c => c.Id == _customerId);

                if (customer != null)
                {
                    txtFullName.Text = customer.FullName;
                    txtEmail.Text = customer.Email;
                    txtPhone.Text = customer.Phone;
                    txtTC.Text = customer.TCNo.ToString();
                    txtVergiDairesi.Text = customer.VergiDairesi;
                    txtVergiNo.Text = customer.VergiNo.ToString();
                }

                LoadOrders();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var customer = context.Customers.FirstOrDefault(c => c.Id == _customerId);
                if (customer != null)
                {
                    customer.FullName = txtFullName.Text;
                    customer.Email = txtEmail.Text;
                    customer.Phone = txtPhone.Text;
                    customer.TCNo = txtTC.Text;
                    customer.VergiDairesi = txtVergiDairesi.Text;
                    customer.VergiNo = Convert.ToInt32(txtVergiNo.Text);

                    customer.UpdatedDate = DateTime.UtcNow;

                    context.SaveChanges();
                    MessageBox.Show("Müşteri bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Müşteri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dataGridView1.SelectedRows.Count > 0)
            {
                var dialogResult = MessageBox.Show("Seçili siparişi silmek istediğinize emin misiniz?", "Sipariş Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    int orderId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

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

                            LoadOrders();
                        }
                    }
                }
            }
        }

        private void LoadOrders()
        {
            using (var context = new AppDbContext())
            {
                var orders = context.Orders
                    .Where(o => o.Id == _customerId)
                    .Select(o => new
                    {
                        o.Id,
                        o.FisNo,
                        SevkiyatTarihi = o.ShipmentDate,
                        SiparisTarihi = o.CreatedDate,
                        DetaySayisi = o.OrderDetails.Count,
                        ToplamTutar = o.OrderDetails.Sum(d => d.Quantity * d.UnitPrice)
                    })
                    .ToList();

                dataGridView1.DataSource = orders;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderByCustomerForm orderByCustomerForm = new OrderByCustomerForm();
            orderByCustomerForm.Show();
        }
    }
}
