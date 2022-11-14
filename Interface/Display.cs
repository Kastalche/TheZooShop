using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheZooShop
{
    public class Display : IShopDisplay
    {
        public void AlertNotEnoughMoney(int targetPrice, int balance)
        {
            throw new NotImplementedException();
        }

        public string AskCustomerForName()
        {
            System.Console.WriteLine("Hello, customer! What's you name?");
            string name = Console.ReadLine();
            return name;
        }

        public int ChooseAnimal()
        {
            System.Console.WriteLine("Enter the number of the Animal you want: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        public void GreetCustomer(string name)
        {
            System.Console.WriteLine("Hello, {0}! Welcome to The Zoo Shop!", name);
        }

        public void OpenStore(int day)
        {
            System.Console.WriteLine("This is the {0} day this shop is working! The shop is open! ", day);
        }

        public void ShowAnimals(List<Animal> animals)
        {
            throw new NotImplementedException();
        }

        public void ThankTheCustomer()
        {
            System.Console.WriteLine("Thank you for your purchase! Take good care of you pet!");
        }
    }
}