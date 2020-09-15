using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIRedWizardDanceBehavior_Template : Ray_AIGroundBaseMovementBehavior_Template {
		public float syncRatio;
		public float syncOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			syncRatio = s.Serialize<float>(syncRatio, name: "syncRatio");
			syncOffset = s.Serialize<float>(syncOffset, name: "syncOffset");
		}
		public override uint? ClassCRC => 0x76A09132;
	}
}

