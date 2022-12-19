namespace Automat_Konsol
{
    public class RainBoots : Wares, RainGear
    {
        public RainBoots(string name = "gummistövlar", int cost = 225, string description = "grön gummistövlar") : base(name, cost, description)
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
