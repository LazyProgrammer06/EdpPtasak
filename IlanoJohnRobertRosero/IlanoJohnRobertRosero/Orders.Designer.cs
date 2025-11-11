namespace IlanoJohnRobertRosero
{
    partial class Orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            listViewFoodOrder = new ListView();
            label2 = new Label();
            listViewDrinkOrder = new ListView();
            label3 = new Label();
            btnOrder = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(274, 9);
            label1.Name = "label1";
            label1.Size = new Size(222, 34);
            label1.TabIndex = 1;
            label1.Text = "ORDERS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listViewFoodOrder
            // 
            listViewFoodOrder.Location = new Point(60, 102);
            listViewFoodOrder.Name = "listViewFoodOrder";
            listViewFoodOrder.Size = new Size(237, 218);
            listViewFoodOrder.TabIndex = 2;
            listViewFoodOrder.UseCompatibleStateImageBehavior = false;
            listViewFoodOrder.View = View.Details;
            listViewFoodOrder.SelectedIndexChanged += listViewFood_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(122, 76);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 8;
            label2.Text = "FOODS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listViewDrinkOrder
            // 
            listViewDrinkOrder.Location = new Point(434, 102);
            listViewDrinkOrder.Name = "listViewDrinkOrder";
            listViewDrinkOrder.Size = new Size(239, 218);
            listViewDrinkOrder.TabIndex = 9;
            listViewDrinkOrder.UseCompatibleStateImageBehavior = false;
            listViewDrinkOrder.View = View.Details;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(493, 76);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 10;
            label3.Text = "DRINKS";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(319, 356);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(91, 38);
            btnOrder.TabIndex = 11;
            btnOrder.Text = "ORDER";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 450);
            Controls.Add(btnOrder);
            Controls.Add(label3);
            Controls.Add(listViewDrinkOrder);
            Controls.Add(label2);
            Controls.Add(listViewFoodOrder);
            Controls.Add(label1);
            Name = "Orders";
            Text = "Orders";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ListView listViewFoodOrder;
        private Label label2;
        private ListView listViewDrinkOrder;
        private Label label3;
        private Button btnOrder;
    }
}