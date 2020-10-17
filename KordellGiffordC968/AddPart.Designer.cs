namespace KordellGiffordC968
{
    partial class AddPart
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
            this.minText = new System.Windows.Forms.TextBox();
            this.maxText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.inventoryText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.idText = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.machineID = new System.Windows.Forms.Label();
            this.machineTxt = new System.Windows.Forms.TextBox();
            this.inhouseLabel = new System.Windows.Forms.Label();
            this.outsourcedLabel = new System.Windows.Forms.Label();
            this.pageTitle = new System.Windows.Forms.Label();
            this.outsourcedBtn = new System.Windows.Forms.RadioButton();
            this.inhouseBtn = new System.Windows.Forms.RadioButton();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.compnayNameLabel = new System.Windows.Forms.Label();
            this.companyNameTxt = new System.Windows.Forms.TextBox();
            this.NameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.InventoryToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PriceToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MaxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MinToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CompanyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MIDToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // minText
            // 
            this.minText.BackColor = System.Drawing.Color.Salmon;
            this.minText.Location = new System.Drawing.Point(263, 247);
            this.minText.Name = "minText";
            this.minText.Size = new System.Drawing.Size(65, 20);
            this.minText.TabIndex = 22;
            this.MinToolTip.SetToolTip(this.minText, "Numeric Minimum");
            this.minText.TextChanged += new System.EventHandler(this.minText_TextChanged);
            // 
            // maxText
            // 
            this.maxText.BackColor = System.Drawing.Color.Salmon;
            this.maxText.Location = new System.Drawing.Point(144, 247);
            this.maxText.Name = "maxText";
            this.maxText.Size = new System.Drawing.Size(65, 20);
            this.maxText.TabIndex = 21;
            this.MaxToolTip.SetToolTip(this.maxText, "Numeric Maximum");
            this.maxText.TextChanged += new System.EventHandler(this.maxText_TextChanged);
            // 
            // priceText
            // 
            this.priceText.BackColor = System.Drawing.Color.Salmon;
            this.priceText.Location = new System.Drawing.Point(144, 203);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(121, 20);
            this.priceText.TabIndex = 20;
            this.PriceToolTip.SetToolTip(this.priceText, "Price of Part");
            this.priceText.TextChanged += new System.EventHandler(this.priceText_TextChanged);
            // 
            // inventoryText
            // 
            this.inventoryText.BackColor = System.Drawing.Color.Salmon;
            this.inventoryText.Location = new System.Drawing.Point(144, 165);
            this.inventoryText.Name = "inventoryText";
            this.inventoryText.Size = new System.Drawing.Size(121, 20);
            this.inventoryText.TabIndex = 19;
            this.InventoryToolTip.SetToolTip(this.inventoryText, "Numbers Between Min/Max");
            this.inventoryText.TextChanged += new System.EventHandler(this.inventoryText_TextChanged);
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.Color.Salmon;
            this.nameText.Location = new System.Drawing.Point(144, 130);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(121, 20);
            this.nameText.TabIndex = 18;
            this.NameToolTip.SetToolTip(this.nameText, "Only Letters Allowed");
            this.nameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            // 
            // idText
            // 
            this.idText.Enabled = false;
            this.idText.Location = new System.Drawing.Point(144, 84);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(121, 20);
            this.idText.TabIndex = 11;
            // 
            // idLabel
            // 
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(87, 87);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(40, 20);
            this.idLabel.TabIndex = 12;
            this.idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(82, 130);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 23);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Name";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.Location = new System.Drawing.Point(82, 165);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(100, 23);
            this.inventoryLabel.TabIndex = 14;
            this.inventoryLabel.Text = "Inventory";
            // 
            // priceLabel
            // 
            this.priceLabel.Location = new System.Drawing.Point(82, 206);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(100, 23);
            this.priceLabel.TabIndex = 15;
            this.priceLabel.Text = "Price";
            // 
            // maxLabel
            // 
            this.maxLabel.Location = new System.Drawing.Point(93, 247);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(45, 23);
            this.maxLabel.TabIndex = 16;
            this.maxLabel.Text = "Max";
            // 
            // minLabel
            // 
            this.minLabel.Location = new System.Drawing.Point(227, 247);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(30, 23);
            this.minLabel.TabIndex = 17;
            this.minLabel.Text = "Min";
            // 
            // machineID
            // 
            this.machineID.Location = new System.Drawing.Point(63, 286);
            this.machineID.Name = "machineID";
            this.machineID.Size = new System.Drawing.Size(64, 23);
            this.machineID.TabIndex = 23;
            this.machineID.Text = "Machine ID";
            // 
            // machineTxt
            // 
            this.machineTxt.BackColor = System.Drawing.Color.Salmon;
            this.machineTxt.Location = new System.Drawing.Point(144, 283);
            this.machineTxt.Name = "machineTxt";
            this.machineTxt.Size = new System.Drawing.Size(121, 20);
            this.machineTxt.TabIndex = 24;
            this.MIDToolTip.SetToolTip(this.machineTxt, "Numeric Machine ID");
            this.machineTxt.TextChanged += new System.EventHandler(this.machineTxt_TextChanged);
            // 
            // inhouseLabel
            // 
            this.inhouseLabel.Location = new System.Drawing.Point(141, 34);
            this.inhouseLabel.Name = "inhouseLabel";
            this.inhouseLabel.Size = new System.Drawing.Size(65, 23);
            this.inhouseLabel.TabIndex = 25;
            this.inhouseLabel.Text = "In-House";
            // 
            // outsourcedLabel
            // 
            this.outsourcedLabel.Location = new System.Drawing.Point(229, 34);
            this.outsourcedLabel.Name = "outsourcedLabel";
            this.outsourcedLabel.Size = new System.Drawing.Size(68, 23);
            this.outsourcedLabel.TabIndex = 26;
            this.outsourcedLabel.Text = "Outsourced";
            // 
            // pageTitle
            // 
            this.pageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle.Location = new System.Drawing.Point(12, 20);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(71, 32);
            this.pageTitle.TabIndex = 27;
            this.pageTitle.Text = "Add Part";
            // 
            // outsourcedBtn
            // 
            this.outsourcedBtn.Location = new System.Drawing.Point(212, 30);
            this.outsourcedBtn.Name = "outsourcedBtn";
            this.outsourcedBtn.Size = new System.Drawing.Size(20, 24);
            this.outsourcedBtn.TabIndex = 1;
            this.outsourcedBtn.CheckedChanged += new System.EventHandler(this.outsourcedBtn_CheckedChanged_1);
            // 
            // inhouseBtn
            // 
            this.inhouseBtn.Location = new System.Drawing.Point(120, 29);
            this.inhouseBtn.Name = "inhouseBtn";
            this.inhouseBtn.Size = new System.Drawing.Size(15, 23);
            this.inhouseBtn.TabIndex = 0;
            this.inhouseBtn.CheckedChanged += new System.EventHandler(this.inhouseBtn_CheckedChanged_1);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(224, 320);
            this.save.Margin = new System.Windows.Forms.Padding(2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(56, 30);
            this.save.TabIndex = 29;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(297, 320);
            this.cancel.Margin = new System.Windows.Forms.Padding(2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(56, 30);
            this.cancel.TabIndex = 28;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // compnayNameLabel
            // 
            this.compnayNameLabel.Location = new System.Drawing.Point(51, 283);
            this.compnayNameLabel.Name = "compnayNameLabel";
            this.compnayNameLabel.Size = new System.Drawing.Size(87, 23);
            this.compnayNameLabel.TabIndex = 52;
            this.compnayNameLabel.Text = "Company Name";
            // 
            // companyNameTxt
            // 
            this.companyNameTxt.BackColor = System.Drawing.Color.Salmon;
            this.companyNameTxt.Location = new System.Drawing.Point(144, 283);
            this.companyNameTxt.Name = "companyNameTxt";
            this.companyNameTxt.Size = new System.Drawing.Size(121, 20);
            this.companyNameTxt.TabIndex = 53;
            this.CompanyToolTip.SetToolTip(this.companyNameTxt, "Only Letters Allowed");
            this.companyNameTxt.TextChanged += new System.EventHandler(this.companyNameTxt_TextChanged);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 371);
            this.Controls.Add(this.companyNameTxt);
            this.Controls.Add(this.compnayNameLabel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.pageTitle);
            this.Controls.Add(this.outsourcedLabel);
            this.Controls.Add(this.inhouseLabel);
            this.Controls.Add(this.machineTxt);
            this.Controls.Add(this.machineID);
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
            this.Controls.Add(this.inhouseBtn);
            this.Controls.Add(this.outsourcedBtn);
            this.Name = "AddPart";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox minText;
        private System.Windows.Forms.TextBox maxText;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.TextBox inventoryText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label machineID;
        private System.Windows.Forms.TextBox machineTxt;
        private System.Windows.Forms.Label inhouseLabel;
        private System.Windows.Forms.Label outsourcedLabel;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.RadioButton inhouseBtn;
        private System.Windows.Forms.RadioButton outsourcedBtn;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label compnayNameLabel;
        private System.Windows.Forms.TextBox companyNameTxt;
        private System.Windows.Forms.ToolTip NameToolTip;
        private System.Windows.Forms.ToolTip MinToolTip;
        private System.Windows.Forms.ToolTip MaxToolTip;
        private System.Windows.Forms.ToolTip PriceToolTip;
        private System.Windows.Forms.ToolTip InventoryToolTip;
        private System.Windows.Forms.ToolTip MIDToolTip;
        private System.Windows.Forms.ToolTip CompanyToolTip;
    }
}