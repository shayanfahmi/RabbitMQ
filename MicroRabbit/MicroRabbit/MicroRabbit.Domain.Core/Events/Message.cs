using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Message : IRequest<bool> //Any request using MediatR is expecting a boolean back (true or false) command sent? message processed? etc
    {
        public string MessageType { get; protected set; }

        protected Message() {
            MessageType = GetType().Name;
        }
    }
}
