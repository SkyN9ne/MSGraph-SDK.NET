using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class DirectoryDefinition : Entity, IParsable {
        /// <summary>The discoverabilities property</summary>
        public DirectoryDefinitionDiscoverabilities? Discoverabilities {
            get { return BackingStore?.Get<DirectoryDefinitionDiscoverabilities?>("discoverabilities"); }
            set { BackingStore?.Set("discoverabilities", value); }
        }
        /// <summary>Represents the discovery date and time using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? DiscoveryDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("discoveryDateTime"); }
            set { BackingStore?.Set("discoveryDateTime", value); }
        }
        /// <summary>Name of the directory. Must be unique within the synchronization schema. Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>Collection of objects supported by the directory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ObjectDefinition>? Objects {
            get { return BackingStore?.Get<List<ObjectDefinition>?>("objects"); }
            set { BackingStore?.Set("objects", value); }
        }
#nullable restore
#else
        public List<ObjectDefinition> Objects {
            get { return BackingStore?.Get<List<ObjectDefinition>>("objects"); }
            set { BackingStore?.Set("objects", value); }
        }
#endif
        /// <summary>Whether this object is read-only.</summary>
        public bool? ReadOnly {
            get { return BackingStore?.Get<bool?>("readOnly"); }
            set { BackingStore?.Set("readOnly", value); }
        }
        /// <summary>Read only value that indicates version discovered. null if discovery has not yet occurred.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DirectoryDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DirectoryDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"discoverabilities", n => { Discoverabilities = n.GetEnumValue<DirectoryDefinitionDiscoverabilities>(); } },
                {"discoveryDateTime", n => { DiscoveryDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"objects", n => { Objects = n.GetCollectionOfObjectValues<ObjectDefinition>(ObjectDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"readOnly", n => { ReadOnly = n.GetBoolValue(); } },
                {"version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DirectoryDefinitionDiscoverabilities>("discoverabilities", Discoverabilities);
            writer.WriteDateTimeOffsetValue("discoveryDateTime", DiscoveryDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<ObjectDefinition>("objects", Objects);
            writer.WriteBoolValue("readOnly", ReadOnly);
            writer.WriteStringValue("version", Version);
        }
    }
}
