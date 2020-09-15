using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_SafeLock : W1W_Wheel {
		public CArray<ushort> CArray_ushort__0;
		public bool bool__1_;
		public CArray<EventSender> CArray_EventSender__2;
		public CArray<EventSender> CArray_EventSender__3;
		public Generic<Event> Generic_Event__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			CArray_ushort__0 = s.SerializeObject<CArray<ushort>>(CArray_ushort__0, name: "CArray_ushort__0");
			bool__1_ = s.Serialize<bool>(bool__1_, name: "bool__1_");
			CArray_EventSender__2 = s.SerializeObject<CArray<EventSender>>(CArray_EventSender__2, name: "CArray_EventSender__2");
			CArray_EventSender__3 = s.SerializeObject<CArray<EventSender>>(CArray_EventSender__3, name: "CArray_EventSender__3");
			Generic_Event__4 = s.SerializeObject<Generic<Event>>(Generic_Event__4, name: "Generic_Event__4");
		}
		public override uint? ClassCRC => 0x658F5C51;
	}
}

