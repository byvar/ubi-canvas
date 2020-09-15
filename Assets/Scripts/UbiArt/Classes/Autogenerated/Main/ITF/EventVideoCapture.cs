using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventVideoCapture : Event {
		public bool start;
		public Path path;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				start = s.Serialize<bool>(start, name: "start");
			} else {
				start = s.Serialize<bool>(start, name: "start");
				path = s.SerializeObject<Path>(path, name: "path");
			}
		}
		public override uint? ClassCRC => 0x7292D0DF;
	}
}

