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
    /// The interface IPrintJobRequest.
    /// </summary>
    public partial interface IPrintJobRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PrintJob using POST.
        /// </summary>
        /// <param name="printJobToCreate">The PrintJob to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrintJob.</returns>
        System.Threading.Tasks.Task<PrintJob> CreateAsync(PrintJob printJobToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified PrintJob using POST and returns a <see cref="GraphResponse{PrintJob}"/> object.
        /// </summary>
        /// <param name="printJobToCreate">The PrintJob to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrintJob}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrintJob>> CreateResponseAsync(PrintJob printJobToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified PrintJob.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified PrintJob and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified PrintJob.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PrintJob.</returns>
        System.Threading.Tasks.Task<PrintJob> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified PrintJob and returns a <see cref="GraphResponse{PrintJob}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrintJob}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrintJob>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PrintJob using PATCH.
        /// </summary>
        /// <param name="printJobToUpdate">The PrintJob to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PrintJob.</returns>
        System.Threading.Tasks.Task<PrintJob> UpdateAsync(PrintJob printJobToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PrintJob using PATCH and returns a <see cref="GraphResponse{PrintJob}"/> object.
        /// </summary>
        /// <param name="printJobToUpdate">The PrintJob to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PrintJob}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrintJob>> UpdateResponseAsync(PrintJob printJobToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PrintJob using PUT.
        /// </summary>
        /// <param name="printJobToUpdate">The PrintJob object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<PrintJob> PutAsync(PrintJob printJobToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PrintJob using PUT and returns a <see cref="GraphResponse{PrintJob}"/> object.
        /// </summary>
        /// <param name="printJobToUpdate">The PrintJob object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{PrintJob}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrintJob>> PutResponseAsync(PrintJob printJobToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrintJobRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrintJobRequest Expand(Expression<Func<PrintJob, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPrintJobRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPrintJobRequest Select(Expression<Func<PrintJob, object>> selectExpression);

    }
}
