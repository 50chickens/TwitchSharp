using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchSharp.Api
{
    public enum SearchParameter { Channel = 1, Game = 2,  Query = 3}

    public class VodSearchParameters
    {
        private string displayText;
        private SearchParameter parameter;

        public string DisplayText { get { return this.displayText; }  }
        public SearchParameter Parameter{ get { return this.parameter; }  }

        public VodSearchParameters(string displayText, SearchParameter parameter)
        {
            this.displayText = displayText;
            this.parameter = parameter;

        }
    }
}
