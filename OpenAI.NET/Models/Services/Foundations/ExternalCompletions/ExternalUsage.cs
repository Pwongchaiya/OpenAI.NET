﻿// --------------------------------------------------------------- 
// Copyright (c) Coalition of the Good-Hearted Engineers 
// ---------------------------------------------------------------

using Newtonsoft.Json;

namespace OpenAI.NET.Models.Services.Foundations.ExternalCompletions
{
    public class ExternalUsage
    {
        [JsonProperty(propertyName: "prompt_tokens")]
        public int PromptTokens { get; set; }

        [JsonProperty(propertyName: "completion_tokens")]
        public int CompletionTokens { get; set; }

        [JsonProperty(propertyName: "total_tokens")]
        public int TotalTokens { get; set; }
    }
}
