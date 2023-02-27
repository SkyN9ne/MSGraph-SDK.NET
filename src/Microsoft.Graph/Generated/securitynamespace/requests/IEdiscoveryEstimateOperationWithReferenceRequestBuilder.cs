// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IEdiscoveryEstimateOperationWithReferenceRequestBuilder.
    /// </summary>
    public partial interface IEdiscoveryEstimateOperationWithReferenceRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IEdiscoveryEstimateOperationWithReferenceRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IEdiscoveryEstimateOperationWithReferenceRequest Request(IEnumerable<Microsoft.Graph.Option> options);

        /// <summary>
        /// Gets the request builder for the reference of the ediscoveryEstimateOperation.
        /// </summary>
        /// <returns>The <see cref="IEdiscoveryEstimateOperationReferenceRequestBuilder"/>.</returns>
        IEdiscoveryEstimateOperationReferenceRequestBuilder Reference { get; }

    }
}
