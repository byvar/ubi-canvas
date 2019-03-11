using UnityEngine;

namespace UbiArt.ITF {
	public partial class QuoteCondition : CSerializable {
		[Serialize("Type" )] public StringID Type;
		[Serialize("Value")] public uint Value;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Type));
			SerializeField(s, nameof(Value));
		}
	}
}

