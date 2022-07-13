using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Me.ManagedDevices.Item.UpdateWindowsDeviceAccount {
    /// <summary>Provides operations to call the updateWindowsDeviceAccount method.</summary>
    public class UpdateWindowsDeviceAccountPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The updateWindowsDeviceAccountActionParameter property</summary>
        public Microsoft.Graph.Models.UpdateWindowsDeviceAccountActionParameter UpdateWindowsDeviceAccountActionParameter {
            get { return BackingStore?.Get<Microsoft.Graph.Models.UpdateWindowsDeviceAccountActionParameter>("updateWindowsDeviceAccountActionParameter"); }
            set { BackingStore?.Set("updateWindowsDeviceAccountActionParameter", value); }
        }
        /// <summary>
        /// Instantiates a new updateWindowsDeviceAccountPostRequestBody and sets the default values.
        /// </summary>
        public UpdateWindowsDeviceAccountPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UpdateWindowsDeviceAccountPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateWindowsDeviceAccountPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"updateWindowsDeviceAccountActionParameter", n => { UpdateWindowsDeviceAccountActionParameter = n.GetObjectValue<Microsoft.Graph.Models.UpdateWindowsDeviceAccountActionParameter>(Microsoft.Graph.Models.UpdateWindowsDeviceAccountActionParameter.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Models.UpdateWindowsDeviceAccountActionParameter>("updateWindowsDeviceAccountActionParameter", UpdateWindowsDeviceAccountActionParameter);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
