using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class EventTweeningFullReset : Event {
		[Serialize("sender"          )] public uint sender;
		[Serialize("resetSelectedSet")] public bool resetSelectedSet;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(resetSelectedSet), boolAsByte: true);
			} else {
			}
		}
		public override uint? ClassCRC => 0xA162DBE0;
	}
}

