using System;

namespace SimUDuck
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Yo no puedo volar");
        }
    }
}