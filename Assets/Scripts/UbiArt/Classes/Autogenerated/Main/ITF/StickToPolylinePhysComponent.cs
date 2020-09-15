using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.COL)]
	public partial class StickToPolylinePhysComponent : PhysComponent {
		public bool ForceVerticalBanking;
		public bool IgnoreAngle;
		public bool StartDisable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
			} else {
				ForceVerticalBanking = s.Serialize<bool>(ForceVerticalBanking, name: "ForceVerticalBanking");
				IgnoreAngle = s.Serialize<bool>(IgnoreAngle, name: "IgnoreAngle");
				StartDisable = s.Serialize<bool>(StartDisable, name: "StartDisable");
			}
		}
		public override uint? ClassCRC => 0xB820D559;
	}
}

