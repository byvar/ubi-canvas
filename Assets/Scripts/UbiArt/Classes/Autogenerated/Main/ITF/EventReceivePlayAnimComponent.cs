using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.RL | GameFlags.COL | GameFlags.VH | GameFlags.RO)]
	public partial class EventReceivePlayAnimComponent : ActorComponent {
		[Serialize("startValue"    )] public float startValue;
		[Serialize("displayPhantom")] public int displayPhantom;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(startValue));
				if (s.HasFlags(SerializeFlags.Flags_x03)) {
					SerializeField(s, nameof(displayPhantom));
				}
			} else {
				SerializeField(s, nameof(startValue));
			}
		}
		public override uint? ClassCRC => 0xD945CA93;
	}
}

