using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void SearchProducts(string key)
        {
            //var result = _productDal.GetAll().Where(p => p.Name.Contains(key)).ToList();// Veri tabanından alınmış bilgi üzerinden filtreleme
            var result = _productDal.GetByName(key);// Veri tabanından filtreleme
            dgwProducts.DataSource = result;
        }

        private void Search(string key)
        {
            List<Product> products = new List<Product>();
            var result = _productDal.GetByİd(Convert.ToInt32(key));
            products.Add(result);
            dgwProducts.DataSource = products;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            LoadProducts();
            MessageBox.Show("Added!");

        }


        private void btnUpp_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxUpdateName.Text.ToString(),
                UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxUpdateStockAmount.Text)
            });
            LoadProducts();
            MessageBox.Show("Updatede!");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateName.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateUnitPrice.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateStockAmount.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _productDal.Deleted(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
            MessageBox.Show("Deletede!");
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search(tbxGetById.Text);
        }

    }
}
