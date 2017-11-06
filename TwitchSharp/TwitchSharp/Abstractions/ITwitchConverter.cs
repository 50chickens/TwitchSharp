using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchSharp.Abstractions
{
    public interface ITwitchConvertParameters<T, TOut>
    {
        T Obj { get; set; }
    }

    public interface ITwitchConverter<T, TOut> where T : ITwitchConvertParameters<T, TOut>
    {

        Task<TOut> ConvertAsync(T obj);
    }



}
