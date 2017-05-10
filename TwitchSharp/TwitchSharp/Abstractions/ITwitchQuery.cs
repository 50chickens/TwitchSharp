using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchSharp.Abstractions
{
    public interface ITwitchQuery<TResult>
    {
    }

    public interface ITwitchQueryHandler<TQuery, TResult> where TQuery : ITwitchQuery<TResult>
    {
        Task<TResult> HandleAsync(TQuery query);
    }

    

}
