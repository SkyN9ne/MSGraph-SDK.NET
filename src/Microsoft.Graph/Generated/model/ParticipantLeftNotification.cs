// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Participant Left Notification.
    /// </summary>
    public partial class ParticipantLeftNotification : Entity
    {
    
        /// <summary>
        /// Gets or sets participant id.
        /// ID of the participant under the policy who has left the meeting.
        /// </summary>
        [JsonPropertyName("participantId")]
        public string ParticipantId { get; set; }
    
        /// <summary>
        /// Gets or sets call.
        /// </summary>
        [JsonPropertyName("call")]
        public Call Call { get; set; }
    
    }
}

