using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class CameraShakeConfig_Template : TemplateObj {
		public CListO<CameraShake> shakes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				shakes = s.SerializeObject<CListO<CameraShake>>(shakes, name: "shakes");
			}
		}
		public override uint? ClassCRC => 0x04623994;
	}
}

