using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class BezierCurveComponent : ActorComponent {
		[Serialize("bezier")] public BezierCurve bezier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(bezier));
				}
			}
		}
		public override uint? ClassCRC => 0x75ABD328;
	}
}

