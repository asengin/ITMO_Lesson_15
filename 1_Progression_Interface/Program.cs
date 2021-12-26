using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Progression_Interface
{
    class Program
    {
        /* Условие задачи
         * Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:
         * метод void setStart(int x) - устанавливает начальное значение
         * метод int getNext() - возвращает следующее число ряда
         * метод void reset() - выполняет сброс к начальному значению
         * Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries. 
         * В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.
         */
        /* Решение задачи
         * В методе Main осуществляется запрос у пользователя начального значения и шага арифметической прогрессии.
         * Запрос и установление шага осуществлено в методе SetStep().
         * Создается экз. класса арифметической прогрессии и в цикле прогоняется метод GetNext.
         * Аналогичная конструкция с геометрической прогрессией.
         */
        static void Main(string[] args)
        {
            #region Реализация арифметической прогрессии
            Console.WriteLine("\tАрифметическая прогрессия");
            ArithProgression firstProgression = new ArithProgression();
            Console.Write("Введите начальное значение: ");
            int startAr = Convert.ToInt32(Console.ReadLine());

            firstProgression.SetStep();

            Console.Write("Введите количество членов прогрессии: ");
            int countAr = Convert.ToInt32(Console.ReadLine());

            firstProgression.SetStart(startAr);

            for (int i = 0; i < countAr; i++)
                Console.Write($"{firstProgression.GetNext()}, ");
            #endregion

            #region Реализация геометрической прогрессии
            Console.WriteLine("\n\n\tГеометрическая прогрессия");
            GeomProgression secondProgression = new GeomProgression();
            Console.Write("Введите начальное значение: ");
            int startGeom = Convert.ToInt32(Console.ReadLine());

            secondProgression.SetStep();

            Console.Write("Введите количество членов прогрессии: ");
            int countGeom = Convert.ToInt32(Console.ReadLine());

            secondProgression.SetStart(startGeom);

            for (int i = 0; i < countGeom; i++)
                Console.Write($"{secondProgression.GetNext()}, ");
            #endregion

            Console.ReadKey();
        }
    }
}
