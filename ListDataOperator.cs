using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelPerez
{
    public class ListDataOperator : DataOperator
    {
        public bool SortAscending()
        {
            return true;
        }

        public bool SortDescending()
        {
            return true;
        }

         public bool Shuffle()
        {
            return true;
        }

         public bool PerfectShuffle()
        {
            return true;
        }

         public bool RemoveOdds()
        {
            return true;
        }

         public bool PemoveEven()
        {
            return true;
        }
    }
}
