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
    /// The type Print.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Print>))]
    public partial class Print
    {
    
		///<summary>
		/// The Print constructor
		///</summary>
        public Print()
        {
            this.ODataType = "microsoft.graph.print";
        }
	
        /// <summary>
        /// Gets or sets settings.
        /// Tenant-wide settings for the Universal Print service.
        /// </summary>
        [JsonPropertyName("settings")]
        public PrintSettings Settings { get; set; }
    
        /// <summary>
        /// Gets or sets connectors.
        /// The list of available print connectors.
        /// </summary>
        [JsonPropertyName("connectors")]
        public IPrintConnectorsCollectionPage Connectors { get; set; }
    
        /// <summary>
        /// Gets or sets operations.
        /// </summary>
        [JsonPropertyName("operations")]
        public IPrintOperationsCollectionPage Operations { get; set; }
    
        /// <summary>
        /// Gets or sets printers.
        /// The list of printers registered in the tenant.
        /// </summary>
        [JsonPropertyName("printers")]
        public IPrintPrintersCollectionPage Printers { get; set; }
    
        /// <summary>
        /// Gets or sets services.
        /// The list of available Universal Print service endpoints.
        /// </summary>
        [JsonPropertyName("services")]
        public IPrintServicesCollectionPage Services { get; set; }
    
        /// <summary>
        /// Gets or sets shares.
        /// The list of printer shares registered in the tenant.
        /// </summary>
        [JsonPropertyName("shares")]
        public IPrintSharesCollectionPage Shares { get; set; }
    
        /// <summary>
        /// Gets or sets task definitions.
        /// </summary>
        [JsonPropertyName("taskDefinitions")]
        public IPrintTaskDefinitionsCollectionPage TaskDefinitions { get; set; }
    
        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}

