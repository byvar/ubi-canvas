using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionFishing_Template : BTAction_Template {
		public StringID animFishing;
		public StringID animStopFish;
		public Angle addSnapAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animFishing = s.SerializeObject<StringID>(animFishing, name: "animFishing");
			animStopFish = s.SerializeObject<StringID>(animStopFish, name: "animStopFish");
			addSnapAngle = s.SerializeObject<Angle>(addSnapAngle, name: "addSnapAngle");
		}
		public override uint? ClassCRC => 0x4E7367F4;
	}
}

