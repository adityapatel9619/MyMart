using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMart
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            var pd = product.FindProduct(11);
            Console.WriteLine();





            Console.ReadKey();
        }
    }
}
