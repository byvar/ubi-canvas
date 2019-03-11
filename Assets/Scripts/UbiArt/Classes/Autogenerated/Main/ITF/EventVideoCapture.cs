using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventVideoCapture : Event {
		[Serialize("start" )] public bool start;
		[Serialize("path"  )] public Path path;
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(start));
			} else if (Settings.s.game == Settings.Game.RL) {
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

