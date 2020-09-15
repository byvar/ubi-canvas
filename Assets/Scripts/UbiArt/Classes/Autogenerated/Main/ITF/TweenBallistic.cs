using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class TweenBallistic : TweenTranslation {
		[Serialize("movement"    )] public Vec3d movement;
		[Serialize("startTangent")] public Vec3d startTangent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(movement));
			SerializeField(s, nameof(startTangent));
		}
		public override uint? ClassCRC => 0x61D21A33;
	}
}

