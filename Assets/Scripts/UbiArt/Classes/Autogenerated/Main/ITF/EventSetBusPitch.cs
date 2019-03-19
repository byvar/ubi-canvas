using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL)]
	public partial class EventSetBusPitch : Event {
		[Serialize("sender")] public uint sender;
		[Serialize("pitch" )] public float pitch;
		[Serialize("bus"   )] public StringID bus;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(pitch));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(bus));
				SerializeField(s, nameof(pitch));
			} else {
			}
		}
		public override uint? ClassCRC => 0x73B21DD0;
	}
}

