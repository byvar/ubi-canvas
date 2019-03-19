using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventGameAndWatchSpawn : Event {
		[Serialize("Enum_VH_0__0")] public Enum_VH_0 Enum_VH_0__0;
		[Serialize("ushort__1"   )] public ushort ushort__1;
		[Serialize("float__2"    )] public float float__2;
		[Serialize("float__3"    )] public float float__3;
		[Serialize("float__4"    )] public float float__4;
		[Serialize("StringID__5" )] public StringID StringID__5;
		[Serialize("string__6"   )] public string string__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Enum_VH_0__0));
			SerializeField(s, nameof(ushort__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(float__3));
			SerializeField(s, nameof(float__4));
			SerializeField(s, nameof(StringID__5));
			SerializeField(s, nameof(string__6));
		}
		public enum Enum_VH_0 {
			[Serialize("Gameplay")] Gameplay = 0,
			[Serialize("Decor"   )] Decor = 1,
		}
		public override uint? ClassCRC => 0x27AF0B8A;
	}
}

