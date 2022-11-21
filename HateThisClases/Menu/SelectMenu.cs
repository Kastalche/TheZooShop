using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheZooShop.Interface;

namespace TheZooShop.Interface
{
    public class SelectMenu
    {
        public List<Option> options;
        private readonly ZooShopManager shop;
        public int newIndex = 0;
        public SelectMenu(ZooShopManager sh)
        {
            this.shop = sh;
            options = new List<Option>();
        }
        public void ShowMenu()
        {

            for (int i = 0; i < shop.animals.Count; i++)
            {
                var animal = shop.animals[i];
                options.Add(new Option(animal.Name, animal.Age, animal.Price, () => SelectedAnimal(i)));
            }
            // Create options that you want your menu to have
            // options = new List<Option>
            // {
            //     new Option("Cat", () => SelectedAnimal()),
            //     new Option("Dog", () =>  SelectedAnimal()),
            //     new Option("Racoon", () =>  SelectedAnimal()),
            //     new Option("Exit The Store", () => Environment.Exit(0)),
            // };

            // Set the default index of the selected item to be the first
            int index = 0;

            // Write the menu out
            WriteMenu(options, options[index]);

            // Store key info in here
            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();

                // Handle each key input (down arrow will write the menu again with a different selected item)
                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    if (index + 1 < options.Count)
                    {
                        index++;
                        WriteMenu(options, options[index]);
                    }
                }
                if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    if (index - 1 >= 0)
                    {
                        index--;
                        WriteMenu(options, options[index]);
                    }
                }
                // Handle different action for the option
                if (keyinfo.Key == ConsoleKey.Enter)
                {
                    //int animalIndex = options[index].Selected.Invoke();
                    shop.choosedAnimal = shop.animals[index];
                    newIndex = index;
                    index = 0;
                }

            }
            while (keyinfo.Key != ConsoleKey.X);

            Console.ReadKey();

        }
        // Default action of all the options. You can create more methods
        static int SelectedAnimal(int index)
        {
            Thread.Sleep(3000);
            return index;

        }

        static void WriteMenu(List<Option> options, Option selectedOption)
        {
            Console.Clear();

            foreach (Option option in options)
            {
                if (option == selectedOption)
                {
                    Console.Write("> ");
                }
                else
                {
                    Console.Write(" ");
                }

                Console.WriteLine(option.Name);
            }
        }
    }


}

