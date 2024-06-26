﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private decimal price;
        private int quantity;
        private decimal totalPayment;
        private decimal totalPaymentInclDel;
        private decimal totalPaymentInclDelWrap;
        private decimal totalPaymentInclTax;
        private decimal delivery;
        private decimal wrapping;
        private decimal gst;

        private decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }
        public decimal TotalPaymentInclDel
        {
            get { return totalPaymentInclDel; }
            set { totalPaymentInclDel = value; }
        }
        public decimal TotalPaymentInclDelWrap
        {
            get { return totalPaymentInclDelWrap; }
            set { totalPaymentInclDelWrap = value; }
        }
        public decimal TotalPaymentInclTax
        {
            get { return totalPaymentInclTax; }
            set { totalPaymentInclTax = value; }
        }
        private decimal Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }


        private decimal Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private decimal GST
        {
            get { return gst; }
            set { gst = value; }
        }

        //Constructor for Product
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
        }
        public void calTotalPaymentInclDel()
        {
            TotalPaymentInclDel = (Price * Quantity)+25;
        }
        public void calTotalPaymentInclDelWrap()
        {
            TotalPaymentInclDelWrap = (Price * Quantity) + 25 + 5;
        }
        public void calTotalPaymentInclTax()
        {
            TotalPaymentInclTax = ((Price * Quantity) + 25 + 5)*1.1m;
        }
    }
}
