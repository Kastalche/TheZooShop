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

            throw new NotImplementedException();
        }
        public void Destroy()
        {
            throw new NotImplementedException();
        }
        /NextCustomer();
        OpenStore();
        GreetCustomer();
        TakeCustomerName();
        ShowAnimals();
        //buy animal
        ChooseAnimal();
        InsertMoney();
        CheckIfYoucnaBuyit() //-> NotEnoughMoney(); - throw special exception here.
        BuyAnimal();
        TipTheSeller();
        NextCustomer();
        PlaywithAnimal();
        FeedAnimal();
        ExitShop()/EnterShopAgain();
        //

    }
}