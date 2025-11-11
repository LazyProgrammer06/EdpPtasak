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
    public partial class Products : Form
    {
        public static List<(string name, decimal price)> Foods = new List<(string, decimal)>();
        public static List<(string name, decimal price)> Drinks = new List<(string, decimal)>();

        public static event EventHandler ProductsChanged;
        public Products()
        {
            InitializeComponent();
            listViewFood.View = View.Details;

            listViewFood.Columns.Add("Name", 150);
            listViewFood.Columns.Add("Price", 80);

            listViewDrink.View = View.Details;
            listViewDrink.Columns.Add("Name", 150);
            listViewDrink.Columns.Add("Price", 80);



        }
        private void Products_Load(object sender, EventArgs e)
        {
            LoadFoods();
            LoadDrinks();
        }
        public void LoadFoods()
        {
            listViewFood.Items.Clear();
            foreach (var food in Foods)
            {
                ListViewItem item = new ListViewItem(food.name);
                item.SubItems.Add(food.price.ToString("₱0.00"));
                listViewFood.Items.Add(item);
            }
            ProductsChanged?.Invoke(this, EventArgs.Empty);
        }
        public void LoadDrinks()
        {
            listViewDrink.Items.Clear();
            foreach (var drink in Drinks)
            {
                ListViewItem item = new ListViewItem(drink.name);
                item.SubItems.Add(drink.price.ToString("₱0.00"));
                listViewDrink.Items.Add(item);
            }
            ProductsChanged?.Invoke(this, EventArgs.Empty);
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            AddFood addFoodForm = new AddFood(this);
            addFoodForm.ShowDialog();
        }

        private void listViewFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemoveFood_Click(object sender, EventArgs e)
        {
            RemoveFood removeFood = new RemoveFood(this);
            removeFood.ShowDialog();
        }

        private void btnRemoveDrink_Click(object sender, EventArgs e)
        {
            RemoveDrink removedrink = new RemoveDrink(this);
            removedrink.ShowDialog();
        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            AddDrink addDrinkForm = new AddDrink(this);
            addDrinkForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
