// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionPage.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The interface ICasesRootEdiscoveryCasesCollectionPage.
    /// </summary>
    [InterfaceConverter(typeof(Microsoft.Graph.InterfaceConverter<CasesRootEdiscoveryCasesCollectionPage>))]
    public interface ICasesRootEdiscoveryCasesCollectionPage : Microsoft.Graph.ICollectionPage<EdiscoveryCase>
    {
        /// <summary>
        /// Gets the next page <see cref="ICasesRootEdiscoveryCasesCollectionRequest"/> instance.
        /// </summary>
        ICasesRootEdiscoveryCasesCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(Microsoft.Graph.IBaseClient client, string nextPageLinkString);
    }
}
