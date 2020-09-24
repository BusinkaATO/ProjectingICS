using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class TaxiTransCom : TransportCompany
    {
        public TaxiTransCom(string name): base(name)
        { }
        public override TransportService Create(string n, int c)
        {
            return new TaxiServices(Name, c);
        }
    }
}
