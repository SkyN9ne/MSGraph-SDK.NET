using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class SynchronizationSchedule : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Date and time when this job will expire. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? Expiration {
            get { return BackingStore?.Get<DateTimeOffset?>("expiration"); }
            set { BackingStore?.Set("expiration", value); }
        }
        /// <summary>The interval between synchronization iterations. The value is represented in ISO 8601 format for durations. For example, PT1M represents a period of 1 month.</summary>
        public TimeSpan? Interval {
            get { return BackingStore?.Get<TimeSpan?>("interval"); }
            set { BackingStore?.Set("interval", value); }
        }
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
        /// <summary>The state property</summary>
        public SynchronizationScheduleState? State {
            get { return BackingStore?.Get<SynchronizationScheduleState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Instantiates a new synchronizationSchedule and sets the default values.
        /// </summary>
        public SynchronizationSchedule() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SynchronizationSchedule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationSchedule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"expiration", n => { Expiration = n.GetDateTimeOffsetValue(); } },
                {"interval", n => { Interval = n.GetTimeSpanValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<SynchronizationScheduleState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("expiration", Expiration);
            writer.WriteTimeSpanValue("interval", Interval);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<SynchronizationScheduleState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
