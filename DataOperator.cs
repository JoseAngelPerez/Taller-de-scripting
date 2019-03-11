using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelPerez
{
   public interface DataOperator
    {
       bool SortAscending();

       bool SortDescending();

       bool Shuffle();

       bool PerfectShuffle();

       bool RemoveOdds();

       bool PemoveEven();
    }
}
