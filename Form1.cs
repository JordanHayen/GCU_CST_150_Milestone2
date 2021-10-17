using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Written by Jordan Hayen
// 10/17/2021
// This is my own work.

namespace Milestone2
{
    public partial class Form1 : Form
    {

        InventoryItem[] inventoryItems = new InventoryItem[3]; // Creates an array of InventoryItem objects with three elements

        public Form1()
        {
            InitializeComponent();
        }

        // This code runs when the AddItem button is clicked
        private void AddItem_Click(object sender, EventArgs e)
        {
            
            try // This code can only run if the data entered in the StockTextBox and the PriceTextBox can be parsed into an integer and a double respectively. Made with help from the textbook (Gaddis, 164).
            {
                if (inventoryItems[0] == null || inventoryItems[0].HasBeenRemoved) // If the first item in the inventoryItems array has been removed or has not been instantiated, then the new item should be the first item in the array.
                {
                    inventoryItems[0] = new InventoryItem(NameTextBox.Text, int.Parse(StockTextBox.Text), double.Parse(PriceTextBox.Text)); // The first item in the inventoryItem array is set to a new InventoryITem object with the name, stock and price entered by the user
                    Item0Name.Text = inventoryItems[0].ItemName; // The text of the Item0Name label is set to the ItemName property of the inventoryItems[0]
                    Item0Stock.Text = inventoryItems[0].Stock.ToString(); // The text of the Item0Stock label is set to the ItemStock property of the inventoryItems[0]
                    Item0Price.Text = "$" + inventoryItems[0].Price.ToString(); // The text of the Item0Price label is set to the ItemPrice property of the inventoryItems[0] and a dollar sign is added
                    RemoveItem0.Visible = true; // The button to remove inventoryItem[0] is made visible
                    TotalStockLabel.Text = InventoryItem.TotalStock.ToString(); // The text of the TotalStockLabel is set to the TotalStock property of the InventoryItem class
                    TotalItemsLabel.Text = InventoryItem.TotalItems.ToString(); // The text of the TotalItemsLabel is set to the TotalItems property of the InventoryItem class
                }
                else if(inventoryItems[1] == null || inventoryItems[1].HasBeenRemoved) // If the second item in the inventoryItems array has been removed or has not been instantiated, then the new item should be the second item in the array.
                {
                    inventoryItems[1] = new InventoryItem(NameTextBox.Text, int.Parse(StockTextBox.Text), double.Parse(PriceTextBox.Text)); // The second item in the inventoryItem array is set to a new inventoryITem object with the name, stock and price entered by the user
                    Item1Name.Text = inventoryItems[1].ItemName; // The text of the Item1Name label is set to the ItemName property of the inventoryItems[1]
                    Item1Stock.Text = inventoryItems[1].Stock.ToString(); // The text of the Item1Stock label is set to the ItemStock property of the inventoryItems[1]
                    Item1Price.Text = "$" + inventoryItems[1].Price.ToString(); // The text of the Item1Price label is set to the ItemPrice property of the inventoryItems[1] and a dollar sign is added
                    RemoveItem1.Visible = true; // The button to remove inventoryItem[1] is made visible
                    TotalStockLabel.Text = InventoryItem.TotalStock.ToString(); // The text of the TotalStockLabel is set to the TotalStock property of the InventoryItem class
                    TotalItemsLabel.Text = InventoryItem.TotalItems.ToString(); // The text of the TotalItemsLabel is set to the TotalItems property of the InventoryItem class
                }
                else if(inventoryItems[2] == null || inventoryItems[2].HasBeenRemoved) // If the third item in the inventoryItems array has been removed or has not been instantiated, then the new item should be the first item in the array.
                {
                    inventoryItems[2] = new InventoryItem(NameTextBox.Text, int.Parse(StockTextBox.Text), double.Parse(PriceTextBox.Text)); // The third item in the inventoryItem array is set to a new inventoryITem object with the name, stock and price entered by the user
                    Item2Name.Text = inventoryItems[2].ItemName; // The text of the Item2Name label is set to the ItemName property of the inventoryItems[2]
                    Item2Stock.Text = inventoryItems[2].Stock.ToString(); // The text of the Item2Stock label is set to the ItemStock property of the inventoryItems[2]
                    Item2Price.Text = "$" + inventoryItems[2].Price.ToString(); // The text of the Item2Price label is set to the ItemPrice property of the inventoryItems[2] and a dollar sign is added
                    RemoveItem2.Visible = true; // The button to remove inventoryItem[2] is made visible
                    TotalStockLabel.Text = InventoryItem.TotalStock.ToString(); // The text of the TotalStockLabel is set to the TotalStock property of the InventoryItem class
                    TotalItemsLabel.Text = InventoryItem.TotalItems.ToString(); // The text of the TotalItemsLabel is set to the TotalItems property of the InventoryItem class
                }
                else // If all of the items in the array have been instantiated and none have been removed, then a MessageBox is displayed informing the user that the list is full
                {
                    MessageBox.Show("Item list full");
                }

            }
            catch (Exception ex) // If the data entered by the user cannot be parsed into the necessary data types, a message is displayed saying as much
            {
                MessageBox.Show(ex.Message);
            }

            NameTextBox.Text = ""; // The text of NameTextBox is cleared
            StockTextBox.Text = ""; // The text of StockTextBox is cleared
            PriceTextBox.Text = ""; // The text of PriceTextBox is cleared
        }

