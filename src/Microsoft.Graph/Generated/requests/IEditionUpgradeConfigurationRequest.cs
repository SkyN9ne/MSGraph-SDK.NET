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
    /// The interface IEditionUpgradeConfigurationRequest.
    /// </summary>
    public partial interface IEditionUpgradeConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EditionUpgradeConfiguration using POST.
        /// </summary>
        /// <param name="editionUpgradeConfigurationToCreate">The EditionUpgradeConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EditionUpgradeConfiguration.</returns>
        System.Threading.Tasks.Task<EditionUpgradeConfiguration> CreateAsync(EditionUpgradeConfiguration editionUpgradeConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified EditionUpgradeConfiguration using POST and returns a <see cref="GraphResponse{EditionUpgradeConfiguration}"/> object.
        /// </summary>
        /// <param name="editionUpgradeConfigurationToCreate">The EditionUpgradeConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EditionUpgradeConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EditionUpgradeConfiguration>> CreateResponseAsync(EditionUpgradeConfiguration editionUpgradeConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EditionUpgradeConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EditionUpgradeConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EditionUpgradeConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EditionUpgradeConfiguration.</returns>
        System.Threading.Tasks.Task<EditionUpgradeConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EditionUpgradeConfiguration and returns a <see cref="GraphResponse{EditionUpgradeConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EditionUpgradeConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EditionUpgradeConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EditionUpgradeConfiguration using PATCH.
        /// </summary>
        /// <param name="editionUpgradeConfigurationToUpdate">The EditionUpgradeConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EditionUpgradeConfiguration.</returns>
        System.Threading.Tasks.Task<EditionUpgradeConfiguration> UpdateAsync(EditionUpgradeConfiguration editionUpgradeConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EditionUpgradeConfiguration using PATCH and returns a <see cref="GraphResponse{EditionUpgradeConfiguration}"/> object.
        /// </summary>
        /// <param name="editionUpgradeConfigurationToUpdate">The EditionUpgradeConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EditionUpgradeConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EditionUpgradeConfiguration>> UpdateResponseAsync(EditionUpgradeConfiguration editionUpgradeConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EditionUpgradeConfiguration using PUT.
        /// </summary>
        /// <param name="editionUpgradeConfigurationToUpdate">The EditionUpgradeConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<EditionUpgradeConfiguration> PutAsync(EditionUpgradeConfiguration editionUpgradeConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EditionUpgradeConfiguration using PUT and returns a <see cref="GraphResponse{EditionUpgradeConfiguration}"/> object.
        /// </summary>
        /// <param name="editionUpgradeConfigurationToUpdate">The EditionUpgradeConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{EditionUpgradeConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<EditionUpgradeConfiguration>> PutResponseAsync(EditionUpgradeConfiguration editionUpgradeConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEditionUpgradeConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEditionUpgradeConfigurationRequest Expand(Expression<Func<EditionUpgradeConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEditionUpgradeConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEditionUpgradeConfigurationRequest Select(Expression<Func<EditionUpgradeConfiguration, object>> selectExpression);

    }
}
