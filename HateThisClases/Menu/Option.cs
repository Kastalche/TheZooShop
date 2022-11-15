using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheZooShop.Interface
{
    public class Option
    {
        public string Name { get; }
        public string Type { get; }
        public int Price { get; }
        public int Age { get; }
        public Func<int> Selected { get; }

        public Option(string name, int price, int age, Func<int> selected)
        {
            Name = name;
            Age = Age;
            Price = price;
            Selected = selected;
        }
    }
}