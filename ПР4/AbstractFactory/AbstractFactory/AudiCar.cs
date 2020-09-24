using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class AudiCar : AbstractCar
    {
        public AudiCar(string name)
        {
            Name = name;
        }
        public override int MaxSpeed(AbstractEngine engine)
        {
            int ms = engine.max_speed;
            return ms;
        }
        public override string Type(AbstractBody body)
        {
            string t = body.body_type;
            return t;
        }
        public override string ToString()
        {
            return "Машина " + Name;
        }

    }
}
