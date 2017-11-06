using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchSharp.Implementations;

namespace TwitchSharp.Abstractions
{
    public interface ICommandHandler<TCommand>
    {
        Task HandleAsync(TCommand command);

        event ProgressChangedHandler ProgressChanged;
    }
}
