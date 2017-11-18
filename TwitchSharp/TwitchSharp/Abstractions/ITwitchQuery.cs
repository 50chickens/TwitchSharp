using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TwitchSharp.Abstractions
{
    public interface ITwitchQuery<TResult>
    {
        string Location { get; }

        
    }

    public interface ITwitchQueryHandler<TQuery, TResult> where TQuery : ITwitchQuery<TResult>
    {

        CancellationToken Token { get; set; }
        Task<TResult> HandleAsync(TQuery query);


        //TResult Handle(TQuery query);

    }

    

}
