namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_UIMenuPlayerStatsComponent_Template : UIMenuBasic_Template {
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

