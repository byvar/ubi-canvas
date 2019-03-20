using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL)]
	public partial class EventSetBusPitch : Event {
		[Serialize("bus"   )] public StringID bus;
		[Serialize("pitch" )] public float pitch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(bus));
				SerializeField(s, nameof(pitch));
			}
		}
		public override uint? ClassCRC => 0x73B21DD0;
	}
}

