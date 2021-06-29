using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStock
{
    class ItemList
    {
        public List<Item> items = new();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void DeleteItem(int itemId)
        {
            items.RemoveAt(itemId);
        }

        public void ChangeStockCount(int itemID, int Value)
        {
            if (Value > 0)
            {
                items[itemID].StockCount -= Value;
            }
            else Console.WriteLine("Please enter a number above 0");
        }

        public void PrintAllItems()
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i}) {items[i]}");
            }
        }
    }
}
