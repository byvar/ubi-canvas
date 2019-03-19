using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class PieceData : CSerializable {
		[Serialize("Path__0"    )] public Path Path__0;
		[Serialize("StringID__1")] public StringID StringID__1;
		[Serialize("int__2"     )] public int int__2;
		[Serialize("int__3"     )] public int int__3;
		[Serialize("StringID__4")] public StringID StringID__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Path__0));
			SerializeField(s, nameof(StringID__1));
			SerializeField(s, nameof(int__2));
			SerializeField(s, nameof(int__3));
			SerializeField(s, nameof(StringID__4));
		}
	}
}

