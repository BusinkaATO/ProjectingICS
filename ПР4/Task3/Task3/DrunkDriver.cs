using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
   class DrunkDriver : TransportService
    {
        public int CategoryOfCar { get; set; }
        public DrunkDriver(string name, int category) : base(name)
        {
            /*1 - Легковой автомобиль
              2 - Грузовой автомобиль
              3 - Минивен
              4 - Легковой автомобиль (преиум класс)*/
            CategoryOfCar = category;
        }
        public override double CostTransportation(double distance)
        {
            switch (CategoryOfCar)
            {
                case 1:
                    return distance * 1;
                case 2:
                    return distance * 3;
                case 3:
                    return distance * 1.5;
                case 4:
                    return distance * 5;
                default:
                    return distance * 1;
            }
            
        }
        public override string ToString()
        {
            string s = String.Format("Фирма {0}, поездка категории {1}", Name, CategoryOfCar);
            return s;
        }
    }
}
