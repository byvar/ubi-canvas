namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class StickToPolylinePhysComponent : PhysComponent {
		public bool ForceVerticalBanking;
		public bool IgnoreAngle;
		public bool StartDisable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RO || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
			} else {
				ForceVerticalBanking = s.Serialize<bool>(ForceVerticalBanking, name: "ForceVerticalBanking");
				IgnoreAngle = s.Serialize<bool>(IgnoreAngle, name: "IgnoreAngle");
				StartDisable = s.Serialize<bool>(StartDisable, name: "StartDisable");
			}
		}
		public override uint? ClassCRC => 0xB820D559;
	}
}

