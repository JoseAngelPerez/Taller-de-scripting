using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelPerez
{
   public interface DataOperator
    {
       bool SortAscending(string tipo);

       bool SortDescending(string tipo);

       bool Shuffle(string tipo);

       bool PerfectShuffle(string tipo);

       bool RemoveOdds(string tipo);

       bool PemoveEven(string tipo);
    }
}
