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
    /// The interface IManagedMobileAppRequest.
    /// </summary>
    public partial interface IManagedMobileAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedMobileApp using POST.
        /// </summary>
        /// <param name="managedMobileAppToCreate">The ManagedMobileApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedMobileApp.</returns>
        System.Threading.Tasks.Task<ManagedMobileApp> CreateAsync(ManagedMobileApp managedMobileAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ManagedMobileApp using POST and returns a <see cref="GraphResponse{ManagedMobileApp}"/> object.
        /// </summary>
        /// <param name="managedMobileAppToCreate">The ManagedMobileApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedMobileApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedMobileApp>> CreateResponseAsync(ManagedMobileApp managedMobileAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagedMobileApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagedMobileApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagedMobileApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedMobileApp.</returns>
        System.Threading.Tasks.Task<ManagedMobileApp> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagedMobileApp and returns a <see cref="GraphResponse{ManagedMobileApp}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedMobileApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedMobileApp>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedMobileApp using PATCH.
        /// </summary>
        /// <param name="managedMobileAppToUpdate">The ManagedMobileApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedMobileApp.</returns>
        System.Threading.Tasks.Task<ManagedMobileApp> UpdateAsync(ManagedMobileApp managedMobileAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedMobileApp using PATCH and returns a <see cref="GraphResponse{ManagedMobileApp}"/> object.
        /// </summary>
        /// <param name="managedMobileAppToUpdate">The ManagedMobileApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedMobileApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedMobileApp>> UpdateResponseAsync(ManagedMobileApp managedMobileAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedMobileApp using PUT.
        /// </summary>
        /// <param name="managedMobileAppToUpdate">The ManagedMobileApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ManagedMobileApp> PutAsync(ManagedMobileApp managedMobileAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedMobileApp using PUT and returns a <see cref="GraphResponse{ManagedMobileApp}"/> object.
        /// </summary>
        /// <param name="managedMobileAppToUpdate">The ManagedMobileApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ManagedMobileApp}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedMobileApp>> PutResponseAsync(ManagedMobileApp managedMobileAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedMobileAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedMobileAppRequest Expand(Expression<Func<ManagedMobileApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedMobileAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedMobileAppRequest Select(Expression<Func<ManagedMobileApp, object>> selectExpression);

    }
}
