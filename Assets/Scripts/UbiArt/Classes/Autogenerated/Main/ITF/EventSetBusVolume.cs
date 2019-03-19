using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventSetBusVolume : Event {
		[Serialize("bus"   )] public StringID bus;
		[Serialize("volume")] public Volume volume;
		[Serialize("time"  )] public float time;
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(bus));
				SerializeField(s, nameof(volume));
				SerializeField(s, nameof(time));
			} else if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(volume));
				SerializeField(s, nameof(time));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(bus));
				SerializeField(s, nameof(volume));
				SerializeField(s, nameof(time));
			} else {
			}
		}
		public override uint? ClassCRC => 0x6241355A;
	}
}

