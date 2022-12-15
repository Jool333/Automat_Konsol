using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_Konsol
{
    public interface Drinks
    {
        void Buy(Wallets wallet);
        void Description();
        void Drink();
    }
}
