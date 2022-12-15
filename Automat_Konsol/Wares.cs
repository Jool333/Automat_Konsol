namespace Automat_Konsol
{
    /// <summary>
    /// abstact class handling all wares
    /// they have a name, a cost and a description
    /// </summary>

    public abstract class Wares
    {
        public string name;
        public int cost;
        public string description;
        //public int stock;


        public Wares(string name, int cost, string description)
        {
            this.name = name;
            this.cost = cost;
            this.description = description;
        }
    }
}
