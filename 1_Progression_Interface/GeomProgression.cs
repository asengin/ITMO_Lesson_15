using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Progression_Interface
{
    class GeomProgression : ISeries
    {
        int initialNumber;
        int startNumber;
        int factor;

        private int Factor { get => factor; set => factor = value; }

        public void SetStep()
        {
            Console.Write("Введите знаменатель геометрической прогрессии: ");
            Factor = Convert.ToInt32(Console.ReadLine());
        }
        public int GetNext()
        {
            return initialNumber *= Factor;
        }

        public void Reset()
        {
            SetStart(startNumber);
        }

        public void SetStart(int x)
        {
            initialNumber = startNumber = x;
        }
    }
}
