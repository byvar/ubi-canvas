using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class BTActionOnInputSetFact_Template : BTAction_Template {
		[Serialize("fact"        )] public StringID fact;
		[Serialize("DeviceCheck" )] public eDeviceCheck DeviceCheck;
		[Serialize("PlayerID"    )] public uint PlayerID;
		[Serialize("ActionName"  )] public StringID ActionName;
		[Serialize("StringID__0" )] public StringID StringID__0;
		[Serialize("Enum_VH_0__1")] public Enum_VH_0 Enum_VH_0__1;
		[Serialize("uint__2"     )] public uint uint__2;
		[Serialize("StringID__3" )] public StringID StringID__3;
		[Serialize("bool__4"     )] public bool bool__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(Enum_VH_0__1));
				SerializeField(s, nameof(uint__2));
				SerializeField(s, nameof(StringID__3));
				SerializeField(s, nameof(bool__4));
			} else {
				SerializeField(s, nameof(fact));
				SerializeField(s, nameof(DeviceCheck));
				SerializeField(s, nameof(PlayerID));
				SerializeField(s, nameof(ActionName));
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

