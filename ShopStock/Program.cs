using System;

namespace ShopStock
{
    class Program
    {

        static void Main(string[] args)
        {
            bool run = true;

            ItemList itemList = new();

            CustomerList customerList = new();

            int customerLogin = 0;

            Functions functions = new();

            Item item = new();

            bool loggedin = false;

            while (run)
            {

                if (loggedin)
                {
                    Console.WriteLine("\nWecome back," + customerList.customers[customerLogin].Name);
                }
                Console.WriteLine("\n0) Exit");
                Console.WriteLine("1) Add item");
                Console.WriteLine("2) Delete item");
                Console.WriteLine("3) List items");
                Console.WriteLine("4) Add customer");
                Console.WriteLine("5) Remove customer");
                Console.WriteLine("6) List customers");


                if (loggedin)
                {
                    Console.WriteLine("7) Login as new customer");
                    Console.WriteLine("8) Buy item");
                    Console.WriteLine("9) Print all items\n\n");
                }

                else Console.WriteLine("7) Login as customer\n\n");

                string command = Console.ReadLine();

                if (command == "1")
                {
                    //Item item = new();

                    Console.WriteLine("\nenter name");

                    item.Name = Console.ReadLine();

                    Console.WriteLine("Enter price");

                    item.Price = float.Parse(Console.ReadLine());

                    Console.WriteLine("How much is left?");

                    item.StockCount = int.Parse(Console.ReadLine());

                    itemList.AddItem(item);

                    Console.WriteLine(item.ToString());
                }

                else if (command == "2")
                {
                    Console.WriteLine("\nWhich item are you deleting?");

                    itemList.PrintAllItems();

                    itemList.DeleteItem(int.Parse(Console.ReadLine()));

                    Console.WriteLine("Item delted");
                }

                else if (command == "3")
                {
                    itemList.PrintAllItems();
                }

                else if (command == "4")
                {
                    Customer customer = new();

                    Console.WriteLine("\nenter name");

                    customer.Name = Console.ReadLine();

                    Console.WriteLine("enter password");

                    customer.Password = Console.ReadLine();

                    Console.WriteLine("enter balance");

                    customer.Balance = float.Parse(Console.ReadLine());

                    customerList.AddCustomer(customer);

                    Console.WriteLine("Customer added");
                }

                else if (command == "5")
                {
                    customerList.PrintAllCustomers();

                    Console.WriteLine("which customer would you like to remove");

                    customerList.DeleteCustomer(int.Parse(Console.ReadLine()));

                    Console.WriteLine("Customer removed");
                }

                else if (command == "6")
                {
                    customerList.PrintAllCustomers();
                }

                else if (command == "7")
                {
                    Console.WriteLine("Which customer would you like to login as?\n");
                    customerList.PrintAllCustomers();

                    customerLogin = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter customer password");
                    string customerPassword = Console.ReadLine();


                    if (customerList.CheckPassword(customerLogin, customerPassword))
                    {
                        Console.WriteLine("Success, logged in");
                        loggedin = true;
                    }

                    else Console.WriteLine("Error please enter correct password");
                }

                else if (command == "8")
                {
                    Console.WriteLine("What would you like to buy?");

                    itemList.PrintAllItems();

                    var ItemToBuy = int.Parse(Console.ReadLine());

                    Console.WriteLine("How much would you like to buy?");

                    int Amount = int.Parse(Console.ReadLine());

                    if (customerList.customers[customerLogin].CheckBalance(customerList.customers[customerLogin].Balance, itemList.items[ItemToBuy].Price, Amount))
                    {
                        customerList.customers[customerLogin].BuyItem(itemList.items[ItemToBuy]);

                        customerList.customers[customerLogin].ChangeBalance(-itemList.items[ItemToBuy].Price, Amount);

                        itemList.ChangeStockCount(ItemToBuy, Amount);

                        Console.WriteLine("You bought " + itemList.items[ItemToBuy].Name);

                        customerList.customers[customerLogin].PrintAllItems();
                    }

                    else Console.WriteLine("Sorry you do not have enough money");
                }

                else if (command == "9")
                {
                    customerList.customers[customerLogin].PrintAllItems();

                }

                else if (command == "0")
                {
                    run = false;
                }



                else
                {
                    Console.WriteLine("select valid option");
                }
            }
        }
    }
}
