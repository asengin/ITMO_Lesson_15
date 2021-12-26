using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Progression_Interface
{
    interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
    } 
}
