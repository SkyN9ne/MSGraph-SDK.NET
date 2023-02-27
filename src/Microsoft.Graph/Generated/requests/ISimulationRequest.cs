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
    /// The interface ISimulationRequest.
    /// </summary>
    public partial interface ISimulationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Simulation using POST.
        /// </summary>
        /// <param name="simulationToCreate">The Simulation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Simulation.</returns>
        System.Threading.Tasks.Task<Simulation> CreateAsync(Simulation simulationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Simulation using POST and returns a <see cref="GraphResponse{Simulation}"/> object.
        /// </summary>
        /// <param name="simulationToCreate">The Simulation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Simulation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Simulation>> CreateResponseAsync(Simulation simulationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Simulation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Simulation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Simulation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Simulation.</returns>
        System.Threading.Tasks.Task<Simulation> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Simulation and returns a <see cref="GraphResponse{Simulation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Simulation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Simulation>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Simulation using PATCH.
        /// </summary>
        /// <param name="simulationToUpdate">The Simulation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Simulation.</returns>
        System.Threading.Tasks.Task<Simulation> UpdateAsync(Simulation simulationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Simulation using PATCH and returns a <see cref="GraphResponse{Simulation}"/> object.
        /// </summary>
        /// <param name="simulationToUpdate">The Simulation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Simulation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Simulation>> UpdateResponseAsync(Simulation simulationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Simulation using PUT.
        /// </summary>
        /// <param name="simulationToUpdate">The Simulation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Simulation> PutAsync(Simulation simulationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Simulation using PUT and returns a <see cref="GraphResponse{Simulation}"/> object.
        /// </summary>
        /// <param name="simulationToUpdate">The Simulation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Simulation}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Simulation>> PutResponseAsync(Simulation simulationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISimulationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISimulationRequest Expand(Expression<Func<Simulation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISimulationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISimulationRequest Select(Expression<Func<Simulation, object>> selectExpression);

    }
}
