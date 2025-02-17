// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class MailboxSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Folder ID of an archive folder for the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArchiveFolder {
            get { return BackingStore?.Get<string?>("archiveFolder"); }
            set { BackingStore?.Set("archiveFolder", value); }
        }
#nullable restore
#else
        public string ArchiveFolder {
            get { return BackingStore?.Get<string>("archiveFolder"); }
            set { BackingStore?.Set("archiveFolder", value); }
        }
#endif
        /// <summary>Configuration settings to automatically notify the sender of an incoming email with a message from the signed-in user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.AutomaticRepliesSetting? AutomaticRepliesSetting {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AutomaticRepliesSetting?>("automaticRepliesSetting"); }
            set { BackingStore?.Set("automaticRepliesSetting", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.AutomaticRepliesSetting AutomaticRepliesSetting {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AutomaticRepliesSetting>("automaticRepliesSetting"); }
            set { BackingStore?.Set("automaticRepliesSetting", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The date format for the user&apos;s mailbox.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DateFormat {
            get { return BackingStore?.Get<string?>("dateFormat"); }
            set { BackingStore?.Set("dateFormat", value); }
        }
#nullable restore
#else
        public string DateFormat {
            get { return BackingStore?.Get<string>("dateFormat"); }
            set { BackingStore?.Set("dateFormat", value); }
        }
#endif
        /// <summary>If the user has a calendar delegate, this specifies whether the delegate, mailbox owner, or both receive meeting messages and meeting responses. Possible values are: sendToDelegateAndInformationToPrincipal, sendToDelegateAndPrincipal, sendToDelegateOnly.</summary>
        public Microsoft.Graph.Models.DelegateMeetingMessageDeliveryOptions? DelegateMeetingMessageDeliveryOptions {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DelegateMeetingMessageDeliveryOptions?>("delegateMeetingMessageDeliveryOptions"); }
            set { BackingStore?.Set("delegateMeetingMessageDeliveryOptions", value); }
        }
        /// <summary>The locale information for the user, including the preferred language and country/region.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LocaleInfo? Language {
            get { return BackingStore?.Get<LocaleInfo?>("language"); }
            set { BackingStore?.Set("language", value); }
        }
#nullable restore
#else
        public LocaleInfo Language {
            get { return BackingStore?.Get<LocaleInfo>("language"); }
            set { BackingStore?.Set("language", value); }
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
        /// <summary>The time format for the user&apos;s mailbox.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeFormat {
            get { return BackingStore?.Get<string?>("timeFormat"); }
            set { BackingStore?.Set("timeFormat", value); }
        }
#nullable restore
#else
        public string TimeFormat {
            get { return BackingStore?.Get<string>("timeFormat"); }
            set { BackingStore?.Set("timeFormat", value); }
        }
#endif
        /// <summary>The default time zone for the user&apos;s mailbox.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeZone {
            get { return BackingStore?.Get<string?>("timeZone"); }
            set { BackingStore?.Set("timeZone", value); }
        }
#nullable restore
#else
        public string TimeZone {
            get { return BackingStore?.Get<string>("timeZone"); }
            set { BackingStore?.Set("timeZone", value); }
        }
#endif
        /// <summary>The purpose of the mailbox. Differentiates a mailbox for a single user from a shared mailbox and equipment mailbox in Exchange Online. Possible values are: user, linked, shared, room, equipment, others, unknownFutureValue. Read-only.</summary>
        public Microsoft.Graph.Models.UserPurpose? UserPurpose {
            get { return BackingStore?.Get<Microsoft.Graph.Models.UserPurpose?>("userPurpose"); }
            set { BackingStore?.Set("userPurpose", value); }
        }
        /// <summary>The days of the week and hours in a specific time zone that the user works.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.WorkingHours? WorkingHours {
            get { return BackingStore?.Get<Microsoft.Graph.Models.WorkingHours?>("workingHours"); }
            set { BackingStore?.Set("workingHours", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.WorkingHours WorkingHours {
            get { return BackingStore?.Get<Microsoft.Graph.Models.WorkingHours>("workingHours"); }
            set { BackingStore?.Set("workingHours", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new mailboxSettings and sets the default values.
        /// </summary>
        public MailboxSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MailboxSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MailboxSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"archiveFolder", n => { ArchiveFolder = n.GetStringValue(); } },
                {"automaticRepliesSetting", n => { AutomaticRepliesSetting = n.GetObjectValue<Microsoft.Graph.Models.AutomaticRepliesSetting>(Microsoft.Graph.Models.AutomaticRepliesSetting.CreateFromDiscriminatorValue); } },
                {"dateFormat", n => { DateFormat = n.GetStringValue(); } },
                {"delegateMeetingMessageDeliveryOptions", n => { DelegateMeetingMessageDeliveryOptions = n.GetEnumValue<DelegateMeetingMessageDeliveryOptions>(); } },
                {"language", n => { Language = n.GetObjectValue<LocaleInfo>(LocaleInfo.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"timeFormat", n => { TimeFormat = n.GetStringValue(); } },
                {"timeZone", n => { TimeZone = n.GetStringValue(); } },
                {"userPurpose", n => { UserPurpose = n.GetEnumValue<UserPurpose>(); } },
                {"workingHours", n => { WorkingHours = n.GetObjectValue<Microsoft.Graph.Models.WorkingHours>(Microsoft.Graph.Models.WorkingHours.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("archiveFolder", ArchiveFolder);
            writer.WriteObjectValue<Microsoft.Graph.Models.AutomaticRepliesSetting>("automaticRepliesSetting", AutomaticRepliesSetting);
            writer.WriteStringValue("dateFormat", DateFormat);
            writer.WriteEnumValue<DelegateMeetingMessageDeliveryOptions>("delegateMeetingMessageDeliveryOptions", DelegateMeetingMessageDeliveryOptions);
            writer.WriteObjectValue<LocaleInfo>("language", Language);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("timeFormat", TimeFormat);
            writer.WriteStringValue("timeZone", TimeZone);
            writer.WriteEnumValue<UserPurpose>("userPurpose", UserPurpose);
            writer.WriteObjectValue<Microsoft.Graph.Models.WorkingHours>("workingHours", WorkingHours);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
