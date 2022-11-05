using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheZooShop
{
    public class Dog : Animal
    {
        public Dog(int age, string name, int price, int happiness) : base(age, name, price, happiness)
        {
            picture = new string[] {
                @"<*^)   ",
                @"   \_____/",
                @"  _/   _\ "
            };
        }

        public override void GreetHuman()
        {
            System.Console.WriteLine("Djaf! Djaf!");
        }
    }
}