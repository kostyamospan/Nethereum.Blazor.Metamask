﻿using Nethereum.JsonRpc.Client.RpcMessages;
using Newtonsoft.Json;

namespace Ethereum.Blazor.Metamask.Abstractions.Models
{
    public class MetamaskRpcRequestMessage : RpcRequestMessage
    {

        public MetamaskRpcRequestMessage(object id, string method, string from, params object[] parameterList) : base(id, method,
            parameterList)
        {
            From = from;
        }

        [JsonProperty("from")]
        public string From { get; private set; }
    }
}