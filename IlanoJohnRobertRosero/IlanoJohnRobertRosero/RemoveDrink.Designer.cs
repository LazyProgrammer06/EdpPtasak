namespace IlanoJohnRobertRosero
{
    partial class RemoveDrink
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
            textBoxRemoveDrink = new TextBox();
            notifRemoveDrink = new Label();
            btnRemoveDrink = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(159, 9);
            label1.Name = "label1";
            label1.Size = new Size(222, 34);
            label1.TabIndex = 3;
            label1.Text = "REMOVE DRINK";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxRemoveDrink
            // 
            textBoxRemoveDrink.Location = new Point(138, 46);
            textBoxRemoveDrink.Multiline = true;
            textBoxRemoveDrink.Name = "textBoxRemoveDrink";
            textBoxRemoveDrink.Size = new Size(260, 39);
            textBoxRemoveDrink.TabIndex = 4;
            // 
            // notifRemoveDrink
            // 
            notifRemoveDrink.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notifRemoveDrink.Location = new Point(138, 88);
            notifRemoveDrink.Name = "notifRemoveDrink";
            notifRemoveDrink.Size = new Size(260, 32);
            notifRemoveDrink.TabIndex = 5;
            notifRemoveDrink.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRemoveDrink
            // 
            btnRemoveDrink.Location = new Point(215, 150);
            btnRemoveDrink.Name = "btnRemoveDrink";
            btnRemoveDrink.Size = new Size(96, 37);
            btnRemoveDrink.TabIndex = 6;
            btnRemoveDrink.Text = "REMOVE";
            btnRemoveDrink.UseVisualStyleBackColor = true;
            btnRemoveDrink.Click += btnRemoveDrink_Click;
            // 
            // RemoveDrink
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 250);
            Controls.Add(btnRemoveDrink);
            Controls.Add(notifRemoveDrink);
            Controls.Add(textBoxRemoveDrink);
            Controls.Add(label1);
            Name = "RemoveDrink";
            Text = "RemoveDrink";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxRemoveDrink;
        private Label notifRemoveDrink;
        private Button btnRemoveDrink;
    }
}