using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism15._02._23
{
    internal class Store
    {
        public Product[] Products = new Product[0];

        public void AddProduct(Product product)
        {
          
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }
       public int DairyProductCountLimit()
       {
            int count = 0;
            foreach(Product p in Products)
            {
                if (p is Dairy)
                {
                    Product product = (Dairy)p;
                    count++;                   
                }
            }
            return count;
       }
        public bool HasProductByNo(int no)
        {
            for(int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No == no)
                    return true;
            }
            return false;
        }
        public void GetDrinkProducts()
        {
            foreach(Product p in Products)
            {
                if(p is Drink)
                {
                    Array.Resize(ref Products, Products.Length + 1);
                    Products[Products.Length - 1] = p;
                }
            }
        }

        public void  GetDairyProducts()
        {
            foreach (Product p in Products)
            {
                if (p is Dairy)
                {
                    Array.Resize(ref Products, Products.Length + 1);
                    Products[Products.Length - 1] = p;
                }
            }
        }



    }
}
