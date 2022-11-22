using System;

namespace TheZooShop
{
    public abstract class Animal
    {
        public int Age { get; private set; }
        public string Name { get; private set; }
        public int Price { get; private set; }
        public int Happiness { get; private set; }
        public string[] picture;

        public bool IsHappy;

        public Animal(int age, string name, int price, int happiness)
        {
            this.Age = age;
            this.Name = name;
            this.Price = price;
            this.Happiness = happiness;
        }

        public void ShowAnimalFace()
        {
            for (int i = 0; i < picture.Length; i++)
            {
                Console.Write(picture[i]);
            }
        }
        public abstract void GreetHuman();
        public override string ToString()
        {
            var str = base.ToString();
            str.Remove(0, 11);
            return str;
        }
    }
}