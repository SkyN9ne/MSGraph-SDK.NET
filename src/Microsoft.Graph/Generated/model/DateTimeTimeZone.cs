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
    /// The type DateTimeTimeZone.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DateTimeTimeZone>))]
    public partial class DateTimeTimeZone
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeTimeZone"/> class.
        /// </summary>
        public DateTimeTimeZone()
        {
            this.ODataType = "microsoft.graph.dateTimeTimeZone";
        }

        /// <summary>
        /// Gets or sets dateTime.
        /// A single point of time in a combined date and time representation ({date}T{time}). For example, '2019-04-16T09:00:00'.
        /// </summary>
        [JsonPropertyName("dateTime")]
        public string DateTime { get; set; }
    
        /// <summary>
        /// Gets or sets timeZone.
        /// Represents a time zone, for example, 'Pacific Standard Time'. See below for possible values.
        /// </summary>
        [JsonPropertyName("timeZone")]
        public string TimeZone { get; set; }
    
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
