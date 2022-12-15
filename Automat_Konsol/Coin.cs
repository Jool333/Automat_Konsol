using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_Konsol
{
    internal class Money
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
