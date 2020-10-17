using KordellGiffordC968.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KordellGiffordC968
{
    public partial class ModifyProduct : Form
    {
        public ModifyProduct()
        {
            InitializeComponent();
            formatDGV_AllParts(allParts);
            formatDGV_AssociatedParts(associatedParts);
            autoPopulate();
            Display();
        }

        
        private void autoPopulate()
        {
            var product = Inventory.lookupProduct(Inventory.Products[Inventory.Index].ProductID);
            if (product != null)
            {
                idText.Text = product.ProductID.ToString();
                nameText.Text = product.Name;
                inventoryText.Text = product.InStock.ToString();
                priceText.Text = product.Price.ToString();
                maxText.Text = product.Max.ToString();
                minText.Text = product.Min.ToString();
            }
            else
            {
                MessageBox.Show("There is no matching product");
                this.Hide();
                MainScreen mainScreen = new MainScreen();
                mainScreen.Show();
            }
        }

        private void formatDGV_AllParts(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = Color.Black;
            d.RowHeadersVisible = false;
        }

        private void formatDGV_AssociatedParts(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = Color.Black;
            d.RowHeadersVisible = false;
        }

        public void Display()
        {
            allParts.DataSource = Inventory.AllParts;
            for (var i = 0; i < Inventory.Products[Inventory.Index].AssociatedParts.Count; i++)
            {
                Temp.Add(Inventory.Products[Inventory.Index].AssociatedParts[i]);
            }
            associatedParts.DataSource = Temp;
            allParts.ClearSelection();
            associatedParts.ClearSelection();
            Inventory.IndexParts = -1;
            Inventory.IndexAssociate = -1;
        }

        #region Save/Cancel Functionality

        private BindingList<Part> Temp = new BindingList<Part>();
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (Temp.Count == 0)
            {
                MessageBox.Show("You must associate atleast one part.");
            }
            else
            {
                this.Hide();
                Product updateProduct = new Product(nameText.Text, int.Parse(inventoryText.Text), decimal.Parse(priceText.Text), int.Parse(minText.Text), int.Parse(maxText.Text));
                Inventory.updateProduct(int.Parse(idText.Text), updateProduct);
                for (var i = 0; i < Temp.Count; i++)
                {
                    var updateAssociated = Inventory.Products[Inventory.Index].lookupAssociatedPart(i);
                    if (!Temp.Contains(updateAssociated) && updateAssociated != null)
                    {
                        if (!Inventory.Products[Inventory.Index].removeAssociatedPart(updateAssociated.PartID))
                        {
                            MessageBox.Show($"Unable to unassociate {updateAssociated.Name}");
                        }
                    }
                    else if (!Inventory.Products[Inventory.Index].AssociatedParts.Contains(Temp[i]))
                    {
                        Inventory.Products[Inventory.Index].addAssociatedPart(Temp[i]);
                    }
                }
                MainScreen mainScreen = new MainScreen();
                mainScreen.Show();
            }
        }
        #endregion

        #region Associate Part Manipulation
        private void cellClick_Part(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.IndexParts = allParts.CurrentCell.RowIndex;
        }

        private void cellClick_Associate(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.IndexAssociate = associatedParts.CurrentCell.RowIndex;
        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Temp.Add(Inventory.AllParts[Inventory.IndexParts]);
            associatedParts.DataSource = Temp;
            allParts.ClearSelection();
            associatedParts.ClearSelection();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var name = Temp[Inventory.IndexAssociate].Name;
                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to unassociate {name}?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Temp.RemoveAt(Inventory.IndexAssociate);
                    MessageBox.Show($"{name} has been unassociated.");
                    associatedParts.DataSource = Temp;
                    allParts.ClearSelection();
                    associatedParts.ClearSelection();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a part to unassociate.");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to unassociated selected product.");
            }
        }

        private void productSearchBtn_Click(object sender, EventArgs e)
        {
            allParts.ClearSelection();
            allParts.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            bool success = false;
            if (productSearchTxt.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(productSearchTxt.Text.ToUpper()))
                    {
                        allParts.Rows[i].Selected = true;
                        Inventory.IndexParts = i;
                        success = true;
                    }
                }
                if (!success)
                {
                    MessageBox.Show("Unable to find product.");
                }
            }
            else
            {
                MessageBox.Show("Please enter text to search.");
            }
        }
        #endregion

        #region Text Event Handlers

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameText.Text))
            {
                nameText.BackColor = Color.Salmon;
            }
            else
            {
                nameText.BackColor = Color.White;
            }
            allowSave();
        }

        private void inventoryText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(inventoryText.Text) || inventoryText.Text.All(char.IsLetter) || int.Parse(inventoryText.Text) < int.Parse(minText.Text) || int.Parse(inventoryText.Text) > int.Parse(maxText.Text))
                {
                    inventoryText.BackColor = Color.Salmon;
                }
                else
                {
                    inventoryText.BackColor = Color.White;
                }
                minMaxInventoryValid();
                allowSave();
            }
            catch (FormatException)
            {
                inventoryText.BackColor = Color.Salmon;
            }
        }

        private void priceText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(priceText.Text) || priceText.Text.All(char.IsLetter))
                {
                    priceText.BackColor = Color.Salmon;
                }
                else
                {
                    priceText.BackColor = Color.White;
                }
                allowSave();
            }
            catch (FormatException)
            {
                priceText.BackColor = Color.Salmon;
            }
        }

        private void maxText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(maxText.Text) || maxText.Text.All(char.IsLetter) || int.Parse(maxText.Text) < int.Parse(minText.Text))
                {
                    maxText.BackColor = Color.Salmon;
                }
                else
                {
                    maxText.BackColor = Color.White;
                }
                minMaxInventoryValid();
                allowSave();
            }
            catch (FormatException)
            {
                maxText.BackColor = Color.Salmon;
            }
        }

        private void minText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(minText.Text) || minText.Text.All(char.IsLetter) || int.Parse(maxText.Text) < int.Parse(minText.Text))
                {
                    minText.BackColor = Color.Salmon;
                }
                else
                {
                    minText.BackColor = Color.White;
                }
                minMaxInventoryValid();
                allowSave();
            }
            catch (FormatException)
            {
                minText.BackColor = Color.Salmon;
            }
        }

        private void allowSave()
        {
            if (nameText.BackColor == Color.White && inventoryText.BackColor == Color.White
                && priceText.BackColor == Color.White && maxText.BackColor == Color.White && minText.BackColor == Color.White)
            {
                save.Enabled = true;
            }
            else
            {
                save.Enabled = false;
            }
        }

        private void minMaxInventoryValid()
        {
            var min = minText.Text;
            var max = maxText.Text;
            var inventory = inventoryText.Text;
            if (int.Parse(min) < int.Parse(max) && min.All(char.IsDigit) && !string.IsNullOrEmpty(min))
            {
                minText.BackColor = Color.White;
            }
            else
            {
                minText.BackColor = Color.Salmon;
            }
            if (int.Parse(max) > int.Parse(min) && max.All(char.IsDigit) && !string.IsNullOrEmpty(max))
            {
                maxText.BackColor = Color.White;
            }
            else
            {
                maxText.BackColor = Color.Salmon;
            }
            if (int.Parse(inventory) < int.Parse(max) && int.Parse(inventory) > int.Parse(min) && inventory.All(char.IsDigit) && !string.IsNullOrEmpty(inventory))
            {
                inventoryText.BackColor = Color.White;
            }
            else
            {
                inventoryText.BackColor = Color.Salmon;
            }
        }

        #endregion
    }
}
