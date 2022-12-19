namespace Automat_Konsol
{
    internal class Burger : Wares, Food
    {
        public Burger(string name = "burgare", int cost = 50, string description = "en ostburgare") : base(name, cost, description)
        {
        }

        public void Buy(Wallet vending, Wallet wallet)
        {
            throw new NotImplementedException();
        }

        public void Description()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }
    }
}
