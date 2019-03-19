using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventVideoCapture : Event {
		[Serialize("start" )] public bool start;
		[Serialize("path"  )] public Path path;
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(start));
			} else if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(start));
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(start));
				SerializeField(s, nameof(path));
			} else {
				SerializeField(s, nameof(start));
				SerializeField(s, nameof(path));
			}
		}
		public override uint? ClassCRC => 0x7292D0DF;
	}
}

