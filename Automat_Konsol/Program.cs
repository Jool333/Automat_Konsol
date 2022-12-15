using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace Automat_Konsol
{
    /// <summary>
    /// The main program, presents the user with a menu and creates all wares, the wallet and calls the methods of the ware classes, 
    /// checks if it is a valid input and displays error if not
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            //lägg till alla produkter/användare/plånböcker
            Water water = new Water();
            Soda soda = new Soda();
            Beer beer = new Beer();
            Burger burger = new Burger();
            Pizza pizza = new Pizza();
            Kebab kebab = new Kebab();
            Umbrella umbrella = new Umbrella();
            RainBoots rainBoots = new RainBoots();
            RainCoat rainCoat = new RainCoat();
            List<Money> walletMoney;
            List<Money> vendingMoney;
            Wallet
                wallet = new Wallet("Johan", walletMoney = new List<Money>()
            { 
            new Money(1,10),
            new Money(5,10),
            new Money(10,10),
            new Money(20,0),
            new Money(50,0),
            new Money(100,0)
            });
            Wallet vending = new Wallet("Vending", vendingMoney = new List<Money>()
            {
            new Money(1,0),
            new Money(5,0),
            new Money(10,0),
            new Money(20,0),
            new Money(50,0),
            new Money(100,0)
            });
    
            //presentera val för anv
            int choice;
            int subchoice;
            do
            {
                Console.WriteLine("Vad önskas?" +
               "\n1.\tVatten" +
               "\n2.\tLäsk" +
               "\n3.\tÖl" +
               "\n4.\tBurgare" +
               "\n5.\tPizza" +
               "\n6.\tKebab" +
               "\n7.\tParaply" +
               "\n8.\tGummistövlar" +
               "\n9.\tRegnjacka" +
               "\n10\tSätta in pengar" +
               "\n0.\tAvsluta programmet");
                choice = ConvertInputToInt();
                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;

                    case 1:
                        do
                        {
                            ShowSubmenu();
                            subchoice = ConvertInputToInt();
                            switch (subchoice)
                            {
                                case 1:
                                    water.Description();
                                    break;
                                case 2:
                                    water.Buy(wallet);
                                    break;
                                default:
                                    ShowInvalidInput();
                                    break;
                            }
                        } while (subchoice != 2 && subchoice != 1);
                        break;

                    case 2:
                        do
                        {
                            ShowSubmenu();
                            subchoice = ConvertInputToInt();
                            switch (subchoice)
                            {
                                case 1:
                                    soda.Description();
                                    break;
                                case 2:
                                    soda.Buy(wallet);
                                    break;
                                default:
                                    ShowInvalidInput();
                                    break;
                            }
                        } while (subchoice != 2 && subchoice != 1);
                        break;

                    case 3:
                        do
                        {
                            ShowSubmenu();
                            subchoice = ConvertInputToInt();
                            switch (subchoice)
                            {
                                case 1:
                                    beer.Description();
                                    break;
                                case 2:
                                    beer.Buy(wallet);
                                    break;
                                default:
                                    ShowInvalidInput();
                                    break;
                            }
                        } while (subchoice != 2 && subchoice != 1);
                        break;

                    case 4:
                        do
                        {
                            ShowSubmenu();
                            subchoice = ConvertInputToInt();
                            switch (subchoice)
                            {
                                case 1:
                                    burger.Description();
                                    break;
                                case 2:
                                    burger.Buy(wallet);
                                    break;
                                default:
                                    ShowInvalidInput();
                                    break;
                            }
                        } while (subchoice != 2 && subchoice != 1);
                        break;
                    case 5:
                        do
                        {
                            ShowSubmenu();
                            subchoice = ConvertInputToInt();
                            switch (subchoice)
                            {
                                case 1:
                                    pizza.Description();
                                    break;
                                case 2:
                                    pizza.Buy(wallet);
                                    break;
                                default:
                                    ShowInvalidInput();
                                    break;
                            }
                        } while (subchoice != 2 && subchoice != 1);
                        break;
                    case 6:
                        do
                        {
                            ShowSubmenu();
                            subchoice = ConvertInputToInt();
                            switch (subchoice)
                            {
                                case 1:
                                    kebab.Description();
                                    break;
                                case 2:
                                    kebab.Buy(wallet);
                                    break;
                                default:
                                    ShowInvalidInput();
                                    break;
                            }
                        } while (subchoice != 2 && subchoice != 1);
                        break;
                    case 7:
                        do
                        {
                            ShowSubmenu();
                            subchoice = ConvertInputToInt();
                            switch (subchoice)
                            {
                                case 1:
                                    umbrella.Description();
                                    break;
                                case 2:
                                    umbrella.Buy(wallet);
                                    break;
                                default:
                                    ShowInvalidInput();
                                    break;
                            }
                        } while (subchoice != 2 && subchoice != 1);
                        break;
                    case 8:
                        do
                        {
                            ShowSubmenu();
                            subchoice = ConvertInputToInt();
                            switch (subchoice)
                            {
                                case 1:
                                    rainBoots.Description();
                                    break;
                                case 2:
                                    rainBoots.Buy(wallet);
                                    break;
                                default:
                                    ShowInvalidInput();
                                    break;
                            }
                        } while (subchoice != 2 && subchoice != 1);
                        break;
                    case 9:
                        do
                        {
                            ShowSubmenu();
                            subchoice = ConvertInputToInt();
                            switch (subchoice)
                            {
                                case 1:
                                    rainCoat.Description();
                                    break;
                                case 2:
                                    rainCoat.Buy(wallet);
                                    break;
                                default:
                                    ShowInvalidInput();
                                    break;
                            }
                        } while (subchoice != 2 && subchoice != 1);
                        break;
                    case 10:
                        Console.Clear();    
                        Console.WriteLine($"Pengar i plånboken, totalt: {wallet.getBalance()}kr, uppdelat:\n{wallet.ToString()}" +
                            $"\nPengar redan insatta i automaten: {vending.getBalance()}kr.");
                        vending.AddFunds(wallet);
                        break;
                    default:
                        ShowInvalidInput();
                        break;
                }
            } while (choice != 0);



        }
        /// <summary>
        /// Reads the users input and tries to converts it to int
        /// </summary>
        /// <returns>The converted input if it is parseable, if it cant returns -1</returns>
        public static int ConvertInputToInt()
        {
            return int.TryParse(Console.ReadLine(), out int result) ? result : -1;
        }
        /// <summary>
        /// Displays press any key to continue on a new line and then waits for a user to press any key before clearing the console
        /// </summary>
        public static void ShowPressAnyKey()
        {
            Console.Write("Tryck valfri knapp för att fortsätta...");
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Shows the submenu
        /// </summary>
        public static void ShowSubmenu()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?" +
                "\n1.\tSee the description" +
                "\n2.\tPurchase");
        }
        public static void ShowInvalidInput()
        {
            Console.Clear();
            Console.WriteLine("Ogiltigt input, vänligen försök igen");
        }
        
    }
}