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
    /// The interface IWorkbookChartGridlinesRequest.
    /// </summary>
    public partial interface IWorkbookChartGridlinesRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChartGridlines using POST.
        /// </summary>
        /// <param name="workbookChartGridlinesToCreate">The WorkbookChartGridlines to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartGridlines.</returns>
        System.Threading.Tasks.Task<WorkbookChartGridlines> CreateAsync(WorkbookChartGridlines workbookChartGridlinesToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified WorkbookChartGridlines using POST and returns a <see cref="GraphResponse{WorkbookChartGridlines}"/> object.
        /// </summary>
        /// <param name="workbookChartGridlinesToCreate">The WorkbookChartGridlines to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartGridlines}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartGridlines>> CreateResponseAsync(WorkbookChartGridlines workbookChartGridlinesToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WorkbookChartGridlines.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WorkbookChartGridlines and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WorkbookChartGridlines.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartGridlines.</returns>
        System.Threading.Tasks.Task<WorkbookChartGridlines> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WorkbookChartGridlines and returns a <see cref="GraphResponse{WorkbookChartGridlines}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartGridlines}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartGridlines>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WorkbookChartGridlines using PATCH.
        /// </summary>
        /// <param name="workbookChartGridlinesToUpdate">The WorkbookChartGridlines to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookChartGridlines.</returns>
        System.Threading.Tasks.Task<WorkbookChartGridlines> UpdateAsync(WorkbookChartGridlines workbookChartGridlinesToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WorkbookChartGridlines using PATCH and returns a <see cref="GraphResponse{WorkbookChartGridlines}"/> object.
        /// </summary>
        /// <param name="workbookChartGridlinesToUpdate">The WorkbookChartGridlines to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookChartGridlines}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartGridlines>> UpdateResponseAsync(WorkbookChartGridlines workbookChartGridlinesToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WorkbookChartGridlines using PUT.
        /// </summary>
        /// <param name="workbookChartGridlinesToUpdate">The WorkbookChartGridlines object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WorkbookChartGridlines> PutAsync(WorkbookChartGridlines workbookChartGridlinesToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WorkbookChartGridlines using PUT and returns a <see cref="GraphResponse{WorkbookChartGridlines}"/> object.
        /// </summary>
        /// <param name="workbookChartGridlinesToUpdate">The WorkbookChartGridlines object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WorkbookChartGridlines}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartGridlines>> PutResponseAsync(WorkbookChartGridlines workbookChartGridlinesToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartGridlinesRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartGridlinesRequest Expand(Expression<Func<WorkbookChartGridlines, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartGridlinesRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartGridlinesRequest Select(Expression<Func<WorkbookChartGridlines, object>> selectExpression);

    }
}
