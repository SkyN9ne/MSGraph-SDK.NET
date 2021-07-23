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
    /// The interface INotebookRequest.
    /// </summary>
    public partial interface INotebookRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Notebook using POST.
        /// </summary>
        /// <param name="notebookToCreate">The Notebook to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Notebook.</returns>
        System.Threading.Tasks.Task<Notebook> CreateAsync(Notebook notebookToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Notebook using POST and returns a <see cref="GraphResponse{Notebook}"/> object.
        /// </summary>
        /// <param name="notebookToCreate">The Notebook to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Notebook}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Notebook>> CreateResponseAsync(Notebook notebookToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Notebook.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Notebook and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Notebook.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Notebook.</returns>
        System.Threading.Tasks.Task<Notebook> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Notebook and returns a <see cref="GraphResponse{Notebook}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Notebook}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Notebook>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Notebook using PATCH.
        /// </summary>
        /// <param name="notebookToUpdate">The Notebook to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Notebook.</returns>
        System.Threading.Tasks.Task<Notebook> UpdateAsync(Notebook notebookToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Notebook using PATCH and returns a <see cref="GraphResponse{Notebook}"/> object.
        /// </summary>
        /// <param name="notebookToUpdate">The Notebook to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Notebook}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Notebook>> UpdateResponseAsync(Notebook notebookToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Notebook using PUT.
        /// </summary>
        /// <param name="notebookToUpdate">The Notebook object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Notebook> PutAsync(Notebook notebookToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Notebook using PUT and returns a <see cref="GraphResponse{Notebook}"/> object.
        /// </summary>
        /// <param name="notebookToUpdate">The Notebook object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Notebook}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Notebook>> PutResponseAsync(Notebook notebookToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        INotebookRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        INotebookRequest Expand(Expression<Func<Notebook, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        INotebookRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        INotebookRequest Select(Expression<Func<Notebook, object>> selectExpression);

    }
}
