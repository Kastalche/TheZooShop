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

        }
        public void Destroy()
        {

        }

        public void BuyAnimal()
        {
            shop.currentCustomer.money-shop.chosenAnimal.price;
            currentCustomer.pet.Add(shop.chosenAnimal);
            shop.chosenAnimal=null;
        }

        private void AskForContinue()
        {

            System.Console.WriteLine("Do you want to continue shopping in the shop? ");
            //yes go to choose animal state, false 
        }

        private void GoodbyeToCustomer()
        {
            System.Console.WriteLine("Thanks For Shopping at our store, have a nice day!
            ");
            shop.Transition(nextCustomer);
        }

    }
}