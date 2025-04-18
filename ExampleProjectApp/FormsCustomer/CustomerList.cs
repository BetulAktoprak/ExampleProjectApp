using ExampleProjectApp.Context;

namespace ExampleProjectApp
{
    public partial class CustomerList : Form
    {
        public CustomerList()
        {
            InitializeComponent();
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            LoadCustomer();

        }

        private void LoadCustomer()
        {
            using (var context = new AppDbContext())
            {
                var customerList = context.Customers.Select(c => new
                {
                    c.Id,
                    c.TCNo,
                    c.FullName,
                    c.Email,
                    c.Phone,
                    c.VergiDairesi,
                    c.VergiNo,
                    c.CreatedDate
                }).ToList();

                dgvCustomerList.DataSource = customerList;
            }
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.CustomerAdded += (s, ev) => LoadCustomer();
            addCustomerForm.Show();
        }

        private void dgvCustomerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int customerId = Convert.ToInt32(dgvCustomerList.Rows[e.RowIndex].Cells["Id"].Value);
                CustomerInformationForm customerInformationForm = new CustomerInformationForm(customerId);
                customerInformationForm.CustomerUpdated += (s, ev) => LoadCustomer();
                customerInformationForm.Show();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCustomer();
        }
    }
}
