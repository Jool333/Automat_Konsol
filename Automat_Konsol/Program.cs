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
            Wallets wallet = new Wallets("Johan");
            //presentera val för anv
            int choice;
            int subchoice;
            do
            {
                Console.WriteLine("What are you looking for?" +
               "\n1.\tDrink" +
               "\n2.\tFood" +
               "\n3.\tRain gear" +
               "\n4,\tAdd money" +
               "\n0.\tExit the program");
                choice = ConvertInputToInt();
                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Which kind of drink do look for?" +
                                "\n0.\tReturn to the previous menu" +
                                "\n1.\tWater" +
                                "\n2.\tSoda" +
                                "\n3.\tBeer");
                            subchoice = ConvertInputToInt();
                            switch (subchoice)
                            {
                                case 0:
                                    Console.Clear();    
                                    break;
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("What would you like to do?" +
                                        "\n0.\tReturn to the previous menu" +
                                        "\n1.\tSee the description" +
                                        "\n2.\tPurchase");
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
                                            Console.Clear();
                                            Console.WriteLine("Invalid input try again: ");
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("What would you like to do?" +
                                        "\n0.\tReturn to the previous menu" +
                                        "\n1.\tSee the description" +
                                        "\n2.\tPurchase");
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
                                            Console.Clear();
                                            Console.WriteLine("Invalid input try again: ");
                                            break;
                                    }
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("What would you like to do?" +
                                        "\n0.\tReturn to the previous menu" +
                                        "\n1.\tSee the description" +
                                        "\n2.\tPurchase");
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
                                            Console.Clear();
                                            Console.WriteLine("Invalid input try again: ");
                                            break;
                                    }
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Invalid input try again: ");
                                    break;
                            }
                        } while (subchoice != 0);
                        
                        break;
                    case 2:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Which dish do you wish to purchase?" +
                                "\n0.\tReturn to the previous menu" +
                                "\n1.\tBurger" +
                                "\n2.\tPizza" +
                                "\n3.\tKebab");
                            subchoice = ConvertInputToInt();
                            switch (subchoice)
                            {
                                case 0:
                                    Console.Clear();
                                    break;
                                case 1:
                                    break;
                                case 2:
                                    break;
                                case 3:
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Invalid input try again: ");
                                    break;
                            }
                        } while (subchoice != 0);
                        break;
                    case 3:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Which piece of rain gear do you wish to purchase?" +
                                "\n0.\tReturn to the previous menu" +
                                "\n1.\tUmbrella" +
                                "\n2.\tRain boots" +
                                "\n3.\tRain coat");
                            subchoice = ConvertInputToInt();
                            switch (subchoice)
                            {
                                case 0:
                                    Console.Clear();
                                    break;
                                case 1:
                                    break;
                                case 2:
                                    break;
                                case 3:
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Invalid input try again: ");
                                    break;
                            }
                        } while (subchoice != 0);
                        break;
                    case 4:
                        Console.WriteLine("Hur mycket vill du sätta in?");
                        int.TryParse(Console.ReadLine(), out int result);
                        wallet.AddFunds(result);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid input try again: ");
                        break;
                }
            } while (choice != 0);
            


        }
        /// <summary>
        /// Reads the users input and tries to converts it to int
        /// </summary>
        /// <returns>The converted input if it is parseable, if it cant returns -1</returns>
        private static int ConvertInputToInt()
        {
            return int.TryParse(Console.ReadKey().KeyChar.ToString(), out int result) ? result : -1;
        }
        /// <summary>
        /// Displays press any key to continue on a new line and then waits for a user to press any key before clearing the console
        /// </summary>
        public static void ShowPressAnyKey()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}