﻿using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace BotCore
{
    public interface IConfiguration
    {
        [JsonProperty]
        String Token { get; }
        [JsonProperty]
        String WebHook { get; }
        [JsonProperty]
        String UriListener { get; }
    }
    

    public interface IBot
    {
        void RegisterMessageProcessor(IMessageProcessor proc);
        Task SendMessageAsync(IChatSession sess, IOutgoingMessage msg);
        void Start();
        void Stop();
    }
}