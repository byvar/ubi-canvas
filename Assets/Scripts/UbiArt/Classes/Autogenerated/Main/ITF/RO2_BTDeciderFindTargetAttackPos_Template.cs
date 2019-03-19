using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTDeciderFindTargetAttackPos_Template : BTDecider_Template {
		[Serialize("factTarget")] public StringID factTarget;
		[Serialize("factPos"   )] public StringID factPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(factTarget));
			SerializeField(s, nameof(factPos));
		}
		public override uint? ClassCRC => 0xD0B345FC;
	}
}

