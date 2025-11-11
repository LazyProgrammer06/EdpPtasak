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
    public partial class RemoveDrink : Form
    {
        private Products productForm;
        public RemoveDrink(Products form)
        {
            InitializeComponent();
            productForm = form;
        }

        private void btnRemoveDrink_Click(object sender, EventArgs e)
        {
            string removeDrink = textBoxRemoveDrink.Text.Trim();

            if (string.IsNullOrWhiteSpace(removeDrink))
            {
                notifRemoveDrink.ForeColor = System.Drawing.Color.Red;
                notifRemoveDrink.Text = "The field can't be empty.";
                return;
            }
            var drinkItem = Products.Drinks.FirstOrDefault(d => d.name == removeDrink);

            if (drinkItem.name == null)
            {
                notifRemoveDrink.ForeColor = System.Drawing.Color.Red;
                notifRemoveDrink.Text = "Drink not found.";
                return;
            }
            Products.Drinks.Remove(drinkItem);
            productForm.LoadDrinks();

            notifRemoveDrink.ForeColor = System.Drawing.Color.Green;
            notifRemoveDrink.Text = $"{removeDrink} removed successfully!";

            textBoxRemoveDrink.Clear();
            textBoxRemoveDrink.Focus();
        }
    }
}
