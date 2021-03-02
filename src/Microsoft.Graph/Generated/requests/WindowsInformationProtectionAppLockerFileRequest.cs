// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type WindowsInformationProtectionAppLockerFileRequest.
    /// </summary>
    public partial class WindowsInformationProtectionAppLockerFileRequest : BaseRequest, IWindowsInformationProtectionAppLockerFileRequest
    {
        /// <summary>
        /// Constructs a new WindowsInformationProtectionAppLockerFileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WindowsInformationProtectionAppLockerFileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WindowsInformationProtectionAppLockerFile using POST.
        /// </summary>
        /// <param name="windowsInformationProtectionAppLockerFileToCreate">The WindowsInformationProtectionAppLockerFile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsInformationProtectionAppLockerFile.</returns>
        public async System.Threading.Tasks.Task<WindowsInformationProtectionAppLockerFile> CreateAsync(WindowsInformationProtectionAppLockerFile windowsInformationProtectionAppLockerFileToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<WindowsInformationProtectionAppLockerFile>(windowsInformationProtectionAppLockerFileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified WindowsInformationProtectionAppLockerFile using POST and returns a <see cref="GraphResponse{WindowsInformationProtectionAppLockerFile}"/> object.
        /// </summary>
        /// <param name="windowsInformationProtectionAppLockerFileToCreate">The WindowsInformationProtectionAppLockerFile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsInformationProtectionAppLockerFile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtectionAppLockerFile>> CreateResponseAsync(WindowsInformationProtectionAppLockerFile windowsInformationProtectionAppLockerFileToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<WindowsInformationProtectionAppLockerFile>(windowsInformationProtectionAppLockerFileToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified WindowsInformationProtectionAppLockerFile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<WindowsInformationProtectionAppLockerFile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WindowsInformationProtectionAppLockerFile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified WindowsInformationProtectionAppLockerFile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsInformationProtectionAppLockerFile.</returns>
        public async System.Threading.Tasks.Task<WindowsInformationProtectionAppLockerFile> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<WindowsInformationProtectionAppLockerFile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified WindowsInformationProtectionAppLockerFile and returns a <see cref="GraphResponse{WindowsInformationProtectionAppLockerFile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsInformationProtectionAppLockerFile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtectionAppLockerFile>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<WindowsInformationProtectionAppLockerFile>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified WindowsInformationProtectionAppLockerFile using PATCH.
        /// </summary>
        /// <param name="windowsInformationProtectionAppLockerFileToUpdate">The WindowsInformationProtectionAppLockerFile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsInformationProtectionAppLockerFile.</returns>
        public async System.Threading.Tasks.Task<WindowsInformationProtectionAppLockerFile> UpdateAsync(WindowsInformationProtectionAppLockerFile windowsInformationProtectionAppLockerFileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<WindowsInformationProtectionAppLockerFile>(windowsInformationProtectionAppLockerFileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WindowsInformationProtectionAppLockerFile using PATCH and returns a <see cref="GraphResponse{WindowsInformationProtectionAppLockerFile}"/> object.
        /// </summary>
        /// <param name="windowsInformationProtectionAppLockerFileToUpdate">The WindowsInformationProtectionAppLockerFile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsInformationProtectionAppLockerFile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtectionAppLockerFile>> UpdateResponseAsync(WindowsInformationProtectionAppLockerFile windowsInformationProtectionAppLockerFileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<WindowsInformationProtectionAppLockerFile>(windowsInformationProtectionAppLockerFileToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsInformationProtectionAppLockerFileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsInformationProtectionAppLockerFileRequest Expand(Expression<Func<WindowsInformationProtectionAppLockerFile, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsInformationProtectionAppLockerFileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsInformationProtectionAppLockerFileRequest Select(Expression<Func<WindowsInformationProtectionAppLockerFile, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="windowsInformationProtectionAppLockerFileToInitialize">The <see cref="WindowsInformationProtectionAppLockerFile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WindowsInformationProtectionAppLockerFile windowsInformationProtectionAppLockerFileToInitialize)
        {

        }
    }
}
