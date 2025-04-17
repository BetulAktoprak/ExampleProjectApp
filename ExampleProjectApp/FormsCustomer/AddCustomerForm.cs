using ExampleProjectApp.Context;
using ExampleProjectApp.Entities;

namespace ExampleProjectApp
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {

                if (!int.TryParse(txtTC.Text, out int tcNo) || !int.TryParse(txtVergiNo.Text, out int vergiNo))
                {
                    MessageBox.Show("TC No ve Vergi No sayısal olmalıdır.");
                    return;
                }

                var newCustomer = new Customer
                {
                    FullName = txtFullName.Text,
                    TCNo = txtTC.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    VergiNo = int.Parse(txtVergiNo.Text),
                    VergiDairesi = txtVergiDairesi.Text
                };

                if (string.IsNullOrWhiteSpace(txtTC.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                    MessageBox.Show("Lütfen tüm zorunlu alanları doldurun.");
                    return;
                }

                context.Customers.Add(newCustomer);
                context.SaveChanges();

                MessageBox.Show("Kullanıcı başarıyla kaydedildi!");
                CustomerClear();
            }
        }

        private void CustomerClear()
        {
            txtFullName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtTC.Clear();
            txtVergiNo.Clear();
            txtVergiDairesi.Clear();
        }
    }
}
