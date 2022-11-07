namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_145_sub_73FEB0 : CSerializable {
		public Color challengeExpertColor;
		public float challengeSwitchDelay;
		public float challengeSwitchSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			challengeExpertColor = s.SerializeObject<Color>(challengeExpertColor, name: "challengeExpertColor");
			challengeSwitchDelay = s.Serialize<float>(challengeSwitchDelay, name: "challengeSwitchDelay");
			challengeSwitchSpeed = s.Serialize<float>(challengeSwitchSpeed, name: "challengeSwitchSpeed");
		}
		public override uint? ClassCRC => 0xE80EF191;
	}
}

