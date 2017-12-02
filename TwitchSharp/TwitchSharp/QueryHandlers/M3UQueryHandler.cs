﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitch.Api;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{

    public class M3UQueryHandler : ITwitchQueryHandler<GetTwitchM3UQuery, M3U>
    {
        private readonly ITwitchClient client;


        public M3UQueryHandler(ITwitchClient client)
        {
            this.client = client;

        }



        public async Task<M3U> HandleAsync(GetTwitchM3UQuery query)
        {

            TwitchClient client = (TwitchClient)this.client;
            

            string text = await this.client.GetTwitchDataAsString(query.Location);

            text = text.Replace("\"", "");

            text = text.Replace("\r", "");


            return new M3U()
            {
                Text = text
            };
            

        }
    }





}
