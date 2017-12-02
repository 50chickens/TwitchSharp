using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TwitchSharp.Abstractions;
using TwitchSharp.Implementations;

namespace TwitchSharp
{
    public class JoinFileCommandHandler : ICommandHandler<JoinFileCommand>
    {
        private readonly ITwitchMediaFileProcessor iTwitchMediaFileProcessor;

        public CancellationToken Token
        {
            get; set;
        }

        public event ProgressChangedHandler ProgressChanged;

        public JoinFileCommandHandler(ITwitchMediaFileProcessor iTwitchMediaFileProcessor)
        {
            this.iTwitchMediaFileProcessor = iTwitchMediaFileProcessor;
           
            
        }

        public async Task HandleAsync(JoinFileCommand command)
        {

            await iTwitchMediaFileProcessor.JoinTSFilesAsync(command.BaseFile, command.FileToAppend, Token);

        }

        

    }
}
