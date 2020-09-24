using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    class CelsAdapt
    {
        Fahrenheit f;
        double f_grad;
        public CelsAdapt(Fahrenheit fr)
        {
            f = fr;
        }

        public double GetFahr()
        {
            f_grad = f.GetRandomFahr();
            return f_grad;
        }

        public double FahrToCels()
        {
            double cels;
            cels = (f_grad - 32) * 5 / 9;
            return cels;
        }
    }
}
