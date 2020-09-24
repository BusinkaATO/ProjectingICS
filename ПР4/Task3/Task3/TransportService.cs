using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    abstract class TransportService
    {
        public string Name { get; set; }
        public TransportService(string name)
        {
            Name = name;
        }

        abstract public double CostTransportation(double distance);

    }
}
