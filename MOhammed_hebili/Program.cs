using MOhammed_hebili.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOhammed_hebili
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ProductClass> productClass = new List<ProductClass>()
            {
                new ProductClass
                {
                    Brand = "Cola",
                    Name = "Zero",
                    Volume = "150 ml"
                },
                new ProductClass
                {
                    Brand = "Fanta",
                    Name = "Lemon",
                    Volume = "1000 ml"
                },
                new ProductClass
                {
                    Brand = "Soda",
                    Name = "Gas",
                    Volume = "150 ml"
                }
            };

            foreach (var item in productClass)
            {
                Console.WriteLine(item.GetCode());
            }
            Console.ReadKey();
        }
    }
}
