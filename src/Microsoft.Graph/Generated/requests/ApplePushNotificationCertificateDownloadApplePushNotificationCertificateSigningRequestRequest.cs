// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type ApplePushNotificationCertificateDownloadApplePushNotificationCertificateSigningRequestRequest.
    /// </summary>
    public partial class ApplePushNotificationCertificateDownloadApplePushNotificationCertificateSigningRequestRequest : BaseRequest, IApplePushNotificationCertificateDownloadApplePushNotificationCertificateSigningRequestRequest
    {
        /// <summary>
        /// Constructs a new ApplePushNotificationCertificateDownloadApplePushNotificationCertificateSigningRequestRequest.
        /// </summary>
        public ApplePushNotificationCertificateDownloadApplePushNotificationCertificateSigningRequestRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public async System.Threading.Tasks.Task<string> GetAsync(
            CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var response = await this.SendAsync<ODataMethodStringResponse>(null, cancellationToken);
            return response.Value;
        }

        /// <summary>
        /// Issues the GET request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public System.Threading.Tasks.Task<GraphResponse<ODataMethodStringResponse>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ODataMethodStringResponse>(null, cancellationToken);
        }


        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IApplePushNotificationCertificateDownloadApplePushNotificationCertificateSigningRequestRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IApplePushNotificationCertificateDownloadApplePushNotificationCertificateSigningRequestRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }
    }
}
