namespace IlanoJohnRobertRosero
{
    partial class AddDrink
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
            textBoxAddDrink = new TextBox();
            notifAddDrink = new Label();
            btnAddDrink = new Button();
            textBoxPriceDrink = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(162, 9);
            label1.Name = "label1";
            label1.Size = new Size(222, 34);
            label1.TabIndex = 2;
            label1.Text = "ADD DRINK";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxAddDrink
            // 
            textBoxAddDrink.Location = new Point(144, 46);
            textBoxAddDrink.Multiline = true;
            textBoxAddDrink.Name = "textBoxAddDrink";
            textBoxAddDrink.Size = new Size(260, 39);
            textBoxAddDrink.TabIndex = 3;
            // 
            // notifAddDrink
            // 
            notifAddDrink.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notifAddDrink.Location = new Point(144, 98);
            notifAddDrink.Name = "notifAddDrink";
            notifAddDrink.Size = new Size(260, 32);
            notifAddDrink.TabIndex = 4;
            notifAddDrink.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddDrink
            // 
            btnAddDrink.Location = new Point(217, 163);
            btnAddDrink.Name = "btnAddDrink";
            btnAddDrink.Size = new Size(96, 37);
            btnAddDrink.TabIndex = 5;
            btnAddDrink.Text = "ADD";
            btnAddDrink.UseVisualStyleBackColor = true;
            btnAddDrink.Click += btnAddDrink_Click;
            // 
            // textBoxPriceDrink
            // 
            textBoxPriceDrink.Location = new Point(440, 46);
            textBoxPriceDrink.Multiline = true;
            textBoxPriceDrink.Name = "textBoxPriceDrink";
            textBoxPriceDrink.Size = new Size(67, 39);
            textBoxPriceDrink.TabIndex = 6;
            // 
            // AddDrink
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 284);
            Controls.Add(textBoxPriceDrink);
            Controls.Add(btnAddDrink);
            Controls.Add(notifAddDrink);
            Controls.Add(textBoxAddDrink);
            Controls.Add(label1);
            Name = "AddDrink";
            Text = "AddDrink";
            Load += AddDrink_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxAddDrink;
        private Label notifAddDrink;
        private Button btnAddDrink;
        private TextBox textBoxPriceDrink;
    }
}