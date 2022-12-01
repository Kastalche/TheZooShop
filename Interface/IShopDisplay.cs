using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheZooShop
{
    public interface IShopDisplay
    {
        string AskCustomerForName();
        int AskCustomerForMoney();
        bool AskCustomer();

        void AlertNotEnoughMoney(int targetPrice, int balance);
        void ThankTheCustomer();
        void GreetCustomer(string name);
        void ShowAnimals(List<Animal> animals);
        void AskForContinue();
        void GoodbyeToCustomer();
    }
}