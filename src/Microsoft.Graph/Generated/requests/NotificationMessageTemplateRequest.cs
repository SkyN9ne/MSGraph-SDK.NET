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
    /// The type NotificationMessageTemplateRequest.
    /// </summary>
    public partial class NotificationMessageTemplateRequest : BaseRequest, INotificationMessageTemplateRequest
    {
        /// <summary>
        /// Constructs a new NotificationMessageTemplateRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public NotificationMessageTemplateRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified NotificationMessageTemplate using POST.
        /// </summary>
        /// <param name="notificationMessageTemplateToCreate">The NotificationMessageTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created NotificationMessageTemplate.</returns>
        public async System.Threading.Tasks.Task<NotificationMessageTemplate> CreateAsync(NotificationMessageTemplate notificationMessageTemplateToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<NotificationMessageTemplate>(notificationMessageTemplateToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified NotificationMessageTemplate using POST and returns a <see cref="GraphResponse{NotificationMessageTemplate}"/> object.
        /// </summary>
        /// <param name="notificationMessageTemplateToCreate">The NotificationMessageTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{NotificationMessageTemplate}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<NotificationMessageTemplate>> CreateResponseAsync(NotificationMessageTemplate notificationMessageTemplateToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<NotificationMessageTemplate>(notificationMessageTemplateToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified NotificationMessageTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<NotificationMessageTemplate>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified NotificationMessageTemplate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified NotificationMessageTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The NotificationMessageTemplate.</returns>
        public async System.Threading.Tasks.Task<NotificationMessageTemplate> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<NotificationMessageTemplate>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified NotificationMessageTemplate and returns a <see cref="GraphResponse{NotificationMessageTemplate}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{NotificationMessageTemplate}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<NotificationMessageTemplate>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<NotificationMessageTemplate>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified NotificationMessageTemplate using PATCH.
        /// </summary>
        /// <param name="notificationMessageTemplateToUpdate">The NotificationMessageTemplate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated NotificationMessageTemplate.</returns>
        public async System.Threading.Tasks.Task<NotificationMessageTemplate> UpdateAsync(NotificationMessageTemplate notificationMessageTemplateToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<NotificationMessageTemplate>(notificationMessageTemplateToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified NotificationMessageTemplate using PATCH and returns a <see cref="GraphResponse{NotificationMessageTemplate}"/> object.
        /// </summary>
        /// <param name="notificationMessageTemplateToUpdate">The NotificationMessageTemplate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{NotificationMessageTemplate}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<NotificationMessageTemplate>> UpdateResponseAsync(NotificationMessageTemplate notificationMessageTemplateToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<NotificationMessageTemplate>(notificationMessageTemplateToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public INotificationMessageTemplateRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public INotificationMessageTemplateRequest Expand(Expression<Func<NotificationMessageTemplate, object>> expandExpression)
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
        public INotificationMessageTemplateRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public INotificationMessageTemplateRequest Select(Expression<Func<NotificationMessageTemplate, object>> selectExpression)
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
        /// <param name="notificationMessageTemplateToInitialize">The <see cref="NotificationMessageTemplate"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(NotificationMessageTemplate notificationMessageTemplateToInitialize)
        {

            if (notificationMessageTemplateToInitialize != null && notificationMessageTemplateToInitialize.AdditionalData != null)
            {

                if (notificationMessageTemplateToInitialize.LocalizedNotificationMessages != null && notificationMessageTemplateToInitialize.LocalizedNotificationMessages.CurrentPage != null)
                {
                    notificationMessageTemplateToInitialize.LocalizedNotificationMessages.AdditionalData = notificationMessageTemplateToInitialize.AdditionalData;

                    object nextPageLink;
                    notificationMessageTemplateToInitialize.AdditionalData.TryGetValue("localizedNotificationMessages@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        notificationMessageTemplateToInitialize.LocalizedNotificationMessages.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
