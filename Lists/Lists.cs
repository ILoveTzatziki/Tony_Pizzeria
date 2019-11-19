using System;
using System.Collections.Generic;

namespace Lists
{
    class AllLists
    {
        static void Main(string[] args)
        {
            List<string> listOfIngredients = new List<string>();
            listOfIngredients.Add("Banan");
            listOfIngredients.Add("Extra ost");
            listOfIngredients.Add("Färska tomater");
            listOfIngredients.Add("Basilika");
            listOfIngredients.Add("Fetaost");
            listOfIngredients.Add("Ananas");
            listOfIngredients.Add("Vitlök");
            listOfIngredients.Add("Skinka");
            listOfIngredients.Add("Oregano");
            listOfIngredients.Add("Basturökt skinka");
            listOfIngredients.Add("Champinjoner");
            listOfIngredients.Add("Oxfile");
            listOfIngredients.Add("Kebab");

            Dictionary<string, int> dictionaryOfPizzas = new Dictionary<string, int>();
            dictionaryOfPizzas.Add("Margarita", 80);
            dictionaryOfPizzas.Add("Calzone", 80);
            dictionaryOfPizzas.Add("Vesuvio", 80);
            dictionaryOfPizzas.Add("Hawaii", 80);
            dictionaryOfPizzas.Add("Bussola", 80);

            Dictionary<string, int> dictionaryOfPanPizzas = new Dictionary<string, int>();
            dictionaryOfPizzas.Add("Texas", 80);
            dictionaryOfPizzas.Add("New York", 80);
            dictionaryOfPizzas.Add("Blue Hawaii", 80);
            dictionaryOfPizzas.Add("Vegetariana", 80);
            dictionaryOfPizzas.Add("USA", 80);

            Dictionary<string, int> dictionaryOfCannellonis = new Dictionary<string, int>();
            dictionaryOfCannellonis.Add("Cannelloni med ricotta och spenat", 120);
            dictionaryOfCannellonis.Add("Cannelloni med köttfärs", 120);
            dictionaryOfCannellonis.Add("Cannelloni med kyckling och svamp", 120);

            Dictionary<string, int> dictionaryOfOtherMeals = new Dictionary<string, int>();
            dictionaryOfOtherMeals.Add("Pizzasallad", 120);
            dictionaryOfOtherMeals.Add("Vitlöksbröd", 120);

            Dictionary<string, int> dictionaryOfBeverages = new Dictionary<string, int>();
            dictionaryOfBeverages.Add("Coca-Cola", 25);
            dictionaryOfBeverages.Add("Fanta", 25);
            dictionaryOfBeverages.Add("Sprite", 25);
            dictionaryOfBeverages.Add("Ramlösa", 25);
            dictionaryOfBeverages.Add("Lättöl", 25);

            List<string> listOfOrders = new List<string>();

            List<int> listOfPrices = new List<int>();

            Dictionary<string, int> customerOrderDictionary = new Dictionary<string, int>();
        }
    }
}
