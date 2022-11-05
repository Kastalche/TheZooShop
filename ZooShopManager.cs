using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheZooShop
{
    public class ZooShopManager
    {
        public int freePlacesForAnimals = 10;
        Random random = new Random();
        public List<Animal> animals = new List<Animal>();

        public int profit;

        public void GreetCustomer()
        {
            System.Console.WriteLine("Right now in the shop we have {0} animals.", animals.Count);
        }

        public void ChooseAnimal()
        {

        }

        public void BuyAnimal()
        {

        }

        //     public void AddAnimalsToShop()
        //     {
        //         int numberOfAnimals = random.Next(1, freePlacesForAnimals);

        //         for (int i = 0; i < numberOfAnimals; i++)
        //         {
        //             animals.Add(CreateRandomAnimal);
        //         }
        //     }

        //     private Animal CreateRandomAnimal()
        //     {
        //         int typeAnimal = random.Next(1, 4);
        //         int randomAge = random.Next(1, 15);
        //         int randomPrice = random.Next(1, 500);

        //         switch (typeAnimal)
        //         {
        //             case 1:
        //                 return new Cat(randomAge, CreateRandomName(), randomPrice);
        //             case 2:
        //                 return new Dog(randomAge, CreateRandomName(), randomPrice);
        //             case 3:
        //                 return new Racoon(randomAge, CreateRandomName(), randomPrice);
        //         }
        //     }

        //     private string CreateRandomName()
        //     {
        //         int randomName = random.Next(1, 11);
        //         AnimalNames[randomName].ToString();
        //     }


        // }
    }
}