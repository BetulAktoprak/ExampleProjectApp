using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleProjectApp.FormsProduct
{
    public partial class ProductInformationForm : Form
    {
        private readonly int _productId;
        public ProductInformationForm(int productId)
        {
            InitializeComponent();
            _productId = productId;
            this.Load += ProductInformationForm_Load!;
        }

        private void ProductInformationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
