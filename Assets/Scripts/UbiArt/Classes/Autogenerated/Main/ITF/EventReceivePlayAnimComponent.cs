using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.RL | GameFlags.COL | GameFlags.VH | GameFlags.RO)]
	public partial class EventReceivePlayAnimComponent : ActorComponent {
		public float startValue;
		public bool displayPhantom;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				startValue = s.Serialize<float>(startValue, name: "startValue");
				if (s.HasFlags(SerializeFlags.Editor)) {
					displayPhantom = s.Serialize<bool>(displayPhantom, name: "displayPhantom");
				}
			} else {
				startValue = s.Serialize<float>(startValue, name: "startValue");
			}
		}
		public override uint? ClassCRC => 0xD945CA93;
	}
}

