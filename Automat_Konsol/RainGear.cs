﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_Konsol
{
    public interface RainGear
    {
        void Buy(Wallet wallet);
        void Description();
        void PutOn();
    }
}