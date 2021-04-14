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
    public class MessageAHandler : IRequestHandler<MessageA, string>
    {
        // it knows the message defined in BoundedContextA
        public Task<string> Handle(MessageA request, CancellationToken cancellationToken)
        {
            SomeApplicationServiceB serviceB = new SomeApplicationServiceB();
            string result = serviceB.DoSomething();
            return Task.FromResult(result);
        }
    }
}
