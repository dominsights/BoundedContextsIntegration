using BoundedContextA;
using BoundedContextB;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BoundedContextsIntegration
{
    /// <summary>
    /// Translates <see cref="MessageA"/> into some action in BoundedContextB.
    /// </summary>
    public class MessageBHandler : IRequestHandler<MessageB, string>
    {
        // it knows the message defined in BoundedContextA
        public Task<string> Handle(MessageB request, CancellationToken cancellationToken)
        {
            SomeApplicationServiceA serviceA = new SomeApplicationServiceA();
            string result = serviceA.DoSomething();
            return Task.FromResult(result);
        }
    }
}
