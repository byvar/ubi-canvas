using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_PuzzleBrick : ActorComponent {
		public Enum_VH_0 Enum_VH_0__0;
		public CArrayO<Generic<Event>> CArray_Generic_Event__1;
		public CArrayO<Generic<Event>> CArray_Generic_Event__2;
		public CArrayO<EventSender> CArray_EventSender__3;
		public CArrayO<EventSender> CArray_EventSender__4;
		public CArrayO<EventSender> CArray_EventSender__5;
		public CArrayO<EventSender> CArray_EventSender__6;
		public float float__7;
		public bool bool__8;
		public bool bool__9;
		public bool bool__10;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Enum_VH_0__0 = s.Serialize<Enum_VH_0>(Enum_VH_0__0, name: "Enum_VH_0__0");
			CArray_Generic_Event__1 = s.SerializeObject<CArrayO<Generic<Event>>>(CArray_Generic_Event__1, name: "CArray<Generic<Event>>__1");
			CArray_Generic_Event__2 = s.SerializeObject<CArrayO<Generic<Event>>>(CArray_Generic_Event__2, name: "CArray<Generic<Event>>__2");
			CArray_EventSender__3 = s.SerializeObject<CArrayO<EventSender>>(CArray_EventSender__3, name: "CArray<EventSender>__3");
			CArray_EventSender__4 = s.SerializeObject<CArrayO<EventSender>>(CArray_EventSender__4, name: "CArray<EventSender>__4");
			CArray_EventSender__5 = s.SerializeObject<CArrayO<EventSender>>(CArray_EventSender__5, name: "CArray<EventSender>__5");
			CArray_EventSender__6 = s.SerializeObject<CArrayO<EventSender>>(CArray_EventSender__6, name: "CArray<EventSender>__6");
			float__7 = s.Serialize<float>(float__7, name: "float__7");
			bool__8 = s.Serialize<bool>(bool__8, name: "bool__8");
			bool__9 = s.Serialize<bool>(bool__9, name: "bool__9");
			bool__10 = s.Serialize<bool>(bool__10, name: "bool__10");
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x3236AE96;
	}
}

