namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_SceneConfig_AdversarialGoldenPotato : RO2_SceneConfig_Adversarial {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE5B76026;
	}
}

