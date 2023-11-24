using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Inventory
{
    internal class Product
    {
        private string productName, productCateg, productMfgDate, productExpDate, productDesc;
        private string productPrice;
        private int productQuantity;

        public string ProductName { 
            get {
                return productName;
            } 
            set {
                if (!Regex.Match(value, @"^[a-zA-Z]+$").Success)
                {
                    throw new ProductFormatException();
                } else
                {
                    productName = value;
                }
            }
            }
        public string ProductCateg
        {
            get
            {
                return productCateg;
            }
            set
            {
                if (Regex.Match(value, @"^[a-zA-Z]+$").Success)
                {
                    productCateg = value;
                }
                else
                {
                    throw new ProductFormatException();
                }
            }
        }
        public string ProductMfgDate
        {
            get
            {
                return productMfgDate;
            }
            set
            {
                productMfgDate = value;
            }
        }
        public string ProductExpDate
        {
            get
            {
                return productExpDate;
            }
            set
            {
                productExpDate = value;
            }
        }
        public string ProductPrice
        {
            get
            {
                return productPrice;
            }
            set
            {
                if (Regex.Match(value, @"[0-9][$₱]").Success)
                {
                    productPrice = value;
                }
                else
                {
                    throw new ProductFormatException();
                }
            }
        }
        public int ProductQuantity
        {
            get
            {
                return productQuantity;
            }
            set
            {
                productQuantity = value;
            }
        }
        public string ProductDesc
        {
            get
            {
                return productDesc;
            }
            set
            {
                productDesc = value;
            }
        }
        public Product(string productName, string productDesc, string productMfgDate, string productExpDate, string productCateg, int quantity, string productPrice)
        {
            this.ProductName = productName;
            this.ProductDesc = productDesc;
            this.ProductMfgDate = productMfgDate;
            this.ProductExpDate = productExpDate;
            this.ProductQuantity = quantity;
            this.ProductPrice = productPrice;
            this.ProductCateg = productCateg;
        }
    }

    public class ProductFormatException : Exception
    {
        public ProductFormatException() {
            throw this;
        }
    }
}
