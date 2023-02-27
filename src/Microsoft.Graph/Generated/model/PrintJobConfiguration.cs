// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type PrintJobConfiguration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PrintJobConfiguration>))]
    public partial class PrintJobConfiguration
    {

        /// <summary>
        /// Gets or sets collate.
        /// Whether the printer should collate pages wehen printing multiple copies of a multi-page document.
        /// </summary>
        [JsonPropertyName("collate")]
        public bool? Collate { get; set; }
    
        /// <summary>
        /// Gets or sets colorMode.
        /// The color mode the printer should use to print the job. Valid values are described in the table below. Read-only.
        /// </summary>
        [JsonPropertyName("colorMode")]
        public PrintColorMode? ColorMode { get; set; }
    
        /// <summary>
        /// Gets or sets copies.
        /// The number of copies that should be printed. Read-only.
        /// </summary>
        [JsonPropertyName("copies")]
        public Int32? Copies { get; set; }
    
        /// <summary>
        /// Gets or sets dpi.
        /// The resolution to use when printing the job, expressed in dots per inch (DPI). Read-only.
        /// </summary>
        [JsonPropertyName("dpi")]
        public Int32? Dpi { get; set; }
    
        /// <summary>
        /// Gets or sets duplexMode.
        /// The duplex mode the printer should use when printing the job. Valid values are described in the table below. Read-only.
        /// </summary>
        [JsonPropertyName("duplexMode")]
        public PrintDuplexMode? DuplexMode { get; set; }
    
        /// <summary>
        /// Gets or sets feedOrientation.
        /// The orientation to use when feeding media into the printer. Valid values are described in the following table. Read-only.
        /// </summary>
        [JsonPropertyName("feedOrientation")]
        public PrinterFeedOrientation? FeedOrientation { get; set; }
    
        /// <summary>
        /// Gets or sets finishings.
        /// Finishing processes to use when printing.
        /// </summary>
        [JsonPropertyName("finishings")]
        public IEnumerable<PrintFinishing> Finishings { get; set; }
    
        /// <summary>
        /// Gets or sets fitPdfToPage.
        /// </summary>
        [JsonPropertyName("fitPdfToPage")]
        public bool? FitPdfToPage { get; set; }
    
        /// <summary>
        /// Gets or sets inputBin.
        /// The input bin (tray) to use when printing. See the printer's capabilities for a list of supported input bins.
        /// </summary>
        [JsonPropertyName("inputBin")]
        public string InputBin { get; set; }
    
        /// <summary>
        /// Gets or sets margin.
        /// The margin settings to use when printing.
        /// </summary>
        [JsonPropertyName("margin")]
        public PrintMargin Margin { get; set; }
    
        /// <summary>
        /// Gets or sets mediaSize.
        /// The media size to use when printing. Supports standard size names for ISO and ANSI media sizes.
        /// </summary>
        [JsonPropertyName("mediaSize")]
        public string MediaSize { get; set; }
    
        /// <summary>
        /// Gets or sets mediaType.
        /// </summary>
        [JsonPropertyName("mediaType")]
        public string MediaType { get; set; }
    
        /// <summary>
        /// Gets or sets multipageLayout.
        /// </summary>
        [JsonPropertyName("multipageLayout")]
        public PrintMultipageLayout? MultipageLayout { get; set; }
    
        /// <summary>
        /// Gets or sets orientation.
        /// </summary>
        [JsonPropertyName("orientation")]
        public PrintOrientation? Orientation { get; set; }
    
        /// <summary>
        /// Gets or sets outputBin.
        /// </summary>
        [JsonPropertyName("outputBin")]
        public string OutputBin { get; set; }
    
        /// <summary>
        /// Gets or sets pageRanges.
        /// </summary>
        [JsonPropertyName("pageRanges")]
        public IEnumerable<IntegerRange> PageRanges { get; set; }
    
        /// <summary>
        /// Gets or sets pagesPerSheet.
        /// </summary>
        [JsonPropertyName("pagesPerSheet")]
        public Int32? PagesPerSheet { get; set; }
    
        /// <summary>
        /// Gets or sets quality.
        /// </summary>
        [JsonPropertyName("quality")]
        public PrintQuality? Quality { get; set; }
    
        /// <summary>
        /// Gets or sets scaling.
        /// </summary>
        [JsonPropertyName("scaling")]
        public PrintScaling? Scaling { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
