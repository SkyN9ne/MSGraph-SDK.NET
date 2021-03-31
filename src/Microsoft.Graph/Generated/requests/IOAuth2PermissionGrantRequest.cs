// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IOAuth2PermissionGrantRequest.
    /// </summary>
    public partial interface IOAuth2PermissionGrantRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OAuth2PermissionGrant using POST.
        /// </summary>
        /// <param name="oAuth2PermissionGrantToCreate">The OAuth2PermissionGrant to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OAuth2PermissionGrant.</returns>
        System.Threading.Tasks.Task<OAuth2PermissionGrant> CreateAsync(OAuth2PermissionGrant oAuth2PermissionGrantToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified OAuth2PermissionGrant using POST and returns a <see cref="GraphResponse{OAuth2PermissionGrant}"/> object.
        /// </summary>
        /// <param name="oAuth2PermissionGrantToCreate">The OAuth2PermissionGrant to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OAuth2PermissionGrant}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OAuth2PermissionGrant>> CreateResponseAsync(OAuth2PermissionGrant oAuth2PermissionGrantToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified OAuth2PermissionGrant.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified OAuth2PermissionGrant and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified OAuth2PermissionGrant.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OAuth2PermissionGrant.</returns>
        System.Threading.Tasks.Task<OAuth2PermissionGrant> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified OAuth2PermissionGrant and returns a <see cref="GraphResponse{OAuth2PermissionGrant}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OAuth2PermissionGrant}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OAuth2PermissionGrant>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified OAuth2PermissionGrant using PATCH.
        /// </summary>
        /// <param name="oAuth2PermissionGrantToUpdate">The OAuth2PermissionGrant to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OAuth2PermissionGrant.</returns>
        System.Threading.Tasks.Task<OAuth2PermissionGrant> UpdateAsync(OAuth2PermissionGrant oAuth2PermissionGrantToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified OAuth2PermissionGrant using PATCH and returns a <see cref="GraphResponse{OAuth2PermissionGrant}"/> object.
        /// </summary>
        /// <param name="oAuth2PermissionGrantToUpdate">The OAuth2PermissionGrant to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OAuth2PermissionGrant}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OAuth2PermissionGrant>> UpdateResponseAsync(OAuth2PermissionGrant oAuth2PermissionGrantToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified OAuth2PermissionGrant using PUT.
        /// </summary>
        /// <param name="oAuth2PermissionGrantToUpdate">The OAuth2PermissionGrant object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<OAuth2PermissionGrant> PutAsync(OAuth2PermissionGrant oAuth2PermissionGrantToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified OAuth2PermissionGrant using PUT and returns a <see cref="GraphResponse{OAuth2PermissionGrant}"/> object.
        /// </summary>
        /// <param name="oAuth2PermissionGrantToUpdate">The OAuth2PermissionGrant object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{OAuth2PermissionGrant}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<OAuth2PermissionGrant>> PutResponseAsync(OAuth2PermissionGrant oAuth2PermissionGrantToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOAuth2PermissionGrantRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOAuth2PermissionGrantRequest Expand(Expression<Func<OAuth2PermissionGrant, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOAuth2PermissionGrantRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOAuth2PermissionGrantRequest Select(Expression<Func<OAuth2PermissionGrant, object>> selectExpression);

    }
}
