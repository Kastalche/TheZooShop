using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheZooShop.Interface;

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
            OnAnimalSelected += SelectMenu.SelectedAnimal;
            BuyTheAnimal();
            PlayWithAnimal();
            shop.display.AskForContinue();
            shop.display.GoodbyeToCustomer();
            shop.Transition(State.Welcome);
        }
        public void Destroy()
        {
            OnAnimalSelected -= SelectMenu.SelectedAnimal;
        }
        void OnAnimalSelected()
        {

        }
        public void BuyTheAnimal()
        {
            shop.currentCustomer.Money = shop.currentCustomer.Money - shop.choosedAnimal.Price;
            shop.currentCustomer.pets.Add(shop.choosedAnimal);
            shop.choosedAnimal = null;
        }

        public void PlayWithAnimal()
        {
            //TODO:
        }
    }
}