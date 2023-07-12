using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class UserRegistrationDetails : Entity, IParsable {
        /// <summary>Indicates whether the user has an admin role in the tenant. This value can be used to check the authentication methods that privileged accounts are registered for and capable of.</summary>
        public bool? IsAdmin {
            get { return BackingStore?.Get<bool?>("isAdmin"); }
            set { BackingStore?.Set("isAdmin", value); }
        }
        /// <summary>Indicates whether the user has registered a strong authentication method for multi-factor authentication. The method must be allowed by the authentication methods policy. Supports $filter (eq).</summary>
        public bool? IsMfaCapable {
            get { return BackingStore?.Get<bool?>("isMfaCapable"); }
            set { BackingStore?.Set("isMfaCapable", value); }
        }
        /// <summary>Indicates whether the user has registered a strong authentication method for multi-factor authentication. The method may not necessarily be allowed by the authentication methods policy. Supports $filter (eq).</summary>
        public bool? IsMfaRegistered {
            get { return BackingStore?.Get<bool?>("isMfaRegistered"); }
            set { BackingStore?.Set("isMfaRegistered", value); }
        }
        /// <summary>Indicates whether the user has registered a passwordless strong authentication method (including FIDO2, Windows Hello for Business, and Microsoft Authenticator (Passwordless)) that is allowed by the authentication methods policy. Supports $filter (eq).</summary>
        public bool? IsPasswordlessCapable {
            get { return BackingStore?.Get<bool?>("isPasswordlessCapable"); }
            set { BackingStore?.Set("isPasswordlessCapable", value); }
        }
        /// <summary>Indicates whether the user has registered the required number of authentication methods for self-service password reset and the user is allowed to perform self-service password reset by policy. Supports $filter (eq).</summary>
        public bool? IsSsprCapable {
            get { return BackingStore?.Get<bool?>("isSsprCapable"); }
            set { BackingStore?.Set("isSsprCapable", value); }
        }
        /// <summary>Indicates whether the user is allowed to perform self-service password reset by policy. The user may not necessarily have registered the required number of authentication methods for self-service password reset. Supports $filter (eq).</summary>
        public bool? IsSsprEnabled {
            get { return BackingStore?.Get<bool?>("isSsprEnabled"); }
            set { BackingStore?.Set("isSsprEnabled", value); }
        }
        /// <summary>Indicates whether the user has registered the required number of authentication methods for self-service password reset. The user may not necessarily be allowed to perform self-service password reset by policy. Supports $filter (eq).</summary>
        public bool? IsSsprRegistered {
            get { return BackingStore?.Get<bool?>("isSsprRegistered"); }
            set { BackingStore?.Set("isSsprRegistered", value); }
        }
        /// <summary>Indicates whether system preferred authentication method is enabled. If enabled, the system dynamically determines the most secure authentication method among the methods registered by the user. Supports $filter (eq).</summary>
        public bool? IsSystemPreferredAuthenticationMethodEnabled {
            get { return BackingStore?.Get<bool?>("isSystemPreferredAuthenticationMethodEnabled"); }
            set { BackingStore?.Set("isSystemPreferredAuthenticationMethodEnabled", value); }
        }
        /// <summary>The date and time (UTC) when the record was last updated. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>Collection of authentication methods registered, such as mobilePhone, email, fido2. Supports $filter (any with eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MethodsRegistered {
            get { return BackingStore?.Get<List<string>?>("methodsRegistered"); }
            set { BackingStore?.Set("methodsRegistered", value); }
        }
#nullable restore
#else
        public List<string> MethodsRegistered {
            get { return BackingStore?.Get<List<string>>("methodsRegistered"); }
            set { BackingStore?.Set("methodsRegistered", value); }
        }
#endif
        /// <summary>Collection of authentication methods that the system determined to be the most secure authentication methods among the registered methods for second factor authentication. Possible values are: push, oath, voiceMobile, voiceAlternateMobile, voiceOffice, sms, none, unknownFutureValue. Supports $filter (any with eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SystemPreferredAuthenticationMethods {
            get { return BackingStore?.Get<List<string>?>("systemPreferredAuthenticationMethods"); }
            set { BackingStore?.Set("systemPreferredAuthenticationMethods", value); }
        }
