using System.IO;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheZooShop.States
{
    public class Welcome : IState
    {// u welcome the customer
        //enter the store creates welcome state, say whats yout name and how muc hmoney you have;)
        private readonly ZooShopManager shop;

        public Welcome(ZooShopManager shop)
        {
            this.shop = shop;
        }

        public void Start()
        {
            GreetCustomer();
        }
        public void Destroy()
        {
            throw new NotImplementedException();
        }
        public void NewCustomer()
        {
            System.Console.WriteLine("You have enter the shop! What's your name?");
            string name = Console.ReadLine();

            System.Console.WriteLine("How much money you have decided to spend for a pet?");
            int money = int.Parse(Console.ReadLine());

            Customer newCustomer = new Customer(name, money);
            // TODO: SearchOption.currentCustomer = newCustomer;
        }
        // GreetCustomer();
        // TakeCustomerName();
        // ShowAnimals();
        // ChooseAnimal();

        // NextCustomer();
        // //buy animal
        // InsertMoney();
        // CheckIfYoucnaBuyit() //-> NotEnoughMoney(); - throw special exception here.
        // BuyAnimal();
        // TipTheSeller();
        // NextCustomer();
        // PlaywithAnimal();
        // FeedAnimal();
        // ExitShop()/EnterShopAgain();

        public void GreetCustomer()
        {
            System.Console.WriteLine("Okey then, {0}! Welcome to our zoo shop called Zooland. We are the first Console Aplication Shop in Varna! Nice to meet you.", shop.currentCustomer.Name);
        }
        //

    }
}