using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Automat_Konsol
{
    public class Wallets
    {
        public string user;

        List<Money> money = new List<Money>
        {
            new Money(1,10),
            new Money(5,10),
            new Money(10,10),
            new Money(20,0),
            new Money(50,0),
            new Money(100,0)
        };
        public Wallets(string user)
        {
            this.user = user;
        }

        public void Pay(int cost)
        {
            for (int i = money.Count-1; i >= 0; i--)
            {
                if (cost < 0)
                {
                    ReturnChange(cost);
                    break;
                }
                if (cost == 0) break;

                if (money[i].Count != 0 && money[i].Denomination <= cost)
                {
                    int nbrOf = money[i].Count < cost / money[i].Denomination ? money[i].Count : cost / money[i].Denomination;
                    money[i].Count -= nbrOf;
                    cost -= nbrOf * money[i].Denomination;
                }
            }
            //find closest money over is better
            // remove the money from the pile
        }
        public void AddFunds(int funds)
        {
            //add the specific coins

        }
        public void ReturnChange(int change)
        {

        }
        public int getBalance()
        {
            int sum = 0;
            foreach (var item in money)
            {
                sum += item.Count * item.Denomination;
            }
            return sum;
        }
    }
    
}
