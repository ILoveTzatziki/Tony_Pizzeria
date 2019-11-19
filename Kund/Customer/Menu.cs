using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Console = Colorful.Console;

namespace Customer
{
    class Menu
    {
        public static void MenuChoices()
        {
            string input;
            while (true)
            {
                ShowWelcomeScreen();
                ShowMainMenu();
                input = Console.ReadLine();

                if (int.TryParse(input, out int mainMenuChoice))
                {
                    if (mainMenuChoice > 8)
                    {
                        System.Console.WriteLine("Försök igen!");
                        Console.ReadKey();
                    }
                    Console.Clear();
                    if (mainMenuChoice == 1)
                    {
                        ShowWelcomeScreen();
                        ShowDictionaryOfPizzas();
                        AddPizzaToOrderList();
                        Console.Clear();
                        ShowWelcomeScreen();
                        ShowAnythingMoreMenu();
                        AddSomethingMoreMenu();
                    }

                    else if (mainMenuChoice == 2)
                    {
                        ShowWelcomeScreen();
                        ShowDictionaryOfPanPizzas();
                        AddPanPizzaToOrderList();
                        Console.Clear();
                        ShowWelcomeScreen();
                        ShowAnythingMoreMenu();
                        AddSomethingMoreMenu();
                    }

                    else if (mainMenuChoice == 3)
                    {
                        ShowWelcomeScreen();
                        ShowDictionaryOfCannellonis();
                        AddCannelloniToOrderList();
                        Console.Clear();
                        ShowWelcomeScreen();
                        ShowAnythingMoreMenu();
                        AddSomethingMoreMenu();
                    }

                    else if (mainMenuChoice == 4)
                    {
                        ShowWelcomeScreen();
                        ShowDictionaryOfSalads();
                        AddSaladToOrderList();
                        Console.Clear();
                        ShowWelcomeScreen();
                        ShowAnythingMoreMenu();
                        AddSomethingMoreMenu();
                    }

                    else if (mainMenuChoice == 5)
                    {
                        ShowWelcomeScreen();
                        ShowDictionaryOfBeverages();
                        AddBeverageToOrderList();
                        Console.Clear();
                        ShowWelcomeScreen();
                        ShowAnythingMoreMenu();
                        AddSomethingMoreMenu();
                    }

                    else if (mainMenuChoice == 6)
                    {
                        ShowWelcomeScreen();
                        ShowPizzaBottom();
                        Console.Clear();
                        ShowWelcomeScreen();
                        ShowDictionaryOfIngredients();
                        for (int i = 1; i <= 5; i++)
                        {
                            AddIngredientToOrderList();
                        }
                    }

                    else if (mainMenuChoice == 7)
                    {
                        ShowWelcomeScreen();
                        if (Dictionaries.customerOrderList == null)
                        {
                            Console.WriteLine("Inget beställt än!");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                        ShowCustomerOrderList();

                        ShowAnythingMoreMenu();
                        AddSomethingMoreMenu();
                        Console.Clear();

                    }

                    else if (mainMenuChoice == 8)
                    {
                        ShowWelcomeScreen();
                        CancelOrder();
                    }
                }

                else
                {
                    Console.WriteLine("Endast siffror!");
                    Console.ReadKey();
                }
                Console.Clear();
            }
        }

        public static void ShowWelcomeScreen()
        {
            Console.WriteAscii("PIZZAPALATSET");
        }
        public static void ShowMainMenu()
        {
            Console.WriteLine("-----HUVUDMENY----");
            Console.WriteLine("1. Standardpizzor");
            Console.WriteLine("2. Panpizzor");
            Console.WriteLine("3. Cannelloni");
            Console.WriteLine("4. Sallader");
            Console.WriteLine("5. Dryck");
            Console.WriteLine("6. Göra egen pizza");
            Console.WriteLine("7. Visa beställning/betala");
            Console.WriteLine("8. Avbryt");
            Console.WriteLine("------------------");
        }

        public static void ShowAnythingMoreMenu()
        {
            Console.WriteLine("1. Något att dricka?");
            Console.WriteLine("2. Någon extra ingrediens?");
            Console.WriteLine("3. Betala");
            Console.WriteLine("4. Tillbaka till huvudmenyn");
        }

        public static void AddSomethingMoreMenu()
        {

            string parse;
            parse = Console.ReadLine();
        somethingmore:
            if (int.TryParse(parse, out int input))
            {
                if (input == 1)
                {
                    Console.Clear();
                    ShowWelcomeScreen();
                    ShowDictionaryOfBeverages();
                    AddBeverageToOrderList();
                }
                else if (input == 2)
                {
                    Console.Clear();
                    ShowWelcomeScreen();
                    ShowDictionaryOfIngredients();
                    AddIngredientToOrderList();
                }

                else if (input == 3)
                {
                    Console.Clear();
                    ShowWelcomeScreen();
                    Console.WriteLine("Tack för din beställning!");
                    ShowCustomerOrderList();
                    Dictionaries.customerOrderList.Clear();
                    Console.WriteLine("Tryck valfri knapp för att fortsätta");
                    Console.ReadKey();
                }

                else if (input == 4)
                {
                    Console.Clear();
                    ShowMainMenu();
                }
            }
            else
            {
                Console.WriteLine("Försök igen!");
                Console.ReadKey();
                goto somethingmore;
            }
        }

        public static void ShowDictionaryOfPizzas(int count = 1)
        {
            foreach (var item in Dictionaries.dictionaryOfPizzas)
            {
                Console.WriteLine(count + ". " + item.Key + " " + item.Value + ":-");
                count++;
            }
        }

        public static void ShowDictionaryOfPanPizzas(int count = 1)
        {
            foreach (var item in Dictionaries.dictionaryOfPanPizzas)
            {
                Console.WriteLine(count + ". " + item.Key + " " + item.Value + ":-");
                count++;
            }
        }

        public static void ShowDictionaryOfCannellonis(int count = 1)
        {
            foreach (var item in Dictionaries.dictionaryOfCannellonis)
            {
                Console.WriteLine(count + ". " + item.Key + " " + item.Value + ":-");
                count++;
            }
        }

        public static void ShowDictionaryOfSalads(int count = 1)
        {
            foreach (var item in Dictionaries.dictionaryOfSalads)
            {
                Console.WriteLine(count + ". " + item.Key + " " + item.Value + ":-");
                count++;
            }
        }

        public static void ShowDictionaryOfBeverages(int count = 1)
        {
            foreach (var item in Dictionaries.dictionaryOfBeverages)
            {
                Console.WriteLine(count + ". " + item.Key + " " + item.Value + ":-");
                count++;
            }
        }

        public static void ShowCustomerOrderList(int count = 1)
        {
            int sum = 0;
            Console.WriteLine("Order: ");
            foreach (var item in Dictionaries.customerOrderList)
            {
                Console.WriteLine($"{item.Name} {item.Price}:-");

                sum += item.Price;
            }
            System.Console.WriteLine("------------");
            Console.WriteLine($"Summa: {sum}:-");
            Console.WriteLine();
        }

        public static void ShowDictionaryOfIngredients(int count = 1)
        {
            foreach (var item in Dictionaries.dictionaryOfIngredients)
            {
                Console.WriteLine(count + ". " + item.Key + " " + item.Value + ":-");
                count++;
            }
        }

        public static void ShowPizzaBottom(int count = 1)
        {
            string input;
            System.Console.WriteLine("Välj botten");
            System.Console.WriteLine("1. Standard");
            System.Console.WriteLine("2. Pan");
            input = Console.ReadLine();
            if (int.TryParse(input, out int pizzaBottom))
            {
                if (pizzaBottom == 1)
                {
                    Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "Standardbotten", Price = 60 });
                }
                if (pizzaBottom == 2)
                {
                    Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "Panbotten", Price = 60 });
                }
            }
            else
            {
                System.Console.WriteLine("Endast siffror!");
            }


        }

        public static void GetSumOfOrder(Dictionary<string, int> myDictionary)
        {
            int sum = 0;
            foreach (var item in myDictionary)
            {
                sum += item.Value;
            }
            System.Console.WriteLine($"Summa: {sum}:-");
        }

        public static void AddBeverageToOrderList()
        {
            beverage:
            int beverageChoice = Convert.ToInt32(Console.ReadLine());
            if (beverageChoice == 1)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name= "Coca-Cola",  Price= 25 });
            else if (beverageChoice == 2)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "Fanta", Price = 25 });
            else if (beverageChoice == 3)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "Sprite", Price = 25 });
            else if (beverageChoice == 4)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "Ramlösa", Price = 25 });
            else if (beverageChoice == 5)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "Lättöl", Price = 25 });
            else
            {
                System.Console.Write("Försök igen: ");
                goto beverage;
            }
        }

        public static void AddCannelloniToOrderList()
        {
            cannelloni:
            int cannelloniChoice = Convert.ToInt32(Console.ReadLine());
            if (cannelloniChoice == 1)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "Cannelloni med ricotta och spenat", Price = 120 });
            else if (cannelloniChoice == 2)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "Cannelloni med köttfärs", Price = 120 });
            else if (cannelloniChoice == 3)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "Cannelloni med kyckling och svamp", Price = 120 });
            else
            {
                System.Console.Write("Försök igen: ");
                goto cannelloni;
            }
        }

        public static void AddSaladToOrderList()
        {
            salad:
            int saladChoice = Convert.ToInt32(Console.ReadLine());
            if (saladChoice == 1)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "Avokadosallad", Price = 85 });
            else if (saladChoice == 2)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "Kebabsallad", Price = 85 });
            else if (saladChoice == 3)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "Tonfisksallad", Price = 85 });
            else
            {
                System.Console.Write("Försök igen: ");
                goto salad;
            }
        }

        public static void AddPanPizzaToOrderList()
        {
            panPizza:
            int panPizzaChoice = int.Parse(Console.ReadLine());
            if (panPizzaChoice == 1)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "Texas", Price = 80 });
            else if (panPizzaChoice == 2)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "New York", Price = 80 });
            else if (panPizzaChoice == 3)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "Blue Hawaii", Price = 80 });
            else if (panPizzaChoice == 4)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "Vegetariana", Price = 80 });
            else if (panPizzaChoice == 5)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "USA", Price = 80 });
            else
            {
                System.Console.Write("Försök igen: ");
                goto panPizza;
            }
        }

        public static void AddPizzaToOrderList()
        {
            standardPizza:
            int standardPizzaChoice = int.Parse(Console.ReadLine());
            if (standardPizzaChoice == 1)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "Margarita", Price = 80 });
            else if (standardPizzaChoice == 2)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "Calzone", Price = 80 });
            else if (standardPizzaChoice == 3)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "Vesuvio", Price = 80 });
            else if (standardPizzaChoice == 4)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "Hawaii", Price = 80 });
            else if (standardPizzaChoice == 5)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "Bussola", Price = 80 });
            else
            {
                System.Console.Write("Försök igen: ");
                goto standardPizza;
            }
        }

        public static void AddIngredientToOrderList()
        {
            ingredients:

            int ingredientChoice = int.Parse(Console.ReadLine());
            if (ingredientChoice == 1)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "+Banan", Price = 5 });
            else if (ingredientChoice == 2)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "+Extra ost", Price = 5 });
            else if (ingredientChoice == 3)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "+Färska tomater", Price = 5 });
            else if (ingredientChoice == 4)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "+Basilika", Price = 5 });
            else if (ingredientChoice == 5)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "+Ananas", Price = 5 });
            else if (ingredientChoice == 6)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "+Fetaost", Price = 5 });
            else if (ingredientChoice == 7)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "+Vitlök", Price = 5 });
            else if (ingredientChoice == 8)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "+Skinka", Price = 5 });
            else if (ingredientChoice == 9)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "+Oregano", Price = 5 });
            else if (ingredientChoice == 10)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "+Basturökt skinka", Price = 5 });
            else if (ingredientChoice == 11)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "+Champinjoner", Price = 5 });
            else if (ingredientChoice == 12)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "+Oxfilé", Price = 5 });
            else if (ingredientChoice == 13)
                Dictionaries.customerOrderList.Add(new CustomerOrderItem() { Name = "+Kebab", Price = 5 });
            else
            {
                System.Console.Write("Försök igen: ");
                goto ingredients;
            }
        }

        public static void CancelOrder()
        {
            System.Console.WriteLine("Din order är avbruten");
            Thread.Sleep(2000);
            Dictionaries.customerOrderList.Clear();
            Console.Clear();

        }
    }
}
