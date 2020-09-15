using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AnimGameplayEvent : AnimMarkerEvent {
		public bool value;
		public float valueFloat;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
				value = s.Serialize<bool>(value, name: "value");
			} else {
				value = s.Serialize<bool>(value, name: "value");
				valueFloat = s.Serialize<float>(valueFloat, name: "valueFloat");
			}
		}
		public override uint? ClassCRC => 0xA2242335;
	}
}

