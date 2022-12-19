namespace Automat_Konsol
{
    /// <summary>
    /// Class handling water, inherits Wares and Drinks
    /// Gives defaul values to the constructor and implements methods
    /// </summary>
    public class Water : Wares, Drinks
    {
        public Water(string name = "vatten", int cost = 10, string description = "Kallt och törstsläckande.") : base(name, cost, description)
        {
            this.name = name;
            this.cost = cost;
            this.description = description;
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
                            if (finalcost <= vending.getBalance())
                            {
                                vending.Pay(finalcost, wallet);
                                Console.WriteLine($"Köpet slutfördes, {amount}st för totalt {finalcost}kr");
                                Drink();
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

        public void Drink()
        {
            Console.WriteLine($"Du dricker vattnet, det är {description.ToLower()}");
            Program.ShowPressAnyKey();
        }
    }


}
