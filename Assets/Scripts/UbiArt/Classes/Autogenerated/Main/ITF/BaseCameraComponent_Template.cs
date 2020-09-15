using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR)]
	public partial class BaseCameraComponent_Template : ActorComponent_Template {
		public bool startAsMainCam;
		public float rampUpDestinationCoeff;
		public float rampUpCoeff;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
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

