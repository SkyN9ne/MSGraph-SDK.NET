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
    /// The type User Consent Request.
    /// </summary>
    public partial class UserConsentRequestObject : RequestObject
    {
    
        /// <summary>
        /// Gets or sets reason.
        /// The user's justification for requiring access to the app. Supports $filter (eq only) and $orderby.
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    
        /// <summary>
        /// Gets or sets approval.
        /// Approval decisions associated with a request.
        /// </summary>
        [JsonPropertyName("approval")]
        public Approval Approval { get; set; }
    
    }
}

