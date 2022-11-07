namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class GroundAIControllerComponent : BaseAIControllerComponent {
		public bool AppearDisablePhysic;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL || s.Settings.game == Settings.Game.VH) {
			} else {
				AppearDisablePhysic = s.Serialize<bool>(AppearDisablePhysic, name: "AppearDisablePhysic");
			}
		}
		public override uint? ClassCRC => 0x8B5C8C04;
	}
}

