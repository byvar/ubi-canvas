using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH | GameFlags.RO)]
	public partial class BoxInterpolatorComponent_Template : InterpolatorComponent_Template {
		[Serialize("innerAABB"   )] public Placeholder innerAABB;
		[Serialize("outerAABB"   )] public Placeholder outerAABB;
		[Serialize("AABBRotation")] public Angle AABBRotation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(innerAABB));
				SerializeField(s, nameof(outerAABB));
				SerializeField(s, nameof(AABBRotation));
			} else {
			}
		}
		public override uint? ClassCRC => 0x71F87656;
	}
}

