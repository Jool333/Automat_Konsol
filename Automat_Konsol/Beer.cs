namespace Automat_Konsol
{
    internal class Beer : Wares, Drinks
    {
        public Beer(string name = "öl", int cost = 30, string description = "god och uppfriskande.") : base(name, cost, description)
        {
        }

        public void Buy(Wallet wallet)
        {
            int choice;
            do
            {
                Console.WriteLine($"Vill du köpa {name}? Det kostar: {cost}kr, skriv 1 för ja och 2 för nej");
                choice = Program.ConvertInputToInt();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Hur många önskar du köpa?");
                        int.TryParse(Console.ReadLine(), out int amount);
                        int finalcost = amount * cost;
                        if (finalcost <= wallet.getBalance())
                        {
                            wallet.Pay(finalcost);
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

        public void Description()
        {
            Console.WriteLine(description);
        }

        public void Drink()
        {
            Console.WriteLine($"Du dricker ölen, den är {description.ToLower()}");
            Program.ShowPressAnyKey();
        }
    }
}
