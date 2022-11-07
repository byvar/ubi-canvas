namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_146_sub_73FC80 : CSerializable {
		public int useSwitchChallenge;
		public Vec2d blockerOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			useSwitchChallenge = s.Serialize<int>(useSwitchChallenge, name: "useSwitchChallenge");
			blockerOffset = s.SerializeObject<Vec2d>(blockerOffset, name: "blockerOffset");
		}
		public override uint? ClassCRC => 0x0A5EC37B;
	}
}

