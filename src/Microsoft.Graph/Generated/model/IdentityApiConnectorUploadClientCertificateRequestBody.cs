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
    /// The type IdentityApiConnectorUploadClientCertificateRequestBody.
    /// </summary>
    public partial class IdentityApiConnectorUploadClientCertificateRequestBody
    {
    
        /// <summary>
        /// Gets or sets Pkcs12Value.
        /// </summary>
        [JsonPropertyName("pkcs12Value")]
        public string Pkcs12Value { get; set; }
    
        /// <summary>
        /// Gets or sets Password.
        /// </summary>
        [JsonPropertyName("password")]
        public string Password { get; set; }
    
    }
}
