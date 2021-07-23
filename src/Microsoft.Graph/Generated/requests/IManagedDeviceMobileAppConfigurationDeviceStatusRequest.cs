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
    /// The interface IManagedDeviceMobileAppConfigurationDeviceStatusRequest.
    /// </summary>
    public partial interface IManagedDeviceMobileAppConfigurationDeviceStatusRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedDeviceMobileAppConfigurationDeviceStatus using POST.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationDeviceStatusToCreate">The ManagedDeviceMobileAppConfigurationDeviceStatus to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedDeviceMobileAppConfigurationDeviceStatus.</returns>
        System.Threading.Tasks.Task<ManagedDeviceMobileAppConfigurationDeviceStatus> CreateAsync(ManagedDeviceMobileAppConfigurationDeviceStatus managedDeviceMobileAppConfigurationDeviceStatusToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ManagedDeviceMobileAppConfigurationDeviceStatus using POST and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationDeviceStatus}"/> object.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationDeviceStatusToCreate">The ManagedDeviceMobileAppConfigurationDeviceStatus to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationDeviceStatus}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfigurationDeviceStatus>> CreateResponseAsync(ManagedDeviceMobileAppConfigurationDeviceStatus managedDeviceMobileAppConfigurationDeviceStatusToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagedDeviceMobileAppConfigurationDeviceStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagedDeviceMobileAppConfigurationDeviceStatus and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagedDeviceMobileAppConfigurationDeviceStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedDeviceMobileAppConfigurationDeviceStatus.</returns>
        System.Threading.Tasks.Task<ManagedDeviceMobileAppConfigurationDeviceStatus> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagedDeviceMobileAppConfigurationDeviceStatus and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationDeviceStatus}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationDeviceStatus}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfigurationDeviceStatus>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedDeviceMobileAppConfigurationDeviceStatus using PATCH.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationDeviceStatusToUpdate">The ManagedDeviceMobileAppConfigurationDeviceStatus to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedDeviceMobileAppConfigurationDeviceStatus.</returns>
        System.Threading.Tasks.Task<ManagedDeviceMobileAppConfigurationDeviceStatus> UpdateAsync(ManagedDeviceMobileAppConfigurationDeviceStatus managedDeviceMobileAppConfigurationDeviceStatusToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedDeviceMobileAppConfigurationDeviceStatus using PATCH and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationDeviceStatus}"/> object.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationDeviceStatusToUpdate">The ManagedDeviceMobileAppConfigurationDeviceStatus to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationDeviceStatus}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfigurationDeviceStatus>> UpdateResponseAsync(ManagedDeviceMobileAppConfigurationDeviceStatus managedDeviceMobileAppConfigurationDeviceStatusToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedDeviceMobileAppConfigurationDeviceStatus using PUT.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationDeviceStatusToUpdate">The ManagedDeviceMobileAppConfigurationDeviceStatus object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ManagedDeviceMobileAppConfigurationDeviceStatus> PutAsync(ManagedDeviceMobileAppConfigurationDeviceStatus managedDeviceMobileAppConfigurationDeviceStatusToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedDeviceMobileAppConfigurationDeviceStatus using PUT and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationDeviceStatus}"/> object.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationDeviceStatusToUpdate">The ManagedDeviceMobileAppConfigurationDeviceStatus object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationDeviceStatus}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfigurationDeviceStatus>> PutResponseAsync(ManagedDeviceMobileAppConfigurationDeviceStatus managedDeviceMobileAppConfigurationDeviceStatusToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceMobileAppConfigurationDeviceStatusRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceMobileAppConfigurationDeviceStatusRequest Expand(Expression<Func<ManagedDeviceMobileAppConfigurationDeviceStatus, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceMobileAppConfigurationDeviceStatusRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceMobileAppConfigurationDeviceStatusRequest Select(Expression<Func<ManagedDeviceMobileAppConfigurationDeviceStatus, object>> selectExpression);

    }
}
