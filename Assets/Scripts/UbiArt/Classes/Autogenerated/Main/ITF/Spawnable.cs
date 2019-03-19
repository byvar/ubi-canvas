using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class Spawnable : CSerializable {
		[Serialize("StringID__0")] public StringID StringID__0;
		[Serialize("Path__1"    )] public Path Path__1;
		[Serialize("int__2"     )] public int int__2;
		[Serialize("Vector3__3" )] public Vector3 Vector3__3;
		[Serialize("Angle__4"   )] public Angle Angle__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StringID__0));
			SerializeField(s, nameof(Path__1));
			SerializeField(s, nameof(int__2));
			SerializeField(s, nameof(Vector3__3));
			SerializeField(s, nameof(Angle__4));
		}
	}
}

