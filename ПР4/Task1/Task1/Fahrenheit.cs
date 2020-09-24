using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    class Fahrenheit : FahrInterface
    {
        Random far;
        public Fahrenheit()
        {
            far = new Random();
        }

        public double GetRandomFahr()
        {
            double grad = far.NextDouble() * 10;
            return grad;
        }
    }
}
