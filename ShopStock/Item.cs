using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStock
{
    class Item
    {
        public string Name;
        public float Price;
        public int StockCount;

        public override string ToString()
        {
            return $"Name: {Name} Price: {Price} Stock Count: {StockCount}";
        }
    }
}
