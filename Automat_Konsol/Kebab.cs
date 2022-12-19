namespace Automat_Konsol
{
    internal class Kebab : Wares, Food
    {
        public Kebab(string name = "kebab", int cost = 60, string description = "En kebab med pommes och mild sås.") : base(name, cost, description)
        {
        }

        public void Buy(Wallet vending, Wallet wallet)
        {
            if (vending.getBalance() == 0)
            {
                Console.WriteLine("Där finns inga pengar insatta i automaten.");
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
                                Console.WriteLine($"Köpet slutfördes, {amount}st för totalt {finalcost}kr");
                                Eat();
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

        public void Description()
        {
            Console.Clear();
            Console.WriteLine(description);
        }

        public void Eat()
        {
            Console.WriteLine($"Du äter kebaben, den är {description.ToLower()}");
            Program.ShowPressAnyKey();
        }
    }
}
