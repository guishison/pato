using System;

namespace SimUDuck
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Yo estoy volando");
        }
    }
}