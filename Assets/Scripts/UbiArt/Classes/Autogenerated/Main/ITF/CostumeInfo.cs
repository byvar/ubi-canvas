using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class CostumeInfo : CSerializable {
		[Serialize("StringID__0")] public StringID StringID__0;
		[Serialize("uint__1"    )] public uint uint__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StringID__0));
			SerializeField(s, nameof(uint__1));
		}
	}
}

