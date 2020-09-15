using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionLaunch_Template : BTAction_Template {
		public StringID animLaunching;
		public StringID animFalling;
		public StringID animLanding;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animLaunching = s.SerializeObject<StringID>(animLaunching, name: "animLaunching");
			animFalling = s.SerializeObject<StringID>(animFalling, name: "animFalling");
			animLanding = s.SerializeObject<StringID>(animLanding, name: "animLanding");
		}
		public override uint? ClassCRC => 0x4E1575C0;
	}
}

