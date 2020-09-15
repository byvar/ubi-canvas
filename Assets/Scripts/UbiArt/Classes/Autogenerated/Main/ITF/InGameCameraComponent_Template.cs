using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class InGameCameraComponent_Template : BaseCameraComponent_Template {
		public CamModifier_Template CM;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				CM = s.SerializeObject<CamModifier_Template>(CM, name: "CM");
			}
		}
		public override uint? ClassCRC => 0xD96E4BFB;
	}
}

