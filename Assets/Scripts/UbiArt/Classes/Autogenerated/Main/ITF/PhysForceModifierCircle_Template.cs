using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class PhysForceModifierCircle_Template : PhysForceModifier_Template {
		[Serialize("radius"             )] public float radius;
		[Serialize("angleStart"         )] public Angle angleStart;
		[Serialize("angleEnd"           )] public Angle angleEnd;
		[Serialize("gradientAngleOffset")] public Angle gradientAngleOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(radius));
				SerializeField(s, nameof(angleStart));
				SerializeField(s, nameof(angleEnd));
				SerializeField(s, nameof(gradientAngleOffset));
			} else {
				SerializeField(s, nameof(radius));
				SerializeField(s, nameof(angleStart));
				SerializeField(s, nameof(angleEnd));
			}
		}
		public override uint? ClassCRC => 0xD8719B69;
	}
}

