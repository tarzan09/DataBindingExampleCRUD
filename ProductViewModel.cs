using DataBindingExampleCRUD.Business;
using DataBindingExampleCRUD.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingExampleCRUD
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ProductViewModel()
        {
            Products = ProductValidation.GetProducts();
            DisplayProduct = new Product1089554();
        }

        private Product1089554 displayProduct;
        public Product1089554 DisplayProduct
        {
            get { return displayProduct; }
            set
            {
                displayProduct = new Product1089554
                {
                    Quantity = value.Quantity,
                    ProductId = value.ProductId,
                    Sku = value.Sku,
                    Description = value.Description,
                    Cost = value.Cost,
                    SellPrice = value.SellPrice,
                    Taxable = value.Taxable,
                    Active = value.Active,
                    Notes = value.Notes
                };
                OnPropertyChanged();
            }
        }
        public ProductList Products { get; set; }
    }
}
