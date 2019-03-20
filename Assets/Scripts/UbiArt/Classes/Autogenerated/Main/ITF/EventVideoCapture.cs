using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventVideoCapture : Event {
		[Serialize("start" )] public bool start;
		[Serialize("path"  )] public Path path;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(start));
			} else {
				SerializeField(s, nameof(start));
				SerializeField(s, nameof(path));
			}
		}
		public override uint? ClassCRC => 0x7292D0DF;
	}
}