        // This code runs when the RemoveItem0 button is clicked. It removes inventoryItem[0], clears the text of the labels displaying inventoryItem[0], and updates the text of the labels displaying the static properties of the InventoryItem class
        private void RemoveItem0_Click(object sender, EventArgs e)
        {
            inventoryItems[0].Remove(); // Calls the Remove method of inventoryItem[0]
            Item0Name.Text = ""; // Clears the text of the Item0Name label
            Item0Stock.Text = ""; // Clears the text of the Item0Stock label
            Item0Price.Text = ""; // Clears the text of the Item0Price label
            RemoveItem0.Visible = false; // Hides the RemoveItem0 button
            TotalStockLabel.Text = InventoryItem.TotalStock.ToString(); // The text of the TotalStockLabel is set to the TotalStock property of the InventoryItem class
            TotalItemsLabel.Text = InventoryItem.TotalItems.ToString(); // The text of the TotalItemsLabel is set to the TotalItems property of the InventoryItem class
        }

        // This code runs when the RemoveItem1 button is clicked. It removes inventoryItem[1], clears the text of the labels displaying inventoryItem[1], and updates the text of the labels displaying the static properties of the InventoryItem class
        private void RemoveItem1_Click(object sender, EventArgs e)
        {
            inventoryItems[1].Remove(); // Calls the Remove method of inventoryItem[1]
            Item1Name.Text = ""; // Clears the text of the Item1Name label
            Item1Stock.Text = ""; // Clears the text of the Item1Stock label
            Item1Price.Text = ""; // Clears the text of the Item1Price label
            RemoveItem1.Visible = false; // Hides the RemoveItem1 button
            TotalStockLabel.Text = InventoryItem.TotalStock.ToString(); // The text of the TotalStockLabel is set to the TotalStock property of the InventoryItem class
            TotalItemsLabel.Text = InventoryItem.TotalItems.ToString(); // The text of the TotalItemsLabel is set to the TotalItems property of the InventoryItem class
        }

        // This code runs when the RemoveItem2 button is clicked. It removes inventoryItem[2], clears the text of the labels displaying inventoryItem[2], and updates the text of the labels displaying the static properties of the InventoryItem class
        private void RemoveItem2_Click(object sender, EventArgs e)
        {
            inventoryItems[2].Remove(); // Calls the Remove method of inventoryItem[2]
            Item2Name.Text = ""; // Clears the text of the Item2Name label
            Item2Stock.Text = ""; // Clears the text of the Item2Stock label
            Item2Price.Text = ""; // Clears the text of the Item2Price label
            RemoveItem2.Visible = false; // Hides the RemoveItem2 button
            TotalStockLabel.Text = InventoryItem.TotalStock.ToString(); // The text of the TotalStockLabel is set to the TotalStock property of the InventoryItem class
            TotalItemsLabel.Text = InventoryItem.TotalItems.ToString(); // The text of the TotalItemsLabel is set to the TotalItems property of the InventoryItem class
        }
    }
}

// References:
// Gaddis, T. (2020). Starting Out With Visual C#. Pearson.