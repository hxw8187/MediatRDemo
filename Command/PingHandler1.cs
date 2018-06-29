using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRDemo.Command
{
    public class PingHandler1 : IRequestHandler<Ping, string>
    {
        public async Task<string> Handle(Ping request, CancellationToken cancellationToken)
        {
            var b = await Task.Run<string>(() =>
            {
                return "Ping Handler 1";
            });

            return b;
        }
    }
}
