using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_BarbedWire : W1W_InteractiveGenComponent {
		public bool bool__0;
		public Enum_VH_0_ Enum_VH_0__1;
		public uint uint__2;
		public uint uint__3;
		public Generic<Event> Generic_Event__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Enum_VH_0__1 = s.Serialize<Enum_VH_0_>(Enum_VH_0__1, name: "Enum_VH_0__1");
			uint__2 = s.Serialize<uint>(uint__2, name: "uint__2");
			uint__3 = s.Serialize<uint>(uint__3, name: "uint__3");
			Generic_Event__4 = s.SerializeObject<Generic<Event>>(Generic_Event__4, name: "Generic<Event>__4");
			if (s.HasFlags(SerializeFlags.Persistent)) {
				bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			}
		}
		public enum Enum_VH_0_ {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x34FD17E0;
	}
}

