namespace Automat_Konsol
{
    public class Umbrella : Wares, RainGear
    {
        public Umbrella(string name = "paraply", int cost = 75, string description = "Ett svart paraply") : base(name, cost, description)
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

        public void PutOn()
        {
            throw new NotImplementedException();
        }
    }
}
