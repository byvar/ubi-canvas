using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR)]
	public partial class BaseCameraComponent_Template : ActorComponent_Template {
		[Serialize("startAsMainCam")] public bool startAsMainCam;
		[Serialize("rampUpDestinationCoeff")] public float rampUpDestinationCoeff;
		[Serialize("rampUpCoeff"   )] public float rampUpCoeff;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(startAsMainCam));
				SerializeField(s, nameof(rampUpDestinationCoeff));
				SerializeField(s, nameof(rampUpCoeff));
			} else {
				SerializeField(s, nameof(startAsMainCam));
				SerializeField(s, nameof(rampUpCoeff));
			}
		}
		public override uint? ClassCRC => 0x680B2173;
	}
}

