using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_TouchSpringPlatformComponent_Template : RO2_TouchSpringPlatformBaseComponent_Template {
		public StringID playAnimOnHold;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			playAnimOnHold = s.SerializeObject<StringID>(playAnimOnHold, name: "playAnimOnHold");
		}
		public override uint? ClassCRC => 0xC253AA58;
	}
}

