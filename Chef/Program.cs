using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Timer = System.Timers.Timer;
namespace bagare
{
    class Program
    {
        static void Main(string[] args)
        {
            // bools to see if order is acppeted or done
            bool runtime = true;
            
            //git test
            
            
            // numbers to save down
            int number = 0;
            int test = 5;
            int poss = 1;
            Console.CursorVisible = false;
            //list for order
            List<Tuple<string, int, bool>> orders = new List<Tuple<string, int, bool>>
            {
                new Tuple<string, int, bool>("pizza1", 1, false),
                new Tuple<string, int, bool>("pizza2", 2, false),
                new Tuple<string, int, bool>("pizza3", 3, false),
                new Tuple<string, int, bool>("pizza4", 4, false),
                new Tuple<string, int, bool>("pizza1", 5, false)
            };


            List<Chef.Orders> orderlista = new List<Chef.Orders>(); 
            foreach(Tuple<string,int,bool> item in orders)
            {
                orderlista.Add(new Chef.Orders() { id = item.Item2, orderObj = item.Item1, making = item.Item3 });
            }
               
            
            // while so it is allways going
            while (true)
            {
                //while to see when we have gone thrue all the orders
                Console.ForegroundColor = ConsoleColor.White;
                while (runtime)
                {
                    // order that are waiting
                    Console.WriteLine("Ordar som väntar:");
                    // look for eatch value in list
                    foreach (var item in orderlista)
                    {
                        
                        // add one ot number to see what order is witch
                        number++;

                        //if u are on the number
                        if (number != poss && item.making == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Write($"{item.id} \n");
                        }
                        if (number == poss && item.making == true)
                        {
                            
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.Green;
                            
                            Console.Write($"{item.id}\n{item.orderObj}\n");
                            
                           
                        }
                        if (number == poss && item.making==false)
                        {
                            //change color on text and background
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.White;
                            // write what is in he box
                            Console.Write($"{item.id}\n{item.orderObj}  \n");
                        }

                        //else turn back to normal
                        else if (item.making != true)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($"{item.id} \n");
                        }
                    }//first fe loop
                    //set test as the last posible number
                    test = number;
                    // go oute of loop
                    runtime = false;
                    //if last vlue is it change all exlse to normal
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                // if you press down or s
                Console.ForegroundColor = ConsoleColor.Black; 
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.DownArrow || key.KeyChar == 's') 
                {
                    // poss gouse down one position in the text
                    poss = poss + 1;
                    // and start going thru the oredrs
                    runtime = true;
                    //clear the window
                    Console.Clear();
                    //reset the number on orders
                    number = 0;
                }
                // same as down but oppisit way
                if (key.Key == ConsoleKey.UpArrow || key.KeyChar == 'w')
                {
                    poss = poss - 1;
                    runtime = true;
                    Console.Clear();
                    number = 0;
                }
                    // if u press enter
                    if (key.Key == ConsoleKey.Enter)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    // clear window
                    Console.Clear();
                    
                   
                   
                    //set number to 0
                    number = 0;
                    // write oute the rite order


                    
                    foreach (var item in orderlista.ToList())
                    {
                        number++;
                        if (key.Key == ConsoleKey.Enter && item.making == true && number == poss)
                        {
                            orderlista.Remove(item);
                        }
                        //when poss is number the write the item
                        if (poss == number)
                        {
                          item.making=true;
                            
                            Console.WriteLine($"{item.id}\n{item.orderObj}");

                          
                            
                        }
                       
                    }
                }
                else { }
               
                //look if u go over or under the posible value go to lowest numberor highest
                if (poss > test)
                {
                    poss = 1;
                }
                if (poss == 0)
                {
                    poss = test;
                }
            }
        }
    }
}