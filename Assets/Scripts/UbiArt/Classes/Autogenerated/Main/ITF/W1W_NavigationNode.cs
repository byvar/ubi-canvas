using System;
using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_NavigationNode : TrajectoryNodeComponent {
		[Serialize("StringID__0"           )] public StringID StringID__0;
		[Serialize("float__1"              )] public float float__1;
		[Serialize("bool__2"               )] public bool bool__2;
		[Serialize("bool__3"               )] public bool bool__3;
		[Serialize("StringID__4"           )] public StringID StringID__4;
		[Serialize("Enum_VH_0__5"          )] public Enum_VH_0 Enum_VH_0__5;
		[Serialize("CArray<EventSender>__6")] public CArray<EventSender> CArray_EventSender__6;
		[Serialize("CArray<EventSender>__7")] public CArray<EventSender> CArray_EventSender__7;
		[Serialize("Generic<Event>__8"     )] public Generic<Event> Generic_Event__8;
		[Serialize("StringID__9"           )] public StringID StringID__9;
		[Serialize("bool__10"              )] public bool bool__10;
		[Serialize("Enum_VH_1__11"         )] public Enum_VH_1 Enum_VH_1__11;
		[Serialize("Enum_VH_2__12"         )] public Enum_VH_2 Enum_VH_2__12;
		[Serialize("StringID__13"          )] public StringID StringID__13;
		[Serialize("StringID__14"          )] public StringID StringID__14;
		[Serialize("bool__15"              )] public bool bool__15;
		[Serialize("bool__16"              )] public bool bool__16;
		[Serialize("float__17"             )] public float float__17;
		[Serialize("float__18"             )] public float float__18;
		[Serialize("StringID__19"          )] public StringID StringID__19;
		[Serialize("Enum_VH_3__20"         )] public Enum_VH_1 Enum_VH_1__20;
		[Serialize("float__21"             )] public float float__21;
		[Serialize("StringID__22"          )] public StringID StringID__22;
		[Serialize("Generic<Event>__23"    )] public Generic<Event> Generic_Event__23;
		[Serialize("bool__24"              )] public bool bool__24;
		[Serialize("bool__25"              )] public bool bool__25;
		[Serialize("bool__26"              )] public bool bool__26;
		[Serialize("Path__27"              )] public Path Path__27;
		[Serialize("bool__28"              )] public bool bool__28;
		[Serialize("Color__29"             )] public Color Color__29;
		[Serialize("float__30"             )] public float float__30;
		[Serialize("bool__31"              )] public bool bool__31;
		[Serialize("Color__32"             )] public Color Color__32;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StringID__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(bool__2));
			SerializeField(s, nameof(bool__3));
			SerializeField(s, nameof(StringID__4));
			SerializeField(s, nameof(Enum_VH_0__5));
			SerializeField(s, nameof(CArray_EventSender__6));
			SerializeField(s, nameof(CArray_EventSender__7));
			SerializeField(s, nameof(Generic_Event__8));
			SerializeField(s, nameof(StringID__9));
			SerializeField(s, nameof(bool__10));
			SerializeField(s, nameof(Enum_VH_1__11));
			SerializeField(s, nameof(Enum_VH_2__12));
			SerializeField(s, nameof(StringID__13));
			SerializeField(s, nameof(StringID__14));
			SerializeField(s, nameof(bool__15));
			SerializeField(s, nameof(bool__16));
			SerializeField(s, nameof(float__17));
			SerializeField(s, nameof(float__18));
			SerializeField(s, nameof(StringID__19));
			SerializeField(s, nameof(Enum_VH_1__20));
			SerializeField(s, nameof(float__21));
			SerializeField(s, nameof(StringID__22));
			SerializeField(s, nameof(Generic_Event__23));
			SerializeField(s, nameof(bool__24));
			SerializeField(s, nameof(bool__25));
			SerializeField(s, nameof(bool__26));
			SerializeField(s, nameof(Path__27));
			SerializeField(s, nameof(bool__28));
			SerializeField(s, nameof(Color__29));
			SerializeField(s, nameof(float__30));
			SerializeField(s, nameof(bool__31));
			SerializeField(s, nameof(Color__32));
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
		}
		[Flags]
		public enum Enum_VH_1 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public enum Enum_VH_2 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_6")] Value_6 = 6,
			[Serialize("Value_7")] Value_7 = 7,
		}
		public override uint? ClassCRC => 0x51B409B1;
	}
}

