namespace Automat_Konsol
{
    public class RainCoat : Wares, RainGear
    {
        public RainCoat(string name = "regnjacka", int cost = 150, string description = "en gul regnjacka") : base(name, cost, description)
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
