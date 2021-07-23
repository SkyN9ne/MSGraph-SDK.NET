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
    /// The type TokenIssuancePolicyRequest.
    /// </summary>
    public partial class TokenIssuancePolicyRequest : BaseRequest, ITokenIssuancePolicyRequest
    {
        /// <summary>
        /// Constructs a new TokenIssuancePolicyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public TokenIssuancePolicyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified TokenIssuancePolicy using POST.
        /// </summary>
        /// <param name="tokenIssuancePolicyToCreate">The TokenIssuancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TokenIssuancePolicy.</returns>
        public async System.Threading.Tasks.Task<TokenIssuancePolicy> CreateAsync(TokenIssuancePolicy tokenIssuancePolicyToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<TokenIssuancePolicy>(tokenIssuancePolicyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified TokenIssuancePolicy using POST and returns a <see cref="GraphResponse{TokenIssuancePolicy}"/> object.
        /// </summary>
        /// <param name="tokenIssuancePolicyToCreate">The TokenIssuancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TokenIssuancePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TokenIssuancePolicy>> CreateResponseAsync(TokenIssuancePolicy tokenIssuancePolicyToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<TokenIssuancePolicy>(tokenIssuancePolicyToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified TokenIssuancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<TokenIssuancePolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified TokenIssuancePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified TokenIssuancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TokenIssuancePolicy.</returns>
        public async System.Threading.Tasks.Task<TokenIssuancePolicy> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<TokenIssuancePolicy>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified TokenIssuancePolicy and returns a <see cref="GraphResponse{TokenIssuancePolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TokenIssuancePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TokenIssuancePolicy>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<TokenIssuancePolicy>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified TokenIssuancePolicy using PATCH.
        /// </summary>
        /// <param name="tokenIssuancePolicyToUpdate">The TokenIssuancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TokenIssuancePolicy.</returns>
        public async System.Threading.Tasks.Task<TokenIssuancePolicy> UpdateAsync(TokenIssuancePolicy tokenIssuancePolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<TokenIssuancePolicy>(tokenIssuancePolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified TokenIssuancePolicy using PATCH and returns a <see cref="GraphResponse{TokenIssuancePolicy}"/> object.
        /// </summary>
        /// <param name="tokenIssuancePolicyToUpdate">The TokenIssuancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TokenIssuancePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TokenIssuancePolicy>> UpdateResponseAsync(TokenIssuancePolicy tokenIssuancePolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<TokenIssuancePolicy>(tokenIssuancePolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified TokenIssuancePolicy using PUT.
        /// </summary>
        /// <param name="tokenIssuancePolicyToUpdate">The TokenIssuancePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<TokenIssuancePolicy> PutAsync(TokenIssuancePolicy tokenIssuancePolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<TokenIssuancePolicy>(tokenIssuancePolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified TokenIssuancePolicy using PUT and returns a <see cref="GraphResponse{TokenIssuancePolicy}"/> object.
        /// </summary>
        /// <param name="tokenIssuancePolicyToUpdate">The TokenIssuancePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{TokenIssuancePolicy}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TokenIssuancePolicy>> PutResponseAsync(TokenIssuancePolicy tokenIssuancePolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<TokenIssuancePolicy>(tokenIssuancePolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITokenIssuancePolicyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITokenIssuancePolicyRequest Expand(Expression<Func<TokenIssuancePolicy, object>> expandExpression)
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
        public ITokenIssuancePolicyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ITokenIssuancePolicyRequest Select(Expression<Func<TokenIssuancePolicy, object>> selectExpression)
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
        /// <param name="tokenIssuancePolicyToInitialize">The <see cref="TokenIssuancePolicy"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(TokenIssuancePolicy tokenIssuancePolicyToInitialize)
        {

        }
    }
}
