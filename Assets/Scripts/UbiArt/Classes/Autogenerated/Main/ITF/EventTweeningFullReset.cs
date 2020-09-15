using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class EventTweeningFullReset : Event {
		public bool resetSelectedSet;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				resetSelectedSet = s.Serialize<bool>(resetSelectedSet, name: "resetSelectedSet", options: CSerializerObject.Options.BoolAsByte);
			} else {
			}
		}
		public override uint? ClassCRC => 0xA162DBE0;
	}
}

