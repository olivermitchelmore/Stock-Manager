using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStock
{
    class Customer
    {

        public string Name;
        public float Balance;
        public string Password;
        public List<Item> Items = new();

        public override string ToString()
        {
            return $"Password: {Password} Name: {Name} Balance: {Balance} Items: {Items}";
        }

        public void ChangeBalance(float value, int Amount)
        {
            if (Amount == 0) Amount = 1;

            Balance += value * Amount;
        }

        public bool CheckBalance(float balance, float price, int amount)
        {
            if (balance < price * amount)
            {
                Console.WriteLine("Sorry you do not have enough money");

                return false;
            }
            
            return true;
        }

        public void BuyItem(Item item)
        {
            Items.Add(item);
        }

        public void PrintAllItems()
        {

            Console.WriteLine("Items in basket:");

            for(int i = 0; i < Items.Count; i++)
            {
                Console.WriteLine($"{Items[i].Name}");
            }
        }
    }
}
