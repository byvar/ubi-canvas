using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_BossSequenceComponent : ActorComponent {
		[Serialize("bool__0"  )] public bool bool__0;
		[Serialize("Path__1"  )] public Path Path__1;
		[Serialize("Path__2"  )] public Path Path__2;
		[Serialize("Path__3"  )] public Path Path__3;
		[Serialize("uint__4"  )] public uint uint__4;
		[Serialize("float__5" )] public float float__5;
		[Serialize("float__6" )] public float float__6;
		[Serialize("float__7" )] public float float__7;
		[Serialize("float__8" )] public float float__8;
		[Serialize("float__9" )] public float float__9;
		[Serialize("float__10")] public float float__10;
		[Serialize("float__11")] public float float__11;
		[Serialize("float__12")] public float float__12;
		[Serialize("float__13")] public float float__13;
		[Serialize("float__14")] public float float__14;
		[Serialize("bool__15" )] public bool bool__15;
		[Serialize("uint__16" )] public uint uint__16;
		[Serialize("float__17")] public float float__17;
		[Serialize("float__18")] public float float__18;
		[Serialize("float__19")] public float float__19;
		[Serialize("uint__20" )] public uint uint__20;
		[Serialize("float__21")] public float float__21;
		[Serialize("float__22")] public float float__22;
		[Serialize("float__23")] public float float__23;
		[Serialize("float__24")] public float float__24;
		[Serialize("float__25")] public float float__25;
		[Serialize("uint__26" )] public uint uint__26;
		[Serialize("float__27")] public float float__27;
		[Serialize("float__28")] public float float__28;
		[Serialize("float__29")] public float float__29;
		[Serialize("float__30")] public float float__30;
		[Serialize("float__31")] public float float__31;
		[Serialize("uint__32" )] public uint uint__32;
		[Serialize("float__33")] public float float__33;
		[Serialize("float__34")] public float float__34;
		[Serialize("float__35")] public float float__35;
		[Serialize("bool__36" )] public bool bool__36;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__0));
			SerializeField(s, nameof(Path__1));
			SerializeField(s, nameof(Path__2));
			SerializeField(s, nameof(Path__3));
			SerializeField(s, nameof(uint__4));
			SerializeField(s, nameof(float__5));
			SerializeField(s, nameof(float__6));
			SerializeField(s, nameof(float__7));
			SerializeField(s, nameof(float__8));
			SerializeField(s, nameof(float__9));
			SerializeField(s, nameof(float__10));
			SerializeField(s, nameof(float__11));
			SerializeField(s, nameof(float__12));
			SerializeField(s, nameof(float__13));
			SerializeField(s, nameof(float__14));
			SerializeField(s, nameof(bool__15));
			SerializeField(s, nameof(uint__16));
			SerializeField(s, nameof(float__17));
			SerializeField(s, nameof(float__18));
			SerializeField(s, nameof(float__19));
			SerializeField(s, nameof(uint__20));
			SerializeField(s, nameof(float__21));
			SerializeField(s, nameof(float__22));
			SerializeField(s, nameof(float__23));
			SerializeField(s, nameof(float__24));
			SerializeField(s, nameof(float__25));
			SerializeField(s, nameof(uint__26));
			SerializeField(s, nameof(float__27));
			SerializeField(s, nameof(float__28));
			SerializeField(s, nameof(float__29));
			SerializeField(s, nameof(float__30));
			SerializeField(s, nameof(float__31));
			SerializeField(s, nameof(uint__32));
			SerializeField(s, nameof(float__33));
			SerializeField(s, nameof(float__34));
			SerializeField(s, nameof(float__35));
			SerializeField(s, nameof(bool__36));
		}
		public override uint? ClassCRC => 0x64536F79;
	}
}

