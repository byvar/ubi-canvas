using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventSequenceActivatePlayers : Event {
		[Serialize("activate" )] public bool activate;
		[Serialize("playStart")] public bool playStart;
		[Serialize("sender"   )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(activate));
			} else if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(activate));
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(activate));
				SerializeField(s, nameof(playStart));
			} else {
				SerializeField(s, nameof(activate));
				SerializeField(s, nameof(playStart));
			}
		}
		public override uint? ClassCRC => 0xC1B4AADE;
	}
}

