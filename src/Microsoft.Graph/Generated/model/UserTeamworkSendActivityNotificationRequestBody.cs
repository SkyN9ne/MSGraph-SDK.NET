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
    /// The type UserTeamworkSendActivityNotificationRequestBody.
    /// </summary>
    public partial class UserTeamworkSendActivityNotificationRequestBody
    {
    
        /// <summary>
        /// Gets or sets Topic.
        /// </summary>
        [JsonPropertyName("topic")]
        public TeamworkActivityTopic Topic { get; set; }
    
        /// <summary>
        /// Gets or sets ActivityType.
        /// </summary>
        [JsonPropertyName("activityType")]
        public string ActivityType { get; set; }
    
        /// <summary>
        /// Gets or sets ChainId.
        /// </summary>
        [JsonPropertyName("chainId")]
        public Int64? ChainId { get; set; }
    
        /// <summary>
        /// Gets or sets PreviewText.
        /// </summary>
        [JsonPropertyName("previewText")]
        public ItemBody PreviewText { get; set; }
    
        /// <summary>
        /// Gets or sets TemplateParameters.
        /// </summary>
        [JsonPropertyName("templateParameters")]
        public IEnumerable<KeyValuePair> TemplateParameters { get; set; }
    
    }
}
