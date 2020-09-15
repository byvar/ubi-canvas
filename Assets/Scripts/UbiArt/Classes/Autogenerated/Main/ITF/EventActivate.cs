using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class EventActivate : Event {
		public int activated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				activated = s.Serialize<int>(activated, name: "activated");
			} else {
			}
		}
		public override uint? ClassCRC => 0x9D550A44;
	}
}

