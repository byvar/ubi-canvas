using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class BTActionOnInputSetFact_Template : BTAction_Template {
		public StringID fact;
		public eDeviceCheck DeviceCheck;
		public uint PlayerID;
		public StringID ActionName;
		public StringID StringID__0;
		public Enum_VH_0 Enum_VH_0__1;
		public uint uint__2;
		public StringID StringID__3;
		public bool bool__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
				Enum_VH_0__1 = s.Serialize<Enum_VH_0>(Enum_VH_0__1, name: "Enum_VH_0__1");
				uint__2 = s.Serialize<uint>(uint__2, name: "uint__2");
				StringID__3 = s.SerializeObject<StringID>(StringID__3, name: "StringID__3");
				bool__4 = s.Serialize<bool>(bool__4, name: "bool__4");
			} else {
				fact = s.SerializeObject<StringID>(fact, name: "fact");
				DeviceCheck = s.Serialize<eDeviceCheck>(DeviceCheck, name: "DeviceCheck");
				PlayerID = s.Serialize<uint>(PlayerID, name: "PlayerID");
				ActionName = s.SerializeObject<StringID>(ActionName, name: "ActionName");
			}
		}
		public enum eDeviceCheck {
			[Serialize("eDeviceCheck_Any")] Any = 0,
			[Serialize("eDeviceCheck_One")] One = 1,
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x17945F68;
	}
}

