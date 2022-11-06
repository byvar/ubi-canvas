using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventLockPlayers : Event {
		public bool bool__0;
		public bool bool__1;
		public Enum_VH_0 Enum_VH_0__2;
		public bool bool__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
			Enum_VH_0__2 = s.Serialize<Enum_VH_0>(Enum_VH_0__2, name: "Enum_VH_0__2");
			bool__3 = s.Serialize<bool>(bool__3, name: "bool__3");
		}
		public enum Enum_VH_0 {
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_0")] Value_0 = 0,
		}
		public override uint? ClassCRC => 0xCAB6A9B8;
	}
}

