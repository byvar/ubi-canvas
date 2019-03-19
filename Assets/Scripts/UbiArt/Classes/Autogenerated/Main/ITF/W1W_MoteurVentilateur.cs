using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_MoteurVentilateur : ActorComponent {
		[Serialize("bool__0"    )] public bool bool__0;
		[Serialize("float__1"   )] public float float__1;
		[Serialize("float__2"   )] public float float__2;
		[Serialize("StringID__3")] public StringID StringID__3;
		[Serialize("StringID__4")] public StringID StringID__4;
		[Serialize("StringID__5")] public StringID StringID__5;
		[Serialize("float__6"   )] public float float__6;
		[Serialize("float__7"   )] public float float__7;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(StringID__3));
			SerializeField(s, nameof(StringID__4));
			SerializeField(s, nameof(StringID__5));
			SerializeField(s, nameof(float__6));
			SerializeField(s, nameof(float__7));
		}
		public override uint? ClassCRC => 0x9342C7BD;
	}
}

