namespace IlanoJohnRobertRosero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void A_Click(object sender, EventArgs e)
        {
            Products productsForm = new Products();
            productsForm.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Orders orderForm = new Orders();
            orderForm.Show();
            this.Hide();
        }
    }
}
