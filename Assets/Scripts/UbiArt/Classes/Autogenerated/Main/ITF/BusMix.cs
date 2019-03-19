using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class BusMix : CSerializable {
		[Serialize("StringID__0"     )] public StringID StringID__0;
		[Serialize("uint__1"         )] public uint uint__1;
		[Serialize("float__2"        )] public float float__2;
		[Serialize("float__3"        )] public float float__3;
		[Serialize("float__4"        )] public float float__4;
		[Serialize("CList<BusDef>__5")] public CList<BusDef> CList_BusDef__5;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StringID__0));
			SerializeField(s, nameof(uint__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(float__3));
			SerializeField(s, nameof(float__4));
			SerializeField(s, nameof(CList_BusDef__5));
		}
	}
}

