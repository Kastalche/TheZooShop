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
        }

        public void Destroy()
        {
            //open store;)
            throw new NotImplementedException();
        }

        public void AddAnimalsToShop()
        {
            int numberOfAnimals = random.Next(1, shop.freePlacesForAnimals);

            for (int i = 0; i < numberOfAnimals; i++)
            {
                shop.animals.Add(CreateRandomAnimal());
                shop.freePlacesForAnimals--;
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
            int randomIndex = random.Next(1, 11);
            var randomName = (AnimalNames)randomIndex;
            return randomName.ToString();
            // return AnimalNames.[randomName].ToString();
        }
    }
}