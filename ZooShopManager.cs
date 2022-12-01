using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheZooShop.States;

namespace TheZooShop
{
    public class ZooShopManager
    {
        Random random = new Random();

        public readonly Display display;

        public int freePlacesForAnimals { get; set; }
        private int profit;
        public List<Animal> animals;


        #region DataHolders   //TODO: Exract in new class
        public IState currentState;
        public Customer currentCustomer;
        public Animal choosedAnimal;

        #endregion


        public ZooShopManager(int freePlacesForAnimals)
        {
            this.freePlacesForAnimals = freePlacesForAnimals;

            animals = new List<Animal>();
            profit = 0;
            display = new Display();

            Transition(State.Init);
        }

        public void Transition(State newState)
        {
            currentState?.Destroy();

            switch (newState)
            {
                case State.Init:
                    currentState = new Init(this);
                    break;

                case State.Welcome:
                    currentState = new Welcome(this);
                    break;

                case State.ChooseAnimal:
                    currentState = new ChooseAnimal(this);
                    break;

                case State.BuyAnimal:
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