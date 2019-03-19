using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Vehicle : W1W_InteractiveGenComponent {
		[Serialize("uint__0"        )] public uint uint__0;
		[Serialize("bool__1"        )] public bool bool__1;
		[Serialize("Enum_VH_0__2"   )] public Enum_VH_0 Enum_VH_0__2;
		[Serialize("bool__3"        )] public bool bool__3;
		[Serialize("bool__4"        )] public bool bool__4;
		[Serialize("bool__5"        )] public bool bool__5;
		[Serialize("float__6"       )] public float float__6;
		[Serialize("float__7"       )] public float float__7;
		[Serialize("int__8"         )] public int int__8;
		[Serialize("uint__9"        )] public uint uint__9;
		[Serialize("uint__10"       )] public uint uint__10;
		[Serialize("uint__11"       )] public uint uint__11;
		[Serialize("uint__12"       )] public uint uint__12;
		[Serialize("bool__13"       )] public bool bool__13;
		[Serialize("float__14"      )] public float float__14;
		[Serialize("float__15"      )] public float float__15;
		[Serialize("float__16"      )] public float float__16;
		[Serialize("float__17"      )] public float float__17;
		[Serialize("float__18"      )] public float float__18;
		[Serialize("float__19"      )] public float float__19;
		[Serialize("float__20"      )] public float float__20;
		[Serialize("float__21"      )] public float float__21;
		[Serialize("float__22"      )] public float float__22;
		[Serialize("float__23"      )] public float float__23;
		[Serialize("float__24"      )] public float float__24;
		[Serialize("Path__25"       )] public Path Path__25;
		[Serialize("Path__26"       )] public Path Path__26;
		[Serialize("float__27"      )] public float float__27;
		[Serialize("bool__28"       )] public bool bool__28;
		[Serialize("bool__29"       )] public bool bool__29;
		[Serialize("bool__30"       )] public bool bool__30;
		[Serialize("bool__31"       )] public bool bool__31;
		[Serialize("bool__32"       )] public bool bool__32;
		[Serialize("float__33"      )] public float float__33;
		[Serialize("float__34"      )] public float float__34;
		[Serialize("uint__35"       )] public uint uint__35;
		[Serialize("float__36"      )] public float float__36;
		[Serialize("Enum_VH_0__37"  )] public Enum_VH_0 Enum_VH_0__37;
		[Serialize("EventSender__38")] public EventSender EventSender__38;
		[Serialize("EventSender__39")] public EventSender EventSender__39;
		[Serialize("EventSender__40")] public EventSender EventSender__40;
		[Serialize("EventSender__41")] public EventSender EventSender__41;
		[Serialize("EventSender__42")] public EventSender EventSender__42;
		[Serialize("float__43"      )] public float float__43;
		[Serialize("float__44"      )] public float float__44;
		[Serialize("float__45"      )] public float float__45;
		[Serialize("float__46"      )] public float float__46;
		[Serialize("float__47"      )] public float float__47;
		[Serialize("float__48"      )] public float float__48;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(float__14));
				SerializeField(s, nameof(float__15));
				SerializeField(s, nameof(float__16));
				SerializeField(s, nameof(float__17));
				SerializeField(s, nameof(float__18));
				SerializeField(s, nameof(float__19));
				SerializeField(s, nameof(float__20));
				SerializeField(s, nameof(float__21));
				SerializeField(s, nameof(float__22));
				SerializeField(s, nameof(float__23));
				SerializeField(s, nameof(float__24));
				SerializeField(s, nameof(Path__25));
				SerializeField(s, nameof(Path__26));
				SerializeField(s, nameof(float__27));
				SerializeField(s, nameof(bool__28));
				SerializeField(s, nameof(bool__29));
				SerializeField(s, nameof(bool__30));
				SerializeField(s, nameof(bool__31));
				SerializeField(s, nameof(bool__32));
				SerializeField(s, nameof(float__33));
				SerializeField(s, nameof(float__34));
				SerializeField(s, nameof(uint__35));
				SerializeField(s, nameof(float__36));
				SerializeField(s, nameof(Enum_VH_0__37));
				SerializeField(s, nameof(EventSender__38));
				SerializeField(s, nameof(EventSender__39));
				SerializeField(s, nameof(EventSender__40));
				SerializeField(s, nameof(EventSender__41));
				SerializeField(s, nameof(EventSender__42));
				SerializeField(s, nameof(float__43));
				SerializeField(s, nameof(float__44));
				SerializeField(s, nameof(float__45));
				SerializeField(s, nameof(float__46));
				SerializeField(s, nameof(float__47));
				SerializeField(s, nameof(float__48));
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(uint__0));
				SerializeField(s, nameof(bool__1));
				SerializeField(s, nameof(Enum_VH_0__2));
				SerializeField(s, nameof(bool__3));
				SerializeField(s, nameof(bool__4));
				SerializeField(s, nameof(bool__5));
				SerializeField(s, nameof(float__6));
				SerializeField(s, nameof(float__7));
				SerializeField(s, nameof(int__8));
				SerializeField(s, nameof(uint__9));
				SerializeField(s, nameof(uint__10));
				SerializeField(s, nameof(uint__11));
				SerializeField(s, nameof(uint__12));
				SerializeField(s, nameof(bool__13));
			}
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0"  )] Value_0 = 0,
			[Serialize("Value_1"  )] Value_1 = 1,
			[Serialize("Value_2"  )] Value_2 = 2,
			[Serialize("Value_4"  )] Value_4 = 4,
			[Serialize("Value_8"  )] Value_8 = 8,
			[Serialize("Value_12" )] Value_12 = 12,
			[Serialize("Value_14" )] Value_14 = 14,
			[Serialize("Value_16" )] Value_16 = 16,
			[Serialize("Value_32" )] Value_32 = 32,
			[Serialize("Value_33" )] Value_33 = 33,
			[Serialize("Value_64" )] Value_64 = 64,
			[Serialize("Value_128")] Value_128 = 128,
			[Serialize("Value__1" )] Value__1 = -1,
		}
		public override uint? ClassCRC => 0x84019D6E;
	}
}

