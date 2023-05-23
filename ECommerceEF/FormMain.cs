using ECommerceEF.Data;

namespace ECommerceEF
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            listBox1.Items.Clear();
            using (ProductDbContext db = new ProductDbContext())
            {
                var products = db.Products;
                foreach (var item in products)
                {
                    listBox1.Items.Add(item.Name);
                }
            }

        }

        private void btnAddSuppplyer_Click(object sender, EventArgs e)
        {
            FormAddSupplyer formAddSupplyer = new FormAddSupplyer();
            if (formAddSupplyer.ShowDialog() == DialogResult.OK)
            {

                MessageBox.Show("Supplier added");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormAddProduct formAddProduct = new FormAddProduct();
            if(DialogResult.OK == formAddProduct.ShowDialog())
            {
                MessageBox.Show("Product added");
            }
        }
    }
}