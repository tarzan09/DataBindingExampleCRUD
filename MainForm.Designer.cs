namespace DataBindingExampleCRUD
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonNewProduct = new System.Windows.Forms.Button();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxSku = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.checkBoxTaxable = new System.Windows.Forms.CheckBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSellPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.IntegralHeight = false;
            this.listBoxProducts.Location = new System.Drawing.Point(0, 0);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(128, 470);
            this.listBoxProducts.TabIndex = 1;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxProducts_SelectedIndexChanged);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(259, 413);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(85, 23);
            this.buttonDeleteProduct.TabIndex = 17;
            this.buttonDeleteProduct.TabStop = false;
            this.buttonDeleteProduct.Text = "D&elete";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonNewProduct
            // 
            this.buttonNewProduct.Location = new System.Drawing.Point(168, 413);
            this.buttonNewProduct.Name = "buttonNewProduct";
            this.buttonNewProduct.Size = new System.Drawing.Size(85, 23);
            this.buttonNewProduct.TabIndex = 16;
            this.buttonNewProduct.TabStop = false;
            this.buttonNewProduct.Text = "&New Product";
            this.buttonNewProduct.UseVisualStyleBackColor = true;
            this.buttonNewProduct.Click += new System.EventHandler(this.buttonNewProduct_Click);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(234, 17);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 3;
            this.textBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "&Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "&Cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "&Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "S&KU:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&List";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(350, 413);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(85, 23);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.TabStop = false;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxSku
            // 
            this.textBoxSku.Location = new System.Drawing.Point(234, 52);
            this.textBoxSku.Name = "textBoxSku";
            this.textBoxSku.Size = new System.Drawing.Size(100, 20);
            this.textBoxSku.TabIndex = 5;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(234, 87);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(201, 20);
            this.textBoxDescription.TabIndex = 7;
            // 
            // checkBoxTaxable
            // 
            this.checkBoxTaxable.AutoSize = true;
            this.checkBoxTaxable.Location = new System.Drawing.Point(234, 203);
            this.checkBoxTaxable.Name = "checkBoxTaxable";
            this.checkBoxTaxable.Size = new System.Drawing.Size(64, 17);
            this.checkBoxTaxable.TabIndex = 12;
            this.checkBoxTaxable.Text = "&Taxable";
            this.checkBoxTaxable.UseVisualStyleBackColor = true;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(234, 122);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost.TabIndex = 9;
            this.textBoxCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Location = new System.Drawing.Point(332, 203);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(56, 17);
            this.checkBoxActive.TabIndex = 13;
            this.checkBoxActive.Text = "&Active";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sell &Price:";
            // 
            // textBoxSellPrice
            // 
            this.textBoxSellPrice.Location = new System.Drawing.Point(234, 157);
            this.textBoxSellPrice.Name = "textBoxSellPrice";
            this.textBoxSellPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxSellPrice.TabIndex = 11;
            this.textBoxSellPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "N&otes:";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.AcceptsReturn = true;
            this.textBoxNotes.AcceptsTab = true;
            this.textBoxNotes.Location = new System.Drawing.Point(168, 249);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNotes.Size = new System.Drawing.Size(267, 144);
            this.textBoxNotes.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(474, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSellPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.buttonNewProduct);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSku);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.checkBoxTaxable);
            this.Controls.Add(this.textBoxCost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataBinding Example CRUD";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonNewProduct;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxSku;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.CheckBox checkBoxTaxable;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSellPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Button button1;
    }
}

