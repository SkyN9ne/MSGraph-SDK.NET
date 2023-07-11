using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    public class EdiscoveryReviewSet : DataSet, IParsable {
        /// <summary>Represents queries within the review set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EdiscoveryReviewSetQuery>? Queries {
            get { return BackingStore?.Get<List<EdiscoveryReviewSetQuery>?>("queries"); }
            set { BackingStore?.Set("queries", value); }
        }
#nullable restore
#else
        public List<EdiscoveryReviewSetQuery> Queries {
            get { return BackingStore?.Get<List<EdiscoveryReviewSetQuery>>("queries"); }
            set { BackingStore?.Set("queries", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new ediscoveryReviewSet and sets the default values.
        /// </summary>
        public EdiscoveryReviewSet() : base() {
            OdataType = "#microsoft.graph.security.ediscoveryReviewSet";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EdiscoveryReviewSet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdiscoveryReviewSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"queries", n => { Queries = n.GetCollectionOfObjectValues<EdiscoveryReviewSetQuery>(EdiscoveryReviewSetQuery.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<EdiscoveryReviewSetQuery>("queries", Queries);
        }
    }
}
