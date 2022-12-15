using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_Konsol
{
    internal class Kebab : Wares, Food
    {
        public Kebab(string name = "kebab", int cost = 60, string description = "Kebab med pommes och mild sås") : base(name, cost, description)
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
