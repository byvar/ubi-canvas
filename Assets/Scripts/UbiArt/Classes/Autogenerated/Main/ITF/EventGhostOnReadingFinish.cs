using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL)]
	public partial class EventGhostOnReadingFinish : Event {
		[Serialize("ghostIndex")] public uint ghostIndex;
		[Serialize("sender"    )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(ghostIndex));
			} else {
				SerializeField(s, nameof(ghostIndex));
			}
		}
		public override uint? ClassCRC => 0x3D1C19B5;
	}
}

