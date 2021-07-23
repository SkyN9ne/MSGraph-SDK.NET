// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum WindowsDeliveryOptimizationMode.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WindowsDeliveryOptimizationMode
    {
    
        /// <summary>
        /// User Defined
        /// </summary>
        UserDefined = 0,
	
        /// <summary>
        /// Http Only
        /// </summary>
        HttpOnly = 1,
	
        /// <summary>
        /// Http With Peering Nat
        /// </summary>
        HttpWithPeeringNat = 2,
	
        /// <summary>
        /// Http With Peering Private Group
        /// </summary>
        HttpWithPeeringPrivateGroup = 3,
	
        /// <summary>
        /// Http With Internet Peering
        /// </summary>
        HttpWithInternetPeering = 4,
	
        /// <summary>
        /// Simple Download
        /// </summary>
        SimpleDownload = 99,
	
        /// <summary>
        /// Bypass Mode
        /// </summary>
        BypassMode = 100,
	
    }
}
