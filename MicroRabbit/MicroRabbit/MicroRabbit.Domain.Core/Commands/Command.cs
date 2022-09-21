using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; } //Only those who inherit from this class can set the timestamp with protected set

        protected Command()
        { 
            Timestamp = DateTime.Now;
        }
    }
}
