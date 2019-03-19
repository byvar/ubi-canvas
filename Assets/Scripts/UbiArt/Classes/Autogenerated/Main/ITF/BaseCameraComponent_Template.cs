using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR)]
	public partial class BaseCameraComponent_Template : ActorComponent_Template {
		[Serialize("startAsMainCam")] public bool startAsMainCam;
		[Serialize("rampUpCoeff"   )] public float rampUpCoeff;
		[Serialize("int__0"        )] public int int__0;
		[Serialize("float__1"      )] public float float__1;
		[Serialize("float__2"      )] public float float__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(int__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(float__2));
			} else {
				SerializeField(s, nameof(startAsMainCam));
				SerializeField(s, nameof(rampUpCoeff));
			}
		}
		public override uint? ClassCRC => 0x680B2173;
	}
}

