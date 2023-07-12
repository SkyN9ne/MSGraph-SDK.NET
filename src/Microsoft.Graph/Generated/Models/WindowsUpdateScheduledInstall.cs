using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class WindowsUpdateScheduledInstall : WindowsUpdateInstallScheduleType, IParsable {
        /// <summary>Possible values for a weekly schedule.</summary>
        public WeeklySchedule? ScheduledInstallDay {
            get { return BackingStore?.Get<WeeklySchedule?>("scheduledInstallDay"); }
            set { BackingStore?.Set("scheduledInstallDay", value); }
        }
        /// <summary>Scheduled Install Time during day</summary>
        public Time? ScheduledInstallTime {
            get { return BackingStore?.Get<Time?>("scheduledInstallTime"); }
            set { BackingStore?.Set("scheduledInstallTime", value); }
        }
        /// <summary>
        /// Instantiates a new windowsUpdateScheduledInstall and sets the default values.
        /// </summary>
        public WindowsUpdateScheduledInstall() : base() {
            OdataType = "#microsoft.graph.windowsUpdateScheduledInstall";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsUpdateScheduledInstall CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsUpdateScheduledInstall();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"scheduledInstallDay", n => { ScheduledInstallDay = n.GetEnumValue<WeeklySchedule>(); } },
                {"scheduledInstallTime", n => { ScheduledInstallTime = n.GetTimeValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<WeeklySchedule>("scheduledInstallDay", ScheduledInstallDay);
            writer.WriteTimeValue("scheduledInstallTime", ScheduledInstallTime);
        }
    }
}
