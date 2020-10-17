namespace KordellGiffordC968
{
    partial class MainScreen
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
            this.products = new System.Windows.Forms.DataGridView();
            this.parts = new System.Windows.Forms.DataGridView();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnRemovePart = new System.Windows.Forms.Button();
            this.btnModifyPart = new System.Windows.Forms.Button();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.productSearchBtn = new System.Windows.Forms.Button();
            this.productSearchTxt = new System.Windows.Forms.TextBox();
            this.partsSearchBtn = new System.Windows.Forms.Button();
            this.partsSearchTxt = new System.Windows.Forms.TextBox();
            this.productTitle = new System.Windows.Forms.Label();
            this.partsTitle = new System.Windows.Forms.Label();
            this.ScreenTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parts)).BeginInit();
            this.SuspendLayout();
            // 
            // products
            // 
            this.products.AllowUserToAddRows = false;
            this.products.AllowUserToDeleteRows = false;
            this.products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products.Location = new System.Drawing.Point(635, 97);
            this.products.Margin = new System.Windows.Forms.Padding(2);
            this.products.MultiSelect = false;
            this.products.Name = "products";
            this.products.ReadOnly = true;
            this.products.RowHeadersVisible = false;
            this.products.RowHeadersWidth = 51;
            this.products.RowTemplate.Height = 24;
            this.products.Size = new System.Drawing.Size(516, 230);
            this.products.TabIndex = 0;
            this.products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClick_Product);
            // 
            // parts
            // 
            this.parts.AccessibleName = "";
            this.parts.AllowUserToAddRows = false;
            this.parts.AllowUserToDeleteRows = false;
            this.parts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parts.Location = new System.Drawing.Point(37, 97);
            this.parts.Margin = new System.Windows.Forms.Padding(2);
            this.parts.MultiSelect = false;
            this.parts.Name = "parts";
            this.parts.ReadOnly = true;
            this.parts.RowHeadersVisible = false;
            this.parts.RowHeadersWidth = 51;
            this.parts.RowTemplate.Height = 24;
            this.parts.Size = new System.Drawing.Size(552, 230);
            this.parts.TabIndex = 6;
            this.parts.Tag = "";
            this.parts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClick_Part);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(982, 346);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(52, 30);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProduct.Location = new System.Drawing.Point(1095, 346);
            this.btnRemoveProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(56, 30);
            this.btnRemoveProduct.TabIndex = 5;
            this.btnRemoveProduct.Text = "Delete";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnAddPart
            // 
            this.btnAddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPart.Location = new System.Drawing.Point(414, 346);
            this.btnAddPart.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(52, 30);
            this.btnAddPart.TabIndex = 7;
            this.btnAddPart.Text = "Add";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnRemovePart
            // 
            this.btnRemovePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePart.Location = new System.Drawing.Point(533, 346);
            this.btnRemovePart.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemovePart.Name = "btnRemovePart";
            this.btnRemovePart.Size = new System.Drawing.Size(56, 30);
            this.btnRemovePart.TabIndex = 8;
            this.btnRemovePart.Text = "Delete";
            this.btnRemovePart.UseVisualStyleBackColor = true;
            this.btnRemovePart.Click += new System.EventHandler(this.btnRemovePart_Click);
            // 
            // btnModifyPart
            // 
            this.btnModifyPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyPart.Location = new System.Drawing.Point(470, 346);
            this.btnModifyPart.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifyPart.Name = "btnModifyPart";
            this.btnModifyPart.Size = new System.Drawing.Size(59, 30);
            this.btnModifyPart.TabIndex = 9;
            this.btnModifyPart.Text = "Modify";
            this.btnModifyPart.UseVisualStyleBackColor = true;
            this.btnModifyPart.Click += new System.EventHandler(this.btnModifyPart_Click);
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyProduct.Location = new System.Drawing.Point(1038, 346);
            this.btnModifyProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(53, 30);
            this.btnModifyProduct.TabIndex = 10;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = true;
            this.btnModifyProduct.Click += new System.EventHandler(this.btnModifyProduct_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(1080, 453);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(71, 30);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // productSearchBtn
            // 
            this.productSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSearchBtn.Location = new System.Drawing.Point(809, 64);
            this.productSearchBtn.Name = "productSearchBtn";
            this.productSearchBtn.Size = new System.Drawing.Size(68, 23);
            this.productSearchBtn.TabIndex = 1;
            this.productSearchBtn.Text = "Search";
            this.productSearchBtn.UseVisualStyleBackColor = true;
            this.productSearchBtn.Click += new System.EventHandler(this.btnSearch_Product);
            // 
            // productSearchTxt
            // 
            this.productSearchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSearchTxt.Location = new System.Drawing.Point(883, 64);
            this.productSearchTxt.Name = "productSearchTxt";
            this.productSearchTxt.Size = new System.Drawing.Size(268, 23);
            this.productSearchTxt.TabIndex = 2;
            // 
            // partsSearchBtn
            // 
            this.partsSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsSearchBtn.Location = new System.Drawing.Point(247, 64);
            this.partsSearchBtn.Name = "partsSearchBtn";
            this.partsSearchBtn.Size = new System.Drawing.Size(68, 23);
            this.partsSearchBtn.TabIndex = 12;
            this.partsSearchBtn.Text = "Search";
            this.partsSearchBtn.UseVisualStyleBackColor = true;
            this.partsSearchBtn.Click += new System.EventHandler(this.btnSearch_Parts);
            // 
            // partsSearchTxt
            // 
            this.partsSearchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsSearchTxt.Location = new System.Drawing.Point(321, 64);
            this.partsSearchTxt.Name = "partsSearchTxt";
            this.partsSearchTxt.Size = new System.Drawing.Size(268, 23);
            this.partsSearchTxt.TabIndex = 13;
            // 
            // productTitle
            // 
            this.productTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productTitle.Location = new System.Drawing.Point(632, 74);
            this.productTitle.Name = "productTitle";
            this.productTitle.Size = new System.Drawing.Size(171, 34);
            this.productTitle.TabIndex = 14;
            this.productTitle.Text = "Products";
            // 
            // partsTitle
            // 
            this.partsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsTitle.Location = new System.Drawing.Point(33, 74);
            this.partsTitle.Name = "partsTitle";
            this.partsTitle.Size = new System.Drawing.Size(171, 34);
            this.partsTitle.TabIndex = 15;
            this.partsTitle.Text = "Parts";
            // 
            // ScreenTitle
            // 
            this.ScreenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTitle.Location = new System.Drawing.Point(12, 27);
            this.ScreenTitle.Name = "ScreenTitle";
            this.ScreenTitle.Size = new System.Drawing.Size(258, 34);
            this.ScreenTitle.TabIndex = 16;
            this.ScreenTitle.Text = "Inventory Management System";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 503);
            this.Controls.Add(this.ScreenTitle);
            this.Controls.Add(this.partsSearchTxt);
            this.Controls.Add(this.partsSearchBtn);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnModifyProduct);
            this.Controls.Add(this.btnModifyPart);
            this.Controls.Add(this.btnRemovePart);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.products);
            this.Controls.Add(this.parts);
            this.Controls.Add(this.productSearchBtn);
            this.Controls.Add(this.productSearchTxt);
            this.Controls.Add(this.productTitle);
            this.Controls.Add(this.partsTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.form_load);
            ((System.ComponentModel.ISupportInitialize)(this.products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView products;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.DataGridView parts;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnRemovePart;
        private System.Windows.Forms.Button btnModifyPart;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button productSearchBtn;
        private System.Windows.Forms.TextBox productSearchTxt;
        private System.Windows.Forms.Button partsSearchBtn;
        private System.Windows.Forms.TextBox partsSearchTxt;
        private System.Windows.Forms.Label productTitle;
        private System.Windows.Forms.Label partsTitle;
        private System.Windows.Forms.Label ScreenTitle;
    }
}

