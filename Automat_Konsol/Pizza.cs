using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_Konsol
{
    internal class Pizza : Wares, Food
    {
        public Pizza(string name = "pizza", int cost = 70, string description = "en Hawaii pizza") : base(name, cost, description)
        {
        }

        public void Buy(Wallet wallet)
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
