using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRDemo.Command
{
    public class SomeEvent : INotification
    {
        public SomeEvent(string message)
        {
            Message = message;
        }

        public string Message { get; }
    }
}
