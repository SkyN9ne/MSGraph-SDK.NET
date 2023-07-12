using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class ReportRoot : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Container for navigation properties for Azure AD authentication methods resources.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AuthenticationMethodsRoot? AuthenticationMethods {
            get { return BackingStore?.Get<AuthenticationMethodsRoot?>("authenticationMethods"); }
            set { BackingStore?.Set("authenticationMethods", value); }
        }
#nullable restore
#else
        public AuthenticationMethodsRoot AuthenticationMethods {
            get { return BackingStore?.Get<AuthenticationMethodsRoot>("authenticationMethods"); }
            set { BackingStore?.Set("authenticationMethods", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Retrieve a list of daily print usage summaries, grouped by printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintUsageByPrinter>? DailyPrintUsageByPrinter {
            get { return BackingStore?.Get<List<PrintUsageByPrinter>?>("dailyPrintUsageByPrinter"); }
            set { BackingStore?.Set("dailyPrintUsageByPrinter", value); }
        }
#nullable restore
#else
        public List<PrintUsageByPrinter> DailyPrintUsageByPrinter {
            get { return BackingStore?.Get<List<PrintUsageByPrinter>>("dailyPrintUsageByPrinter"); }
            set { BackingStore?.Set("dailyPrintUsageByPrinter", value); }
        }
#endif
        /// <summary>Retrieve a list of daily print usage summaries, grouped by user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintUsageByUser>? DailyPrintUsageByUser {
            get { return BackingStore?.Get<List<PrintUsageByUser>?>("dailyPrintUsageByUser"); }
            set { BackingStore?.Set("dailyPrintUsageByUser", value); }
        }
#nullable restore
#else
        public List<PrintUsageByUser> DailyPrintUsageByUser {
            get { return BackingStore?.Get<List<PrintUsageByUser>>("dailyPrintUsageByUser"); }
            set { BackingStore?.Set("dailyPrintUsageByUser", value); }
        }
#endif
        /// <summary>Retrieve a list of monthly print usage summaries, grouped by printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintUsageByPrinter>? MonthlyPrintUsageByPrinter {
            get { return BackingStore?.Get<List<PrintUsageByPrinter>?>("monthlyPrintUsageByPrinter"); }
            set { BackingStore?.Set("monthlyPrintUsageByPrinter", value); }
        }
#nullable restore
#else
        public List<PrintUsageByPrinter> MonthlyPrintUsageByPrinter {
            get { return BackingStore?.Get<List<PrintUsageByPrinter>>("monthlyPrintUsageByPrinter"); }
            set { BackingStore?.Set("monthlyPrintUsageByPrinter", value); }
        }
#endif
        /// <summary>Retrieve a list of monthly print usage summaries, grouped by user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintUsageByUser>? MonthlyPrintUsageByUser {
            get { return BackingStore?.Get<List<PrintUsageByUser>?>("monthlyPrintUsageByUser"); }
            set { BackingStore?.Set("monthlyPrintUsageByUser", value); }
        }
#nullable restore
#else
        public List<PrintUsageByUser> MonthlyPrintUsageByUser {
            get { return BackingStore?.Get<List<PrintUsageByUser>>("monthlyPrintUsageByUser"); }
            set { BackingStore?.Set("monthlyPrintUsageByUser", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Represents an abstract type that contains resources for attack simulation and training reports.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SecurityReportsRoot? Security {
            get { return BackingStore?.Get<SecurityReportsRoot?>("security"); }
            set { BackingStore?.Set("security", value); }
        }
#nullable restore
#else
        public SecurityReportsRoot Security {
            get { return BackingStore?.Get<SecurityReportsRoot>("security"); }
            set { BackingStore?.Set("security", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new reportRoot and sets the default values.
        /// </summary>
        public ReportRoot() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ReportRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReportRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"authenticationMethods", n => { AuthenticationMethods = n.GetObjectValue<AuthenticationMethodsRoot>(AuthenticationMethodsRoot.CreateFromDiscriminatorValue); } },
                {"dailyPrintUsageByPrinter", n => { DailyPrintUsageByPrinter = n.GetCollectionOfObjectValues<PrintUsageByPrinter>(PrintUsageByPrinter.CreateFromDiscriminatorValue)?.ToList(); } },
                {"dailyPrintUsageByUser", n => { DailyPrintUsageByUser = n.GetCollectionOfObjectValues<PrintUsageByUser>(PrintUsageByUser.CreateFromDiscriminatorValue)?.ToList(); } },
                {"monthlyPrintUsageByPrinter", n => { MonthlyPrintUsageByPrinter = n.GetCollectionOfObjectValues<PrintUsageByPrinter>(PrintUsageByPrinter.CreateFromDiscriminatorValue)?.ToList(); } },
                {"monthlyPrintUsageByUser", n => { MonthlyPrintUsageByUser = n.GetCollectionOfObjectValues<PrintUsageByUser>(PrintUsageByUser.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"security", n => { Security = n.GetObjectValue<SecurityReportsRoot>(SecurityReportsRoot.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<AuthenticationMethodsRoot>("authenticationMethods", AuthenticationMethods);
            writer.WriteCollectionOfObjectValues<PrintUsageByPrinter>("dailyPrintUsageByPrinter", DailyPrintUsageByPrinter);
            writer.WriteCollectionOfObjectValues<PrintUsageByUser>("dailyPrintUsageByUser", DailyPrintUsageByUser);
            writer.WriteCollectionOfObjectValues<PrintUsageByPrinter>("monthlyPrintUsageByPrinter", MonthlyPrintUsageByPrinter);
            writer.WriteCollectionOfObjectValues<PrintUsageByUser>("monthlyPrintUsageByUser", MonthlyPrintUsageByUser);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<SecurityReportsRoot>("security", Security);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
