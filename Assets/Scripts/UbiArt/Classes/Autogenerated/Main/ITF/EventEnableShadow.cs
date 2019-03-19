using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class EventEnableShadow : Event {
		[Serialize("Enable")] public bool Enable;
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
			} else {
				SerializeField(s, nameof(Enable));
			}
		}
		public override uint? ClassCRC => 0xF1CB5691;
	}
}

