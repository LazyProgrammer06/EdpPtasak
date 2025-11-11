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
    public partial class RemoveFood : Form
    {
        private Products productForm;
        public RemoveFood(Products form)
        {
            InitializeComponent();
            productForm = form;
        }

        private void btnRemoveFood_Click(object sender, EventArgs e)
        {
            string removeFood = textRemoveFood.Text.Trim();

            if (string.IsNullOrWhiteSpace(removeFood))
            {
                notifRemoveFood.ForeColor = System.Drawing.Color.Red;
                notifRemoveFood.Text = "The field can't be empty.";
                return;
            }
            var foodItem = Products.Foods.FirstOrDefault(f => f.name == removeFood);

            if (foodItem.name == null)
            {
                notifRemoveFood.ForeColor = System.Drawing.Color.Red;
                notifRemoveFood.Text = "Food not found.";
                return;
            }
            Products.Foods.Remove(foodItem);
            productForm.LoadFoods();

            notifRemoveFood.ForeColor = System.Drawing.Color.Green;
            notifRemoveFood.Text = $"{removeFood} removed successfully!";

            textRemoveFood.Clear();
            textRemoveFood.Focus();
        }
    }
}
