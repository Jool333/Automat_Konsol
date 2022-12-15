using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_Konsol
{
    internal class Beer : Wares, Drinks
    {
        public Beer(string name = "Beer", int cost = 30, string description = "Nice and refreshing.") : base(name, cost, description)
        {
        }

        public void Buy(Wallets wallet)
        {
            Console.WriteLine($"Do you wish to purchase beer? It costs: {_cost}, type 1 for yes and 2 for no");
            int.TryParse(Console.ReadLine(), out int choice);
            do
            {
                switch (choice)
                {
                    case 1:
                        int balance = wallet.getBalance();
                        int maxAmount= wallet.getBalance()/_cost;
                        Console.WriteLine($"How many do you wish to purchase? You have {balance}kr and can buy maximum {maxAmount}");
                        int.TryParse(Console.ReadLine(), out int amount);
                        int finalcost = amount * _cost;
                        if (finalcost <= wallet.getBalance())
                        {
                            wallet.Pay(finalcost);
                            Console.WriteLine($"Successfully purchased {amount} beer for {finalcost}, do you wish to drink the beer? type 1 for yes and 2 for no");
                            int.TryParse(Console.ReadLine(), out int subchoice);
                            switch (subchoice)
                            {
                                case 1:
                                    Drink();
                                    break;
                                case 2:
                                    break;
                                default:
                                    Console.WriteLine("invalid choice");
                                    Program.ShowPressAnyKey();
                                    break;
                            }
                        }

                        break;
                    case 2:
                        Console.WriteLine("The beer was not purchased.");
                        Program.ShowPressAnyKey();
                        break;
                    default:
                        Console.WriteLine("invalid menu choice");
                        Program.ShowPressAnyKey();
                        break;
                }
            } while (choice > 1);
        }

        public void Description()
        {
            Console.WriteLine(_description);
        }

        public void Drink()
        {
            Console.WriteLine($"You drink the beer, its {_description.ToLower()}");
        }
    }
}
