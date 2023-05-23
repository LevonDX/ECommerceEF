using ECommerceEF.context;
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
    public partial class FormAddSupplyer : Form
    {
        public Supplyer Supplyer { get; set; } = new Supplyer();
        public FormAddSupplyer()
        {
            InitializeComponent();
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            using (ProductDbContext dbContext = new ProductDbContext())
            {
                Supplyer.Name = textBox1.Text;
                dbContext.Supplyers.Add(Supplyer);
                await dbContext.SaveChangesAsync();
                DialogResult = DialogResult.OK;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FormAddSupplyer_Load(object sender, EventArgs e)
        {

        }
    }
}
