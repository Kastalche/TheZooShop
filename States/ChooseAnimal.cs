using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheZooShop.Interface;

namespace TheZooShop.States
{
    public class ChooseAnimal : IState
    {
        private readonly ZooShopManager shop;

        public ChooseAnimal(ZooShopManager shop)
        {
            this.shop = shop;
        }
        public void Start()
        {
            System.Console.WriteLine("These are the animals in our store. Feel free to choose wiych one u like most. When u are ready press enter the X. <3");
            Thread.Sleep(5000);
            SelectMenu selectMenu = new SelectMenu(shop);
            selectMenu.ShowMenu();
            BuyAnimal();


            // shop.display.ShowAnimals(shop.animals);
            // int index = shop.display.ChooseAnimal();
            // Animal chosenAnimal = shop.animals[index];
        }
        public void BuyAnimal()
        {
            if (shop.choosedAnimal != null)
            {
                if (CheckForEnoughMoney(shop.choosedAnimal, shop.currentCustomer))
                {
                    shop.Transition(State.BuyAnimal);
                }
                else
                {
                    System.Console.WriteLine("Not Enough Money");
                    shop.choosedAnimal = null;
                    shop.Transition(State.BuyAnimal);
                }
            }
            else
            {
                shop.Transition(State.ChooseAnimal);
            }
        }
        private bool CheckForEnoughMoney(Animal animal, Customer customer)
        {
            if (animal.Price > customer.Money)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public void Destroy()
        {

        }
        //choosvash animal, ako i dostatychno pari kupuvash trygvash
        //eeventurallu buy and choose animal can be merged 
        //you can tip the seler if u have enough money kupuvash i sledva nextCustomer() otnovo na welcome
    }
}