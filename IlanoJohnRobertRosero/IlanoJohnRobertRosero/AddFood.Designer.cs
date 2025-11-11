namespace IlanoJohnRobertRosero
{
    partial class AddFood
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
            textBoxAddFood = new TextBox();
            notifAddFood = new Label();
            btnAddFood = new Button();
            textBoxPriceFood = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 9);
            label1.Name = "label1";
            label1.Size = new Size(222, 34);
            label1.TabIndex = 1;
            label1.Text = "ADD FOOD";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxAddFood
            // 
            textBoxAddFood.Location = new Point(137, 60);
            textBoxAddFood.Multiline = true;
            textBoxAddFood.Name = "textBoxAddFood";
            textBoxAddFood.Size = new Size(260, 39);
            textBoxAddFood.TabIndex = 2;
            textBoxAddFood.TextChanged += textBox1_TextChanged;
            // 
            // notifAddFood
            // 
            notifAddFood.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notifAddFood.Location = new Point(137, 108);
            notifAddFood.Name = "notifAddFood";
            notifAddFood.Size = new Size(260, 32);
            notifAddFood.TabIndex = 3;
            notifAddFood.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(218, 172);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(96, 37);
            btnAddFood.TabIndex = 4;
            btnAddFood.Text = "ADD";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // textBoxPriceFood
            // 
            textBoxPriceFood.Location = new Point(420, 60);
            textBoxPriceFood.Multiline = true;
            textBoxPriceFood.Name = "textBoxPriceFood";
            textBoxPriceFood.Size = new Size(81, 39);
            textBoxPriceFood.TabIndex = 5;
            // 
            // AddFood
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 263);
            Controls.Add(textBoxPriceFood);
            Controls.Add(btnAddFood);
            Controls.Add(notifAddFood);
            Controls.Add(textBoxAddFood);
            Controls.Add(label1);
            Name = "AddFood";
            Text = "AddFood";
            Load += AddFood_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxAddFood;
        private Label notifAddFood;
        private Button btnAddFood;
        private TextBox textBoxPriceFood;
    }
}