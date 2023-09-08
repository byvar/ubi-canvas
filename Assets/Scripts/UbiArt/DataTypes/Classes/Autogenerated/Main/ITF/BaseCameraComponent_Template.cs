namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.RAVersion)]
	public partial class BaseCameraComponent_Template : ActorComponent_Template {
		public bool startAsMainCam;
		public float rampUpDestinationCoeff;
		public float rampUpCoeff;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO) {
				startAsMainCam = s.Serialize<bool>(startAsMainCam, name: "startAsMainCam");
				rampUpDestinationCoeff = s.Serialize<float>(rampUpDestinationCoeff, name: "rampUpDestinationCoeff");
				rampUpCoeff = s.Serialize<float>(rampUpCoeff, name: "rampUpCoeff");
			} else {
				startAsMainCam = s.Serialize<bool>(startAsMainCam, name: "startAsMainCam");
				rampUpCoeff = s.Serialize<float>(rampUpCoeff, name: "rampUpCoeff");
			}
		}
		public override uint? ClassCRC => 0x680B2173;
	}
}

