using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace KassörskanV2
{
    class Menu
    {
        public static void ShowDoneOrders()
        {
            // A list that takes in variable e.
            List<int> orders = new List<int>();
            int e = 101;

        start:
            // When the new orders arrive, then it starts here:
            Console.Clear();
            for (int i = 1; i <= 5; i++)
            {
                orders.Add(e);
                e++;

            }
            // If the orderlist isn't empty yet, it starts here:
            while (true)
            {
                Console.Clear();
                Console.ResetColor();
                Console.WriteLine("Orders");

                // The variable and loop shows a list of five different numbers, the counter shows 1 - 5 and orders show at first 101 - 105.
                int count = 1;
                foreach (var item in orders)
                {
                    // Makes the numbers to the left white.
                    Console.ResetColor();
                    Console.Write(count++ + ". ");
                    // Makes the numbers to the right green(for done).
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine($"{item}");


                }

                Console.ResetColor();
                Console.WriteLine("______\n");
                string parse;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Done!\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Remove: ");

                parse = Console.ReadLine();

                // A tryparse method that only can register integers, if it isn't it will jump down to the else statement.
                if (int.TryParse(parse, out int input))
                {
                    // Remove at index 0 in the List
                    if (input == 1)
                    {
                        orders.RemoveAt(0);
                    }
                    // Remove at index 1 in the List
                    else if (input == 2)
                    {
                        try
                        {
                            orders.RemoveAt(1);
                        }
                        catch (Exception)
                        {
                            // If this index is already removed this will make it too not crash.
                        }
                    }
                    // Remove at index 2 in the List
                    else if (input == 3)
                    {
                        try
                        {
                            orders.RemoveAt(2);
                        }
                        catch (Exception)
                        {
                            // If this index is already removed this will make it too not crash.
                        }
                    }
                    // Remove at index 3 in the List
                    else if (input == 4)
                    {
                        try
                        {
                            orders.RemoveAt(3);
                        }
                        catch (Exception)
                        {
                            // If this index is already removed this will make it too not crash.
                        }
                    }
                    // Remove at index 4 in the List
                    else if (input == 5)
                    {
                        try
                        {
                            orders.RemoveAt(4);
                        }
                        catch (Exception)
                        {
                            // If this index is already removed this will make it too not crash.
                        }
                    }

                    // If the List is empty it will search for new orders that are done.
                    if (orders.Count == 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Waiting for new orders . . .");
                        Thread.Sleep(5000);
                        goto start;
                    }




                    // If the input is below 0 and higher than 5, do this.
                    if (input > 5 || input <= 0)
                    {
                        Console.WriteLine("You can't do that");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("You can't do that");
                    Console.ReadKey();
                }
            }
        }
    }
}
