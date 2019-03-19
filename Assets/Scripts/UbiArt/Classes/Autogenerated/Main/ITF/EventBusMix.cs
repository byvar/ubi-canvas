using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventBusMix : Event {
		[Serialize("activate" )] public int activate;
		[Serialize("sender"   )] public uint sender;
		[Serialize("busMix"   )] public Placeholder busMix;
		[Serialize("name"     )] public StringID name;
		[Serialize("BusMix__0")] public BusMix BusMix__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(activate));
				SerializeField(s, nameof(BusMix__0));
			} else if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(activate));
				SerializeField(s, nameof(busMix));
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(activate));
				SerializeField(s, nameof(busMix));
			} else {
			}
		}
		public override uint? ClassCRC => 0xAEA6BBF0;
	}
}

