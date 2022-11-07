namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_WaveBallComponent_Template : ActorComponent_Template {
		public float scaleWhenOff;
		public float scaleWhenOn;
		public float offToOnDelay;
		public float onToOffDelay;
		public Path texturePath;
		public float spikeMultiplier_Preparing;
		public float spikeMultiplier_Idle;
		public Color colorOn;
		public Color colorOff;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			scaleWhenOff = s.Serialize<float>(scaleWhenOff, name: "scaleWhenOff");
			scaleWhenOn = s.Serialize<float>(scaleWhenOn, name: "scaleWhenOn");
			offToOnDelay = s.Serialize<float>(offToOnDelay, name: "offToOnDelay");
			onToOffDelay = s.Serialize<float>(onToOffDelay, name: "onToOffDelay");
			texturePath = s.SerializeObject<Path>(texturePath, name: "texturePath");
			spikeMultiplier_Preparing = s.Serialize<float>(spikeMultiplier_Preparing, name: "spikeMultiplier_Preparing");
			spikeMultiplier_Idle = s.Serialize<float>(spikeMultiplier_Idle, name: "spikeMultiplier_Idle");
			colorOn = s.SerializeObject<Color>(colorOn, name: "colorOn");
			colorOff = s.SerializeObject<Color>(colorOff, name: "colorOff");
		}
		public override uint? ClassCRC => 0xB268A3CF;
	}
}

