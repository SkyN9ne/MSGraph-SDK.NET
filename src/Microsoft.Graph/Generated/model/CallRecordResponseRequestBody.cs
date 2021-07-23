// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type CallRecordResponseRequestBody.
    /// </summary>
    public partial class CallRecordResponseRequestBody
    {
    
        /// <summary>
        /// Gets or sets Prompts.
        /// </summary>
        [JsonPropertyName("prompts")]
        public IEnumerable<Prompt> Prompts { get; set; }
    
        /// <summary>
        /// Gets or sets BargeInAllowed.
        /// </summary>
        [JsonPropertyName("bargeInAllowed")]
        public bool? BargeInAllowed { get; set; }
    
        /// <summary>
        /// Gets or sets InitialSilenceTimeoutInSeconds.
        /// </summary>
        [JsonPropertyName("initialSilenceTimeoutInSeconds")]
        public Int32? InitialSilenceTimeoutInSeconds { get; set; }
    
        /// <summary>
        /// Gets or sets MaxSilenceTimeoutInSeconds.
        /// </summary>
        [JsonPropertyName("maxSilenceTimeoutInSeconds")]
        public Int32? MaxSilenceTimeoutInSeconds { get; set; }
    
        /// <summary>
        /// Gets or sets MaxRecordDurationInSeconds.
        /// </summary>
        [JsonPropertyName("maxRecordDurationInSeconds")]
        public Int32? MaxRecordDurationInSeconds { get; set; }
    
        /// <summary>
        /// Gets or sets PlayBeep.
        /// </summary>
        [JsonPropertyName("playBeep")]
        public bool? PlayBeep { get; set; }
    
        /// <summary>
        /// Gets or sets StopTones.
        /// </summary>
        [JsonPropertyName("stopTones")]
        public IEnumerable<string> StopTones { get; set; }
    
        /// <summary>
        /// Gets or sets ClientContext.
        /// </summary>
        [JsonPropertyName("clientContext")]
        public string ClientContext { get; set; }
    
    }
}
