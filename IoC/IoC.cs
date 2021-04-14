using BoundedContextsIntegration;
using MediatR;
using StructureMap;
using System;

namespace IoC
{
    public class IoC
    {
        public void Register()
        {
            var container = new Container(cfg =>
            {
                cfg.Scan(scanner =>
                {
                    scanner.TheCallingAssembly();
                    scanner.AddAllTypesOf(typeof(IRequestHandler<,>));
                    scanner.AddAllTypesOf(typeof(INotificationHandler<>));
                    scanner.AssemblyContainingType(typeof(MessageAHandler));
                });
                cfg.For<ServiceFactory>().Use<ServiceFactory>(ctx => ctx.GetInstance);
                cfg.For<IMediator>().Use<Mediator>();
            });

            Container = container;
        }

        public Container Container { get; set; }
    }
}
