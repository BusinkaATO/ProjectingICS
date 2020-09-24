using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main()
        {
            
            CarFactory audi_car = new AudiFactory();
            Client c2 = new Client(audi_car);
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час. Тип кузова {2}", c2.ToString(), c2.RunMaxSpeed(), c2.RunBody());
        }
    }
}
