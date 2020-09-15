using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.VH | GameFlags.RO | GameFlags.COL)]
	public partial class CameraModifierComponent_Template : ActorComponent_Template {
		[Serialize("CM"         )] public CamModifier_Template CM;
		[Serialize("SCALE"      )] public Vec2d SCALE;
		[Serialize("CM_override")] public CamModifierOverride_Template CM_override;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RJR) {
				SerializeField(s, nameof(CM));
				SerializeField(s, nameof(CM_override));
			} else {
				SerializeField(s, nameof(CM));
				SerializeField(s, nameof(SCALE));
			}
		}
		public override uint? ClassCRC => 0xDCA22B54;
	}
}

