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
    /// The type EducationSchoolRequest.
    /// </summary>
    public partial class EducationSchoolRequest : BaseRequest, IEducationSchoolRequest
    {
        /// <summary>
        /// Constructs a new EducationSchoolRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EducationSchoolRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified EducationSchool using POST.
        /// </summary>
        /// <param name="educationSchoolToCreate">The EducationSchool to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationSchool.</returns>
        public async System.Threading.Tasks.Task<EducationSchool> CreateAsync(EducationSchool educationSchoolToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<EducationSchool>(educationSchoolToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified EducationSchool using POST and returns a <see cref="GraphResponse{EducationSchool}"/> object.
        /// </summary>
        /// <param name="educationSchoolToCreate">The EducationSchool to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationSchool}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EducationSchool>> CreateResponseAsync(EducationSchool educationSchoolToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<EducationSchool>(educationSchoolToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified EducationSchool.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<EducationSchool>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EducationSchool and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified EducationSchool.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationSchool.</returns>
        public async System.Threading.Tasks.Task<EducationSchool> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<EducationSchool>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified EducationSchool and returns a <see cref="GraphResponse{EducationSchool}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationSchool}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EducationSchool>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<EducationSchool>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EducationSchool using PATCH.
        /// </summary>
        /// <param name="educationSchoolToUpdate">The EducationSchool to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EducationSchool.</returns>
        public async System.Threading.Tasks.Task<EducationSchool> UpdateAsync(EducationSchool educationSchoolToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<EducationSchool>(educationSchoolToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EducationSchool using PATCH and returns a <see cref="GraphResponse{EducationSchool}"/> object.
        /// </summary>
        /// <param name="educationSchoolToUpdate">The EducationSchool to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EducationSchool}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EducationSchool>> UpdateResponseAsync(EducationSchool educationSchoolToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<EducationSchool>(educationSchoolToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EducationSchool using PUT.
        /// </summary>
        /// <param name="educationSchoolToUpdate">The EducationSchool object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<EducationSchool> PutAsync(EducationSchool educationSchoolToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<EducationSchool>(educationSchoolToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EducationSchool using PUT and returns a <see cref="GraphResponse{EducationSchool}"/> object.
        /// </summary>
        /// <param name="educationSchoolToUpdate">The EducationSchool object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{EducationSchool}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EducationSchool>> PutResponseAsync(EducationSchool educationSchoolToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<EducationSchool>(educationSchoolToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationSchoolRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationSchoolRequest Expand(Expression<Func<EducationSchool, object>> expandExpression)
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
        public IEducationSchoolRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationSchoolRequest Select(Expression<Func<EducationSchool, object>> selectExpression)
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
        /// <param name="educationSchoolToInitialize">The <see cref="EducationSchool"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(EducationSchool educationSchoolToInitialize)
        {

            if (educationSchoolToInitialize != null)
            {
                if (educationSchoolToInitialize.Classes != null && educationSchoolToInitialize.Classes.CurrentPage != null)
                {
                    educationSchoolToInitialize.Classes.InitializeNextPageRequest(this.Client, educationSchoolToInitialize.ClassesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    educationSchoolToInitialize.Classes.AdditionalData = educationSchoolToInitialize.AdditionalData;
                }
                if (educationSchoolToInitialize.Users != null && educationSchoolToInitialize.Users.CurrentPage != null)
                {
                    educationSchoolToInitialize.Users.InitializeNextPageRequest(this.Client, educationSchoolToInitialize.UsersNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    educationSchoolToInitialize.Users.AdditionalData = educationSchoolToInitialize.AdditionalData;
                }

            }


        }
    }
}
