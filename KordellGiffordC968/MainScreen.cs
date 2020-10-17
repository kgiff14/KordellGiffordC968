using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;
using KordellGiffordC968.Main;

namespace KordellGiffordC968
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            formatDGV_Products(products);
            formatDGV_AllParts(parts);
            display();
        }

        private void formatDGV_Products(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = Color.Black;
            d.RowHeadersVisible = false;
        }

        private void formatDGV_AllParts(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = Color.Black;
            d.RowHeadersVisible = false;
        }
        private void display()
        {
            products.DataSource = Inventory.Products;
            parts.DataSource = Inventory.AllParts;
            products.ClearSelection();
            parts.ClearSelection();
            Inventory.Index = -1;
            Inventory.IndexParts = -1;
        }

        private void form_load(object sender, EventArgs e)
        {
            display();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region Products
        private void cellClick_Product(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.Index = products.CurrentCell.RowIndex;

        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {

            if (Inventory.Index < 0)
            {
                MessageBox.Show("Please select a row.");
            }
            else
            {
                try
                {
                    var productName = Inventory.Products[Inventory.Index].Name;
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete {productName}?", "Confirm", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (Inventory.Products[Inventory.Index].AssociatedParts.Count <= 0)
                        {
                            if (Inventory.removeProduct(Inventory.Index))
                            {
                                display();
                                MessageBox.Show($"{productName} has been deleted.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("The product has associated parts and cannot be deleted.");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to unassociated selected product.");
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }

        private void btnSearch_Product(object sender, EventArgs e)
        {
            products.ClearSelection();
            products.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            bool success = false;
            if (productSearchTxt.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(productSearchTxt.Text.ToUpper()))
                    {
                        products.Rows[i].Selected = true;
                        Inventory.Index = i;
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
        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            if (Inventory.Index < 0)
            {
                MessageBox.Show("Please select a row.");
            }
            else
            {
                this.Hide();
                ModifyProduct modifyProduct = new ModifyProduct();
                modifyProduct.Show();
            }
        }
        #endregion

        #region AllParts

        private void cellClick_Part(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.IndexParts = parts.CurrentCell.RowIndex;
        }

        private void btnSearch_Parts(object sender, EventArgs e)
        {
            parts.ClearSelection();
            parts.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            bool success = false;
            if (partsSearchTxt.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(partsSearchTxt.Text.ToUpper()))
                    {
                        parts.Rows[i].Selected = true;
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
        private void btnRemovePart_Click(object sender, EventArgs e)
        {

            if (Inventory.IndexParts < 0)
            {
                MessageBox.Show("Please select a row.");
            }
            else
            {
                try
                {
                    var partName = Inventory.AllParts[Inventory.IndexParts].Name;
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete {partName}?", "Confirm", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (Inventory.deletePart(Inventory.AllParts[Inventory.IndexParts]))
                        {
                            display();
                            MessageBox.Show($"{partName} has been deleted.");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to unassociated selected part.");
                }
            }
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPart addPart = new AddPart();
            addPart.Show();
        }

        private void btnModifyPart_Click(object sender, EventArgs e)
        {
            if (Inventory.IndexParts < 0)
            {
                MessageBox.Show("Please select a row.");
            }
            else
            {
                this.Hide();
                ModifyPart modifyPart = new ModifyPart();
                modifyPart.Show();
            }
        }
        #endregion
    }
}
