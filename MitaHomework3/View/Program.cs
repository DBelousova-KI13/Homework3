using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите необходимое количество случайных чисел: ");
            int num = 0;
            while (num < 1)
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Введено некорректное значение. Введите целое неотрицательное число.");
                }
            }
            var numb = new Numbertron();
            var jay = new Jay();
            var sBob = new SilentBob();
            numb.NewNumber += jay.FetchNewNumber;
            numb.NewNumber += sBob.FetchNewNumber;
            for (int i = 1; i < num; i++)
            {
                numb.Generate();
            }
            if (jay.Score > sBob.Score)
            {
                Console.WriteLine("Jay wins");
            }
            else if (sBob.Score > jay.Score)
            {
                Console.WriteLine("Silent Bob wins");
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
    }
}
