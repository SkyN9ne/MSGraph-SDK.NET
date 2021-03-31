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
    /// The interface ITeamsAsyncOperationRequest.
    /// </summary>
    public partial interface ITeamsAsyncOperationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TeamsAsyncOperation using POST.
        /// </summary>
        /// <param name="teamsAsyncOperationToCreate">The TeamsAsyncOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TeamsAsyncOperation.</returns>
        System.Threading.Tasks.Task<TeamsAsyncOperation> CreateAsync(TeamsAsyncOperation teamsAsyncOperationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified TeamsAsyncOperation using POST and returns a <see cref="GraphResponse{TeamsAsyncOperation}"/> object.
        /// </summary>
        /// <param name="teamsAsyncOperationToCreate">The TeamsAsyncOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsAsyncOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsAsyncOperation>> CreateResponseAsync(TeamsAsyncOperation teamsAsyncOperationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified TeamsAsyncOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified TeamsAsyncOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified TeamsAsyncOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TeamsAsyncOperation.</returns>
        System.Threading.Tasks.Task<TeamsAsyncOperation> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified TeamsAsyncOperation and returns a <see cref="GraphResponse{TeamsAsyncOperation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsAsyncOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsAsyncOperation>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified TeamsAsyncOperation using PATCH.
        /// </summary>
        /// <param name="teamsAsyncOperationToUpdate">The TeamsAsyncOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TeamsAsyncOperation.</returns>
        System.Threading.Tasks.Task<TeamsAsyncOperation> UpdateAsync(TeamsAsyncOperation teamsAsyncOperationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified TeamsAsyncOperation using PATCH and returns a <see cref="GraphResponse{TeamsAsyncOperation}"/> object.
        /// </summary>
        /// <param name="teamsAsyncOperationToUpdate">The TeamsAsyncOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TeamsAsyncOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsAsyncOperation>> UpdateResponseAsync(TeamsAsyncOperation teamsAsyncOperationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified TeamsAsyncOperation using PUT.
        /// </summary>
        /// <param name="teamsAsyncOperationToUpdate">The TeamsAsyncOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<TeamsAsyncOperation> PutAsync(TeamsAsyncOperation teamsAsyncOperationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified TeamsAsyncOperation using PUT and returns a <see cref="GraphResponse{TeamsAsyncOperation}"/> object.
        /// </summary>
        /// <param name="teamsAsyncOperationToUpdate">The TeamsAsyncOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{TeamsAsyncOperation}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsAsyncOperation>> PutResponseAsync(TeamsAsyncOperation teamsAsyncOperationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsAsyncOperationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsAsyncOperationRequest Expand(Expression<Func<TeamsAsyncOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsAsyncOperationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsAsyncOperationRequest Select(Expression<Func<TeamsAsyncOperation, object>> selectExpression);

    }
}
