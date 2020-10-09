using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionUTurnToTarget_Template : BTAction_Template {
		public StringID factTarget;
		public StringID animStand;
		public StringID animTurn;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			factTarget = s.SerializeObject<StringID>(factTarget, name: "factTarget");
			animStand = s.SerializeObject<StringID>(animStand, name: "animStand");
			animTurn = s.SerializeObject<StringID>(animTurn, name: "animTurn");
		}
		public override uint? ClassCRC => 0x9151DD3E;
	}
}

