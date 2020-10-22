using System;

namespace SimUDuck.App
{
    class SimUDuckSimulator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simulando el pato real... \r\n");
            var mallard = new MullardDuck();
            mallard.Quack();
            mallard.Fly();
            mallard.Swim();

            Console.WriteLine("\r\nSimulando el pato de modelo... \r\n");
            var model = new ModelDuck();
            model.Quack();
            model.Fly();
            model.Swim();

            Console.WriteLine("\r\nSimulando el pato de goma... \r\n");
            var rubber = new RubberDuck();
            rubber.Quack();
            rubber.Fly();
            rubber.Swim();

            Console.WriteLine("\r\nSimulando el pato de señuelo... \r\n");
            var decoy = new DecoyDuck();
            decoy.Quack();
            decoy.Fly();
            decoy.Swim();
            Console.Read();
        }
    }
}
