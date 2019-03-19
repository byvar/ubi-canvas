using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class Helmut : Npc {
		[Serialize("bool__0"           )] public bool bool__0;
		[Serialize("bool__1"           )] public bool bool__1;
		[Serialize("Enum_VH_0__2"      )] public Enum_VH_0 Enum_VH_0__2;
		[Serialize("bool__3"           )] public bool bool__3;
		[Serialize("float__4"          )] public float float__4;
		[Serialize("float__5"          )] public float float__5;
		[Serialize("float__6"          )] public float float__6;
		[Serialize("float__7"          )] public float float__7;
		[Serialize("float__8"          )] public float float__8;
		[Serialize("Path__9"           )] public Path Path__9;
		[Serialize("bool__10"          )] public bool bool__10;
		[Serialize("bool__11"          )] public bool bool__11;
		[Serialize("float__12"         )] public float float__12;
		[Serialize("StringID__13"      )] public StringID StringID__13;
		[Serialize("Generic<Event>__14")] public Generic<Event> Generic_Event__14;
		[Serialize("Generic<Event>__15")] public Generic<Event> Generic_Event__15;
		[Serialize("Generic<Event>__16")] public Generic<Event> Generic_Event__16;
		[Serialize("Generic<Event>__17")] public Generic<Event> Generic_Event__17;
		[Serialize("Generic<Event>__18")] public Generic<Event> Generic_Event__18;
		[Serialize("Generic<Event>__19")] public Generic<Event> Generic_Event__19;
		[Serialize("Generic<Event>__20")] public Generic<Event> Generic_Event__20;
		[Serialize("Generic<Event>__21")] public Generic<Event> Generic_Event__21;
		[Serialize("Generic<Event>__22")] public Generic<Event> Generic_Event__22;
		[Serialize("Generic<Event>__23")] public Generic<Event> Generic_Event__23;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(bool__1));
				SerializeField(s, nameof(Enum_VH_0__2));
				SerializeField(s, nameof(bool__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(float__6));
				SerializeField(s, nameof(float__7));
				SerializeField(s, nameof(float__8));
				SerializeField(s, nameof(Path__9));
				SerializeField(s, nameof(bool__10));
				SerializeField(s, nameof(bool__11));
				SerializeField(s, nameof(float__12));
				SerializeField(s, nameof(StringID__13));
				SerializeField(s, nameof(Generic_Event__14));
				SerializeField(s, nameof(Generic_Event__15));
				SerializeField(s, nameof(Generic_Event__16));
				SerializeField(s, nameof(Generic_Event__17));
				SerializeField(s, nameof(Generic_Event__18));
				SerializeField(s, nameof(Generic_Event__19));
				SerializeField(s, nameof(Generic_Event__20));
				SerializeField(s, nameof(Generic_Event__21));
				SerializeField(s, nameof(Generic_Event__22));
				SerializeField(s, nameof(Generic_Event__23));
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(bool__0));
			}
		}
		public enum Enum_VH_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_5")] Value_5 = 5,
		}
		public override uint? ClassCRC => 0x677C4A14;
	}
}

