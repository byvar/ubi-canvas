using UnityEngine;

namespace UbiArt.ITF {
	public partial class CreditsDatum : CSerializable {
		[Serialize("text" )] public SmartLocId text;
		[Serialize("style")] public uint style;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(text));
			SerializeField(s, nameof(style));
		}
	}
}

