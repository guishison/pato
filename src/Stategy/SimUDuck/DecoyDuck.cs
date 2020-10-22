using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            QuackBehavior = new Squeak();
            FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("Yo soy un pato de señuelo");
        }
    }
}
