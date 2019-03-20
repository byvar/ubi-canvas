using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventSequenceActivatePlayers : Event {
		[Serialize("activate" )] public bool activate;
		[Serialize("playStart")] public bool playStart;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(activate));
			} else {
				SerializeField(s, nameof(activate));
				SerializeField(s, nameof(playStart));
			}
		}
		public override uint? ClassCRC => 0xC1B4AADE;
	}
}

