namespace IlanoJohnRobertRosero
{
    partial class ProcessOrder
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
            textBox1 = new TextBox();
            btnAddOrder = new Button();
            btnRemoveOrder = new Button();
            listView1 = new ListView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxPayment = new TextBox();
            btnPay = new Button();
            ResultChange = new Label();
            ResultTotal = new Label();
            btnPrint = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(144, 9);
            label1.Name = "label1";
            label1.Size = new Size(222, 34);
            label1.TabIndex = 2;
            label1.Text = "PROCESS ORDER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 64);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 36);
            textBox1.TabIndex = 3;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(307, 64);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(75, 35);
            btnAddOrder.TabIndex = 4;
            btnAddOrder.Text = "ADD";
            btnAddOrder.UseVisualStyleBackColor = true;
            // 
            // btnRemoveOrder
            // 
            btnRemoveOrder.Location = new Point(412, 65);
            btnRemoveOrder.Name = "btnRemoveOrder";
            btnRemoveOrder.Size = new Size(75, 35);
            btnRemoveOrder.TabIndex = 5;
            btnRemoveOrder.Text = "REMOVE";
            btnRemoveOrder.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(94, 120);
            listView1.Name = "listView1";
            listView1.Size = new Size(288, 239);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(94, 409);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 7;
            label2.Text = "Total:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(94, 448);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 8;
            label3.Text = "Payment:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(94, 487);
            label4.Name = "label4";
            label4.Size = new Size(68, 23);
            label4.TabIndex = 9;
            label4.Text = "Change:";
            // 
            // textBoxPayment
            // 
            textBoxPayment.Location = new Point(168, 448);
            textBoxPayment.Name = "textBoxPayment";
            textBoxPayment.Size = new Size(122, 23);
            textBoxPayment.TabIndex = 10;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(307, 448);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(59, 23);
            btnPay.TabIndex = 11;
            btnPay.Text = "PAY";
            btnPay.UseVisualStyleBackColor = true;
            // 
            // ResultChange
            // 
            ResultChange.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResultChange.Location = new Point(168, 487);
            ResultChange.Name = "ResultChange";
            ResultChange.Size = new Size(122, 23);
            ResultChange.TabIndex = 12;
            // 
            // ResultTotal
            // 
            ResultTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResultTotal.Location = new Point(168, 409);
            ResultTotal.Name = "ResultTotal";
            ResultTotal.Size = new Size(122, 23);
            ResultTotal.TabIndex = 13;
            ResultTotal.Click += label6_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(205, 552);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 35);
            btnPrint.TabIndex = 14;
            btnPrint.Text = "PRINT";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // ProcessOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 599);
            Controls.Add(btnPrint);
            Controls.Add(ResultTotal);
            Controls.Add(ResultChange);
            Controls.Add(btnPay);
            Controls.Add(textBoxPayment);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(btnRemoveOrder);
            Controls.Add(btnAddOrder);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ProcessOrder";
            Text = "ProcessOrder";
            Load += ProcessOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnAddOrder;
        private Button btnRemoveOrder;
        private ListView listView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxPayment;
        private Button btnPay;
        private Label ResultChange;
        private Label ResultTotal;
        private Button btnPrint;
    }
}