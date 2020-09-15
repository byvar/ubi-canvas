using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventMetronomeSetBPM : Event {
		public uint bpm;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO 
				|| Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				bpm = s.Serialize<uint>(bpm, name: "bpm");
			} else {
			}
		}
		public override uint? ClassCRC => 0x444B5170;
	}
}

