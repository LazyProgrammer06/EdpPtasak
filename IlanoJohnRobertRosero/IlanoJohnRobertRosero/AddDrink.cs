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
    public partial class AddDrink : Form
    {
        private Products productsForm;
        public AddDrink(Products form)
        {
            InitializeComponent();
            productsForm = form;
        }

        private void AddDrink_Load(object sender, EventArgs e)
        {

        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            string name = textBoxAddDrink.Text.Trim();
            string priceText = textBoxPriceDrink.Text.Trim();

            notifAddDrink.Text = "";
            notifAddDrink.ForeColor = System.Drawing.Color.Red;

            if(string.IsNullOrWhiteSpace(name))
            {
                notifAddDrink.ForeColor = System.Drawing.Color.Red;
                notifAddDrink.Text = "Please enter a drink.";
                return;
            }
            if (!decimal.TryParse(priceText, out decimal price) || price <= 0)
            {
                notifAddDrink.ForeColor = System.Drawing.Color.Red;
                notifAddDrink.Text = "Please enter a price.";
                return;
            }
            Products.Drinks.Add((name, price));
            productsForm.LoadDrinks();

            notifAddDrink.ForeColor = System.Drawing.Color.Green;
            notifAddDrink.Text = $"{name} added successfully!";

            textBoxAddDrink.Clear();
            textBoxPriceDrink.Clear();
            textBoxAddDrink.Focus();
        }
    }
}
