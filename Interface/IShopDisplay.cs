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

        void ShowAnimals(List<Animal> animals);

        void AlertNotEnoughMoney(int targetPrice, int balance);

        void ThankTheCustomer();
        

        int ChooseAnimal();

        string AskCustomerForName();
    }
}