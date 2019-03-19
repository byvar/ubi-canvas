using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Breakable : ActorComponent {
		[Serialize("bool__0"                         )] public bool bool__0;
		[Serialize("CArray<W1W_BreakableSequence>__1")] public CArray<W1W_BreakableSequence> CArray_W1W_BreakableSequence__1;
		[Serialize("Enum_VH_0__2"                    )] public Enum_VH_0 Enum_VH_0__2;
		[Serialize("int__3"                          )] public int int__3;
		[Serialize("Generic<Event>__4"               )] public Generic<Event> Generic_Event__4;
		[Serialize("Generic<Event>__5"               )] public Generic<Event> Generic_Event__5;
		[Serialize("Generic<Event>__6"               )] public Generic<Event> Generic_Event__6;
		[Serialize("Generic<Event>__7"               )] public Generic<Event> Generic_Event__7;
		[Serialize("Generic<Event>__8"               )] public Generic<Event> Generic_Event__8;
		[Serialize("CArray<Generic<Event>>__9"       )] public CArray<Generic<Event>> CArray_Generic_Event__9;
		[Serialize("bool__10"                        )] public bool bool__10;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(CArray_W1W_BreakableSequence__1));
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(Enum_VH_0__2));
				SerializeField(s, nameof(int__3));
				SerializeField(s, nameof(Generic_Event__4));
				SerializeField(s, nameof(Generic_Event__5));
				SerializeField(s, nameof(Generic_Event__6));
				SerializeField(s, nameof(Generic_Event__7));
				SerializeField(s, nameof(Generic_Event__8));
				SerializeField(s, nameof(CArray_Generic_Event__9));
			}
			SerializeField(s, nameof(bool__10));
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(bool__0));
			}
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
		public override uint? ClassCRC => 0x6BEA7750;
	}
}

