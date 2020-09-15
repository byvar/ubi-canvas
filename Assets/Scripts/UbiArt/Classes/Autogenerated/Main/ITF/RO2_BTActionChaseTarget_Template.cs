using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionChaseTarget_Template : BTAction_Template {
		public Generic<PhysShape> enemyDetectionRange;
		public StringID animWalk;
		public StringID animUTurn;
		public float timeChaseWithoutTarget;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enemyDetectionRange = s.SerializeObject<Generic<PhysShape>>(enemyDetectionRange, name: "enemyDetectionRange");
			animWalk = s.SerializeObject<StringID>(animWalk, name: "animWalk");
			animUTurn = s.SerializeObject<StringID>(animUTurn, name: "animUTurn");
			timeChaseWithoutTarget = s.Serialize<float>(timeChaseWithoutTarget, name: "timeChaseWithoutTarget");
		}
		public override uint? ClassCRC => 0x6C61B3B3;
	}
}

