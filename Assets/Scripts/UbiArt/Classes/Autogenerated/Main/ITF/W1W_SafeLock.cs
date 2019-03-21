using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_SafeLock : W1W_Wheel {
		[Serialize("CArray<unsigned short>__0")] public CArray<ushort> CArray_ushort__0;
		[Serialize("bool__1"                  )] public bool bool__1_;
		[Serialize("CArray<EventSender>__2"   )] public CArray<EventSender> CArray_EventSender__2;
		[Serialize("CArray<EventSender>__3"   )] public CArray<EventSender> CArray_EventSender__3;
		[Serialize("Generic<Event>__4"        )] public Generic<Event> Generic_Event__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(CArray_ushort__0));
			SerializeField(s, nameof(bool__1_));
			SerializeField(s, nameof(CArray_EventSender__2));
			SerializeField(s, nameof(CArray_EventSender__3));
			SerializeField(s, nameof(Generic_Event__4));
		}
		public override uint? ClassCRC => 0x658F5C51;
	}
}

