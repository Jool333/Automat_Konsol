using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_Konsol
{
    public class RainCoat : Wares, RainGear
    {
        public RainCoat(string name = "regnjacka", int cost = 150, string description = "en gul regnjacka") : base(name, cost, description)
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

        public void PutOn()
        {
            throw new NotImplementedException();
        }
    }
}
