using DataBindingExampleCRUD.Common;
using DataBindingExampleCRUD.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using InvoicesService;

namespace DataBindingExampleCRUD
{
    public partial class MainForm : Form
    {
        private ProductViewModel productVM;
        private BindingSource productsSource = new BindingSource();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                productVM = new ProductViewModel();
                setBindings();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setBindings()
        {
            textBoxQuantity.DataBindings.Add("Text", productVM, "DisplayProduct.Quantity", true, DataSourceUpdateMode.OnValidation, "0", "#,##0;(#,##0);0");
            textBoxSku.DataBindings.Add("Text", productVM, "DisplayProduct.Sku", false, DataSourceUpdateMode.OnValidation, "");
            textBoxDescription.DataBindings.Add("Text", productVM, "DisplayProduct.Description");
            textBoxCost.DataBindings.Add("Text", productVM, "DisplayProduct.Cost", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");
            textBoxSellPrice.DataBindings.Add("Text", productVM, "DisplayProduct.SellPrice", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");

            checkBoxTaxable.DataBindings.Add("Checked", productVM, "DisplayProduct.Taxable");
            checkBoxActive.DataBindings.Add("Checked", productVM, "DisplayProduct.Active");

            textBoxNotes.DataBindings.Add("Text", productVM, "DisplayProduct.Notes");

            productsSource.DataSource = productVM.Products;
            listBoxProducts.DataSource = productsSource;
            listBoxProducts.DisplayMember = "Sku";

        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = Math.Max(0, listBoxProducts.SelectedIndex);
            Product1089554 product = productVM.Products[selectedIndex];
            productVM.DisplayProduct = product;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBoxProducts.SelectedIndex;

                Product1089554 product = productVM.DisplayProduct;
                int rowsAffected;

                if (product.ProductId > 0)
                {
                    rowsAffected = ProductValidation.UpdateProduct(product);
                }
                else
                {
                    rowsAffected = ProductValidation.AddProduct(product);
                }

                if (rowsAffected > 0)
                {
                    refreshListBox();
                    listBoxProducts.SelectedIndex = index;
                }
                else
                {
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("No DB changes were made", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ProductValidation.ErrorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonNewProduct_Click(object sender, EventArgs e)
        {
            productVM.DisplayProduct = new Product1089554 { Active = true };
            textBoxQuantity.Select();
            textBoxQuantity.SelectAll();
        }

        
        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product1089554 product = productVM.DisplayProduct;
                ProductValidation.DeleteProduct(product);
                refreshListBox();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshListBox()
        {
            productVM.Products = ProductValidation.GetProducts();
            listBoxProducts.DataSource = productVM.Products;
            listBoxProducts.DisplayMember = "Sku";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InvoicesService.InvoicesWS invWs = new InvoicesService.InvoicesWS();
            string invoices = invWs.ListInvoices();
            Debug.Print(invoices);

        }
    }
}
