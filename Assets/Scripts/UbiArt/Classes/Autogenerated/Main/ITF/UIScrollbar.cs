using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class UIScrollbar : UIComponent {
		public StringID textBoxFriendly;
		public float speed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				textBoxFriendly = s.SerializeObject<StringID>(textBoxFriendly, name: "textBoxFriendly");
				speed = s.Serialize<float>(speed, name: "speed");
			}
		}
		public override uint? ClassCRC => 0x6B682541;
	}
}

