namespace KordellGiffordC968
{
    partial class AddProduct
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
            this.components = new System.ComponentModel.Container();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.inventoryText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.maxText = new System.Windows.Forms.TextBox();
            this.minText = new System.Windows.Forms.TextBox();
            this.allParts = new System.Windows.Forms.DataGridView();
            this.associatedParts = new System.Windows.Forms.DataGridView();
            this.partsLabel = new System.Windows.Forms.Label();
            this.associatedPartsLabel = new System.Windows.Forms.Label();
            this.partsSearchBtn = new System.Windows.Forms.Button();
            this.partsSearchTxt = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.pageTitle = new System.Windows.Forms.Label();
            this.NameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.InventoryToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PriceToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MaxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MinToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.allParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(60, 146);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(40, 20);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(55, 189);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 23);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.Location = new System.Drawing.Point(55, 224);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(100, 23);
            this.inventoryLabel.TabIndex = 2;
            this.inventoryLabel.Text = "Inventory";
            // 
            // priceLabel
            // 
            this.priceLabel.Location = new System.Drawing.Point(55, 265);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(100, 23);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price";
            // 
            // maxLabel
            // 
            this.maxLabel.Location = new System.Drawing.Point(60, 306);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(45, 23);
            this.maxLabel.TabIndex = 4;
            this.maxLabel.Text = "Max";
            // 
            // minLabel
            // 
            this.minLabel.Location = new System.Drawing.Point(161, 306);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(30, 23);
            this.minLabel.TabIndex = 5;
            this.minLabel.Text = "Min";
            // 
            // idText
            // 
            this.idText.Enabled = false;
            this.idText.Location = new System.Drawing.Point(117, 143);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(121, 20);
            this.idText.TabIndex = 0;
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.Color.Salmon;
            this.nameText.Location = new System.Drawing.Point(117, 189);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(121, 20);
            this.nameText.TabIndex = 6;
            this.NameToolTip.SetToolTip(this.nameText, "Letters Only Allowed");
            this.nameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            // 
            // inventoryText
            // 
            this.inventoryText.BackColor = System.Drawing.Color.Salmon;
            this.inventoryText.Location = new System.Drawing.Point(117, 224);
            this.inventoryText.Name = "inventoryText";
            this.inventoryText.Size = new System.Drawing.Size(121, 20);
            this.inventoryText.TabIndex = 7;
            this.InventoryToolTip.SetToolTip(this.inventoryText, "Numbers Between Max/Min");
            this.inventoryText.TextChanged += new System.EventHandler(this.inventoryText_TextChanged);
            // 
            // priceText
            // 
            this.priceText.BackColor = System.Drawing.Color.Salmon;
            this.priceText.Location = new System.Drawing.Point(117, 262);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(121, 20);
            this.priceText.TabIndex = 8;
            this.PriceToolTip.SetToolTip(this.priceText, "Numeric Price of Product");
            this.priceText.TextChanged += new System.EventHandler(this.priceText_TextChanged);
            // 
            // maxText
            // 
            this.maxText.BackColor = System.Drawing.Color.Salmon;
            this.maxText.Location = new System.Drawing.Point(90, 306);
            this.maxText.Name = "maxText";
            this.maxText.Size = new System.Drawing.Size(65, 20);
            this.maxText.TabIndex = 9;
            this.MaxToolTip.SetToolTip(this.maxText, "Numeric Maximum");
            this.maxText.TextChanged += new System.EventHandler(this.maxText_TextChanged);
            // 
            // minText
            // 
            this.minText.BackColor = System.Drawing.Color.Salmon;
            this.minText.Location = new System.Drawing.Point(188, 306);
            this.minText.Name = "minText";
            this.minText.Size = new System.Drawing.Size(65, 20);
            this.minText.TabIndex = 10;
            this.MinToolTip.SetToolTip(this.minText, "Numeric Minimum");
            this.minText.TextChanged += new System.EventHandler(this.minText_TextChanged);
            // 
            // allParts
            // 
            this.allParts.AccessibleName = "";
            this.allParts.AllowUserToAddRows = false;
            this.allParts.AllowUserToDeleteRows = false;
            this.allParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allParts.Location = new System.Drawing.Point(347, 68);
            this.allParts.Margin = new System.Windows.Forms.Padding(2);
            this.allParts.MultiSelect = false;
            this.allParts.Name = "allParts";
            this.allParts.ReadOnly = true;
            this.allParts.RowHeadersVisible = false;
            this.allParts.RowHeadersWidth = 51;
            this.allParts.RowTemplate.Height = 24;
            this.allParts.Size = new System.Drawing.Size(508, 160);
            this.allParts.TabIndex = 0;
            this.allParts.Tag = "";
            this.allParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClick_Part);
            // 
            // associatedParts
            // 
            this.associatedParts.AccessibleName = "";
            this.associatedParts.AllowUserToAddRows = false;
            this.associatedParts.AllowUserToDeleteRows = false;
            this.associatedParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.associatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedParts.Location = new System.Drawing.Point(344, 289);
            this.associatedParts.Margin = new System.Windows.Forms.Padding(2);
            this.associatedParts.MultiSelect = false;
            this.associatedParts.Name = "associatedParts";
            this.associatedParts.ReadOnly = true;
            this.associatedParts.RowHeadersVisible = false;
            this.associatedParts.RowHeadersWidth = 51;
            this.associatedParts.RowTemplate.Height = 24;
            this.associatedParts.Size = new System.Drawing.Size(508, 156);
            this.associatedParts.TabIndex = 60;
            this.associatedParts.Tag = "";
            this.associatedParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClick_Associate);
            // 
            // partsLabel
            // 
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(344, 45);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(158, 20);
            this.partsLabel.TabIndex = 12;
            this.partsLabel.Text = "All candidate Parts";
            // 
            // associatedPartsLabel
            // 
            this.associatedPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.associatedPartsLabel.Location = new System.Drawing.Point(341, 268);
            this.associatedPartsLabel.Name = "associatedPartsLabel";
            this.associatedPartsLabel.Size = new System.Drawing.Size(232, 20);
            this.associatedPartsLabel.TabIndex = 13;
            this.associatedPartsLabel.Text = "Parts Associated with this Product";
            // 
            // partsSearchBtn
            // 
            this.partsSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsSearchBtn.Location = new System.Drawing.Point(513, 39);
            this.partsSearchBtn.Name = "partsSearchBtn";
            this.partsSearchBtn.Size = new System.Drawing.Size(68, 23);
            this.partsSearchBtn.TabIndex = 14;
            this.partsSearchBtn.Text = "Search";
            this.partsSearchBtn.UseVisualStyleBackColor = true;
            this.partsSearchBtn.Click += new System.EventHandler(this.btnSearch_Parts);
            // 
            // partsSearchTxt
            // 
            this.partsSearchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsSearchTxt.Location = new System.Drawing.Point(587, 39);
            this.partsSearchTxt.Name = "partsSearchTxt";
            this.partsSearchTxt.Size = new System.Drawing.Size(268, 23);
            this.partsSearchTxt.TabIndex = 15;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(803, 233);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(52, 30);
            this.btnAddProduct.TabIndex = 16;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProduct.Location = new System.Drawing.Point(799, 464);
            this.btnRemoveProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(56, 30);
            this.btnRemoveProduct.TabIndex = 17;
            this.btnRemoveProduct.Text = "Delete";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(799, 505);
            this.cancel.Margin = new System.Windows.Forms.Padding(2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(56, 30);
            this.cancel.TabIndex = 18;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(739, 505);
            this.save.Margin = new System.Windows.Forms.Padding(2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(56, 30);
            this.save.TabIndex = 19;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // pageTitle
            // 
            this.pageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle.Location = new System.Drawing.Point(60, 41);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(183, 34);
            this.pageTitle.TabIndex = 43;
            this.pageTitle.Text = "Add Product";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 546);
            this.Controls.Add(this.pageTitle);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.partsSearchTxt);
            this.Controls.Add(this.partsSearchBtn);
            this.Controls.Add(this.associatedParts);
            this.Controls.Add(this.associatedPartsLabel);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.allParts);
            this.Controls.Add(this.minText);
            this.Controls.Add(this.maxText);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.inventoryText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Name = "AddProduct";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.allParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox inventoryText;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.TextBox maxText;
        private System.Windows.Forms.TextBox minText;
        private System.Windows.Forms.DataGridView allParts;
        private System.Windows.Forms.DataGridView associatedParts;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label associatedPartsLabel;
        private System.Windows.Forms.Button partsSearchBtn;
        private System.Windows.Forms.TextBox partsSearchTxt;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.ToolTip NameToolTip;
        private System.Windows.Forms.ToolTip InventoryToolTip;
        private System.Windows.Forms.ToolTip PriceToolTip;
        private System.Windows.Forms.ToolTip MaxToolTip;
        private System.Windows.Forms.ToolTip MinToolTip;
    }
}