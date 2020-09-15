using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.VH | GameFlags.RO | GameFlags.COL)]
	public partial class CameraModifierComponent_Template : ActorComponent_Template {
		public CamModifier_Template CM;
		public Vec2d SCALE;
		public CamModifierOverride_Template CM_override;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RJR) {
				CM = s.SerializeObject<CamModifier_Template>(CM, name: "CM");
				CM_override = s.SerializeObject<CamModifierOverride_Template>(CM_override, name: "CM_override");
			} else {
				CM = s.SerializeObject<CamModifier_Template>(CM, name: "CM");
				SCALE = s.SerializeObject<Vec2d>(SCALE, name: "SCALE");
			}
		}
		public override uint? ClassCRC => 0xDCA22B54;
	}
}

