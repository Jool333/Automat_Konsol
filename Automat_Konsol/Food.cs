namespace Automat_Konsol
{
    public interface Food
    {
        void Buy(Wallet vending, Wallet wallet);
        void Description();
        void Eat();
    }
}
