﻿using Newtonsoft.Json;

namespace OpenHAB.NetRestApi.Models.Events.Payloads
{
    public class ItemStateChangedPayload
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("oldType")]
        public string OldType { get; set; }

        [JsonProperty("oldValue")]
        public string OldValue { get; set; }
    }
}