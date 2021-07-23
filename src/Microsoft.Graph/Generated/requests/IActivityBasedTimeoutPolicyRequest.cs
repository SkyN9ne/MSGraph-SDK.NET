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
    /// The interface IActivityBasedTimeoutPolicyRequest.
    /// </summary>
    public partial interface IActivityBasedTimeoutPolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ActivityBasedTimeoutPolicy using POST.
        /// </summary>
        /// <param name="activityBasedTimeoutPolicyToCreate">The ActivityBasedTimeoutPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ActivityBasedTimeoutPolicy.</returns>
        System.Threading.Tasks.Task<ActivityBasedTimeoutPolicy> CreateAsync(ActivityBasedTimeoutPolicy activityBasedTimeoutPolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ActivityBasedTimeoutPolicy using POST and returns a <see cref="GraphResponse{ActivityBasedTimeoutPolicy}"/> object.
        /// </summary>
        /// <param name="activityBasedTimeoutPolicyToCreate">The ActivityBasedTimeoutPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ActivityBasedTimeoutPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ActivityBasedTimeoutPolicy>> CreateResponseAsync(ActivityBasedTimeoutPolicy activityBasedTimeoutPolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ActivityBasedTimeoutPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ActivityBasedTimeoutPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ActivityBasedTimeoutPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ActivityBasedTimeoutPolicy.</returns>
        System.Threading.Tasks.Task<ActivityBasedTimeoutPolicy> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ActivityBasedTimeoutPolicy and returns a <see cref="GraphResponse{ActivityBasedTimeoutPolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ActivityBasedTimeoutPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ActivityBasedTimeoutPolicy>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ActivityBasedTimeoutPolicy using PATCH.
        /// </summary>
        /// <param name="activityBasedTimeoutPolicyToUpdate">The ActivityBasedTimeoutPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ActivityBasedTimeoutPolicy.</returns>
        System.Threading.Tasks.Task<ActivityBasedTimeoutPolicy> UpdateAsync(ActivityBasedTimeoutPolicy activityBasedTimeoutPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ActivityBasedTimeoutPolicy using PATCH and returns a <see cref="GraphResponse{ActivityBasedTimeoutPolicy}"/> object.
        /// </summary>
        /// <param name="activityBasedTimeoutPolicyToUpdate">The ActivityBasedTimeoutPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ActivityBasedTimeoutPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ActivityBasedTimeoutPolicy>> UpdateResponseAsync(ActivityBasedTimeoutPolicy activityBasedTimeoutPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ActivityBasedTimeoutPolicy using PUT.
        /// </summary>
        /// <param name="activityBasedTimeoutPolicyToUpdate">The ActivityBasedTimeoutPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ActivityBasedTimeoutPolicy> PutAsync(ActivityBasedTimeoutPolicy activityBasedTimeoutPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ActivityBasedTimeoutPolicy using PUT and returns a <see cref="GraphResponse{ActivityBasedTimeoutPolicy}"/> object.
        /// </summary>
        /// <param name="activityBasedTimeoutPolicyToUpdate">The ActivityBasedTimeoutPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ActivityBasedTimeoutPolicy}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ActivityBasedTimeoutPolicy>> PutResponseAsync(ActivityBasedTimeoutPolicy activityBasedTimeoutPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IActivityBasedTimeoutPolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IActivityBasedTimeoutPolicyRequest Expand(Expression<Func<ActivityBasedTimeoutPolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IActivityBasedTimeoutPolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IActivityBasedTimeoutPolicyRequest Select(Expression<Func<ActivityBasedTimeoutPolicy, object>> selectExpression);

    }
}
