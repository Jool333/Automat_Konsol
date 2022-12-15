namespace Automat_Konsol
{
    /// <summary>
    /// class handling Money, they have a denomnation and a count
    /// </summary>
    public class Money
    {
        public int Denomination { get; set; }
        public int Count { get; set; }

        public Money(int denomition, int count)
        {
            Denomination = denomition;
            Count = count;
        }


    }
}
