// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type PrinterBaseJobsCollectionRequestBuilder.
    /// </summary>
    public partial class PrinterBaseJobsCollectionRequestBuilder : BaseRequestBuilder, IPrinterBaseJobsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new PrinterBaseJobsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PrinterBaseJobsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IPrinterBaseJobsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IPrinterBaseJobsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new PrinterBaseJobsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IPrintJobRequestBuilder"/> for the specified PrinterBasePrintJob.
        /// </summary>
        /// <param name="id">The ID for the PrinterBasePrintJob.</param>
        /// <returns>The <see cref="IPrintJobRequestBuilder"/>.</returns>
        public IPrintJobRequestBuilder this[string id]
        {
            get
            {
                return new PrintJobRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
