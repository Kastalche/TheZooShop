using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheZooShop.States
{
    public class BuyAnimal : IState
    {
        private readonly ZooShopManager shop;

        public BuyAnimal(ZooShopManager shop)
        {
            this.shop = shop;
        }

        public void Start()
        {
            BuyChosenAnimal();
            AskForContinue();
            GoodbyeToCustomer();
        }
        public void Destroy()
        {

        }

        public void BuyChosenAnimal()
        {
            System.Console.WriteLine("You have bought a {0}", shop.choosedAnimal);
            shop.currentCustomer.Money -= shop.choosedAnimal.Price;
            shop.currentCustomer.pets.Add(shop.choosedAnimal);
            shop.choosedAnimal = null;
        }

        private void AskForContinue()
        {
            System.Console.WriteLine("Do you want to continue shopping in the shop? ");
            string input = Console.ReadLine();

            if (input is "Yes" or "yes")
            {

                shop.Transition(State.ChooseAnimal);
            }

            else if (input is "No" or "no")
            {
                shop.choosedAnimal.GreetHuman();
                System.Console.WriteLine(shop.choosedAnimal.picture);
                GoodbyeToCustomer();
                shop.Transition(State.Welcome);
            }

            else
            {
                System.Console.WriteLine("Please answer with Yes or No");
                AskForContinue();
            }

            //yes go to choose animal state, false 
        }

        private void GoodbyeToCustomer()
        {
            System.Console.WriteLine("Thanks For Shopping at our store, have a nice day!");
            shop.Transition(State.Welcome);
        }

    }
}