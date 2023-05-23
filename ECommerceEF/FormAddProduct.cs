using ECommerceEF.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECommerceEF
{
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
            
        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            using (ProductDbContext db = new ProductDbContext())
            {

                var supplyers = db.Supplyers.ToList();
                comboBox1.DataSource = supplyers;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ProductDbContext db = new ProductDbContext())
            {
                var product = new context.Product();
                product.Name = textBox1.Text;
                product.Price = Convert.ToDecimal(textBox2.Text);
                product.SupplyerId = Convert.ToInt32(comboBox1.SelectedValue);
                db.Products.Add(product);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
