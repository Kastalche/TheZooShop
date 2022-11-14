using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheZooShop
{
    public class ZooShopManager
    {
        private int freePlacesForAnimals{get;private set;}

        private int profit;
        public List<Animal> animals; 

        public States currentState;
        public Customer currentCustomer;

        Random random = new Random();

        public ZooShopManager(int freePlacesForAnimals)
        {
            this.freePlacesForAnimals=freePlacesForAnimals;

            animals= new List<Animal>();
            profit=0;

            Transition(Init);
        }

         public void Transition(States newState)
    {
        currentState?.Destroy();

        switch (newState)
        {
            case States.Init:
                currentState = new Init(this);
                break;

            case States.Welcome:
                currentState = new Welcome(this);
                break;

            case States.ChooseAnimal:
                currentState = new ChooseAnimal(this);
                break;

            case States.BuyAnimal:
                currentState = new BuyAnimal(this);
                break;

            default:
                throw new System.Exception($"Unknown State: {newState}");
        }

        currentState.Start();
    }

    // public void ShowShopProfit()
    // {
    //     System.Console.WriteLine();
    // }

    }
}