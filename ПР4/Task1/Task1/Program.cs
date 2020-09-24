using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrenheit fahrenheit = new Fahrenheit();
            CelsAdapt celsAdapt = new CelsAdapt(fahrenheit);
            Console.WriteLine("Получено град. в Фаренгейт: {0}, переведено в {1} град. Цельсия", celsAdapt.GetFahr(), celsAdapt.FahrToCels());
        }
    }
}
