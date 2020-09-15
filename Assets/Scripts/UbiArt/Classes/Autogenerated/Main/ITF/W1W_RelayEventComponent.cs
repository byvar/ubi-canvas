using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_RelayEventComponent : ActorComponent {
		public CArray<W1W_RelayEventComponent.RelayData> CArray_W1W_RelayEventComponent_RelayData__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			CArray_W1W_RelayEventComponent_RelayData__0 = s.SerializeObject<CArray<W1W_RelayEventComponent.RelayData>>(CArray_W1W_RelayEventComponent_RelayData__0, name: "CArray_W1W_RelayEventComponent_RelayData__0");
		}
		[Games(GameFlags.VH)]
		public partial class RelayData : CSerializable {
			public Generic<Event> Generic_Event__0;
			public CArray<Generic<Event>> CArray_Generic_Event__1;
			public float float__2;
			public uint uint__3;
			public bool bool__4;
			public bool bool__5;
			public bool bool__6;
			public bool bool__7;
			public bool bool__8;
			public bool bool__9;
			public bool bool__10;
			public bool bool__11;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				Generic_Event__0 = s.SerializeObject<Generic<Event>>(Generic_Event__0, name: "Generic_Event__0");
				CArray_Generic_Event__1 = s.SerializeObject<CArray<Generic<Event>>>(CArray_Generic_Event__1, name: "CArray_Generic_Event__1");
				float__2 = s.Serialize<float>(float__2, name: "float__2");
				uint__3 = s.Serialize<uint>(uint__3, name: "uint__3");
				bool__4 = s.Serialize<bool>(bool__4, name: "bool__4");
				bool__5 = s.Serialize<bool>(bool__5, name: "bool__5");
				bool__6 = s.Serialize<bool>(bool__6, name: "bool__6");
				bool__7 = s.Serialize<bool>(bool__7, name: "bool__7");
				bool__8 = s.Serialize<bool>(bool__8, name: "bool__8");
				bool__9 = s.Serialize<bool>(bool__9, name: "bool__9");
				bool__10 = s.Serialize<bool>(bool__10, name: "bool__10");
				bool__11 = s.Serialize<bool>(bool__11, name: "bool__11");
			}
		}
		public override uint? ClassCRC => 0xF9EC95CA;
	}
}

