using System;
using System.Collections.Generic;
using System.Text;

namespace Customer
{
    public static class Dictionaries
    {
        public static Dictionary<string, int> dictionaryOfIngredients = new Dictionary<string, int>()
        {
            { "Banan", 5 },
            { "Extra ost", 5 },
            { "Färska tomater", 5 },
            { "Basilika", 5 },
            { "Ananas", 5 },
            { "Fetaost", 5 },
            { "Vitlök", 5 },
            { "Skinka", 5 },
            { "Oregano", 5 },
            { "Basturökt skinka", 5 },
            { "Champinjoner", 5 },
            { "Oxfilé", 5 },
            { "Kebab", 5 },
        };
        
        public static Dictionary<string, int> dictionaryOfPizzas = new Dictionary<string, int>()
        {
            { "Margarita", 80 },
            { "Calzone", 80 },
            { "Vesuvio", 80 },
            { "Hawaii", 80 },
            { "Bussola", 80 },
        };

        public static Dictionary<string, int> dictionaryOfPanPizzas = new Dictionary<string, int>()
        {
            { "Texas", 80 },
            { "New York", 80 },
            { "Blue Hawaii", 80 },
            { "Vegetariana", 80 },
            { "USA", 80 },
        };

        public static Dictionary<string, int> dictionaryOfCannellonis = new Dictionary<string, int>()
        {
            { "Cannelloni med ricotta och spenat", 120 },
            { "Cannelloni med köttfärs", 120 },
            { "Cannelloni med kyckling och svamp", 120 },
        };


        public static Dictionary<string, int> dictionaryOfSalads = new Dictionary<string, int>()
        {
            {"Avokadosallad (avokado, tomat, parmesan, olivolja)", 85 },
            {"Kebabsallad (kebab, vitlökssås, tomat, tomatsås)", 85 },
            {"Tonfisksallad (tonfisk, majonnäs, ägg, olivolja)", 85 },
        };

        public static Dictionary<string, int> dictionaryOfOtherMeals = new Dictionary<string, int>()
        {
            { "Pizzasallad", 120 },
            { "Vitlöksbröd", 120 },
        };


        public static Dictionary<string, int> dictionaryOfBeverages = new Dictionary<string, int>()
        {
            { "Coca-Cola", 25 },
            { "Fanta", 25 },
            { "Sprite", 25 },
            { "Ramlösa", 25 },
            { "Lättöl", 25 },
        };

        public static List<CustomerOrderItem> customerOrderList = new List<CustomerOrderItem>();

    }
}
