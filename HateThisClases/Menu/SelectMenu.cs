// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using TheZooShop.Interface.Menu;

// namespace TheZooShop.Interface
// {
//     public class SelectMenu
//     {
//         public List<Option> options;
//         public ZooShopManager shop;
//         public int newIndex = 0;
//         public SelectMenu(ZooShopManager sh)
//         {
//             this.shop = sh;
//             options = new List<Option>();
//         }
//         public void ShowMenu()
//         {
//             foreach (var animal in shop.animals)
//             {
//                 options.Add(new Option(animal.Name, animal.ToString(), animal.Age, animal.Price, () => SelectedAnimal()));
//             }
//             // Create options that you want your menu to have
//             // options = new List<Option>
//             // {
//             //     new Option("Cat", () => SelectedAnimal()),
//             //     new Option("Dog", () =>  SelectedAnimal()),
//             //     new Option("Racoon", () =>  SelectedAnimal()),
//             //     new Option("Exit The Store", () => Environment.Exit(0)),
//             // };

//             // Set the default index of the selected item to be the first
//             int index = 0;

//             // Write the menu out
//             WriteMenu(options, options[index]);

//             // Store key info in here
//             ConsoleKeyInfo keyinfo;
//             do
//             {
//                 keyinfo = Console.ReadKey();

//                 // Handle each key input (down arrow will write the menu again with a different selected item)
//                 if (keyinfo.Key == ConsoleKey.DownArrow)
//                 {
//                     if (index + 1 < options.Count)
//                     {
//                         index++;
//                         WriteMenu(options, options[index]);
//                     }
//                 }
//                 if (keyinfo.Key == ConsoleKey.UpArrow)
//                 {
//                     if (index - 1 >= 0)
//                     {
//                         index--;
//                         WriteMenu(options, options[index]);
//                     }
//                 }
//                 // Handle different action for the option
//                 if (keyinfo.Key == ConsoleKey.Enter)
//                 {
//                     options[index].Selected.Invoke();
//                     newIndex = index;
//                     index = 0;
//                 }
//             }
//             while (keyinfo.Key != ConsoleKey.X);

//             Console.ReadKey();

//         }
//         // Default action of all the options. You can create more methods
//         static Animal SelectedAnimal()
//         {
//             Thread.Sleep(3000);
//             return GetAninal();

//         }

//         public Animal GetAninal()
//         {
//             return shop.animals[newIndex];
//         }



//         static void WriteMenu(List<Option> options, Option selectedOption)
//         {
//             Console.Clear();

//             foreach (Option option in options)
//             {
//                 if (option == selectedOption)
//                 {
//                     Console.Write("> ");
//                 }
//                 else
//                 {
//                     Console.Write(" ");
//                 }

//                 Console.WriteLine(option.Name);
//             }
//         }
//     }


// }

