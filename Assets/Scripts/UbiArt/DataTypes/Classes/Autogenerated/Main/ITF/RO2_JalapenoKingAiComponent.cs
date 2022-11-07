namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_JalapenoKingAiComponent : AIComponent {
		public bool dead;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				dead = s.Serialize<bool>(dead, name: "dead");
			}
		}
		public override uint? ClassCRC => 0x02CCB5E2;
	}
}

