using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Progression_Interface
{
    class ArithProgression : ISeries
    {
        int initialNumber;
        int startNumber;
        int step;

        public void SetStep()
        {
            Console.Write("Введите шаг арифметической прогрессии: ");
            Step = Convert.ToInt32(Console.ReadLine());
        }

        private int Step { get => step; set => step = value; }

        public void SetStart(int x)
        {
            initialNumber = startNumber = x;
        }
        public int GetNext()
        {
            return initialNumber += Step;
        }

        public void Reset()
        {
            SetStart(startNumber);
        }
    }
}
