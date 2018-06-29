using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRDemo.Command
{
    public class SomeEventHandler1 : INotificationHandler<SomeEvent>
    {
        private readonly ILogger<SomeEventHandler1> _logger;

        public SomeEventHandler1(ILogger<SomeEventHandler1> logger)
        {
            _logger = logger;
        }

        public async Task Handle(SomeEvent notification, CancellationToken cancellationToken)
        {
            await Task.Run(() => _logger.LogWarning($"Handled1: {notification.Message}"));
        }
    }
}
