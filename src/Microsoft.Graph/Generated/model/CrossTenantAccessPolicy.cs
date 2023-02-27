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
    /// The type Cross Tenant Access Policy.
    /// </summary>
    public partial class CrossTenantAccessPolicy : PolicyBase
    {
    
        ///<summary>
        /// The CrossTenantAccessPolicy constructor
        ///</summary>
        public CrossTenantAccessPolicy()
        {
            this.ODataType = "microsoft.graph.crossTenantAccessPolicy";
        }

        /// <summary>
        /// Gets or sets allowed cloud endpoints.
        /// </summary>
        [JsonPropertyName("allowedCloudEndpoints")]
        public IEnumerable<string> AllowedCloudEndpoints { get; set; }
    
        /// <summary>
        /// Gets or sets default.
        /// Defines the default configuration for how your organization interacts with external Azure Active Directory organizations.
        /// </summary>
        [JsonPropertyName("default")]
        public CrossTenantAccessPolicyConfigurationDefault Default { get; set; }
    
        /// <summary>
        /// Gets or sets partners.
        /// Defines partner-specific configurations for external Azure Active Directory organizations.
        /// </summary>
        [JsonPropertyName("partners")]
        public ICrossTenantAccessPolicyPartnersCollectionPage Partners { get; set; }

        /// <summary>
        /// Gets or sets partnersNextLink.
        /// </summary>
        [JsonPropertyName("partners@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string PartnersNextLink { get; set; }
    
    }
}

