using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.COL)]
	public partial class StickToPolylinePhysComponent : PhysComponent {
		[Serialize("ForceVerticalBanking")] public bool ForceVerticalBanking;
		[Serialize("IgnoreAngle"         )] public bool IgnoreAngle;
		[Serialize("StartDisable"        )] public bool StartDisable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
			} else {
				SerializeField(s, nameof(ForceVerticalBanking));
				SerializeField(s, nameof(IgnoreAngle));
				SerializeField(s, nameof(StartDisable));
			}
		}
		public override uint? ClassCRC => 0xB820D559;
	}
}

