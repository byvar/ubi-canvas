using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_BasculePlatformComponent_Template : ActorComponent_Template {
		[Serialize("StringID__0" )] public StringID StringID__0;
		[Serialize("StringID__1" )] public StringID StringID__1;
		[Serialize("Angle__2"    )] public Angle Angle__2;
		[Serialize("float__3"    )] public float float__3;
		[Serialize("float__4"    )] public float float__4;
		[Serialize("float__5"    )] public float float__5;
		[Serialize("float__6"    )] public float float__6;
		[Serialize("float__7"    )] public float float__7;
		[Serialize("float__8"    )] public float float__8;
		[Serialize("StringID__9" )] public StringID StringID__9;
		[Serialize("StringID__10")] public StringID StringID__10;
		[Serialize("StringID__11")] public StringID StringID__11;
		[Serialize("StringID__12")] public StringID StringID__12;
		[Serialize("Angle__13"   )] public Angle Angle__13;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StringID__0));
			SerializeField(s, nameof(StringID__1));
			SerializeField(s, nameof(Angle__2));
			SerializeField(s, nameof(float__3));
			SerializeField(s, nameof(float__4));
			SerializeField(s, nameof(float__5));
			SerializeField(s, nameof(float__6));
			SerializeField(s, nameof(float__7));
			SerializeField(s, nameof(float__8));
			SerializeField(s, nameof(StringID__9));
			SerializeField(s, nameof(StringID__10));
			SerializeField(s, nameof(StringID__11));
			SerializeField(s, nameof(StringID__12));
			SerializeField(s, nameof(Angle__13));
		}
		public override uint? ClassCRC => 0xB91AC03E;
	}
}

