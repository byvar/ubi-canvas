using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AnimGameplayEvent : AnimMarkerEvent {
		public bool value;
		public float valueFloat;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
			} else if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL || s.Settings.game == Settings.Game.VH) {
				value = s.Serialize<bool>(value, name: "value");
			} else {
				value = s.Serialize<bool>(value, name: "value");
				valueFloat = s.Serialize<float>(valueFloat, name: "valueFloat");
			}
		}
		public override uint? ClassCRC => 0xA2242335;
	}
}

