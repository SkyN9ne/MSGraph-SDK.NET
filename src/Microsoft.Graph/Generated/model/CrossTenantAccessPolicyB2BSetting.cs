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
    /// The type CrossTenantAccessPolicyB2BSetting.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CrossTenantAccessPolicyB2BSetting>))]
    public partial class CrossTenantAccessPolicyB2BSetting
    {

        /// <summary>
        /// Gets or sets applications.
        /// The list of applications targeted with your cross-tenant access policy.
        /// </summary>
        [JsonPropertyName("applications")]
        public CrossTenantAccessPolicyTargetConfiguration Applications { get; set; }
    
        /// <summary>
        /// Gets or sets usersAndGroups.
        /// The list of users and groups targeted with your cross-tenant access policy.
        /// </summary>
        [JsonPropertyName("usersAndGroups")]
        public CrossTenantAccessPolicyTargetConfiguration UsersAndGroups { get; set; }
    
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
