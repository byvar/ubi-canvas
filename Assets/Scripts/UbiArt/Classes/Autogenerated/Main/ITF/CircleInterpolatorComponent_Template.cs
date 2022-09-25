using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class CircleInterpolatorComponent_Template : InterpolatorComponent_Template {
		public float innerRadius;
		public float outerRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.COL) {
			} else {
				innerRadius = s.Serialize<float>(innerRadius, name: "innerRadius");
				outerRadius = s.Serialize<float>(outerRadius, name: "outerRadius");
			}
		}
		public override uint? ClassCRC => 0x6A69DF6E;
	}
}

