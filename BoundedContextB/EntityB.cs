using MediatR;
using System;
using System.Threading.Tasks;

namespace BoundedContextB
{
    public class EntityB
    {
        private IMediator _mediator;

        public EntityB(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<string> MethodB()
        {
            return await _mediator.Send(new MessageB());
        }
    }
}
