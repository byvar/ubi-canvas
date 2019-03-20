using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventBusMix : Event {
		[Serialize("activate" )] public int activate;
		[Serialize("busMix"   )] public BusMix busMix;
		[Serialize("name"     )] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(activate));
				SerializeField(s, nameof(busMix));
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(activate));
				SerializeField(s, nameof(busMix));
			} else {
			}
		}
		public override uint? ClassCRC => 0xAEA6BBF0;
	}
}

