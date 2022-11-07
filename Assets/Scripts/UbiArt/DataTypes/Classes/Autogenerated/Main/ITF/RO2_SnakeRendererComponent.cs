namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_SnakeRendererComponent : GraphicComponent {
		public bool alignOnTrajectoryOnStart;
		public bool flipWithDirection;
		public bool disablePolyline;
		public bool disableTopPolyline;
		public bool disableBottomPolyline;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					alignOnTrajectoryOnStart = s.Serialize<bool>(alignOnTrajectoryOnStart, name: "alignOnTrajectoryOnStart", options: CSerializerObject.Options.BoolAsByte);
					flipWithDirection = s.Serialize<bool>(flipWithDirection, name: "flipWithDirection", options: CSerializerObject.Options.BoolAsByte);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					alignOnTrajectoryOnStart = s.Serialize<bool>(alignOnTrajectoryOnStart, name: "alignOnTrajectoryOnStart");
					flipWithDirection = s.Serialize<bool>(flipWithDirection, name: "flipWithDirection");
					disablePolyline = s.Serialize<bool>(disablePolyline, name: "disablePolyline");
					disableTopPolyline = s.Serialize<bool>(disableTopPolyline, name: "disableTopPolyline");
					disableBottomPolyline = s.Serialize<bool>(disableBottomPolyline, name: "disableBottomPolyline");
				}
			}
		}
		public override uint? ClassCRC => 0xC5B35E73;
	}
}

