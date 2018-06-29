using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRDemo.Command
{
    public class SomeEventHandler2 : INotificationHandler<SomeEvent>
    {
        private readonly ILogger<SomeEventHandler2> _logger;

        public SomeEventHandler2(ILogger<SomeEventHandler2> logger)
        {
            _logger = logger;
        }

        public async Task Handle(SomeEvent notification, CancellationToken cancellationToken)
        {
            await Task.Run(() => _logger.LogWarning($"Handled2: {notification.Message}"));
        }
    }
}
