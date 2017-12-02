using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TwitchSharp.Abstractions
{
    public interface ITwitchMediaFileProcessor
    {
        Task JoinTSFilesAsync (string file1, string file2, CancellationToken cancellationToken);
    }
}
