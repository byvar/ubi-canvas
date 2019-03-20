using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL)]
	public partial class EventGhostOnReadingFinish : Event {
		[Serialize("ghostIndex")] public uint ghostIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ghostIndex));
		}
		public override uint? ClassCRC => 0x3D1C19B5;
	}
}

