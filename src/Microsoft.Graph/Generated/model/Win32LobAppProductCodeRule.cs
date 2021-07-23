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
    /// The type Win32LobAppProductCodeRule.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Win32LobAppProductCodeRule>))]
    public partial class Win32LobAppProductCodeRule : Win32LobAppRule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Win32LobAppProductCodeRule"/> class.
        /// </summary>
        public Win32LobAppProductCodeRule()
        {
            this.ODataType = "microsoft.graph.win32LobAppProductCodeRule";
        }

        /// <summary>
        /// Gets or sets productCode.
        /// The product code of the app.
        /// </summary>
        [JsonPropertyName("productCode")]
        public string ProductCode { get; set; }
    
        /// <summary>
        /// Gets or sets productVersion.
        /// The product version comparison value.
        /// </summary>
        [JsonPropertyName("productVersion")]
        public string ProductVersion { get; set; }
    
        /// <summary>
        /// Gets or sets productVersionOperator.
        /// The product version comparison operator. Possible values are: notConfigured, equal, notEqual, greaterThan, greaterThanOrEqual, lessThan, lessThanOrEqual.
        /// </summary>
        [JsonPropertyName("productVersionOperator")]
        public Win32LobAppRuleOperator? ProductVersionOperator { get; set; }
    
    }
}
