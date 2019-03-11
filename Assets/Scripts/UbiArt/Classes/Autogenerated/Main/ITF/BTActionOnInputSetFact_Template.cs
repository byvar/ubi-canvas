using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTActionOnInputSetFact_Template : BTAction_Template {
		[Serialize("fact"       )] public StringID fact;
		[Serialize("DeviceCheck")] public eDeviceCheck DeviceCheck;
		[Serialize("PlayerID"   )] public uint PlayerID;
		[Serialize("ActionName" )] public StringID ActionName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fact));
			SerializeField(s, nameof(DeviceCheck));
			SerializeField(s, nameof(PlayerID));
			SerializeField(s, nameof(ActionName));
		}
		public enum eDeviceCheck {
			[Serialize("eDeviceCheck_Any")] Any = 0,
			[Serialize("eDeviceCheck_One")] One = 1,
		}
		public override uint? ClassCRC => 0x17945F68;
	}
}

