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
    /// The type Teamwork Tag Member.
    /// </summary>
    public partial class TeamworkTagMember : Entity
    {
    
        /// <summary>
        /// Gets or sets display name.
        /// The member's display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets tenant id.
        /// The ID of the tenant that the tag member is a part of.
        /// </summary>
        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// The user ID of the member.
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
    }
}

