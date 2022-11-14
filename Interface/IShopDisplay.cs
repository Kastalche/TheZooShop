using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheZooShop
{
    public interface IShopDisplay
    {
        void OpenStore(int day);
        void GreetCustomer(string name);

        string AskCustomerForName();
        void ShowAnimals(List<Animal> animals);
        int ChooseAnimal();
        void AlertNotEnoughMoney(int targetPrice, int balance);
        void ThankTheCustomer();
    }
}