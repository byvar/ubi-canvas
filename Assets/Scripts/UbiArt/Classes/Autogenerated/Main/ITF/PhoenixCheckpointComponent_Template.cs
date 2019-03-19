using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class PhoenixCheckpointComponent_Template : CSerializable {
		[Serialize("StringID__0")] public StringID StringID__0;
		[Serialize("StringID__1")] public StringID StringID__1;
		[Serialize("StringID__2")] public StringID StringID__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StringID__0));
			SerializeField(s, nameof(StringID__1));
			SerializeField(s, nameof(StringID__2));
		}
		public override uint? ClassCRC => 0x61104501;
	}
}

