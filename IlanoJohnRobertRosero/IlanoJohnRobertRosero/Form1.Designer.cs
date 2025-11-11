namespace IlanoJohnRobertRosero
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnViewProducts = new Button();
            btnOrder = new Button();
            SuspendLayout();
            // 
            // btnViewProducts
            // 
            btnViewProducts.Location = new Point(198, 61);
            btnViewProducts.Name = "btnViewProducts";
            btnViewProducts.Size = new Size(199, 40);
            btnViewProducts.TabIndex = 0;
            btnViewProducts.Text = "VIEW PRODUCTS";
            btnViewProducts.UseVisualStyleBackColor = true;
            btnViewProducts.Click += A_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(198, 120);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(199, 40);
            btnOrder.TabIndex = 1;
            btnOrder.Text = "ORDER";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 265);
            Controls.Add(btnOrder);
            Controls.Add(btnViewProducts);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewProducts;
        private Button btnOrder;
    }
}
