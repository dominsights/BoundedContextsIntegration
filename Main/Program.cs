using BoundedContextA;
using System;
using IoC;
using MediatR;
using BoundedContextB;

namespace Main
{
    public class Program
    {
        static void Main()
        {
            IoC.IoC ioc = new IoC.IoC();
            ioc.Register();

            var mediator = ioc.Container.GetInstance<IMediator>();

            Console.WriteLine("--- Communicating from context A to context B. ---");
            EntityA entityA = new EntityA(mediator);
            Console.WriteLine(entityA.MethodA().Result);
            Console.WriteLine();

            Console.WriteLine("--- Communicating from context B to context A. ---");
            EntityB entityB = new EntityB(mediator);
            Console.WriteLine(entityB.MethodB().Result);

            Console.ReadKey();
        }
    }
}
