using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL)]
	public partial class EventCutRope : Event {
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
			} else {
			}
		}
		public override uint? ClassCRC => 0xF0AEF918;
	}
}

