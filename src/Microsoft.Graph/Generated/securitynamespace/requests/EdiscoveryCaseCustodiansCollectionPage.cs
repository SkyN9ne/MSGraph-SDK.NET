// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionPage.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;

    /// <summary>
    /// The type EdiscoveryCaseCustodiansCollectionPage.
    /// </summary>
    public partial class EdiscoveryCaseCustodiansCollectionPage : Microsoft.Graph.CollectionPage<EdiscoveryCustodian>, IEdiscoveryCaseCustodiansCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IEdiscoveryCaseCustodiansCollectionRequest"/> instance.
        /// </summary>
        public IEdiscoveryCaseCustodiansCollectionRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(Microsoft.Graph.IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new EdiscoveryCaseCustodiansCollectionRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
