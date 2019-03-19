using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class BodyPartActorRenderer_Template : CSerializable {
		[Serialize("Path__0"    )] public Path Path__0;
		[Serialize("StringID__1")] public StringID StringID__1;
		[Serialize("StringID__2")] public StringID StringID__2;
		[Serialize("StringID__3")] public StringID StringID__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Path__0));
			SerializeField(s, nameof(StringID__1));
			SerializeField(s, nameof(StringID__2));
			SerializeField(s, nameof(StringID__3));
		}
	}
}

