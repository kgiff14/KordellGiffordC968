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
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
            initInhouse();
        }

        #region Save/Cancel Functionality

        private void save_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (machineTxt.BackColor == Color.White)
            {
                Part newPart = new Inhouse(nameText.Text, int.Parse(inventoryText.Text), decimal.Parse(priceText.Text), int.Parse(minText.Text), int.Parse(maxText.Text), int.Parse(machineTxt.Text));
                Inventory.addPart(newPart);
            }
            else
            {
                Part newPart = new Outsourced(nameText.Text, int.Parse(inventoryText.Text), decimal.Parse(priceText.Text), int.Parse(minText.Text), int.Parse(maxText.Text), companyNameTxt.Text);
                Inventory.addPart(newPart);
            }
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
        }

        #endregion

        #region Text Event Handers

        private void outsourcedBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            machineID.Hide();
            machineTxt.Hide();
            companyNameTxt.Show();
            compnayNameLabel.Show();
        }

        private void inhouseBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            machineID.Show();
            machineTxt.Show();
            companyNameTxt.Hide();
            compnayNameLabel.Hide();
        }

        private void initInhouse()
        {
            inhouseBtn.Select();
        }

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

        private void companyNameTxt_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrEmpty(companyNameTxt.Text) || int.TryParse(companyNameTxt.Text, out number))
            {
                companyNameTxt.BackColor = Color.Salmon;
            }
            else
            {
                companyNameTxt.BackColor = Color.White;
            }
            allowSave();
        }

        private void machineTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(machineTxt.Text) || machineTxt.Text.All(char.IsLetter))
            {
                machineTxt.BackColor = Color.Salmon;
            }
            else
            {
                machineTxt.BackColor = Color.White;
            }
            allowSave();
        }

        private void allowSave()
        {
            if (nameText.BackColor == Color.White && inventoryText.BackColor == Color.White
                && priceText.BackColor == Color.White && maxText.BackColor == Color.White && minText.BackColor == Color.White
                && (machineTxt.BackColor == Color.White || companyNameTxt.BackColor == Color.White))
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
