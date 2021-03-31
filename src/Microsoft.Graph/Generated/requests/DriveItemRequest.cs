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
    /// The type DriveItemRequest.
    /// </summary>
    public partial class DriveItemRequest : BaseRequest, IDriveItemRequest
    {
        /// <summary>
        /// Constructs a new DriveItemRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DriveItemRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DriveItem using POST.
        /// </summary>
        /// <param name="driveItemToCreate">The DriveItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DriveItem.</returns>
        public async System.Threading.Tasks.Task<DriveItem> CreateAsync(DriveItem driveItemToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<DriveItem>(driveItemToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DriveItem using POST and returns a <see cref="GraphResponse{DriveItem}"/> object.
        /// </summary>
        /// <param name="driveItemToCreate">The DriveItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DriveItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DriveItem>> CreateResponseAsync(DriveItem driveItemToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<DriveItem>(driveItemToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified DriveItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<DriveItem>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DriveItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified DriveItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DriveItem.</returns>
        public async System.Threading.Tasks.Task<DriveItem> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<DriveItem>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DriveItem and returns a <see cref="GraphResponse{DriveItem}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DriveItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DriveItem>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<DriveItem>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DriveItem using PATCH.
        /// </summary>
        /// <param name="driveItemToUpdate">The DriveItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DriveItem.</returns>
        public async System.Threading.Tasks.Task<DriveItem> UpdateAsync(DriveItem driveItemToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<DriveItem>(driveItemToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DriveItem using PATCH and returns a <see cref="GraphResponse{DriveItem}"/> object.
        /// </summary>
        /// <param name="driveItemToUpdate">The DriveItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DriveItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DriveItem>> UpdateResponseAsync(DriveItem driveItemToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<DriveItem>(driveItemToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DriveItem using PUT.
        /// </summary>
        /// <param name="driveItemToUpdate">The DriveItem object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<DriveItem> PutAsync(DriveItem driveItemToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<DriveItem>(driveItemToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DriveItem using PUT and returns a <see cref="GraphResponse{DriveItem}"/> object.
        /// </summary>
        /// <param name="driveItemToUpdate">The DriveItem object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{DriveItem}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DriveItem>> PutResponseAsync(DriveItem driveItemToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<DriveItem>(driveItemToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDriveItemRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDriveItemRequest Expand(Expression<Func<DriveItem, object>> expandExpression)
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
        public IDriveItemRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDriveItemRequest Select(Expression<Func<DriveItem, object>> selectExpression)
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
        /// <param name="driveItemToInitialize">The <see cref="DriveItem"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DriveItem driveItemToInitialize)
        {

            if (driveItemToInitialize != null && driveItemToInitialize.AdditionalData != null)
            {

                if (driveItemToInitialize.Children != null && driveItemToInitialize.Children.CurrentPage != null)
                {
                    driveItemToInitialize.Children.AdditionalData = driveItemToInitialize.AdditionalData;

                    object nextPageLink;
                    driveItemToInitialize.AdditionalData.TryGetValue("children@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        driveItemToInitialize.Children.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (driveItemToInitialize.Permissions != null && driveItemToInitialize.Permissions.CurrentPage != null)
                {
                    driveItemToInitialize.Permissions.AdditionalData = driveItemToInitialize.AdditionalData;

                    object nextPageLink;
                    driveItemToInitialize.AdditionalData.TryGetValue("permissions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        driveItemToInitialize.Permissions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (driveItemToInitialize.Subscriptions != null && driveItemToInitialize.Subscriptions.CurrentPage != null)
                {
                    driveItemToInitialize.Subscriptions.AdditionalData = driveItemToInitialize.AdditionalData;

                    object nextPageLink;
                    driveItemToInitialize.AdditionalData.TryGetValue("subscriptions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        driveItemToInitialize.Subscriptions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (driveItemToInitialize.Thumbnails != null && driveItemToInitialize.Thumbnails.CurrentPage != null)
                {
                    driveItemToInitialize.Thumbnails.AdditionalData = driveItemToInitialize.AdditionalData;

                    object nextPageLink;
                    driveItemToInitialize.AdditionalData.TryGetValue("thumbnails@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        driveItemToInitialize.Thumbnails.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (driveItemToInitialize.Versions != null && driveItemToInitialize.Versions.CurrentPage != null)
                {
                    driveItemToInitialize.Versions.AdditionalData = driveItemToInitialize.AdditionalData;

                    object nextPageLink;
                    driveItemToInitialize.AdditionalData.TryGetValue("versions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        driveItemToInitialize.Versions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
