using EmergenceGuardian.FFmpeg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{
    public class TwitchMediaFileProcessor : ITwitchMediaFileProcessor
    {
        public async Task JoinTSFilesAsync(string file1, string file2, CancellationToken cancellationToken)
        {

            if (cancellationToken.IsCancellationRequested)
            {
                cancellationToken.ThrowIfCancellationRequested();
            }

            ProcessStartOptions Options = new ProcessStartOptions(FFmpegDisplayMode.Interface, "Encoding to H264/AAC (Simple)");
            string Src = file1;
            string Dst = file2;
            await Task.Run(() => {
                MediaEncoder.Encode(Src, "h264", "aac", null, Dst, Options);
            });

            throw new NotImplementedException();
        }
    }
}
