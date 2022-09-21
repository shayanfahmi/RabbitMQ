using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler
        where TEvent : Event //IEventHandler takes in any type of event, implements IEventHandler, where the event has to be of type Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler { }
}
