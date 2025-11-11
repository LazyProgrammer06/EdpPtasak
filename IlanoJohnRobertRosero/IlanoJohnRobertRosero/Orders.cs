using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlanoJohnRobertRosero
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            LoadFoods();
            LoadDrinks();

            listViewFoodOrder.View = View.Details;

            listViewFoodOrder.Columns.Add("Menu Food", 150);
            listViewFoodOrder.Columns.Add("Price", 80);

            listViewDrinkOrder.View = View.Details;
            listViewDrinkOrder.Columns.Add("Menu Drinks", 150);
            listViewDrinkOrder.Columns.Add("Price", 80);

            Products.ProductsChanged += OnProductsChanged;
        }
        private void OnProductsChanged(object sender, EventArgs e)
        {
            LoadFoods();
            LoadDrinks();
        }
        public void LoadFoods()
        {
            listViewFoodOrder.Items.Clear();
            foreach (var item in Products.Foods)
            {
                ListViewItem listItem = new ListViewItem(item.name);
                listItem.SubItems.Add(item.price.ToString("0.00"));
                listViewFoodOrder.Items.Add(listItem);
            }
        }
        public void LoadDrinks()
        {
            listViewDrinkOrder.Items.Clear();
            foreach (var item in Products.Drinks)
            {
                ListViewItem listItem = new ListViewItem(item.name);
                listItem.SubItems.Add(item.price.ToString("0.00"));
                listViewDrinkOrder.Items.Add(listItem);
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Products.ProductsChanged -= OnProductsChanged;
            base.OnFormClosing(e);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listViewFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ProcessOrder processOrder = new ProcessOrder();
            processOrder.ShowDialog();
        }
    }
}
