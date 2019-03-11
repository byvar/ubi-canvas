using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIShooterStepDamageBehavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("stepDamageList")] public Placeholder stepDamageList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(stepDamageList));
		}
		public override uint? ClassCRC => 0xA9B7DFCD;
	}
}

