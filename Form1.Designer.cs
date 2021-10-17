namespace Milestone2
{
    partial class Form1
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
            this.AddItem = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.StockTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RemoveItem0 = new System.Windows.Forms.Button();
            this.RemoveItem1 = new System.Windows.Forms.Button();
            this.RemoveItem2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Item0Name = new System.Windows.Forms.Label();
            this.Item1Name = new System.Windows.Forms.Label();
            this.Item2Name = new System.Windows.Forms.Label();
            this.Item0Stock = new System.Windows.Forms.Label();
            this.Item1Stock = new System.Windows.Forms.Label();
            this.Item2Stock = new System.Windows.Forms.Label();
            this.Item0Price = new System.Windows.Forms.Label();
            this.Item1Price = new System.Windows.Forms.Label();
            this.Item2Price = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalStockLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalItemsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(60, 280);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(75, 20);
            this.AddItem.TabIndex = 0;
            this.AddItem.Text = "Add Item";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(173, 280);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // StockTextBox
            // 
            this.StockTextBox.Location = new System.Drawing.Point(316, 280);
            this.StockTextBox.Name = "StockTextBox";
            this.StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.StockTextBox.TabIndex = 2;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(457, 280);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(173, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(316, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item Stock";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(453, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Item Price";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveItem0
            // 
            this.RemoveItem0.Location = new System.Drawing.Point(283, 30);
            this.RemoveItem0.Name = "RemoveItem0";
            this.RemoveItem0.Size = new System.Drawing.Size(75, 20);
            this.RemoveItem0.TabIndex = 10;
            this.RemoveItem0.Text = "Remove";
            this.RemoveItem0.UseVisualStyleBackColor = true;
            this.RemoveItem0.Visible = false;
            this.RemoveItem0.Click += new System.EventHandler(this.RemoveItem0_Click);
            // 
            // RemoveItem1
            // 
            this.RemoveItem1.Location = new System.Drawing.Point(283, 75);
            this.RemoveItem1.Name = "RemoveItem1";
            this.RemoveItem1.Size = new System.Drawing.Size(75, 20);
            this.RemoveItem1.TabIndex = 11;
            this.RemoveItem1.Text = "Remove";
            this.RemoveItem1.UseVisualStyleBackColor = true;
            this.RemoveItem1.Visible = false;
            this.RemoveItem1.Click += new System.EventHandler(this.RemoveItem1_Click);
            // 
            // RemoveItem2
            // 
            this.RemoveItem2.Location = new System.Drawing.Point(283, 120);
            this.RemoveItem2.Name = "RemoveItem2";
            this.RemoveItem2.Size = new System.Drawing.Size(75, 20);
            this.RemoveItem2.TabIndex = 12;
            this.RemoveItem2.Text = "Remove";
            this.RemoveItem2.UseVisualStyleBackColor = true;
            this.RemoveItem2.Visible = false;
            this.RemoveItem2.Click += new System.EventHandler(this.RemoveItem2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Item Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(105, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Item Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(197, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Item Price";
            // 
            // Item0Name
            // 
            this.Item0Name.AutoSize = true;
            this.Item0Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Item0Name.Location = new System.Drawing.Point(12, 30);
            this.Item0Name.Name = "Item0Name";
            this.Item0Name.Size = new System.Drawing.Size(13, 20);
            this.Item0Name.TabIndex = 16;
            this.Item0Name.Text = " ";
            // 
            // Item1Name
            // 
            this.Item1Name.AutoSize = true;
            this.Item1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Item1Name.Location = new System.Drawing.Point(12, 75);
            this.Item1Name.Name = "Item1Name";
            this.Item1Name.Size = new System.Drawing.Size(13, 20);
            this.Item1Name.TabIndex = 17;
            this.Item1Name.Text = " ";
            // 
            // Item2Name
            // 
            this.Item2Name.AutoSize = true;
            this.Item2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Item2Name.Location = new System.Drawing.Point(12, 120);
            this.Item2Name.Name = "Item2Name";
            this.Item2Name.Size = new System.Drawing.Size(13, 20);
            this.Item2Name.TabIndex = 18;
            this.Item2Name.Text = " ";
            // 
            // Item0Stock
            // 
            this.Item0Stock.AutoSize = true;
            this.Item0Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Item0Stock.Location = new System.Drawing.Point(105, 30);
            this.Item0Stock.Name = "Item0Stock";
            this.Item0Stock.Size = new System.Drawing.Size(13, 20);
            this.Item0Stock.TabIndex = 19;
            this.Item0Stock.Text = " ";
            // 
            // Item1Stock
            // 
            this.Item1Stock.AutoSize = true;
            this.Item1Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Item1Stock.Location = new System.Drawing.Point(105, 75);
            this.Item1Stock.Name = "Item1Stock";
            this.Item1Stock.Size = new System.Drawing.Size(13, 20);
            this.Item1Stock.TabIndex = 20;
            this.Item1Stock.Text = " ";
            // 
            // Item2Stock
            // 
            this.Item2Stock.AutoSize = true;
            this.Item2Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Item2Stock.Location = new System.Drawing.Point(105, 120);
            this.Item2Stock.Name = "Item2Stock";
            this.Item2Stock.Size = new System.Drawing.Size(13, 20);
            this.Item2Stock.TabIndex = 21;
            this.Item2Stock.Text = " ";
            // 
            // Item0Price
            // 
            this.Item0Price.AutoSize = true;
            this.Item0Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Item0Price.Location = new System.Drawing.Point(197, 30);
            this.Item0Price.Name = "Item0Price";
            this.Item0Price.Size = new System.Drawing.Size(13, 20);
            this.Item0Price.TabIndex = 22;
            this.Item0Price.Text = " ";
            // 
            // Item1Price
            // 
            this.Item1Price.AutoSize = true;
            this.Item1Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Item1Price.Location = new System.Drawing.Point(197, 75);
            this.Item1Price.Name = "Item1Price";
            this.Item1Price.Size = new System.Drawing.Size(13, 20);
            this.Item1Price.TabIndex = 23;
            this.Item1Price.Text = " ";
            // 
            // Item2Price
            // 
            this.Item2Price.AutoSize = true;
            this.Item2Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Item2Price.Location = new System.Drawing.Point(197, 120);
            this.Item2Price.Name = "Item2Price";
            this.Item2Price.Size = new System.Drawing.Size(13, 20);
            this.Item2Price.TabIndex = 24;
            this.Item2Price.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(444, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Total Stock of Items:";
            // 
            // TotalStockLabel
            // 
            this.TotalStockLabel.AutoSize = true;
            this.TotalStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TotalStockLabel.Location = new System.Drawing.Point(605, 45);
            this.TotalStockLabel.Name = "TotalStockLabel";
            this.TotalStockLabel.Size = new System.Drawing.Size(13, 20);
            this.TotalStockLabel.TabIndex = 26;
            this.TotalStockLabel.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(507, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Total Items:";
            // 
            // TotalItemsLabel
            // 
            this.TotalItemsLabel.AutoSize = true;
            this.TotalItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TotalItemsLabel.Location = new System.Drawing.Point(605, 75);
            this.TotalItemsLabel.Name = "TotalItemsLabel";
            this.TotalItemsLabel.Size = new System.Drawing.Size(13, 20);
            this.TotalItemsLabel.TabIndex = 28;
            this.TotalItemsLabel.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 369);
            this.Controls.Add(this.TotalItemsLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TotalStockLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Item2Price);
            this.Controls.Add(this.Item1Price);
            this.Controls.Add(this.Item0Price);
            this.Controls.Add(this.Item2Stock);
            this.Controls.Add(this.Item1Stock);
            this.Controls.Add(this.Item0Stock);
            this.Controls.Add(this.Item2Name);
            this.Controls.Add(this.Item1Name);
            this.Controls.Add(this.Item0Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RemoveItem2);
            this.Controls.Add(this.RemoveItem1);
            this.Controls.Add(this.RemoveItem0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.StockTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AddItem);
            this.Name = "Form1";
            this.Text = "InventoryItem Class Implementation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox StockTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RemoveItem0;
        private System.Windows.Forms.Button RemoveItem1;
        private System.Windows.Forms.Button RemoveItem2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Item0Name;
        private System.Windows.Forms.Label Item1Name;
        private System.Windows.Forms.Label Item2Name;
        private System.Windows.Forms.Label Item0Stock;
        private System.Windows.Forms.Label Item1Stock;
        private System.Windows.Forms.Label Item2Stock;
        private System.Windows.Forms.Label Item0Price;
        private System.Windows.Forms.Label Item1Price;
        private System.Windows.Forms.Label Item2Price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotalStockLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TotalItemsLabel;
    }
}

