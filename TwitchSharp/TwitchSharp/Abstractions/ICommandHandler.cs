using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TwitchSharp.Implementations;

namespace TwitchSharp.Abstractions
{
    public interface ICommandHandler<TCommand>
    {
        Task HandleAsync(TCommand command);

        CancellationToken Token { get; set; }

        event ProgressChangedHandler ProgressChanged;
    }
}
