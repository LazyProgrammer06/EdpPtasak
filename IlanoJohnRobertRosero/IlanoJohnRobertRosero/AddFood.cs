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
    public partial class AddFood : Form
    {
        private Products productsForm;
        public AddFood(Products form)
        {
            InitializeComponent();
            productsForm = form;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddFood_Load(object sender, EventArgs e)
        {

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = textBoxAddFood.Text.Trim();
            string priceText = textBoxPriceFood.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                notifAddFood.ForeColor = System.Drawing.Color.Red;
                notifAddFood.Text = "The field can't be empty.";
                return;
            }
            if (!decimal.TryParse(priceText, out decimal price) || price <= 0)
            {
                notifAddFood.ForeColor = System.Drawing.Color.Red;
                notifAddFood.Text = "Please enter the correct price.";
                return;
            }
            Products.Foods.Add((name, price));
            productsForm.LoadFoods();

            notifAddFood.ForeColor = System.Drawing.Color.Green;
            notifAddFood.Text = $"{name} added successfully!";

            textBoxAddFood.Clear();
            textBoxPriceFood.Clear();
            textBoxAddFood.Focus();
        }
    }
}
