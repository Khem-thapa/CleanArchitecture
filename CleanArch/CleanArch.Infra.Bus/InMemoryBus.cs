using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Core.Commands;
using MediatR;
using System;
using System.Threading.Tasks;

namespace CleanArch.Infra.Bus
{

    /// <summary>
    /// Sealed class to restrict from inheritence
    /// </summary>
    public sealed class InMemoryBus : IMeditorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }
    }
}
