using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_SpawnFxRand : ShapeComponent {
		[Serialize("StringID__0")] public StringID StringID__0;
		[Serialize("float__1"   )] public float float__1;
		[Serialize("float__2"   )] public float float__2;
		[Serialize("Path__3"    )] public Path Path__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StringID__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(Path__3));
		}
		public override uint? ClassCRC => 0x9614DB43;
	}
}

