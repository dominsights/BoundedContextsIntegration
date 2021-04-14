using MediatR;
using System;
using System.Threading.Tasks;

namespace BoundedContextA
{
    public class EntityA
    {
        private IMediator _mediator;

        public EntityA(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<string> MethodA()
        {
            return await _mediator.Send(new MessageA());
        }
    }
}
