using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class DrunkDriverTransCom : TransportCompany
    {
        public DrunkDriverTransCom(string name) : base(name)
        { }
        public override TransportService Create(string n, int c)
        {
            return new DrunkDriver(Name, c);
        }
    }
}
