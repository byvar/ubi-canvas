using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_PuzzleBrick : ActorComponent {
		[Serialize("Enum_VH_0__0"             )] public Enum_VH_0 Enum_VH_0__0;
		[Serialize("CArray<Generic<Event>>__1")] public CArray<Generic<Event>> CArray_Generic_Event__1;
		[Serialize("CArray<Generic<Event>>__2")] public CArray<Generic<Event>> CArray_Generic_Event__2;
		[Serialize("CArray<EventSender>__3"   )] public CArray<EventSender> CArray_EventSender__3;
		[Serialize("CArray<EventSender>__4"   )] public CArray<EventSender> CArray_EventSender__4;
		[Serialize("CArray<EventSender>__5"   )] public CArray<EventSender> CArray_EventSender__5;
		[Serialize("CArray<EventSender>__6"   )] public CArray<EventSender> CArray_EventSender__6;
		[Serialize("float__7"                 )] public float float__7;
		[Serialize("bool__8"                  )] public bool bool__8;
		[Serialize("bool__9"                  )] public bool bool__9;
		[Serialize("bool__10"                 )] public bool bool__10;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Enum_VH_0__0));
			SerializeField(s, nameof(CArray_Generic_Event__1));
			SerializeField(s, nameof(CArray_Generic_Event__2));
			SerializeField(s, nameof(CArray_EventSender__3));
			SerializeField(s, nameof(CArray_EventSender__4));
			SerializeField(s, nameof(CArray_EventSender__5));
			SerializeField(s, nameof(CArray_EventSender__6));
			SerializeField(s, nameof(float__7));
			SerializeField(s, nameof(bool__8));
			SerializeField(s, nameof(bool__9));
			SerializeField(s, nameof(bool__10));
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

