using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_Konsol
{
    public class Water : Wares , Drinks
    {
        public Water(string name = "Water", int cost = 10, string description = "Cold and rehydrating.") : base(name, cost, description)
        {
            this._name = name;
            this._cost = cost;
            this._description = description;
        }

        public void Buy(Wallets wallet)
        {
            Console.WriteLine($"Do you wish to purchase water? It costs: {_cost}, type 1 for yes and 2 for no");
            int.TryParse(Console.ReadLine(), out int choice);
            do
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("How many do you wish to purchase?");
                        int.TryParse(Console.ReadLine(), out int amount);
                        int finalcost = amount*_cost;
                        if (finalcost <= wallet.getBalance())
                        {
                            wallet.Pay(finalcost);
                            Console.WriteLine($"Successfully purchased {amount} water for {finalcost}, do you wish to drink the water? type 1 for yes and 2 for no");
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
                        Console.WriteLine("The water was not purchased.");
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
            Console.Clear();
            Console.WriteLine(_description);
            Program.ShowPressAnyKey();
        }

        public void Drink()
        {
            Console.WriteLine($"You drink the water, its {_description.ToLower()}");
        }
    }

    
}
