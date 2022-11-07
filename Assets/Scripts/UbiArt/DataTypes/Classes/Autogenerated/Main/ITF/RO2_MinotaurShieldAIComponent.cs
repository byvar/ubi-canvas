namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_MinotaurShieldAIComponent : RO2_AIComponent {
		public bool standOnce;
		public bool useDestructionDelay;
		public bool dead;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				standOnce = s.Serialize<bool>(standOnce, name: "standOnce", options: CSerializerObject.Options.BoolAsByte);
				if (s.HasFlags(SerializeFlags.Persistent)) {
					dead = s.Serialize<bool>(dead, name: "dead");
				}
			} else {
				standOnce = s.Serialize<bool>(standOnce, name: "standOnce");
				useDestructionDelay = s.Serialize<bool>(useDestructionDelay, name: "useDestructionDelay");
				if (s.HasFlags(SerializeFlags.Persistent)) {
					dead = s.Serialize<bool>(dead, name: "dead");
				}
			}
		}
		public override uint? ClassCRC => 0x126B81D8;
	}
}

