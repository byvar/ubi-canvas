using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class EventShowScoreboard : Event {
		[Serialize("display")] public int display;
		[Serialize("sender" )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(display));
			} else {
				SerializeField(s, nameof(display));
			}
		}
		public override uint? ClassCRC => 0xF87620F8;
	}
}

