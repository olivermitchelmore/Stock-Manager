using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStock
{
    class Functions
    {

        public void DisplayMenu(bool loggedin)
        {
            Console.WriteLine("\n\n0) Exit");
            Console.WriteLine("1) Add item");
            Console.WriteLine("2) Delete item");
            Console.WriteLine("3) List items");
            Console.WriteLine("4) Add customer");
            Console.WriteLine("5) Remove customer");
            Console.WriteLine("6) List customers");

            if (loggedin)
            {
                Console.WriteLine("7) Login as new customer");
                Console.WriteLine("8) Buy item\n\n");
            }

            else Console.WriteLine("7) Login as customer\n\n");

        }

    }
}
