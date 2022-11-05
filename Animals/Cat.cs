using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheZooShop
{
    public class Cat : Animal
    {
        public Cat(int age, string name, int price, int happiness) : base(age, name, price, happiness)
        {
            picture = new string[] {
                @" ^. .^ ",
                @"  =^= ",
                @"   ~  "
            };
        }

        public override void GreetHuman()
        {
            System.Console.WriteLine("Meow! Meow!");
        }
    }
}