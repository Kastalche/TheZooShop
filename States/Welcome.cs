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
            NewCustomer();
            display.GreetCustomer();
            shop.Transition(State.ChooseAnimal);

        }
        public void Destroy()
        {
        }

        public void NewCustomer()
        {
            string name = display.AskCustomerForName();
            int money = AskForCustomerMoney();

            Customer newCustomer = new Customer(name, money);
            shop.currentCustomer = newCustomer;
            // TODO: SearchOption.currentCustomer = newCustomer;
        }
    }
}