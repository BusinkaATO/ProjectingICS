using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число и последние, а также шаг соответственно (f, l, h): ");
            int f = Convert.ToInt32(Console.ReadLine());
            int l = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());
            Progression val = new GeometricProgression(f, l, h);
            val.TemplateMethod();
        }
    }
}
