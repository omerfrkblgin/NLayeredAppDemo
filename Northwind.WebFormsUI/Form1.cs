using Northwind.Business.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Business.Abstract;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
        }
        private IProductService _productService;
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProduct.DataSource = _productService.GetAll();
        }
    }
}
