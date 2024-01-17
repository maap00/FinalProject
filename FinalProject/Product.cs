using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Product 
    {


        private int _idProduct;
        private string _descriptionProduct;
        private double _costProduct;
        private double _priceProduct;
        private double _stock;
        private string _idUser;


        public Product()
        {
            this._idProduct = 0;
            this._descriptionProduct = string.Empty;
            this._costProduct = 0;
            this._priceProduct = 0;
            this._stock = 0;
            this._idUser = string.Empty;
        }
        public Product(int idProduct, string descriptionProduct, double costProduct, double priceProduct, double stock, string idUser)
        {
            this._idProduct = idProduct;
            this._descriptionProduct = descriptionProduct;
            this._costProduct = costProduct;
            this._priceProduct = priceProduct;
            this._stock = stock;
            this._idUser = idUser;
        }

        public void showDates()
        {
            Console.WriteLine(this._idProduct.ToString());
            Console.WriteLine(this._descriptionProduct.ToString());
            Console.WriteLine(this._costProduct.ToString());
            Console.WriteLine(this._priceProduct.ToString());
            Console.WriteLine(this._stock.ToString());
            Console.WriteLine(this._idUser.ToString());

        }

        public int idProduct
        {
            get
            {
                return this._idProduct;
            }
            set
            {
                this._idProduct = value;
            }
        }
        public string descriptionProduct
        {
            get
            {
                return this._descriptionProduct;
            }
            set
            {
                this._descriptionProduct = value;
            }
        }

        public double costProduct
        {
            get
            {
                return  this._costProduct;

            }
            set
            {
                this._costProduct = value;
            }
        }

        public double priceProduct
        {
            get
            {
                return this._priceProduct;

            }
            set
            {
                this._priceProduct = value;
            }
        }
        public double stock
        {
            get
            {
                return this._stock;

            }
            set
            {
                this._stock = value;
            }
        }

        public string idUser
        {
            get
            {
                return this._idUser;

            }
            set
            {
                this._idUser = value;
            }
        }
    }
}
