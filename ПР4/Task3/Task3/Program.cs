using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportCompany trCom = new DrunkDriverTransCom("Служба 'Пьяный водитель'");
            TransportService compService = trCom.Create("Пьяный водитель", 2);
            double dist = 15.5;
            Print(compService, dist);
        }

        private static void Print(TransportService compTax, double distg)
        {
            Console.WriteLine("Компания {0}, расстояние {1}, стоимость: {2}",
            compTax.ToString(), distg, compTax.CostTransportation(distg));
        }
    }
}
