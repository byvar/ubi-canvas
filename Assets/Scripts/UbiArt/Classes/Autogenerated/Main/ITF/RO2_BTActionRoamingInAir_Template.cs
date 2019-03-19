using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionRoamingInAir_Template : BTAction_Template {
		[Serialize("animFly"      )] public StringID animFly;
		[Serialize("uTurnToPlayer")] public bool uTurnToPlayer;
		[Serialize("safeDistance" )] public float safeDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animFly));
			SerializeField(s, nameof(uTurnToPlayer));
			SerializeField(s, nameof(safeDistance));
		}
		public override uint? ClassCRC => 0xB2037A0D;
	}
}

