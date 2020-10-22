using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            QuackBehavior = new MuteQuack(); 
            FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("Yo soy un pato de goma");
        }
    }
}
