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
    /// The interface IEducationOrganizationRequest.
    /// </summary>
    public partial interface IEducationOrganizationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EducationOrganization using POST.
        /// </summary>
        /// <param name="educationOrganizationToCreate">The EducationOrganization to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationOrganization.</returns>
        System.Threading.Tasks.Task<EducationOrganization> CreateAsync(EducationOrganization educationOrganizationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified EducationOrganization using POST and returns a <see cref="GraphResponse{EducationOrganization}"/> object.
        /// </summary>
        /// <param name="educationOrganizationToCreate">The EducationOrganization to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationOrganization}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationOrganization>> CreateResponseAsync(EducationOrganization educationOrganizationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EducationOrganization.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EducationOrganization and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EducationOrganization.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationOrganization.</returns>
        System.Threading.Tasks.Task<EducationOrganization> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EducationOrganization and returns a <see cref="GraphResponse{EducationOrganization}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationOrganization}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationOrganization>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationOrganization using PATCH.
        /// </summary>
        /// <param name="educationOrganizationToUpdate">The EducationOrganization to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EducationOrganization.</returns>
        System.Threading.Tasks.Task<EducationOrganization> UpdateAsync(EducationOrganization educationOrganizationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationOrganization using PATCH and returns a <see cref="GraphResponse{EducationOrganization}"/> object.
        /// </summary>
        /// <param name="educationOrganizationToUpdate">The EducationOrganization to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EducationOrganization}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationOrganization>> UpdateResponseAsync(EducationOrganization educationOrganizationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationOrganization using PUT.
        /// </summary>
        /// <param name="educationOrganizationToUpdate">The EducationOrganization object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<EducationOrganization> PutAsync(EducationOrganization educationOrganizationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationOrganization using PUT and returns a <see cref="GraphResponse{EducationOrganization}"/> object.
        /// </summary>
        /// <param name="educationOrganizationToUpdate">The EducationOrganization object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{EducationOrganization}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationOrganization>> PutResponseAsync(EducationOrganization educationOrganizationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationOrganizationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationOrganizationRequest Expand(Expression<Func<EducationOrganization, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationOrganizationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationOrganizationRequest Select(Expression<Func<EducationOrganization, object>> selectExpression);

    }
}
