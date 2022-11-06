using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionRoamingUnderWater_Template : BTAction_Template {
		public StringID animSwimUp;
		public StringID animSwimDown;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animSwimUp = s.SerializeObject<StringID>(animSwimUp, name: "animSwimUp");
			animSwimDown = s.SerializeObject<StringID>(animSwimDown, name: "animSwimDown");
		}
		public override uint? ClassCRC => 0x23188509;
	}
}

