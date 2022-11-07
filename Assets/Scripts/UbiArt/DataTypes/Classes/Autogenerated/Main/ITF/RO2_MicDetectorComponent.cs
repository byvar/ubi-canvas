namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_MicDetectorComponent : ShapeDetectorComponent {
		public float smoothFactor;
		public float validationDuration;
		public float validationRMSLevel;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			smoothFactor = s.Serialize<float>(smoothFactor, name: "smoothFactor");
			validationDuration = s.Serialize<float>(validationDuration, name: "validationDuration");
			validationRMSLevel = s.Serialize<float>(validationRMSLevel, name: "validationRMSLevel");
		}
		public override uint? ClassCRC => 0xA94E89D7;
	}
}

