using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double cashBalance = 5000.00;
            double btcValue = 7480.00;
            double ethValue = 586.15;
            double lteValue = 119.04;

            double btcBalance = 0;
            double ethBalance = 0;
            double lteBalance = 0;

            bool reload = false;
            do
            {
                Console.WriteLine("\\n Please make a selection:\n\n" +
                    "A) Account Balance\n" +
                    "B) Purchase Digital Currency\n" +
                    "S) Sell Digital Currency\n" +
                    "T) Transfer Digital Currency\n" +
                    "X) Exit\n\n");

                ConsoleKey userChoice = Console.ReadKey(true).Key;

                Console.Clear();
                switch (userChoice)
                {
                    case ConsoleKey.A:
                        Console.WriteLine($"Cash Balance:{cashBalance}\n" +
                            $"BTC Balance:{btcBalance}\n" +
                            $"ETH Balance:{ethBalance}\n" +
                            $"LTE Balance:{lteBalance}\n");
                        break;
                    case ConsoleKey.B:
                        Console.WriteLine($"What would you like to purchase?:\n" +
                            $"B) BTC({btcValue})\n" +
                            $"E) ETC({ethValue})\n" +
                            $"L) LTE({lteValue})\n" +
                            $"X) EXIT\n\n");
                        ConsoleKey purchaseChoice = Console.ReadKey(true).Key;
                        Console.Clear();
                        bool purchaseReload = false;
                        do
                        {
                            switch (purchaseChoice)
                            {
                                case ConsoleKey.B:
                                    if (cashBalance >= btcValue)
                                    {
                                        cashBalance -= btcValue;
                                        btcValue++;
                                        Console.WriteLine($"New Cash Balance is: {cashBalance}\n" +
                                            $"New BTC Balance is: {btcBalance}\n\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"You broke homie.");
                                    }
                                    purchaseReload = true;
                                    break;
                                case ConsoleKey.E:
                                    if (cashBalance >= ethValue)
                                    {
                                        cashBalance -= ethValue;
                                        ethValue++;
                                        Console.WriteLine($"New Cash Balance is: {cashBalance}\n" +
                                            $"New ETH Balance is: {ethBalance}\n\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"You broke homie.");
                                    }
                                    purchaseReload = true;
                                    break;
                                case ConsoleKey.L:
                                    if (cashBalance >= lteValue)
                                    {
                                        cashBalance -= lteValue;
                                        lteValue++;
                                        Console.WriteLine($"New Cash Balance is: {cashBalance}\n" +
                                            $"New LTE Balance is: {lteBalance}\n\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"You broke homie.");
                                    }
                                    purchaseReload = true;
                                    break;
                                case ConsoleKey.X:
                                    Console.WriteLine("Have a nice day.");
                                    purchaseReload = true;
                                    break;
                                default:
                                    Console.WriteLine("Invalid Choice, please try again.");
                                    break;
                            }
                        } while (!purchaseReload);
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine($"What would you like to sell?:\n" +
                            $"B) BTC({btcValue})\n" +
                            $"E) ETC({ethValue})\n" +
                            $"L) LTE({lteValue})\n" +
                            $"X) EXIT\n\n");
                        ConsoleKey sellChoice = Console.ReadKey(true).Key;
                        Console.Clear();
                        bool sellReload = false;
                        do
                        {
                            switch (sellChoice)
                            {
                                case ConsoleKey.B:
                                    if (btcValue >= 1)
                                    {
                                        cashBalance += btcValue;
                                        btcValue--;
                                        Console.WriteLine($"New Cash Balance is: {cashBalance}\n" +
                                            $"New BTC Balance is: {btcBalance}\n\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"You digitally broke homie.");
                                    }
                                    sellReload = true;
                                    break;
                                case ConsoleKey.E:
                                    if (ethValue >= 1)
                                    {
                                        cashBalance += ethValue;
                                        ethValue--;
                                        Console.WriteLine($"New Cash Balance is: {cashBalance}\n" +
                                            $"New ETH Balance is: {ethBalance}\n\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"You digitially broke homie.");
                                    }
                                    sellReload = true;
                                    break;
                                case ConsoleKey.L:
                                    if (lteValue >= 1)
                                    {
                                        cashBalance += lteValue;
                                        lteValue--;
                                        Console.WriteLine($"New Cash Balance is: {cashBalance}\n" +
                                            $"New LTE Balance is: {lteBalance}\n\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"You digitally broke homie.");
                                    }
                                    sellReload = true;
                                    break;
                                case ConsoleKey.X:
                                    Console.WriteLine("Have a nice day.");
                                    sellReload = true;
                                    break;
                                default:
                                    Console.WriteLine("Invalid Choice, please try again.");
                                    break;
                            }
                        } while (!sellReload);
                        break;
                    case ConsoleKey.T:
                        Console.WriteLine($"Choose a currency to transfer to:\n" +
                            $"B) BTC({btcValue})\n" +
                            $"E) ETC({ethValue})\n" +
                            $"L) LTE({lteValue})\n" +
                            $"X) EXIT\n\n");
                        ConsoleKey transferChoice = Console.ReadKey(true).Key;
                        Console.Clear();
                        bool transferReload = false;
                        break;
                }

            } while (!reload);


        }
    }
}
