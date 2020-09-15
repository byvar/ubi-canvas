using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_FlareGenerator : ActorComponent {
		public float float__0;
		public int int__1;
		public Path Path__2;
		public Generic<Event> Generic_Event__3;
		public CArray<Generic<Event>> CArray_Generic_Event__4;
		public CArray<Generic<Event>> CArray_Generic_Event__5;
		public CArray<Generic<Event>> CArray_Generic_Event__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float__0 = s.Serialize<float>(float__0, name: "float__0");
			int__1 = s.Serialize<int>(int__1, name: "int__1");
			Path__2 = s.SerializeObject<Path>(Path__2, name: "Path__2");
			Generic_Event__3 = s.SerializeObject<Generic<Event>>(Generic_Event__3, name: "Generic_Event__3");
			CArray_Generic_Event__4 = s.SerializeObject<CArray<Generic<Event>>>(CArray_Generic_Event__4, name: "CArray_Generic_Event__4");
			CArray_Generic_Event__5 = s.SerializeObject<CArray<Generic<Event>>>(CArray_Generic_Event__5, name: "CArray_Generic_Event__5");
			CArray_Generic_Event__6 = s.SerializeObject<CArray<Generic<Event>>>(CArray_Generic_Event__6, name: "CArray_Generic_Event__6");
		}
		public override uint? ClassCRC => 0xA0D8140F;
	}
}

