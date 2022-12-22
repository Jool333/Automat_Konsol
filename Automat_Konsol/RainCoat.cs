﻿namespace Automat_Konsol
{
    public class RainCoat : Wares, RainGear
    {
        public RainCoat(string name = "regnjacka", int cost = 130, string description = "En gul regnjacka.") : base(name, cost, description)
        {
        }
        /// <summary>
        /// Method for purchasing a water, checks if there is any money in the machine, displays the price and how many you could purchase with your current balance, user can select to buy or not
        /// </summary>
        /// <param name="vending"></param>
        /// <param name="wallet"></param>

        public void Buy(Wallet vending, Wallet wallet)
        {
            if (vending.getBalance() == 0)
            {
                Console.WriteLine($"Där finns inga pengar insatta i automaten, {name} kostar {cost}.");
                Program.ShowPressAnyKey();
                return;
            }
            else
            {
                int choice;
                do
                {
                    Console.WriteLine($"Vill du köpa {name}? Det kostar: {cost}kr, för närvarande {vending.getBalance()}kr insatta i automaten, skriv 1 för ja och 2 för nej");
                    choice = Program.ConvertInputToInt();

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine($"Hur många önskar du köpa? Du kan köpa som mest {vending.getBalance() / cost}st.");
                            int.TryParse(Console.ReadLine(), out int amount);
                            int finalcost = amount * cost;
                            if (finalcost <= vending.getBalance() && finalcost != 0)
                            {
                                vending.Pay(finalcost, wallet);
                                Console.WriteLine($"Köpet slutfördes, {amount}st för totalt {finalcost}kr, kvarvarande saldo:  {vending.getBalance()}kr.");
                                Use();
                            }
                            else if (amount > vending.getBalance() / cost)
                            {
                                Console.WriteLine("Du kan inte köpa fler än vad du har satt in pengar för");
                                Program.ShowPressAnyKey();
                            }
                            else
                            {
                                Program.ShowInvalidInput();
                                Program.ShowPressAnyKey();
                            }

                            break;
                        case 2:
                            Console.WriteLine($"{name} köptes inte.");
                            Program.ShowPressAnyKey();
                            break;
                        default:
                            Program.ShowInvalidInput();
                            Program.ShowPressAnyKey();
                            break;
                    }
                } while (choice != 2 && choice != 1);
            }
        }
        /// <summary>
        /// Shows the description of the item
        /// </summary>
        public void Description()
        {
            Console.Clear();
            Console.WriteLine(description);
        }
        /// <summary>
        /// Uses the item, shows a line to display its effects 
        /// </summary>
        public void Use()
        {
            Console.WriteLine($"Du tar på regnjackan, det är {description.ToLower()}");
            Program.ShowPressAnyKey();
        }
    }
}
