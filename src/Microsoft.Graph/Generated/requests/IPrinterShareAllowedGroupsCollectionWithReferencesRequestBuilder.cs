// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IPrinterShareAllowedGroupsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IPrinterShareAllowedGroupsCollectionWithReferencesRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IPrinterShareAllowedGroupsCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IPrinterShareAllowedGroupsCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IGroupWithReferenceRequestBuilder"/> for the specified Group.
        /// </summary>
        /// <param name="id">The ID for the Group.</param>
        /// <returns>The <see cref="IGroupWithReferenceRequestBuilder"/>.</returns>
        IGroupWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IPrinterShareAllowedGroupsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IPrinterShareAllowedGroupsCollectionReferencesRequestBuilder"/>.</returns>
        IPrinterShareAllowedGroupsCollectionReferencesRequestBuilder References { get; }

    }
}
