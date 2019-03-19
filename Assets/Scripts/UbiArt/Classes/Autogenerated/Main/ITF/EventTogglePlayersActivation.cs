using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class EventTogglePlayersActivation : Event {
		[Serialize("activate_player")] public int activate_player;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(activate_player));
		}
		public override uint? ClassCRC => 0x8CB84633;
	}
}

