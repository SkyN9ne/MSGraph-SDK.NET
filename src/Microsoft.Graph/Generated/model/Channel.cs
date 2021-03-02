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
    /// The type Channel.
    /// </summary>
    public partial class Channel : Entity
    {
    
		///<summary>
		/// The Channel constructor
		///</summary>
        public Channel()
        {
            this.ODataType = "microsoft.graph.channel";
        }
	
        /// <summary>
        /// Gets or sets description.
        /// Optional textual description for the channel.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Channel name as it will appear to the user in Microsoft Teams.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets email.
        /// The email address for sending messages to the channel. Read-only.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or sets is favorite by default.
        /// Indicates whether the channel should automatically be marked 'favorite' for all members of the team. Can only be set programmatically with Create team. Default: false.
        /// </summary>
        [JsonPropertyName("isFavoriteByDefault")]
        public bool? IsFavoriteByDefault { get; set; }
    
        /// <summary>
        /// Gets or sets membership type.
        /// The type of the channel. Can be set during creation and cannot be changed. Default: standard.
        /// </summary>
        [JsonPropertyName("membershipType")]
        public ChannelMembershipType? MembershipType { get; set; }
    
        /// <summary>
        /// Gets or sets web url.
        /// A hyperlink that will go to the channel in Microsoft Teams. This is the URL that you get when you right-click a channel in Microsoft Teams and select Get link to channel. This URL should be treated as an opaque blob, and not parsed. Read-only.
        /// </summary>
        [JsonPropertyName("webUrl")]
        public string WebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets files folder.
        /// Metadata for the location where the channel's files are stored.
        /// </summary>
        [JsonPropertyName("filesFolder")]
        public DriveItem FilesFolder { get; set; }
    
        /// <summary>
        /// Gets or sets members.
        /// A collection of membership records associated with the channel.
        /// </summary>
        [JsonPropertyName("members")]
        public IChannelMembersCollectionPage Members { get; set; }
    
        /// <summary>
        /// Gets or sets messages.
        /// A collection of all the messages in the channel. A navigation property. Nullable.
        /// </summary>
        [JsonPropertyName("messages")]
        public IChannelMessagesCollectionPage Messages { get; set; }
    
        /// <summary>
        /// Gets or sets tabs.
        /// A collection of all the tabs in the channel. A navigation property.
        /// </summary>
        [JsonPropertyName("tabs")]
        public IChannelTabsCollectionPage Tabs { get; set; }
    
    }
}

