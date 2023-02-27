// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IMethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface ICrossTenantAccessPolicyConfigurationDefaultResetToSystemDefaultRequestBuilder.
    /// </summary>
    public partial interface ICrossTenantAccessPolicyConfigurationDefaultResetToSystemDefaultRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        ICrossTenantAccessPolicyConfigurationDefaultResetToSystemDefaultRequest Request(IEnumerable<Option> options = null);
    }
}
