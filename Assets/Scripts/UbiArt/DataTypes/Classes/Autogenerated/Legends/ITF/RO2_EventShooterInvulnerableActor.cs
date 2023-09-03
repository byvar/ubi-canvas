namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_EventShooterInvulnerableActor : Event {
		public int invulnerable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			invulnerable = s.Serialize<int>(invulnerable, name: "invulnerable");
		}
		public override uint? ClassCRC => 0x76C291E1;
	}
}

