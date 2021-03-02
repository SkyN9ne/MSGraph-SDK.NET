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
    /// The type Teams App Definition.
    /// </summary>
    public partial class TeamsAppDefinition : Entity
    {
    
		///<summary>
		/// The TeamsAppDefinition constructor
		///</summary>
        public TeamsAppDefinition()
        {
            this.ODataType = "microsoft.graph.teamsAppDefinition";
        }
	
        /// <summary>
        /// Gets or sets created by.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The name of the app provided by the app developer.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets publishing state.
        /// The published status of a specific version of a Teams app. Possible values are:submitted — The specific version of the Teams app has been submitted and is under review. published  — The request to publish the specific version of the Teams app has been approved by the admin and the app is published.  rejected — The request to publish the specific version of the Teams app was rejected by the admin.
        /// </summary>
        [JsonPropertyName("publishingState")]
        public TeamsAppPublishingState? PublishingState { get; set; }
    
        /// <summary>
        /// Gets or sets short description.
        /// </summary>
        [JsonPropertyName("shortDescription")]
        public string ShortDescription { get; set; }
    
        /// <summary>
        /// Gets or sets teams app id.
        /// The id from the Teams App manifest.
        /// </summary>
        [JsonPropertyName("teamsAppId")]
        public string TeamsAppId { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// The version number of the application.
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    
        /// <summary>
        /// Gets or sets bot.
        /// The details of the bot specified in the Teams App manifest.
        /// </summary>
        [JsonPropertyName("bot")]
        public TeamworkBot Bot { get; set; }
    
    }
}

