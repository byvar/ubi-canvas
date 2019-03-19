using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionUTurnToTarget_Template : BTAction_Template {
		[Serialize("factTarget")] public StringID factTarget;
		[Serialize("animStand" )] public StringID animStand;
		[Serialize("animTurn"  )] public StringID animTurn;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(factTarget));
			SerializeField(s, nameof(animStand));
			SerializeField(s, nameof(animTurn));
		}
		public override uint? ClassCRC => 0x9151DD3E;
	}
}

