namespace IlanoJohnRobertRosero
{
    partial class RemoveFood
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
            textRemoveFood = new TextBox();
            notifRemoveFood = new Label();
            btnRemoveFood = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 9);
            label1.Name = "label1";
            label1.Size = new Size(222, 34);
            label1.TabIndex = 2;
            label1.Text = "REMOVE FOOD";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textRemoveFood
            // 
            textRemoveFood.Location = new Point(131, 46);
            textRemoveFood.Multiline = true;
            textRemoveFood.Name = "textRemoveFood";
            textRemoveFood.Size = new Size(260, 39);
            textRemoveFood.TabIndex = 3;
            // 
            // notifRemoveFood
            // 
            notifRemoveFood.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notifRemoveFood.Location = new Point(131, 101);
            notifRemoveFood.Name = "notifRemoveFood";
            notifRemoveFood.Size = new Size(260, 32);
            notifRemoveFood.TabIndex = 4;
            notifRemoveFood.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRemoveFood
            // 
            btnRemoveFood.Location = new Point(209, 147);
            btnRemoveFood.Name = "btnRemoveFood";
            btnRemoveFood.Size = new Size(96, 37);
            btnRemoveFood.TabIndex = 5;
            btnRemoveFood.Text = "REMOVE";
            btnRemoveFood.UseVisualStyleBackColor = true;
            btnRemoveFood.Click += btnRemoveFood_Click;
            // 
            // RemoveFood
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 262);
            Controls.Add(btnRemoveFood);
            Controls.Add(notifRemoveFood);
            Controls.Add(textRemoveFood);
            Controls.Add(label1);
            Name = "RemoveFood";
            Text = "RemoveFood";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textRemoveFood;
        private Label notifRemoveFood;
        private Button btnRemoveFood;
    }
}