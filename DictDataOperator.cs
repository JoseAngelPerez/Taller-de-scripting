﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelPerez
{
    class DictDataOperator : DataOperator
    {
         public bool SortAscending(string tipo)
        {
            return true;
        }

        public bool SortDescending(string tipo)
        {
            return true;
        }

        public bool Shuffle(string tipo)
        {
            return true;
        }

        public bool PerfectShuffle(string tipo)
        {
            return true;
        }

        public bool RemoveOdds(string tipo)
        {
            return true;
        }

        public bool PemoveEven(string tipo)
        {
            return true;
        }
    }
}
