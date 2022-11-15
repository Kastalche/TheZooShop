using System.Data;
using System.Net.Http;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheZooShop.States
{
    public class Init : IState
    {
        private readonly ZooShopManager shop;

        Random random = new Random();

        public Init(ZooShopManager shop)
        {
            this.shop = shop;
        }

        public void Start()
        {
            AddAnimalsToShop();
            ShowAnimals();
            AddMoreAnimals();
            OpenStore();
        }

        public void Destroy()
        {

        }

        private void ShowAnimals()
        {
            System.Console.WriteLine("Right now in the shop there are {0} animals.", shop.animals.Count);
            foreach (var animal in shop.animals)
            {
                System.Console.WriteLine(animal);
            }
        }

        private void AddAnimalsToShop()
        {
            int numberOfAnimals = random.Next(1, shop.freePlacesForAnimals);

            for (int i = 0; i < numberOfAnimals; i++)
            {
                shop.animals.Add(CreateRandomAnimal());
                shop.freePlacesForAnimals--;
            }
        }

        private void OpenStore()
        {
            System.Console.WriteLine("Is the shop ready to be open?");
            string input = Console.ReadLine();

            if (input is "Yes" or "yes")
            {
                System.Console.WriteLine("The Store is Open");
                shop.Transition(State.Welcome);
            }

            else if (input is "No" or "no")
            {
                AddMoreAnimals();
            }

            else
            {
                System.Console.WriteLine("Please answer with Yes or No");
                OpenStore();
            }
        }

        private void AddMoreAnimals()
        {
            System.Console.WriteLine("Do you want to Add More animals?");
            string input = Console.ReadLine();
            if (input is "Yes" or "yes")
            {
                shop.Transition(State.Init);
            }
            else if ((input is "No" or "no"))
            {
                OpenStore();
            }
            else
            {
                System.Console.WriteLine("Please answer with Yes or No");
                AddMoreAnimals();
            }
        }


        private Animal CreateRandomAnimal()
        {
            int typeAnimal = random.Next(1, 4);
            int randomAge = random.Next(1, 15);
            int randomPrice = random.Next(1, 500);
            int randomHappiness = random.Next(1, 100);

            switch (typeAnimal)
            {
                case 1:
                    return new Cat(randomAge, CreateRandomName(), randomPrice, randomHappiness);
                case 2:
                    return new Dog(randomAge, CreateRandomName(), randomPrice, randomHappiness);
                case 3:
                    return new Racoon(randomAge, CreateRandomName(), randomPrice, randomHappiness);
                default:
                    return new Cat(randomAge, CreateRandomName(), randomPrice, randomHappiness);
            }
        }

        private string CreateRandomName()
        {
            // int randomIndex = random.Next(1, AnimalNames.Length + 1);
            // var randomName = (AnimalNames)randomIndex;
            // return randomName.ToString();
            // return AnimalNames.[randomName].ToString();
        }
    }
}
