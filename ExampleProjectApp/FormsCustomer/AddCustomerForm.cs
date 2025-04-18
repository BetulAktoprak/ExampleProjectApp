using ExampleProjectApp.Context;
using ExampleProjectApp.Entities;
using ExampleProjectApp.Validations;

namespace ExampleProjectApp
{
    public partial class AddCustomerForm : Form
    {
        public event EventHandler? CustomerAdded;

        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {

                var newCustomer = new Customer
                {
                    FullName = txtFullName.Text,
                    TCNo = txtTC.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    VergiNo = txtVergiNo.Text,
                    VergiDairesi = txtVergiDairesi.Text
                };

                var validator = new CustomerValidator();
                var result = validator.Validate(newCustomer);

                if (!result.IsValid)
                {
                    var errorMessage = string.Join("\n", result.Errors.Select(e => e.ErrorMessage));
                    MessageBox.Show(errorMessage, "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                context.Customers.Add(newCustomer);
                context.SaveChanges();

                MessageBox.Show("Kullanıcı başarıyla kaydedildi!");
                CustomerAdded?.Invoke(this, EventArgs.Empty);
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