#nullable restore
#else
        public List<string> SystemPreferredAuthenticationMethods {
            get { return BackingStore?.Get<List<string>>("systemPreferredAuthenticationMethods"); }
            set { BackingStore?.Set("systemPreferredAuthenticationMethods", value); }
        }
#endif
        /// <summary>The user display name, such as Adele Vance. Supports $filter (eq, startsWith) and $orderBy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserDisplayName {
            get { return BackingStore?.Get<string?>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
#nullable restore
#else
        public string UserDisplayName {
            get { return BackingStore?.Get<string>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
#endif
        /// <summary>The method the user selected as the default second-factor for performing multi-factor authentication. Possible values are: push, oath, voiceMobile, voiceAlternateMobile, voiceOffice, sms, none, unknownFutureValue. This property is used as preferred MFA method when isSystemPreferredAuthenticationMethodEnabled is false. Supports $filter (any with eq).</summary>
        public UserDefaultAuthenticationMethod? UserPreferredMethodForSecondaryAuthentication {
            get { return BackingStore?.Get<UserDefaultAuthenticationMethod?>("userPreferredMethodForSecondaryAuthentication"); }
            set { BackingStore?.Set("userPreferredMethodForSecondaryAuthentication", value); }
        }
        /// <summary>The user principal name, such as AdeleV@contoso.com. Supports $filter (eq, startsWith) and $orderBy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>Identifies whether the user is a member or guest in the tenant. The possible values are: member, guest, unknownFutureValue.</summary>
        public SignInUserType? UserType {
            get { return BackingStore?.Get<SignInUserType?>("userType"); }
            set { BackingStore?.Set("userType", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserRegistrationDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserRegistrationDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"isAdmin", n => { IsAdmin = n.GetBoolValue(); } },
                {"isMfaCapable", n => { IsMfaCapable = n.GetBoolValue(); } },
                {"isMfaRegistered", n => { IsMfaRegistered = n.GetBoolValue(); } },
                {"isPasswordlessCapable", n => { IsPasswordlessCapable = n.GetBoolValue(); } },
                {"isSsprCapable", n => { IsSsprCapable = n.GetBoolValue(); } },
                {"isSsprEnabled", n => { IsSsprEnabled = n.GetBoolValue(); } },
                {"isSsprRegistered", n => { IsSsprRegistered = n.GetBoolValue(); } },
                {"isSystemPreferredAuthenticationMethodEnabled", n => { IsSystemPreferredAuthenticationMethodEnabled = n.GetBoolValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"methodsRegistered", n => { MethodsRegistered = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"systemPreferredAuthenticationMethods", n => { SystemPreferredAuthenticationMethods = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userPreferredMethodForSecondaryAuthentication", n => { UserPreferredMethodForSecondaryAuthentication = n.GetEnumValue<UserDefaultAuthenticationMethod>(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"userType", n => { UserType = n.GetEnumValue<SignInUserType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isAdmin", IsAdmin);
            writer.WriteBoolValue("isMfaCapable", IsMfaCapable);
            writer.WriteBoolValue("isMfaRegistered", IsMfaRegistered);
            writer.WriteBoolValue("isPasswordlessCapable", IsPasswordlessCapable);
            writer.WriteBoolValue("isSsprCapable", IsSsprCapable);
            writer.WriteBoolValue("isSsprEnabled", IsSsprEnabled);
            writer.WriteBoolValue("isSsprRegistered", IsSsprRegistered);
            writer.WriteBoolValue("isSystemPreferredAuthenticationMethodEnabled", IsSystemPreferredAuthenticationMethodEnabled);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("methodsRegistered", MethodsRegistered);
            writer.WriteCollectionOfPrimitiveValues<string>("systemPreferredAuthenticationMethods", SystemPreferredAuthenticationMethods);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteEnumValue<UserDefaultAuthenticationMethod>("userPreferredMethodForSecondaryAuthentication", UserPreferredMethodForSecondaryAuthentication);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteEnumValue<SignInUserType>("userType", UserType);
        }
    }
}
