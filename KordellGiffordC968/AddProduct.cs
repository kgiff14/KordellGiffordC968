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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            formatDGV_AllParts(allParts);
            formatDGV_AssociateParts(associatedParts);
            Display();
        }


        private void formatDGV_AllParts(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = Color.Black;
            d.RowHeadersVisible = false;
        }
        private void formatDGV_AssociateParts(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = Color.Black;
            d.RowHeadersVisible = false;
        }

        public void Display()
        {
            allParts.DataSource = Inventory.AllParts;
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
                Product newProduct = new Product(nameText.Text, int.Parse(inventoryText.Text), decimal.Parse(priceText.Text), int.Parse(minText.Text), int.Parse(maxText.Text));
                Inventory.addProduct(newProduct);
                for (var i = 0; i < Temp.Count; i++)
                {
                    var updateAssociated = newProduct.lookupAssociatedPart(i);
                    if (!Temp.Contains(updateAssociated) && updateAssociated != null)
                    {
                        if (!newProduct.removeAssociatedPart(updateAssociated.PartID))
                        {
                            MessageBox.Show($"Unable to unassociate {updateAssociated.Name}");
                        }
                    }
                    else if (!newProduct.AssociatedParts.Contains(Temp[i]))
                    {
                        newProduct.addAssociatedPart(Temp[i]);
                    }
                }
                MainScreen mainScreen = new MainScreen();
                mainScreen.Show();
            }
        }

        #endregion

        #region Associate Parts Manipulation

        private void cellClick_Part(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.IndexParts = allParts.CurrentCell.RowIndex;
        }

        private void cellClick_Associate(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.IndexAssociate = associatedParts.CurrentCell.RowIndex;
        }

        private void btnSearch_Parts(object sender, EventArgs e)
        {
            allParts.ClearSelection();
            allParts.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            bool success = false;
            if (partsSearchTxt.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(partsSearchTxt.Text.ToUpper()))
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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (Inventory.IndexParts < 0)
            {
                MessageBox.Show("Please choose a part to associate.");
            }
            else
            {
                Temp.Add(Inventory.AllParts[Inventory.IndexParts]);
                associatedParts.DataSource = Temp;
                allParts.ClearSelection();
                associatedParts.ClearSelection();
            }
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

        #endregion

        #region Text Change Handlers
        private void nameText_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrEmpty(nameText.Text) || int.TryParse(nameText.Text, out number))
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
