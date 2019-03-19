using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class CircleInterpolatorComponent : InterpolatorComponent {
		[Serialize("innerRadius")] public float innerRadius;
		[Serialize("outerRadius")] public float outerRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(innerRadius));
				SerializeField(s, nameof(outerRadius));
			} else {
			}
		}
		public override uint? ClassCRC => 0xBA81CB26;
	}
}

