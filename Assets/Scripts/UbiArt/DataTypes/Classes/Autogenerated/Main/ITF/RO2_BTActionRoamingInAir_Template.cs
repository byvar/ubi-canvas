namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionRoamingInAir_Template : BTAction_Template {
		public StringID animFly;
		public bool uTurnToPlayer;
		public float safeDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animFly = s.SerializeObject<StringID>(animFly, name: "animFly");
			uTurnToPlayer = s.Serialize<bool>(uTurnToPlayer, name: "uTurnToPlayer");
			safeDistance = s.Serialize<float>(safeDistance, name: "safeDistance");
		}
		public override uint? ClassCRC => 0xB2037A0D;
	}
}

