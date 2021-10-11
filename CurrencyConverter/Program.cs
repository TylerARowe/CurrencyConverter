using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyConverterLibrary;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double cashBalance = 5000.00;

            Currencies values = new Currencies(1, 7480.00, 586.15, 119.04);

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
                            $"B) BTC({values.BtcValue})\n" +
                            $"E) ETC({values.EthValue})\n" +
                            $"L) LTE({values.LteValue})\n" +
                            $"X) EXIT\n\n");
                        ConsoleKey purchaseChoice = Console.ReadKey(true).Key;
                        Console.Clear();
                        bool purchaseReload = false;
                        do
                        {
                            switch (purchaseChoice)
                            {
                                case ConsoleKey.B:
                                    if (cashBalance >= values.BtcValue)
                                    {
                                        cashBalance -= values.BtcValue;
                                        values.BtcValue++;
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
                                    if (cashBalance >= values.EthValue)
                                    {
                                        cashBalance -= values.EthValue;
                                        values.EthValue++;
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
                                    if (cashBalance >= values.LteValue)
                                    {
                                        cashBalance -= values.LteValue;
                                        values.LteValue++;
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
                            $"B) BTC({values.BtcValue})\n" +
                            $"E) ETC({values.EthValue})\n" +
                            $"L) LTE({values.LteValue})\n" +
                            $"X) EXIT\n\n");
                        ConsoleKey sellChoice = Console.ReadKey(true).Key;
                        Console.Clear();
                        bool sellReload = false;
                        do
                        {
                            switch (sellChoice)
                            {
                                case ConsoleKey.B:
                                    if (values.BtcValue >= 1)
                                    {
                                        cashBalance += values.BtcValue;
                                        values.BtcValue--;
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
                                    if (values.EthValue >= 1)
                                    {
                                        cashBalance += values.EthValue;
                                        values.EthValue--;
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
                                    if (values.LteValue >= 1)
                                    {
                                        cashBalance += values.LteValue;
                                        values.LteValue--;
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
                            $"B) BTC({values.BtcValue})\n" +
                            $"E) ETC({values.EthValue})\n" +
                            $"L) LTE({values.LteValue})\n" +
                            $"X) EXIT\n\n");
                        ConsoleKey transferChoice = Console.ReadKey(true).Key;
                        Console.Clear();
                        bool transferChoiceReload = false;
                        do
                        {
                            Console.WriteLine($"Choose a currency to transfer from:\n" +
                            $"B) BTC({values.BtcValue})\n" +
                            $"E) ETC({values.EthValue})\n" +
                            $"L) LTE({values.LteValue})\n" +
                            $"X) EXIT\n\n");
                            ConsoleKey transferChoice2 = Console.ReadKey(true).Key;
                            Console.Clear();
                            bool transferReload = false;
                            do
                            {
                                switch (transferChoice2)
                                {
                                    case ConsoleKey.B:
                                        if (transferChoice == ConsoleKey.E)
                                        {
                                            double temp = 0;
                                             temp = values.BtcValue * btcBalance;
                                            ethBalance = temp / values.EthValue;
                                            Console.WriteLine($"Your new ETH Balance is: {ethBalance}");
                                        }
                                        else if (transferChoice == ConsoleKey.L)
                                        {
                                            double temp2 = 0;
                                            temp2 = values.BtcValue * btcBalance;
                                            lteBalance = temp2 / values.LteValue;
                                            Console.WriteLine($"Your new LTE Balance is: {lteBalance}");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ivalid conversion.");
                                        }
                                        transferReload = true;
                                        break;
                                    default:
                                        Console.WriteLine("Invalid Choice, please try again.");
                                        break;
                                }
                            } while (!transferReload);
                        } while (!transferChoiceReload);

                        break;
                }

            } while (!reload);


        }
    }
}
