using System;
using System.Collections.Generic;

namespace MyMart
{
    class Product
    {
        //private int categoryId,productId;
        //private string productName, productDescription, brand,manufacturedBy,createdOn,createdBy;
        //private double mrp, discount, productourprice;      

        private int productId;
        private string pName, pCode, pDescrp,brand, categoryId;
        private int mrp, discount, ourprice;

        List<Product> Products = new List<Product>();

        public Product()
        {
            Product product = new Product();
            product.categoryId = "ANDR001";
            product.productId = 11;
            product.pCode = "SMGM31";
            product.pName = "Samsung Galaxy M31";
            product.pDescrp = "Samsung Galaxy M31 with Quad Camera";
            product.brand = "Samsung Technologies";
            product.mrp = 17000;
            product.discount = 5;
            product.ourprice = 16150;
            Products.Add(product);

            Product product2 = new Product();
            product2.categoryId = "ANDR002";
            product2.productId = 12;
            product2.pCode = "SMGS20";
            product2.pName = "Samsung Galaxy S20";
            product2.pDescrp = "Samsung Galaxy S20 with Cinematic Camera";
            product2.brand = "Samsung Technologies";
            product2.mrp = 80000;
            product2.discount = 10;
            product2.ourprice = 72000;
            Products.Add(product2);

            Product product3 = new Product();
            product3.categoryId = "MONI001";
            product3.productId = 21;
            product3.pCode = "P021";
            product3.pName = "Samsung 21.5inch Monitor ";
            product3.pDescrp = "Samsung 21.5inch Monitor With Bezeless Border";
            product3.brand = "Samsung Technologies";
            product3.mrp = 7620;
            product3.discount = 2;
            product3.ourprice = 7468;
            Products.Add(product3);

            Product product4 = new Product();
            product4.categoryId = "MONI002";
            product4.productId = 22;
            product4.pCode = "P022";
            product4.pName = "HP 19.5inch Monitor";
            product4.pDescrp = "HP 19.5inch Monitor With Night Light Vision Mode";
            product4.brand = "HP Technologies";
            product4.mrp = 7000;
            product4.discount = 5;
            product4.ourprice = 6650;
            Products.Add(product4);

            Product product5 = new Product();
            product5.categoryId = "TV001";
            product5.productId = 31;
            product5.pCode = "P031";
            product5.pName = "Samsung 80 cm (32 inches) Wondertainment (Black)";
            product5.pDescrp = "Samsung 80 cm (32 inches) Wondertainment Series HD Ready LED Smart";
            product5.brand = "Samsung Technologies";
            product5.mrp = 20900;
            product5.discount = 5;
            product5.ourprice = 15999;
            Products.Add(product5);

            Product product6 = new Product();
            product6.categoryId = "TV002";
            product6.productId = 32;
            product6.pCode = "P032";
            product6.pName = "Sony Bravia 101.6 cm (40 inches) (Titan Gray)";
            product6.pDescrp = "Sony Bravia 101.6 cm (40 inches) Full HD LED TV";
            product6.brand = "Sony Technologies";
            product6.mrp = 20900;
            product6.discount = 5;
            product6.ourprice = 15999;
            Products.Add(product6);

            Product product7 = new Product();
            product7.categoryId = "WM001";
            product7.productId = 41;
            product7.pCode = "P041";
            product7.pName = "Samsung 6.2 kg Fully-Automatic (Imperial Silver)";
            product7.pDescrp = "Samsung 6.2 kg Fully-Automatic Top load Washing Machine";
            product7.brand = "Samsung Technologies";
            product7.mrp = 15900;
            product7.discount = 16;
            product7.ourprice = 13290;
            Products.Add(product7);

            Product product8 = new Product();
            product8.categoryId = "WM002";
            product8.productId = 42;
            product8.pCode = "P042";
            product8.pName = "Whirlpool 7 Kg 5 Star Semi-Automatic (Grey Dazzle)";
            product8.pDescrp = "Whirlpool 7 Kg 5 Star Semi-Automatic Top Loading Washing Machine";
            product8.brand = "Whirlpool";
            product8.mrp = 11250;
            product8.discount = 17;
            product8.ourprice = 9290;
            Products.Add(product8);

            Product product9 = new Product();
            product9.categoryId = "FR001";
            product9.productId = 51;
            product9.pCode = "P051";
            product9.pName = "Samsung 192L 4 Star Inverter (Blooming Saffron Red)";
            product9.pDescrp = "Samsung 192 L 4 Star Inverter Direct Cool Single Door Refrigerator";
            product9.brand = "Samsung Technologies";
            product9.mrp = 21990;
            product9.discount = 27;
            product9.ourprice = 15990;
            Products.Add(product9);

            Product product10 = new Product();
            product10.categoryId = "FR002";
            product10.productId = 52;
            product10.pCode = "P052";
            product10.pName = "Haier 195L 4 Star (Dazzle Steel)";
            product10.pDescrp = "Haier 195 L 4 Star Direct-Cool Single-Door Refrigerator";
            product10.brand = "Haier Innovation";
            product10.mrp = 18400;
            product10.discount = 30;
            product10.ourprice = 12790;
            Products.Add(product10);
        }
        public Product FindProduct(string code)
        {
            foreach (Product p in Products)
            {
                if (p.pCode == code)
                    return p;
            }
            return null;
        }

        public Product FindProduct(int productID)
        {
            foreach (Product p in Products)
            {
                if (p.productId == productID)
                    return p;
            }
            return null;
        }
        //Using Indexers
        public Product this[string code] 
        {
            get
            {
                foreach (Product p in Products)
                {
                    if (p.pCode == code)
                        return p;
                }
                return null;
            }
        }
        public Product this[int productID]
        {
            get
            {
                foreach (Product p in Products)
                {
                    if (p.productId == productID)
                        return p;
                }
                return null;
            }
        }
    }
}
