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
    /// The type AccessPackageAnswerString.
    /// </summary>
    public partial class AccessPackageAnswerString : AccessPackageAnswer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPackageAnswerString"/> class.
        /// </summary>
        public AccessPackageAnswerString()
        {
            this.ODataType = "microsoft.graph.accessPackageAnswerString";
        }

        /// <summary>
        /// Gets or sets value.
        /// The value stored on the requestor's user profile, if this answer is configured to be stored as a specific attribute.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    
    }
}
