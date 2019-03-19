using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class CircleInterpolatorComponent_Template : InterpolatorComponent_Template {
		[Serialize("innerRadius")] public float innerRadius;
		[Serialize("outerRadius")] public float outerRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				SerializeField(s, nameof(innerRadius));
				SerializeField(s, nameof(outerRadius));
			}
		}
		public override uint? ClassCRC => 0x6A69DF6E;
	}
}

