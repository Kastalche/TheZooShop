using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheZooShop
{
    public class Racoon : Animal
    {
        public Racoon(int age, string name, int price, int happiness) : base(age, name, price, happiness)
        {
            picture = new string[] {
                @" o   o ",
                @"( *.* )",
                @"(') (')",
                @"(  O  ) ",
                @"(') (')"
            };
        }

        public override void GreetHuman()
        {
            System.Console.WriteLine("Mara ba, simson!");
        }
    }
}