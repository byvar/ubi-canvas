using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class InGameCameraComponent_Template : BaseCameraComponent_Template {
		public CamModifier_Template CM;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.COL) {
			} else {
				CM = s.SerializeObject<CamModifier_Template>(CM, name: "CM");
			}
		}
		public override uint? ClassCRC => 0xD96E4BFB;
	}
}

