// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type InvitationParticipantInfo.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<InvitationParticipantInfo>))]
    public partial class InvitationParticipantInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationParticipantInfo"/> class.
        /// </summary>
        public InvitationParticipantInfo()
        {
            this.ODataType = "microsoft.graph.invitationParticipantInfo";
        }

        /// <summary>
        /// Gets or sets identity.
        /// The identitySet associated with this invitation.
        /// </summary>
        [JsonPropertyName("identity")]
        public IdentitySet Identity { get; set; }
    
        /// <summary>
        /// Gets or sets replacesCallId.
        /// Optional. The call which the target idenity is currently a part of. This call will be dropped once the participant is added.
        /// </summary>
        [JsonPropertyName("replacesCallId")]
        public string ReplacesCallId { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
