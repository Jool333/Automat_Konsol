namespace Automat_Konsol
{
    /// <summary>
    /// interface handling the methods of drinks
    /// can buy, show description and drink
    /// </summary>
    public interface Drinks
    {
        void Buy(Wallet vending, Wallet wallet);
        void Description();
        void Drink();
    }
}
