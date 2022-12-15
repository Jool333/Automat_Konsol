using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_Konsol
{
    public abstract class Wares
    {
        public string _name;
        public int _cost;
        public string _description;
        //public int stock;


        public Wares(string name, int cost, string description)
        {
            _name = name;
            _cost = cost;
            _description = description;
        }
    }
}
