using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_ScopeFireOrder : ActorComponent {
		[Serialize("uint__0"           )] public uint uint__0;
		[Serialize("Enum_VH_0__1"      )] public Enum_VH_0 Enum_VH_0__1;
		[Serialize("float__2"          )] public float float__2;
		[Serialize("float__3"          )] public float float__3;
		[Serialize("Generic<Event>__4" )] public Generic<Event> Generic_Event__4;
		[Serialize("Generic<Event>__5" )] public Generic<Event> Generic_Event__5;
		[Serialize("Generic<Event>__6" )] public Generic<Event> Generic_Event__6;
		[Serialize("Generic<Event>__7" )] public Generic<Event> Generic_Event__7;
		[Serialize("Generic<Event>__8" )] public Generic<Event> Generic_Event__8;
		[Serialize("Generic<Event>__9" )] public Generic<Event> Generic_Event__9;
		[Serialize("Generic<Event>__10")] public Generic<Event> Generic_Event__10;
		[Serialize("Generic<Event>__11")] public Generic<Event> Generic_Event__11;
		[Serialize("Generic<Event>__12")] public Generic<Event> Generic_Event__12;
		[Serialize("Generic<Event>__13")] public Generic<Event> Generic_Event__13;
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
		[Serialize("Generic<Event>__24")] public Generic<Event> Generic_Event__24;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uint__0));
			SerializeField(s, nameof(Enum_VH_0__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(float__3));
			SerializeField(s, nameof(Generic_Event__4));
			SerializeField(s, nameof(Generic_Event__5));
			SerializeField(s, nameof(Generic_Event__6));
			SerializeField(s, nameof(Generic_Event__7));
			SerializeField(s, nameof(Generic_Event__8));
			SerializeField(s, nameof(Generic_Event__9));
			SerializeField(s, nameof(Generic_Event__10));
			SerializeField(s, nameof(Generic_Event__11));
			SerializeField(s, nameof(Generic_Event__12));
			SerializeField(s, nameof(Generic_Event__13));
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
			SerializeField(s, nameof(Generic_Event__24));
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0xB4C3A986;
	}
}

