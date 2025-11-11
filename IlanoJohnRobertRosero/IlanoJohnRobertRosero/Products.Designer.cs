namespace IlanoJohnRobertRosero
{
    partial class Products
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
            listViewFood = new ListView();
            listViewDrink = new ListView();
            btnAddFood = new Button();
            btnRemoveFood = new Button();
            btnAddDrink = new Button();
            btnRemoveDrink = new Button();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 20);
            label1.Name = "label1";
            label1.Size = new Size(222, 34);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listViewFood
            // 
            listViewFood.Location = new Point(28, 107);
            listViewFood.Name = "listViewFood";
            listViewFood.Size = new Size(260, 218);
            listViewFood.TabIndex = 1;
            listViewFood.UseCompatibleStateImageBehavior = false;
            listViewFood.SelectedIndexChanged += listViewFood_SelectedIndexChanged;
            // 
            // listViewDrink
            // 
            listViewDrink.Location = new Point(436, 107);
            listViewDrink.Name = "listViewDrink";
            listViewDrink.Size = new Size(272, 218);
            listViewDrink.TabIndex = 2;
            listViewDrink.UseCompatibleStateImageBehavior = false;
            listViewDrink.View = View.Details;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(41, 345);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(88, 34);
            btnAddFood.TabIndex = 3;
            btnAddFood.Text = "ADD";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // btnRemoveFood
            // 
            btnRemoveFood.Location = new Point(174, 345);
            btnRemoveFood.Name = "btnRemoveFood";
            btnRemoveFood.Size = new Size(88, 34);
            btnRemoveFood.TabIndex = 4;
            btnRemoveFood.Text = "REMOVE";
            btnRemoveFood.UseVisualStyleBackColor = true;
            btnRemoveFood.Click += btnRemoveFood_Click;
            // 
            // btnAddDrink
            // 
            btnAddDrink.Location = new Point(454, 345);
            btnAddDrink.Name = "btnAddDrink";
            btnAddDrink.Size = new Size(88, 34);
            btnAddDrink.TabIndex = 5;
            btnAddDrink.Text = "ADD";
            btnAddDrink.UseVisualStyleBackColor = true;
            btnAddDrink.Click += btnAddDrink_Click;
            // 
            // btnRemoveDrink
            // 
            btnRemoveDrink.Location = new Point(594, 345);
            btnRemoveDrink.Name = "btnRemoveDrink";
            btnRemoveDrink.Size = new Size(88, 34);
            btnRemoveDrink.TabIndex = 6;
            btnRemoveDrink.Text = "REMOVE";
            btnRemoveDrink.UseVisualStyleBackColor = true;
            btnRemoveDrink.Click += btnRemoveDrink_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(97, 81);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 7;
            label2.Text = "FOODS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(526, 81);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 8;
            label3.Text = "DRINKS";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(12, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRemoveDrink);
            Controls.Add(btnAddDrink);
            Controls.Add(btnRemoveFood);
            Controls.Add(btnAddFood);
            Controls.Add(listViewDrink);
            Controls.Add(listViewFood);
            Controls.Add(label1);
            Name = "Products";
            Text = "Products";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ListView listViewFood;
        private ListView listViewDrink;
        private Button btnAddFood;
        private Button btnRemoveFood;
        private Button btnAddDrink;
        private Button btnRemoveDrink;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}