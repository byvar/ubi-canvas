using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionChaseTarget_Template : BTAction_Template {
		[Serialize("enemyDetectionRange"   )] public Generic<PhysShape> enemyDetectionRange;
		[Serialize("animWalk"              )] public StringID animWalk;
		[Serialize("animUTurn"             )] public StringID animUTurn;
		[Serialize("timeChaseWithoutTarget")] public float timeChaseWithoutTarget;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enemyDetectionRange));
			SerializeField(s, nameof(animWalk));
			SerializeField(s, nameof(animUTurn));
			SerializeField(s, nameof(timeChaseWithoutTarget));
		}
		public override uint? ClassCRC => 0x6C61B3B3;
	}
}

