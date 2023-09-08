namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class GroundAIControllerComponent : BaseAIControllerComponent {
		public bool AppearDisablePhysic;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.EngineVersion <= EngineVersion.RO || s.Settings.Game == Game.RL || s.Settings.Game == Game.COL || s.Settings.Game == Game.VH) {
			} else {
				AppearDisablePhysic = s.Serialize<bool>(AppearDisablePhysic, name: "AppearDisablePhysic");
			}
		}
		public override uint? ClassCRC => 0x8B5C8C04;
	}
}

