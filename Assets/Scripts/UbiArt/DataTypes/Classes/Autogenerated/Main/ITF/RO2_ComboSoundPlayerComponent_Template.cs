namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_ComboSoundPlayerComponent_Template : ActorComponent_Template {
		public StringID comboSound;
		public float maxTimeBetweenCombo;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			comboSound = s.SerializeObject<StringID>(comboSound, name: "comboSound");
			maxTimeBetweenCombo = s.Serialize<float>(maxTimeBetweenCombo, name: "maxTimeBetweenCombo");
		}
		public override uint? ClassCRC => 0x0D6F6344;
	}
}

