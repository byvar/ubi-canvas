using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIRedWizardDanceBehavior_Template : Ray_AIGroundBaseMovementBehavior_Template {
		[Serialize("syncRatio" )] public float syncRatio;
		[Serialize("syncOffset")] public float syncOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(syncRatio));
			SerializeField(s, nameof(syncOffset));
		}
		public override uint? ClassCRC => 0x76A09132;
	}
}

