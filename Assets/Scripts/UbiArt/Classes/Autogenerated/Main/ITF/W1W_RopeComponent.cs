using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_RopeComponent : RopeComponent {
		[Serialize("float__0"   )] public float float__0;
		[Serialize("float__1"   )] public float float__1;
		[Serialize("float__2"   )] public float float__2;
		[Serialize("StringID__3")] public StringID StringID__3;
		[Serialize("float__4"   )] public float float__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(float__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(StringID__3));
				SerializeField(s, nameof(float__4));
			}
		}
		public override uint? ClassCRC => 0xD79EDA16;
	}
}

