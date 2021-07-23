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
    /// The type WorkbookChartAddRequestBody.
    /// </summary>
    public partial class WorkbookChartAddRequestBody
    {
    
        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets SourceData.
        /// </summary>
        [JsonPropertyName("sourceData")]
        public System.Text.Json.JsonDocument SourceData { get; set; }
    
        /// <summary>
        /// Gets or sets SeriesBy.
        /// </summary>
        [JsonPropertyName("seriesBy")]
        public string SeriesBy { get; set; }
    
    }
}
